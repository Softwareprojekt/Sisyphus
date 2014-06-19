using SoftwareProjekt.Classes.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt.Classes.Xml
{
    class MathXmlGenerator
    {
        string _xmlDoc;

        public string XmlDoc
        {
            get 
            { 
                return _xmlDoc; 
            }
        }

        public MathXmlGenerator()
        {
            _xmlDoc = "<math xmlns='http://www.w3.org/1998/Math/MathML' display='block'>\n";
        }

        public void AddVector(Vector vec)
        {

        }

        public void AddMatrix(Matrix mat)
        {
        }

        public void AddNode(string node)
        {
            _xmlDoc += node + "\n";
        }

        public void Finish()
        {
            _xmlDoc += "</math>";
        }
    }
}
