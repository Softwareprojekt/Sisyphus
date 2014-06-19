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

//using System.Linq;
//using System.Text;

namespace SoftwareProjekt.Exercises
{
    class LinAbbVielBelVek : AbstractExercise
    {
        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> dict = null;

            // get data needed for calculations.
            dict = view.GetInputData();

            // check dict
            if (!dict.ContainsKey("Matrix1") || !dict.ContainsKey("Vector1") || !dict.ContainsKey("Scalar1"))
            {
                return;
            }

            // input...
            Matrix m = (Matrix)dict["Matrix1"];
            Vector v = (Vector)dict["Vector1"];
            Vector v1 = (Vector)dict["Vector1"];
            float scalar = (float)dict["Scalar1"];

            // calculate...
            v.Multiply(scalar);
            v.Multiply(m);
            // Vector1 also must be shown in the output Coordiante System without the scalar
            v1.Multiply(m);


            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(dict));
        }
    }
}
