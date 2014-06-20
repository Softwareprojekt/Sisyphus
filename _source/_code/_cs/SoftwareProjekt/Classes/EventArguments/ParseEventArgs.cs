using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt.Classes.EventArguments
{
    class ParseEventArgs : EventArgs    
    {
        public ParseEventArgs(float value)
        {
            Value = value;
        }
        public float Value { get; set; }
    }
}
