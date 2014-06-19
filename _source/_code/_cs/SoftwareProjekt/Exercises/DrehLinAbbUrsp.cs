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
    class DrehLinAbbUrsp : AbstractExercise
    {
        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> dict = null;

            // get data needed for calculations.
            dict = view.GetInputData();

            // check dict
            if (!dict.ContainsKey("Angle") || !dict.ContainsKey("VectorX"))
            {
                return;
            }

            // calculate...
            Vector ev1 = (Vector)dict["EV1"];
            Vector ev2 = (Vector)dict["EV2"];
            Vector x = (Vector)dict["VectorX"];
            double angle = (double)dict["Angle"];

            x.Rotate(angle);
            ev1.Rotate(angle);
            ev2.Rotate(angle);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(dict));
        }
    }
}

