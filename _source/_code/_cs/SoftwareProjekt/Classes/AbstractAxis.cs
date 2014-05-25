using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class Axis : IAxis
    {
        private bool _isXAxis;
        private bool _isYAxis;
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="isXAxis">XAxis: true; YAxis: false</param>
        public Axis(bool isXAxis)
        {
            _isXAxis = isXAxis;
            _isYAxis = !isXAxis;
            throw new System.NotImplementedException();
        }

        public string Legend
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float StartValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float EndValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float Scale
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
