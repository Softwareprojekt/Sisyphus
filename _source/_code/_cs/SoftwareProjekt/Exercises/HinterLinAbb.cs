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
    class HinterLinAbb : AbstractExercise
    {
        public HinterLinAbb()
        {
            this.Id = Enums.EExercises.HintereinanderausfLinAbb;
        }

        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check inputData
            if (!inputData.ContainsKey("MatrixM1") || !inputData.ContainsKey("MatrixM2") || !inputData.ContainsKey("VectorX"))
            {
                return;
            }

            // calculate...
            Matrix inputM1 = (Matrix)inputData["MatrixM1"];
            Matrix inputM2 = (Matrix)inputData["MatrixM2"];

            Vector inputX = (Vector)inputData["VectorX"];

            Dictionary<string, Object> outputData = new Dictionary<string, object>();

            // This Vector must be shown in the second Coordinate System
            Vector outputX1 = Vector.Multiply(inputX, inputM1);
            // This Vecotr must be shown in the third Coordinate System
            Vector outputX2 = Vector.Multiply(outputX1, inputM2);
            float detM1 = inputM1.Determinant;
            float detM2 = inputM2.Determinant;

            outputData.Add("VectorX1", outputX1);
            outputData.Add("VectorX2", outputX2);
            outputData.Add("M1Det", detM1);
            outputData.Add("M2Det", detM2);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}
