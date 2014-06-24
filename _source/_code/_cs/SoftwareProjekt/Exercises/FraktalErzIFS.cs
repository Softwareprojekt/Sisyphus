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
using SoftwareProjekt.Enums;
using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;

namespace SoftwareProjekt.Exercises
{
    class FraktalErzIFS : AbstractExercise
    {
        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check inputData
            if (!inputData.ContainsKey("Form") || !inputData.ContainsKey("InputForms")
                || !inputData.ContainsKey("Coefficient_w1") || !inputData.ContainsKey("Coefficient_w2")
                || !inputData.ContainsKey("Coefficient_w3") || !inputData.ContainsKey("MoveVector_w2")
                || !inputData.ContainsKey("MoveVector_w3"))
            {
                return;
            }

            // get input form.
            //TODO: need classes for forms. Triangle, Square, Circle.
            switch ((EInputForms)inputData["Form"])
            {
                case EInputForms.Triangle:
                    break;
                case EInputForms.Square:
                    break;
                case EInputForms.Circle:
                    break;
                case EInputForms.Picture:
                    break;
                default:
                    Console.WriteLine("ERROR @ Enum switch");
                    break;
            }

            Dictionary<string, Object> outputData = new Dictionary<string, object>();
            List<Object> outputForms = new List<Object>();

            // calculate...

            //TODO: need static method in form class: transform (form object, coeff), move(form object, vector), return new form object.
            //e.g.
            //Triangle tri1 = Move(Transform(triOriginal, inputData["Coefficient"]), inputData["MoveVector"]);
            //outputForms.Add(tri1);

            outputData.Add("OutputForms", outputForms);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}

