using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class XmlMindMap
    {
        private string _filename;
        private List<XmlTopic> _listXmlTopic;

        public List<XmlTopic> ListTopic
        {
            get
            {
                return _listXmlTopic;
            }
        }

        public XmlMindMap()
        {
            _filename = "";
            _listXmlTopic = new List<XmlTopic>();
        }

        public bool ParseXml(string filename)
        {
            _filename = filename;

            return true;
        }
    }
}
