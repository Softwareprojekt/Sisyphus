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
    class SpiegLinAbbUrsp : AbstractExercise
    {
        public SpiegLinAbbUrsp()
        {
            this.Id = Enums.EExercises.SpiegelungLinAbbanUrspungsgeraden;
        }

        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check dict
            if (!inputData.ContainsKey("Winkel") || !inputData.ContainsKey("VectorX") || !inputData.ContainsKey("EV1") || !inputData.ContainsKey("EV2"))
            {
                return;
            }

            // calculate...
            Vector inputX = (Vector)inputData["VectorX"];
            Vector inputEV1 = (Vector)inputData["EV1"];
            Vector inputEV2 = (Vector)inputData["EV2"];
            float angle = (float)inputData["Winkel"];

            Line mirror = new Line(angle);
            Matrix M = new Matrix((float)System.Math.Cos(2 * angle), (float)System.Math.Sin(2 * angle), (float)System.Math.Sin(2 * angle), (float)-System.Math.Cos(2 * angle));

            Dictionary<string, Object> outputData = new Dictionary<string, object>();

            Vector outputX = Vector.Mirror(mirror, inputX);
            Vector outputEV1 = Vector.Mirror(mirror, inputEV1);
            Vector outputEV2 = Vector.Mirror(mirror, inputEV2);
            float detM = M.Determinant;

            outputData.Add("VectorX", outputX);
            outputData.Add("EV1", outputEV1);
            outputData.Add("EV2", outputEV2);
            outputData.Add("MDet", detM);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}
