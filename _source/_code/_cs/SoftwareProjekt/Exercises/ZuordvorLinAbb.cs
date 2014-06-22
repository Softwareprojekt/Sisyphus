﻿#region LicenseHeader
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
    class ZuordvorLinAbb : AbstractExercise
    {
        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check dict
            if (!inputData.ContainsKey("M1") || !inputData.ContainsKey("M2") || !inputData.ContainsKey("VectorX"))
            {
                return;
            }

            // calculate...
            Vector inputM1 = (Vector)inputData["M1"];
            Vector inputM2 = (Vector)inputData["M2"];
            Vector inputX = (Vector)inputData["VectorX"];

            Dictionary<string, Object> outputData = new Dictionary<string, object>();

            inputM1.Multiply(inputX.X1);
            inputM2.Multiply(inputX.X2);

            Vector outputX = Vector.Add(inputM1, inputM2);

            outputData.Add("VectorX", outputX);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}