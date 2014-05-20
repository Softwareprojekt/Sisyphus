using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class Axis
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

        public int Legend
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
