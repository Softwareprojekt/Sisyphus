
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
using System.Windows.Forms;


namespace SoftwareProjekt.Forms
{
    public partial class TestView : AbstractView
    {
        public TestView()
        {
            InitializeComponent();
       
            MathXmlGenerator xml = new MathXmlGenerator();
            LineSegment ls = new LineSegment(new PointF(0.0f, 3f), new Vector(0, -2.5f));
            ls.Color = Pens.Blue;

            _coordSys.AddLineSegment(ls);

            Matrix m1 = new Matrix(1.0f, 2.0f, 3.0f, 4.0f);

            Vector v1 = new Vector(1.4f, 10.2f);
            Vector v2 = new Vector(2.8f, 12.17f);

            string expr1 = "cos (&phi;)";            
            string expr2 = "cos(&phi; + " + MathXmlGenerator.PiHalfSign + ")";
            string expr3 = "sin(&phi;)";
            string expr4 = "sin(&phi; + " + MathXmlGenerator.PiHalfSign + ")";

            string expr5 = "cos (&phi;)";
            string expr6 = "cos(&phi; + " + MathXmlGenerator.PiHalfSign + ")";
            string expr7 = "sin(&phi;)";
            string expr8 = "sin(&phi; + " + MathXmlGenerator.PiHalfSign + ")";

            List<string> expressions = new List<string>();
            expressions.Add(expr1);
            expressions.Add(expr2);
            expressions.Add(expr3);
            expressions.Add(expr4);

            List<string> expressions1 = new List<string>();
            expressions1.Add(expr2);
            expressions1.Add(expr4);


            List<string> expressions2 = new List<string>();
            expressions2.Add(expr1);
            expressions2.Add(expr2);
            expressions2.Add(expr3);
            expressions2.Add(expr4);
            expressions2.Add(expr5);
            expressions2.Add(expr6);
            expressions2.Add(expr7);
            expressions2.Add(expr8);

            List<Color> colors = new List<Color>();
            colors.Add(Color.Red);
            colors.Add(Color.Blue);
            colors.Add(Color.Green);
            colors.Add(Color.Orange);
            colors.Add(Color.Red);
            colors.Add(Color.Blue);
            colors.Add(Color.Green);
            colors.Add(Color.Orange);

            /*xml.AddVector(v1, Color.Red);

            xml.AddSign(EMathSign.Assignment);
            xml.AddMatrix(m1, Color.Blue, Color.DarkGreen);

            xml.AddSign(EMathSign.Assignment);
            xml.AddCombinedVectors(v1, v2, Color.DarkGreen, Color.DarkOrange, EMathSign.Minus);*/

            // xml.AddMathExpression(expressions, colors, EMathSign.Minus, EMathType.Vector);

            // xml.AddMathExpression(expressions1, colors, EMathSign.Minus, EMathType.None);

            xml.AddMathExpression(expressions2, colors, EMathSign.Minus, EMathType.Matrix);

            xml.Finish();

            ctlFormularTest.WriteEquationToPicBox(xml.XmlDoc);
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            Console.WriteLine(sender.ToString() + " " + e.ToString());
            _matrix.Matrix = (Matrix)e.CalcValues["Matrix1"];
            _vector.Vector = (Vector)e.CalcValues["Vector1"];
        }

        private void _btnCalc_Click(object sender, EventArgs e)
        {
        	if (this.CheckInputs())
        	{
            	this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        	}
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("Matrix1", _matrix.Matrix);
            retVal.Add("Vector1", _vector.Vector);

            return retVal;
        }
        
		protected override bool CheckInputs()
		{
			if (_matrix.Matrix.IsValid() && _vector.Vector.IsValid())
			{
#if DEBUG
				Console.WriteLine("SUCCESS @ Inputs are valid.");
#endif
				return true;
			}
#if DEBUG
			Console.WriteLine("ERROR @ Inputs are not valid.");
#endif
			return false;
		}

        public override bool LoadState(Dictionary<string, Object> state)
        {
            return false;
        }
    }
}
