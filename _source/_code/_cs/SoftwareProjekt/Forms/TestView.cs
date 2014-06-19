
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
using SoftwareProjekt.Classes.Xml;
using SoftwareProjekt.Enums;
using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;


namespace SoftwareProjekt.Forms
{
    public partial class TestView :AbstractView
    {
        public TestView()
        {
            InitializeComponent();
           // ctlFormDrawTest.Equation = "f(x^(->)= sqrt(x))";
            //ctlFormDrawTest.WriteEquationToPicBox(ctlFormDrawTest.Equation);

            MathXmlGenerator xml = new MathXmlGenerator();

            Matrix m1 = new Matrix(1.0f, 2.0f, 3.0f, 4.0f);

            Vector v1 = new Vector(1.4f, 10.2f);

            //xml.AddNode("<mover> <msub> <mi>x</mi> <mn>0</mn> </msub> <mo>&rarr;</mo> </mover>");
            xml.AddVector(v1, Color.Red);

            xml.AddNode("<mo> = </mo>");
            xml.AddMatrix(m1, Color.Blue, Color.DarkGreen);

            xml.Finish();

            ctlFormDrawTest.WriteEquationToPicBox(xml.XmlDoc);
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            Console.WriteLine(sender.ToString() + " " + e.ToString());
            _matrix.Matrix = (Matrix)e.CalcValues["Matrix1"];
            _vector.Vector = (Vector)e.CalcValues["Vector1"];
        }

        private void _btnCalc_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("Matrix1", _matrix.Matrix);
            retVal.Add("Vector1", _vector.Vector);

            return retVal;
        }
    }
}
