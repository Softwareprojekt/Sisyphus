using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public interface IAxis
    {
        int Legend
        {
            get;
            set;
        }

        int StartValue
        {
            get;
            set;
        }

        int EndValue
        {
            get;
            set;
        }
    }
}
