
#region LicenseHeader
/*
 * Copyright (C) 2014 Technische Hochschule Amberg
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
#endregion

using System;

namespace SoftwareProjekt.Classes.Math
{
    public class Matrix
    {
        private float _x11;
        private float _x12;
        private float _x21;
        private float _x22;

        /// <summary>
        /// Empty ctor.
        /// </summary>
        public Matrix()
        {
            this.X11 = float.NaN;
            this.X12 = float.NaN;
            this.X21 = float.NaN;
            this.X22 = float.NaN;
        }

        /// <summary>
        /// ctor
        /// </summary>
        public Matrix(float x_11, float x_12, float x_21, float x_22)
        {
            this.X11 = x_11;
            this.X12 = x_12;
            this.X21 = x_21;
            this.X22 = x_22;
        }

        /// <summary>
        /// Gets the Determinant of this Matrix
        /// </summary>
        public float Determinant
        {
            get
            {
                return X11 * X22 - X12 * X21;
            }
        }

        public float X11
        {
            get { return _x11; }
            set
            {
                _x11 = (float)System.Math.Round(value, 5);
            }
        }

        public float X12
        {
            get { return _x12; }
            set
            {
                _x12 = (float)System.Math.Round(value, 5);
            }
        }

        public float X21
        {
            get { return _x21; }
            set
            {
                _x21 = (float)System.Math.Round(value, 5);
            }
        }

        public float X22
        {
            get { return _x22; }
            set
            {
                _x22 = (float)System.Math.Round(value, 5);
            }
        }

        public override string ToString()
        {
            return string.Format("[Matrix X11={0}, X12={1}, X21={2}, X22={3}]", this.X11, this.X12, this.X21, this.X22);
        }

        /// <summary>
        /// Inverts this Matrix
        /// </summary>
        public void Invert()
        {
            Matrix m = (Matrix)this.MemberwiseClone();
            float tmp = X11;
            this.X11 = X22;
            this.X22 = tmp;
            this.X12 *= -1;
            this.X21 *= -1;
            if (this.Determinant != 0f)
            {
                this.Multiply(1 / Determinant);
            }
            else
            {
                this.X11 = m.X11;
                this.X22 = m.X22;
                this.X12 = m.X12;
                this.X21 = m.X21;
                throw new ArgumentException("The Matrix values are not vaild for this operation, determinant = 0");
            }

        }

        /// <summary>
        /// Inverts a Matrix and returns the new one
        /// </summary>
        static public Matrix Invert(Matrix matrix)
        {
            if (matrix.Determinant != 0f)
            {
                Matrix m = new Matrix(matrix.X22, -matrix.X12, -matrix.X21, matrix.X11);
                m.Multiply(1 / matrix.Determinant);
                return m;
            }
            else
            {
                throw new ArgumentException("The Matrix values are not vaild for this operation, determinant = 0");
            }
        }
        /// <summary>
        /// Multiplies this Matrix with a scalar
        /// </summary>
        public void Multiply(float scalar)
        {
            this.X11 *= scalar;
            this.X12 *= scalar;
            this.X21 *= scalar;
            this.X22 *= scalar;
        }
        /// <summary>
        /// Multiplies a Matrix with an scalar and retruns the new Matrix
        /// </summary>
        static public Matrix Multiply(Matrix matrix, float scalar)
        {
            Matrix m = new Matrix(matrix.X11, matrix.X12, matrix.X21, matrix.X22);
            m.Multiply(scalar);
            return m;
        }


        /// <summary>
        /// Multiplies this Matrix with an other one
        /// </summary>
        public void Multiply(Matrix newMatrix)
        {
            float x_11 = X11 * newMatrix.X11 + X12 * newMatrix.X21;
            float x_12 = X11 * newMatrix.X21 + X12 * newMatrix.X22;
            float x_21 = X21 * newMatrix.X11 + X22 * newMatrix.X21;
            float x_22 = X21 * newMatrix.X12 + X22 * newMatrix.X22;
            this.X11 = x_11;
            this.X12 = x_12;
            this.X21 = x_21;
            this.X22 = x_22;
        }

        /// <summary>
        /// Multiplies two Matrices and retruns the new Matrix
        /// </summary>
        public Matrix Multiply(Matrix firstMatrix, Matrix secondMatrix)
        {
            float x_11 = firstMatrix.X11 * secondMatrix.X11 + firstMatrix.X12 * secondMatrix.X21;
            float x_12 = firstMatrix.X11 * secondMatrix.X21 + firstMatrix.X12 * secondMatrix.X22;
            float x_21 = firstMatrix.X21 * secondMatrix.X11 + firstMatrix.X22 * secondMatrix.X21;
            float x_22 = firstMatrix.X21 * secondMatrix.X12 + firstMatrix.X22 * secondMatrix.X22;
            return new Matrix(x_11, x_12, x_21, x_22);
        }

        /// <summary>
        /// Adds a Matrix to this Matrix
        /// </summary>
        public void Add(Matrix newMatrix)
        {
            this.X11 += newMatrix.X11;
            this.X12 += newMatrix.X12;
            this.X21 += newMatrix.X21;
            this.X22 += newMatrix.X22;
        }

        /// <summary>
        /// Adds two Matrices and returns the new one
        /// </summary>
        static public Matrix Add(Matrix firstMatrix, Matrix secondMatrix)
        {
            return new Matrix(firstMatrix.X11 + secondMatrix.X11, firstMatrix.X12 + secondMatrix.X12, firstMatrix.X21 + secondMatrix.X21, firstMatrix.X22 + secondMatrix.X22);
        }

        public bool IsValid()
        {
            return !float.IsNaN(this.X11) && !float.IsNaN(this.X12) && !float.IsNaN(this.X21) && !float.IsNaN(this.X22);
        }

        public bool IsContractive()
        {
            double val1 = (System.Math.Pow(this.X11, 2) + System.Math.Pow(this.X21, 2));
            double val2 = (System.Math.Pow(this.X12, 2) + System.Math.Pow(this.X22, 2));
            bool retval = val1 < 1 && val2 < 1 && (val1 + val2 + System.Math.Pow(this.X11 * this.X12 + this.X21 * this.X22, 2)) < (1 + val1 + val2);
            return retval;
        }
    }
}
