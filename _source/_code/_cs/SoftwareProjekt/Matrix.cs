using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class Matrix : IMathObject
    {
        /// <summary>
        /// ctor
        /// </summary>
        public Matrix(float x_11, float x_12, float x_21, float x_22)
        {
            throw new System.NotImplementedException();
        }

        public float Determinante
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void GetData()
        {
            throw new NotImplementedException();
        }

        public void Invert()
        {
            throw new System.NotImplementedException();
        }

        public void Multiply(Matrix newMatrix)
        {
            throw new System.NotImplementedException();
        }

        public Matrix Multiply(Matrix firstMatrix, Matrix secondMatrix)
        {
            throw new System.NotImplementedException();
        }
    }
}
