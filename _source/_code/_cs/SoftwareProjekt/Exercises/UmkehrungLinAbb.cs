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

using SoftwareProjekt.Classes.EventArguments;
using SoftwareProjekt.Classes.Math;
using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;

namespace SoftwareProjekt.Exercises
{
    class UmkehrungLinAbb : AbstractExercise
    {
        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> dict = null;

            // get data needed for calculations.
            dict = view.GetInputData();

            // check dict
            if (!dict.ContainsKey("Matrix1") || !dict.ContainsKey("VectorX") || !dict.ContainsKey("VectorY"))
            {
                return;
            }

            // calculate...
            // This is the (input) Vector x shown in the first Coordinate System
            Vector x = (Vector)dict["VectorX"];
            // This is the (input) Vector y shown in the second Coordinate System
            Vector y = (Vector)dict["VectorY"];
            // This is the input Matrix
            Matrix m = (Matrix)dict["Matrix1"];

            //  This is the (calculated) Vector x shown in the second Coordinate System
            x.Multiply(m);
            // This is the inverted (input) Matrix
            m.Invert();
            // This is the (calculated) Vector y shown in the first Coordinate System
            y.Multiply(m);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(dict));
        }
    }
}
