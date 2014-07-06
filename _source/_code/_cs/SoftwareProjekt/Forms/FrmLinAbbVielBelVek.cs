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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoftwareProjekt.Classes.EventArguments;
using SoftwareProjekt.Classes.Math;
using SoftwareProjekt.Enums;
using SoftwareProjekt.Interfaces;
using SoftwareProjekt.Classes.Xml;

namespace SoftwareProjekt.Forms
{
    public partial class FrmLinAbbVielBelVek : AbstractView
    {
        private LineSegment _vectorInputX;
        private LineSegment _vectorOutputX;
        private LineSegment _vectorInputXScaled;
        private LineSegment _vectorOutputXScaled;

        string _functionBlock;
        string _functionBlock2;

        public FrmLinAbbVielBelVek()
        {
            InitializeComponent();

            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVectorInputX.Vector, Pens.Blue);

            this.ctlVectorInputX.TextChanged += this.OnTextChanged;
            cosInput.AddLineSegment(_vectorInputX);

            // &alpha;
            // f(alpha * x)
            _functionBlock = "<mn>f</mn>\n";
            _functionBlock += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock += "<mrow>\n";
            _functionBlock += "<mo>(</mo>\n";
            _functionBlock += "<mover>\n";
            _functionBlock += "\t<mi>&alpha; * x</mi>\n";
            _functionBlock += "\t<mo>&rarr;</mo>\n";
            _functionBlock += "</mover>\n";
            _functionBlock += "<mo>)</mo>\n";
            _functionBlock += "</mrow>\n";

            // f(x)
            _functionBlock2 = "<mn>f</mn>\n";
            _functionBlock2 += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock2 += "<mrow>\n";
            _functionBlock2 += "<mo>(</mo>\n";
            _functionBlock2 += "<mover>\n";
            _functionBlock2 += "\t<mi>x</mi>\n";
            _functionBlock2 += "\t<mo>&rarr;</mo>\n";
            _functionBlock2 += "</mover>\n";
            _functionBlock2 += "<mo>)</mo>\n";
            _functionBlock2 += "</mrow>\n";

            CreateFormular();
        }

        private void CreateFormular()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            xmlGen.AddNode(_functionBlock);
            xmlGen.AddSign(EMathSign.Assignment);

            Matrix m = new Matrix();
            m.X11 = (float.IsNaN(ctlMatrixInput.Matrix.X11)) ? 0.0f : ctlMatrixInput.Matrix.X11;
            m.X21 = (float.IsNaN(ctlMatrixInput.Matrix.X21)) ? 0.0f : ctlMatrixInput.Matrix.X21;
            m.X12 = (float.IsNaN(ctlMatrixInput.Matrix.X12)) ? 0.0f : ctlMatrixInput.Matrix.X12;
            m.X22 = (float.IsNaN(ctlMatrixInput.Matrix.X22)) ? 0.0f : ctlMatrixInput.Matrix.X22;

            Vector x = new Vector();
            x.X1 = (float.IsNaN(ctlVectorInputX.Vector.X1)) ? 0.0f : ctlVectorInputX.Vector.X1;
            x.X2 = (float.IsNaN(ctlVectorInputX.Vector.X2)) ? 0.0f : ctlVectorInputX.Vector.X2;

            xmlGen.AddMatrix(m, Color.Blue, Color.Blue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mi>&alpha;</mi>");
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mover>\n \t<mi>x</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");
            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddNode("<mi>&alpha;</mi>");
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddMatrix(m, Color.Blue, Color.Blue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mover>\n \t<mi>x</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");
            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddNode("<mi>&alpha;</mi>");
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode(_functionBlock2);

            xmlGen.Finish();
            ctlMathEqua.WriteEquationToPicBox(xmlGen.XmlDoc);
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("MatrixM1", ctlMatrixInput.Matrix);
            retVal.Add("VectorX", ctlVectorInputX.Vector);
            retVal.Add("Scalar", _ctlScalarInput.FloatValue);
            
            return retVal;
        }

        private void butDeterminante_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosInput.ClearLineSegments();
            cosOutput.ClearLineSegments();
            cosInput.AddLineSegment(_vectorInputX);

            Console.WriteLine(sender.ToString() + " " + e.ToString());

            _vectorInputXScaled = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorXScaledInput"], Pens.Black);
            _vectorOutputX = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorX"], Pens.Blue);
            _vectorOutputXScaled = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorXScaledOutput"], Pens.Black);

            cosInput.AddLineSegment(_vectorInputXScaled);
            cosOutput.AddLineSegment(_vectorOutputX);
            cosOutput.AddLineSegment(_vectorOutputXScaled);
        }

        private void butFunctionAMultX_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

		protected override bool CheckInputs()
		{
            if (ctlMatrixInput.Matrix.IsValid() && ctlVectorInputX.Vector.IsValid() && _ctlScalarInput.IsValid())
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

        public void OnTextChanged(object sender, EventArgs e)
        {
            _vectorInputX.Vector = ctlVectorInputX.Vector;
            cosInput.Refresh();
        }

        public override bool LoadState(Dictionary<string, object> state)
        {
            // state does not exist in workbook.
            if (state == null)
            {
                return false;
            }
            else if (!state.ContainsKey("VectorX") || !state.ContainsKey("Scalar"))
            {
                return false;
            }

            ctlVectorInputX.Vector = (Vector)state["VectorX"];
            _ctlScalarInput.Text = state["Scalar"].ToString();
            return true;
        }
    }
}
