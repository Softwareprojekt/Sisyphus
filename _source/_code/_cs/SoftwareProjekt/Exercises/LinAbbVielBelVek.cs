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
    class LinAbbVielBelVek : AbstractExercise
    {
        public LinAbbVielBelVek()
        {
            this.Id = Enums.EExercises.LinAbbMitVielfachemBelVek;
        }

        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check dict
            if (!inputData.ContainsKey("MatrixM1") || !inputData.ContainsKey("VectorX") || !inputData.ContainsKey("Scalar1"))
            {
                return;
            }

            // calculate...
            Matrix inputM1 = (Matrix)inputData["MatrixM1"];
            Vector inputX = (Vector)inputData["VectorX"];
            float scalar = (float)inputData["Scalar1"];

            Dictionary<string, Object> outputData = new Dictionary<string, object>();

            // Vector XmultipliedA must be shown in the first Coordiante System
            Vector XmultiScalar = Vector.Multiply(inputX, scalar);

            Vector outputX = Vector.Multiply(inputX, inputM1);
            Vector outputX2 = Vector.Multiply(XmultiScalar, inputM1);

            outputData.Add("VectorX", outputX);
            outputData.Add("VectorX2", outputX2);
            outputData.Add("VectorMulti", XmultiScalar);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}

