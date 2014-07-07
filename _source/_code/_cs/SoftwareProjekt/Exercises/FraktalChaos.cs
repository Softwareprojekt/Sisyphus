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
using SoftwareProjekt.Forms;
using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace SoftwareProjekt.Exercises
{
    class FraktalChaos : AbstractExercise
    {
        public FraktalChaos()
        {
            this.Id = EExercises.FraktalerzeugungMitChaos;
        }

        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check dict
            if (!inputData.ContainsKey("Matrix1") || !inputData.ContainsKey("Matrix2") || !inputData.ContainsKey("Matrix3") || !inputData.ContainsKey("Matrix4")
                || !inputData.ContainsKey("Vector1") || !inputData.ContainsKey("Vector2") || !inputData.ContainsKey("Vector3") || !inputData.ContainsKey("Vector4")
                || !inputData.ContainsKey("Prob1") || !inputData.ContainsKey("Prob2") || !inputData.ContainsKey("Prob3") || !inputData.ContainsKey("Prob4")
                || !inputData.ContainsKey("Iter") || !inputData.ContainsKey("Steps"))
            {
                Console.WriteLine("ERROR @ Check Dict in FraktalChaos: Missing Data.");
                return;
            }

            // calculate...
            Matrix m1 = (Matrix)inputData["Matrix1"];
            Matrix m2 = (Matrix)inputData["Matrix2"];
            Matrix m3 = (Matrix)inputData["Matrix3"];
            Matrix m4 = (Matrix)inputData["Matrix4"];

            Vector v1 = (Vector)inputData["Vector1"];
            Vector v2 = (Vector)inputData["Vector2"];
            Vector v3 = (Vector)inputData["Vector3"];
            Vector v4 = (Vector)inputData["Vector4"];

            float prob1 = (float)inputData["Prob1"];
            float prob2 = (float)inputData["Prob2"];
            float prob3 = (float)inputData["Prob3"];
            float prob4 = (float)inputData["Prob4"];

            float iter = (float)inputData["Iter"];
            float steps = (float)inputData["Steps"];

            float val1 = prob1;
            float val2 = prob1 + prob2;
            float val3 = prob1 + prob2 + prob3;
            Vector lastPoint = new Vector(0, 0);

            List<PointF> pointList = new List<PointF>();
            Random r = new Random();
            for (int i = 1; i <= iter; i++)
            {
                int random = r.Next(0, 100);

                //chooses the function to calculate
                if (0 <= random && random < val1)
                {
                    lastPoint = Vector.AffineAbbildung(lastPoint, m1, v1);
                }
                else if (val1 <= random && random < val2)
                {
                    lastPoint = Vector.AffineAbbildung(lastPoint, m2, v2);
                }
                else if (val2 <= random && random < val3)
                {
                    lastPoint = Vector.AffineAbbildung(lastPoint, m3, v3);
                }
                else
                {
                    lastPoint = Vector.AffineAbbildung(lastPoint, m4, v4);
                }
                pointList.Add(new PointF(lastPoint.X1, lastPoint.X2));

                //Don't know why, but otherwise it doesn't work
                //System.Threading.Thread.Sleep(1);

                if (i % (iter / steps) == 0 || i == iter)
                {
                    Dictionary<string, Object> outputData = new Dictionary<string, object>();
                    outputData.Add("Points", pointList);
                    outputData.Add("CurrentIteration", i);
                    // call base dowork and pass the calculated data.
                    base.Finalize(new ExerciseEventArgs(outputData, (i == iter)));
                }

            }
        }
    }
}
