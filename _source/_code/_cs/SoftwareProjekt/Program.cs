﻿
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

            TestView view = new TestView();

            IController cont = new Controller(view);

            //TestExercise exercise = new TestExercise();

            //DrehLinAbbUrsp exercise = new DrehLinAbbUrsp();
            //FrmDrehLinAbbUrsp view = new FrmDrehLinAbbUrsp();

            //cont.AddExercise(exercise, view);

            Application.Run(view);

            //FrmMain mainView = new FrmMain();

            //TestObject to = new TestObject();

            //cont.AddView(to);

            //Application.Run(to);
        }
    }
}
