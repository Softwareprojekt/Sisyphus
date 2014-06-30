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

//using System.Linq;
//using System.Text;

namespace SoftwareProjekt.Exercises
{
    class LinAbbSumBelVek : AbstractExercise
    {
        public LinAbbSumBelVek()
        {
            this.Id = Enums.EExercises.LinAbbAusSumBelVek;
        }

        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check dict
            if (!inputData.ContainsKey("MatrixM1") || !inputData.ContainsKey("VectorX") || !inputData.ContainsKey("VectorY"))
            {
                return;
            }

            // calculate...
            Matrix inputM1 = (Matrix)inputData["MatrixM1"];
            Vector inputX = (Vector)inputData["VectorX"];
            Vector inputY = (Vector)inputData["VectorY"];

            Dictionary<string, Object> outputData = new Dictionary<string, object>();

            // This Vector must be shown in the first Coordinate System as the result of x + y
            Vector XplusY = Vector.Add(inputX, inputY);

            // This Vector must be shown in the second Coorinate System
            Vector outputX = Vector.Multiply(inputX, inputM1);
            // This Vector must be shown in the second Coorinate System
            Vector outputY = Vector.Multiply(inputY, inputM1);
            // This Vector must be shown in the second Coorinate System
            Vector outputXplusY = Vector.Multiply(XplusY, inputM1);

            outputData.Add("OutputX", outputX);
            outputData.Add("OutputY", outputY);
            outputData.Add("OutputXplusY", outputXplusY);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}
