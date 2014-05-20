using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class Arrow: System.Windows.Forms.UserControl
    {

        public Point EndPoint
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool IsAngleVisible
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public System.Drawing.KnownColor Color
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Label
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string AngleLabel
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }

    public class Vector : IMathObject
    {
        public void GetData()
        {
            throw new NotImplementedException();
        }

        public Vector Addition(Vector newVector)
        {
            throw new System.NotImplementedException();
        }
    }
}
