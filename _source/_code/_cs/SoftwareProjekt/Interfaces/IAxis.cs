using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public interface IAxis
    {
        string Legend
        {
            get;
            set; 
        }
         
        float StartValue
        {
            get;
            set ;
        }

        float EndValue
        {
            get;
            set;
        }

        float Scale
        {
            get;
            set;
        }
    }
}
