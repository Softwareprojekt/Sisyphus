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
            throw new System.NotImplementedException();
        }
    
        public int X
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Y
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Add(Vector newVector)
        {
            throw new System.NotImplementedException();
        }

        static public Vector Add(Vector firstVector, Vector secondVector)
        {
            throw new System.NotImplementedException();
        }

        public void Rotate(float degree)
        {
            throw new System.NotImplementedException();
        }

        public void Rotate(Matrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public void Scale(Matrix scaleMatrix)
        {
            throw new System.NotImplementedException();
        }

        public void Mirror(Line line)
        {
            throw new System.NotImplementedException();
        }

        public void Multiply(Matrix matrix)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// magnitude or norm
        /// </summary>
        public void Length()
        {
            throw new System.NotImplementedException();
        }

        static public Matrix Multiply(Matrix firstMatrix, Matrix secondMatrix)
        {
            throw new System.NotImplementedException();
        }

        public void GetData()
        {
            throw new NotImplementedException();
        }
    }
}
