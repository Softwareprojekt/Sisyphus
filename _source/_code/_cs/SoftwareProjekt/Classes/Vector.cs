
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class Vector : IMathObject
    {
        /// <summary>
        /// ctor
        /// </summary>
        public Vector(float x1, float x2)
        {
            X1 = x1;
            X2 = x2;
        }

        public float X1 { get; set; }

        public float X2 { get; set; }

        public float Length
        {
            get
            {
                return (float)Math.Sqrt(X1 * X1 + X2 * X2);
            }
        }

        public void Add(Vector newVector)
        {
            X1 += newVector.X1;
            X2 += newVector.X2;
        }

        static public Vector Add(Vector firstVector, Vector secondVector)
        {
            return new Vector(firstVector.X1 + secondVector.X1, firstVector.X2 + secondVector.X2);
        }

        public void Rotate(double degree)
        {
            Matrix m = new Matrix((float)Math.Cos(degree), (float)-Math.Sin(degree), (float)Math.Sin(degree), (float)Math.Cos(degree));
            this.Rotate(m);
        }

        public void Rotate(Matrix matrix)
        {
            if (matrix.X11 == matrix.X22 && matrix.X12 == -matrix.X21)
            {
                this.Multiply(matrix);
            }
            else
            {
                throw new ArgumentException("The Matrix values are not vaild for this operation");
            }
        }

        public void Scale(Matrix scaleMatrix)
        {
            if (scaleMatrix.X12 == 0 && scaleMatrix.X21 == 0)
            {
                this.Multiply(scaleMatrix);
            }
            else
            {
                throw new ArgumentException("The Matrix values are not vaild for this operation");
            }
        }

        public void Mirror(Line line)
        {
            throw new System.NotImplementedException();
        }

        public void Multiply(float scalar)
        {
            X1 *= scalar;
            X2 *= scalar;
        }

        /// <summary>
        /// Retruns a new Vector
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        static public Vector Multiply(Vector vector, float scalar)
        {
            return new Vector(vector.X1 * scalar, vector.X2 * scalar);
        }

        /// <summary>
        /// Multiplies this Vector with an second Vector
        /// </summary>
        /// <param name="newVector">the Vector this Vector is multiplied with</param>
        /// <returns>the Dot product of this and the new Vector</returns>
        public float Multiply(Vector newVector)
        {
            return X1 * newVector.X1 + X2 * newVector.X2;
        }

        /// <summary>
        /// Multiplies two Vectors
        /// </summary>
        /// <param name="firstVector">first Vector</param>
        /// <param name="secondVector">second Vector</param>
        /// <returns>the Dot product of the two Vecors</returns>
        static public float Multiply(Vector firstVector, Vector secondVector)
        {
            return firstVector.X1 * secondVector.X1 + firstVector.X2 * secondVector.X2;
        }

        /// <summary>
        /// Multiplies this Vector with a Matrix
        /// </summary>
        /// <param name="Matrix">the Matrix this Vector will be multiplied</param>
        /// <returns>a new Matrix</returns>
        static public Vector Multiply(Vector vector, Matrix Matrix)
        {
            return new Vector(vector.X1 * Matrix.X11 + vector.X2 * Matrix.X12, vector.X1 * Matrix.X21 + vector.X2 * Matrix.X22);
        }

        public void Multiply(Matrix newMatrix)
        {
            X1 = X1 * newMatrix.X11 + X2 * newMatrix.X12;
            X2 = X1 * newMatrix.X21 + X2 * newMatrix.X22;
        }

        public void GetData()
        {
            throw new NotImplementedException();
        }
    }
}
