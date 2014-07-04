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
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace SoftwareProjekt.Exercises
{
    class FraktalErzIFS : AbstractExercise
    {
        public FraktalErzIFS()
        {
            this.Id = EExercises.FraktalerzeugungMitIFS;
        }

        protected override void DoWork(IView view)
        {
            Dictionary<string, Object> inputData = null;
            List<IShape> inputForms = null;
            int steps = 0;

            // get data needed for calculations.
            inputData = view.GetInputData();

            // check inputData
            if (!inputData.ContainsKey("Form") || !inputData.ContainsKey("InputForms")
                || !inputData.ContainsKey("Steps")
                || !inputData.ContainsKey("Matrix_w1") || !inputData.ContainsKey("Matrix_w2") || !inputData.ContainsKey("Matrix_w3")
                || !inputData.ContainsKey("Vector_w1") || !inputData.ContainsKey("Vector_w2") || !inputData.ContainsKey("Vector_w3"))
            {
                return;
            }

            // get input form.
            switch ((EIFSForms)inputData["Form"])
            {
                case EIFSForms.Triangle:
                    inputForms = (List<IShape>)inputData["InputForms"];
                    break;
                case EIFSForms.Rectangle:
                    inputForms = (List<IShape>)inputData["InputForms"];
                    break;
                case EIFSForms.Circle:
                    inputForms = (List<IShape>)inputData["InputForms"];
                    break;
                case EIFSForms.Picture:
                    inputForms = (List<IShape>)inputData["InputForms"];
                    break;
                default:
                    Console.WriteLine("ERROR @ Enum switch");
                    break;
            }
            Dictionary<string, Object> outputData = new Dictionary<string, Object>();
            List<IShape> outputForms = new List<IShape>();

            steps = (int)inputData["Steps"];
            //iterations = (int)inputData["Iterations"];

            // calculate...

            //TODO: need static method in form class: transform (form object, coeff), move(form object, vector), return new form object.
            //e.g.
            //Triangle tri1 = Move(Transform(triOriginal, inputData["Coefficient"]), inputData["MoveVector"]);
            switch ((EIFSForms)inputData["Form"])
            {
                case EIFSForms.Triangle:
                    foreach (Triangle tri in inputForms)
                    {
                        if (steps == 1)
                        {
                            outputForms.Add(Triangle.AffineAbbildung(tri, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                        }
                        else if (steps == 2)
                        {
                            outputForms.Add(Triangle.AffineAbbildung(tri, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                            outputForms.Add(Triangle.AffineAbbildung(tri, (Matrix)inputData["Matrix_w2"], (Vector)inputData["Vector_w2"]));
                        }
                        else //steps == 3
                        {
                            outputForms.Add(Triangle.AffineAbbildung(tri, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                            outputForms.Add(Triangle.AffineAbbildung(tri, (Matrix)inputData["Matrix_w2"], (Vector)inputData["Vector_w2"]));
                            outputForms.Add(Triangle.AffineAbbildung(tri, (Matrix)inputData["Matrix_w3"], (Vector)inputData["Vector_w3"]));
                        }

                    }
                    break;
                case EIFSForms.Rectangle:
                    foreach (RectangleC rect in inputForms)
                    {
                        if (steps == 1)
                        {
                            outputForms.Add(RectangleC.AffineAbbildung(rect, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                        }
                        else if (steps == 2)
                        {
                            outputForms.Add(RectangleC.AffineAbbildung(rect, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                            outputForms.Add(RectangleC.AffineAbbildung(rect, (Matrix)inputData["Matrix_w2"], (Vector)inputData["Vector_w2"]));
                        }
                        else
                        {
                            outputForms.Add(RectangleC.AffineAbbildung(rect, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                            outputForms.Add(RectangleC.AffineAbbildung(rect, (Matrix)inputData["Matrix_w2"], (Vector)inputData["Vector_w2"]));
                            outputForms.Add(RectangleC.AffineAbbildung(rect, (Matrix)inputData["Matrix_w3"], (Vector)inputData["Vector_w3"]));
                        }
                    }
                    break;
                case EIFSForms.Circle:
                    foreach (Circle circle in inputForms)
                    {
                        if (steps == 1)
                        {
                            outputForms.Add(Circle.AffineAbbildung(circle, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                        }
                        else if (steps == 2)
                        {
                            outputForms.Add(Circle.AffineAbbildung(circle, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                            outputForms.Add(Circle.AffineAbbildung(circle, (Matrix)inputData["Matrix_w2"], (Vector)inputData["Vector_w2"]));
                        }
                        else
                        {
                            outputForms.Add(Circle.AffineAbbildung(circle, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                            outputForms.Add(Circle.AffineAbbildung(circle, (Matrix)inputData["Matrix_w2"], (Vector)inputData["Vector_w2"]));
                            outputForms.Add(Circle.AffineAbbildung(circle, (Matrix)inputData["Matrix_w3"], (Vector)inputData["Vector_w3"]));
                        }
                    }
                    break;
                case EIFSForms.Picture:
                    foreach (Polygon polygon in inputForms)
                    {
                        if (steps == 1)
                        {
                            outputForms.Add(Polygon.AffineAbbildung(polygon, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                        }
                        else if (steps == 2)
                        {
                            outputForms.Add(Polygon.AffineAbbildung(polygon, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                            outputForms.Add(Polygon.AffineAbbildung(polygon, (Matrix)inputData["Matrix_w2"], (Vector)inputData["Vector_w2"]));
                        }
                        else
                        {
                            outputForms.Add(Polygon.AffineAbbildung(polygon, (Matrix)inputData["Matrix_w1"], (Vector)inputData["Vector_w1"]));
                            outputForms.Add(Polygon.AffineAbbildung(polygon, (Matrix)inputData["Matrix_w2"], (Vector)inputData["Vector_w2"]));
                            outputForms.Add(Polygon.AffineAbbildung(polygon, (Matrix)inputData["Matrix_w3"], (Vector)inputData["Vector_w3"]));
                        }
                    }
                    break;
                default:
                    Console.WriteLine("ERROR @ Enum switch");
                    break;
            }

            outputData.Add("Form", inputData["Form"]);
            outputData.Add("OutputForms", outputForms);
            // call base dowork and pass the calculated data.
            base.Finalize(new ExerciseEventArgs(outputData));
        }
    }
}

