
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
using System.Drawing;


namespace SoftwareProjekt.Classes.Math
{
    public class Vector
    {
    	private float _x1;
    	private float _x2;
    	
        /// <summary>
        /// Empty ctor.
        /// </summary>
        public Vector()
        {
            this.X1 = float.NaN;
            this.X2 = float.NaN;
        }

        /// <summary>
        /// ctor
        /// </summary>
        public Vector(float x1, float x2)
        {
            this.X1 = x1;
            this.X2 = x2;
        }

        public Vector(PointF point)
        {
            this.X1 = point.X;
            this.X2 = point.Y;
        }

        public float X1 
        {
        	get { return _x1; }
        	set 
        	{
				_x1 = (float)System.Math.Round(value, 5);
        	}
        }

        public float X2 
        {
        	get { return _x2; }
        	set 
        	{
				_x2 = (float)System.Math.Round(value, 5);
        	}
        }

        /// <summary>
        /// Gets the Length of this Vector
        /// </summary>
        public float Length
        {
            get
            {
                return (float)System.Math.Sqrt(this.X1 * this.X1 + this.X2 * this.X2);
            }
        }

        /// <summary>
        /// Gets the Angle between this Vector and the X-Axis (radians)
        /// </summary>
        public float AngleToXAxis
        {
            get
            {                
                return (float)System.Math.Atan2(this.X2, this.X1);
            }
        }
        /// <summary>
        /// Adds a Vector to this Vector
        /// </summary>
        public void Add(Vector newVector)
        {
            this.X1 += newVector.X1;
            this.X2 += newVector.X2;
        }
        /// <summary>
        /// Adds two Vectors an returns the new one
        /// </summary>
        static public Vector Add(Vector firstVector, Vector secondVector)
        {
            return new Vector(firstVector.X1 + secondVector.X1, firstVector.X2 + secondVector.X2);
        }

        /// <summary>
        /// Rotates this Vector around a certain degree
        /// </summary>
        public void Rotate(double degree)
        {
            double rad = ConvertDegreeToRadians(degree);
            Matrix m = new Matrix((float)System.Math.Cos(rad), (float)-System.Math.Sin(rad), (float)System.Math.Sin(rad), (float)System.Math.Cos(rad));
            this.Rotate(m);
        }

        /// <summary>
        /// Rotates a Vector around a certain degree and retruns the new one
        /// </summary>
        static public Vector Rotate(Vector vector, double degree)
        {
            double rad = ConvertDegreeToRadians(degree);
            Matrix m = new Matrix((float)System.Math.Cos(rad), (float)-System.Math.Sin(rad), (float)System.Math.Sin(rad), (float)System.Math.Cos(rad));
            return Vector.Rotate(m, vector);
        }

        /// <summary>
        /// Rotates this Vector with a matrix
        /// </summary>
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
        /// <summary>
        /// Rotates a Vector with a matrix and retruns the new one
        /// </summary>
        static public Vector Rotate(Matrix matrix, Vector vector)
        {
            if (matrix.X11 == matrix.X22 && matrix.X12 == -matrix.X21)
            {
                return Vector.Multiply(vector, matrix);
            }
            else
            {
                throw new ArgumentException("The Matrix values are not vaild for this operation");
            }
        }

        /// <summary>
        /// Scales this Vector
        /// </summary>
        public void Scale(Matrix scaleMatrix)
        {
            if (scaleMatrix.X12 == 0f && scaleMatrix.X21 == 0f)
            {
                this.Multiply(scaleMatrix);
            }
            else
            {
                throw new ArgumentException("The Matrix values are not vaild for this operation");
            }
        }

        /// <summary>
        /// Scales a Vector with an Matrix an retruns the new one
        /// </summary>
        static public Vector Scale(Matrix scaleMatrix, Vector vector)
        {
            if (scaleMatrix.X12 == 0f && scaleMatrix.X21 == 0f)
            {
                return Vector.Multiply(vector, scaleMatrix);
            }
            else
            {
                throw new ArgumentException("The Matrix values are not vaild for this operation");
            }
        }

        /// <summary>
        /// Scales this Vector
        /// </summary>
        public void Scale(float scalar)
        {
            Matrix scaleMatrix = new Matrix(scalar, 0f, 0f, scalar);
            if (scaleMatrix.X12 == 0f && scaleMatrix.X21 == 0f)
            {
                this.Multiply(scaleMatrix);
            }
            else
            {
                throw new ArgumentException("The Matrix values are not vaild for this operation");
            }
        }

        /// <summary>
        /// Scales this Vector
        /// </summary>
        public Vector Scale(Vector vector, float scalar)
        {
            Vector v = new Vector(vector.X1, vector.X2);
            v.Multiply(scalar);  
            return v;
        }

        /// <summary>
        /// Mirrors this Vector at a line through origin
        /// </summary>
        public void Mirror(Line line)
        {
            float angle = line.InnerLineSegment.Vector.AngleToXAxis;
            Matrix m = new Matrix((float)System.Math.Cos(2 * angle), (float)System.Math.Sin(2 * angle), (float)System.Math.Sin(2 * angle), (float)-System.Math.Cos(2 * angle));
            this.Multiply(m);
        }

        /// <summary>
        /// Mirrors a Vector at a line through origin and returns the new one
        /// </summary>
        static public Vector Mirror(Line line, Vector vector)
        {
            float angle = line.InnerLineSegment.Vector.AngleToXAxis;
            Matrix m = new Matrix((float)System.Math.Cos(2 * angle), (float)System.Math.Sin(2 * angle), (float)System.Math.Sin(2 * angle), (float)-System.Math.Cos(2 * angle));
            Vector v = new Vector(vector.X1, vector.X2);
            v.Multiply(m);
            return v;
        }

        /// <summary>
        /// Multiplies this Vector with an scalar
        /// </summary>
        public void Multiply(float scalar)
        {
            this.X1 *= scalar;
            this.X2 *= scalar;
        }

        /// <summary>
        /// Multiplies this Vector with an scalar and retruns the new Vector
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
        /// Multiplies a Vector with a Matrix and retruns the new one
        /// </summary>
        /// <param name="Matrix">the Matrix this Vector will be multiplied</param>
        /// <returns>a new Matrix</returns>
        static public Vector Multiply(Vector vector, Matrix Matrix)
        {
            return new Vector(vector.X1 * Matrix.X11 + vector.X2 * Matrix.X12, vector.X1 * Matrix.X21 + vector.X2 * Matrix.X22);
        }

        /// <summary>
        /// Multiplies this Vector with a Matrix
        /// </summary>
        public void Multiply(Matrix newMatrix)
        {
            float tmp = _x1;
            X1 = X1 * newMatrix.X11 + X2 * newMatrix.X12;
            X2 = tmp * newMatrix.X21 + X2 * newMatrix.X22;
        }

        public override string ToString()
        {
            return string.Format("[Vector X1={0}, X2={1}]", this.X1, this.X2);
        }
        
        public bool IsValid()
        {
        	return !float.IsNaN(this.X1) && !float.IsNaN(this.X2);
        }

        private static double ConvertDegreeToRadians(double degrees)
        {
            return System.Math.PI * degrees / 180.0;
        }
    }
}
