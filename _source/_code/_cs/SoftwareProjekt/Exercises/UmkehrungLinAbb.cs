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
    class UmkehrungLinAbb : AbstractExercise
    {
        public UmkehrungLinAbb()
        {
            this.Id = Enums.EExercises.UmkehrungLinAbb;
        }

        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check dict
            if (!inputData.ContainsKey("Matrix") || !inputData.ContainsKey("VectorX") || !inputData.ContainsKey("VectorY"))
            {
                return;
            }

            // calculate...
            // This is the (input) Vector x shown in the first Coordinate System
            Vector inputX = (Vector)inputData["VectorX"];
            // This is the (input) Vector y shown in the second Coordinate System
            Vector inputY = (Vector)inputData["VectorY"];
            // This is the input Matrix
            Matrix inputM = (Matrix)inputData["Matrix"];


            Dictionary<string, Object> outputData = new Dictionary<string, object>();

            //  This is the (calculated) Vector x shown in the second Coordinate System
            Vector outputX = Vector.Multiply(inputX, inputM);
            // This is the inverted (input) Matrix
            Matrix invM = Matrix.Invert(inputM);
            // This is the (calculated) Vector y shown in the first Coordinate System
            Vector outputY = Vector.Multiply(inputY, invM);

            outputData.Add("VectorX", outputX);
            outputData.Add("EV1", outputY);
            outputData.Add("EV2", invM);

            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}
