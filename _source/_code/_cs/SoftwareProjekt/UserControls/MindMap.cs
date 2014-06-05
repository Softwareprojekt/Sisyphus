
#region LicenseHeader
/*
 * Copyright (C) 2014 Technische Hochschule Amberg
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public class MindMap : UserControl
    {
        private const string _filename = "config.xml";
        private List<MindMapTopicControl> _graphicalTopicList;
        private List<ITopic> _logicalTopicList;
        private XmlMindMap _xmlParser;

        public MindMap ()
        {
            _graphicalTopicList = new List<MindMapTopicControl>();
            _logicalTopicList = new List<ITopic>();
            _xmlParser = new XmlMindMap();

        }

        public void ArrangeMindMap()
        {
            _xmlParser.ParseXml(_filename);

        }

        public void ParseXML()
        {
            throw new System.NotImplementedException();
        }
    }
}
