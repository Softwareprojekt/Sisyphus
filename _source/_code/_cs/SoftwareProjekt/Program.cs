
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

using SoftwareProjekt.Classes;
using SoftwareProjekt.Exercises;
using SoftwareProjekt.Forms;
using SoftwareProjekt.Interfaces;
using System;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitSisyphus initObject = new InitSisyphus();
            bool retVal = initObject.Init();
             /* checking retVal is currently disabled, because not everybody has a config.xml for mindmap*/

            FrmMain view = new FrmMain();

            IController cont = new Controller(view);
        }
    }
}
