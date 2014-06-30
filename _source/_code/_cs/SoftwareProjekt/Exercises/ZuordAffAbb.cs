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
            if (!inputData.ContainsKey("VectorA") || !inputData.ContainsKey("VectorB") || !inputData.ContainsKey("VectorC")
                || !inputData.ContainsKey("VectorA2") || !inputData.ContainsKey("VectorB2") || !inputData.ContainsKey("VectorC2"))
            {
                return;
            }

            // calculate...
            Vector inputA = (Vector)inputData["VectorA"];
            Vector inputB = (Vector)inputData["VectorB"];
            Vector inputC = (Vector)inputData["VectorC"];
            Vector inputA2 = (Vector)inputData["VectorA2"];
            Vector inputB2 = (Vector)inputData["VectorB2"];
            Vector inputC2 = (Vector)inputData["VectorC2"];


            Vector minusA = Vector.Multiply(inputA, -1f);
            Vector minusA2 = Vector.Multiply(inputA2, -1f);

            Vector AB = Vector.Add(inputB, minusA);
            Vector AC = Vector.Add(inputC, minusA);

            Vector A2B2 = Vector.Add(inputB2, minusA2);
            Vector A2C2 = Vector.Add(inputC2, minusA2);

            Dictionary<string, Object> outputData = new Dictionary<string, object>();

            Matrix outputM = new Matrix(AB.X1, AB.X2, AC.X1, AC.X2);
            Matrix outputMinv = Matrix.Invert(outputM);

            outputData.Add("VectorAB", AB);
            outputData.Add("VectorAC", AC);
            outputData.Add("VectorA2B2", A2B2);
            outputData.Add("VectorA2C2", A2C2);
            outputData.Add("M", outputM);
            outputData.Add("Minv", outputMinv);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}

