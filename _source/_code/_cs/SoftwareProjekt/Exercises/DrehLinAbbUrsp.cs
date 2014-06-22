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
        public DrehLinAbbUrsp()
        {
            this.Id = Enums.EExercises.DrehungLinAbbUmUrsprung;
        }

        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check dict
            if (!inputData.ContainsKey("EV1") || !inputData.ContainsKey("EV2") || !inputData.ContainsKey("Angle") || !inputData.ContainsKey("VectorX"))
            {
                return;
            }

            // calculate...
            Vector inputEV1 = (Vector)inputData["EV1"];
            Vector inputEV2 = (Vector)inputData["EV2"];
            Vector inputX = (Vector)inputData["VectorX"];
            float angle = (float)inputData["Angle"];

            Dictionary<string, Object> outputData = new Dictionary<string, object>();

            Vector outputX = Vector.Rotate(inputX, angle);
            Vector outputEV1 = Vector.Rotate(inputEV1, angle);
            Vector outputEV2 = Vector.Rotate(inputEV2, angle);

            outputData.Add("VectorX", outputX);
            outputData.Add("EV1", outputEV1);
            outputData.Add("EV2", outputEV2);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}

