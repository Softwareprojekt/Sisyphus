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
    class ZuordAffAbb : AbstractExercise
    {
        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check dict
            if (!inputData.ContainsKey("UrspVectorA") || !inputData.ContainsKey("UrspVectorB") || !inputData.ContainsKey("UrspVectorC")
                || !inputData.ContainsKey("UrspVectorA2") || !inputData.ContainsKey("UrspVectorB2") || !inputData.ContainsKey("UrspVectorC2"))
            {
                return;
            }

            // calculate...
            Vector inputA = (Vector)inputData["EV1"];
            Vector inputB = (Vector)inputData["EV1"];
            Vector inputC = (Vector)inputData["EV1"];

            inputA.Multiply(-1f);
            Vector AB = Vector.Add(inputB, inputA);
            Vector AC = Vector.Add(inputC, inputA);

            Dictionary<string, Object> outputData = new Dictionary<string, object>();

            Matrix outputM = new Matrix(AB.X1, AB.X2, AC.X1, AC.X2);
            Matrix outputMinv = Matrix.Invert(outputM);

            outputData.Add("M", outputM);
            outputData.Add("Minv", outputMinv);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}

