
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

using SoftwareProjekt.Classes.Xml;
using SoftwareProjekt.UserControls.MindMap;
using SoftwareProjekt.UserControls.Workbook;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoftwareProjekt.Classes
{
    public class WorkBook
    {
        private List<WorkBookView> _controlsList;
        private XmlWorkbook ConfigFile;
        private int _username;
        private ScreenshotCreator _screenshotBuilder;

        public string Username
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<WorkBookView> GetWorkBookControl(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Load(string filename)
        {
            throw new System.NotImplementedException();
        }

        public void Save(int id, UserControl control, string notices)
        {
            throw new System.NotImplementedException();
        }

    }
}
