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
    public partial class FrmHinterLinAbb : AbstractView
    {

        private LineSegment _vectorInputX;
        private LineSegment _vectorOutputX1;
        private LineSegment _vectorOutputX2;

        private string _functionBlock;
        private string _functionBlock1;
        private string _functionBlock2;

        private Matrix m1;
        private Matrix m2;
        private Vector x;

        public FrmHinterLinAbb()
        {
            InitializeComponent();

            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVectorInputX.Vector);

            ctlVectorInputX.TextChanged += this.OnTextChanged;
            ctlMatrixInputM1.TextChanged += this.OnTextChanged;
            ctlMatrixInputM2.TextChanged += OnTextChanged;

            cosInput.AddLineSegment(_vectorInputX);

            m1 = new Matrix();
            m2 = new Matrix();

            x = new Vector();
            // f(x)
            _functionBlock = "<mn>f</mn>\n";
            _functionBlock += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock += "<mrow>\n";
            _functionBlock += "<mo>(</mo>\n";
            _functionBlock += "<mover>\n";
            _functionBlock += "\t<mi>x</mi>\n";
            _functionBlock += "\t<mo>&rarr;</mo>\n";
            _functionBlock += "</mover>\n";
            _functionBlock += "<mo>)</mo>\n";
            _functionBlock += "</mrow>\n";

            // g(x)
            _functionBlock1 = "<mn>g</mn>\n";
            _functionBlock1 += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock1 += "<mrow>\n";
            _functionBlock1 += "<mo>(</mo>\n";
            _functionBlock1 += "<mover>\n";
            _functionBlock1 += "\t<mi>x</mi>\n";
            _functionBlock1 += "\t<mo>&rarr;</mo>\n";
            _functionBlock1 += "</mover>\n";
            _functionBlock1 += "<mo>)</mo>\n";
            _functionBlock1 += "</mrow>\n";

            //g(f(x))
            _functionBlock2 +="<mrow>";
            _functionBlock2 += "\t\t<mi>g</mi><mo>&ApplyFunction;</mo>";
            _functionBlock2 += "\t\t<mo>(</mo>";
            _functionBlock2 += "\t\t<mi>f</mi><mo>&ApplyFunction;</mo>";
            _functionBlock2 += "\t\t<mo>(</mo>";
            _functionBlock2 += "\t\t<mover accent=" + "\" true \""  + ">";
            _functionBlock2 += "\t\t\t\t<mi>x</mi>";
            _functionBlock2 += "\t\t\t<mo>&rarr;</mo>";
            _functionBlock2 += "\t\t</mover>";
            _functionBlock2 += "\t\t<mo>)</mo>";
            _functionBlock2 += "\t\t<mo>)</mo>";
            _functionBlock2 += "</mrow>";

            CreateFormularTopArrow();
            CreateFormularLeftArrow();
            CreateFormularRightArrow();
        }

        private void CreateFormularTopArrow()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            m1.X11 = (float.IsNaN(ctlMatrixInputM1.Matrix.X11)) ? 0.0f : ctlMatrixInputM1.Matrix.X11;
            m1.X21 = (float.IsNaN(ctlMatrixInputM1.Matrix.X21)) ? 0.0f : ctlMatrixInputM1.Matrix.X21;
            m1.X12 = (float.IsNaN(ctlMatrixInputM1.Matrix.X12)) ? 0.0f : ctlMatrixInputM1.Matrix.X12;
            m1.X22 = (float.IsNaN(ctlMatrixInputM1.Matrix.X22)) ? 0.0f : ctlMatrixInputM1.Matrix.X22;

            m2.X11 = (float.IsNaN(ctlMatrixInputM2.Matrix.X11)) ? 0.0f : ctlMatrixInputM2.Matrix.X11;
            m2.X21 = (float.IsNaN(ctlMatrixInputM2.Matrix.X21)) ? 0.0f : ctlMatrixInputM2.Matrix.X21;
            m2.X12 = (float.IsNaN(ctlMatrixInputM2.Matrix.X12)) ? 0.0f : ctlMatrixInputM2.Matrix.X12;
            m2.X22 = (float.IsNaN(ctlMatrixInputM2.Matrix.X22)) ? 0.0f : ctlMatrixInputM2.Matrix.X22;

            x.X1 = (float.IsNaN(ctlVectorInputX.Vector.X1)) ? 0.0f : ctlVectorInputX.Vector.X1;
            x.X2 = (float.IsNaN(ctlVectorInputX.Vector.X2)) ? 0.0f : ctlVectorInputX.Vector.X2;

            xmlGen.AddNode(_functionBlock2);
            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddMatrix(m2, Color.DodgerBlue, Color.DodgerBlue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode(_functionBlock);
            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddMatrix(m2, Color.DodgerBlue, Color.DodgerBlue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mo>(</mo>");
            xmlGen.AddMatrix(m1, Color.Cyan, Color.Cyan);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mover>\n \t<mi>x</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");
            xmlGen.AddNode("<mo>)</mo>");
            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddNode("<mo>(</mo>");
            xmlGen.AddMatrix(m2, Color.DodgerBlue, Color.DodgerBlue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddMatrix(m1, Color.Cyan, Color.Cyan);
            xmlGen.AddNode("<mo>)</mo>");
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mover>\n \t<mi>x</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");

            xmlGen.Finish();
            ctlMathEquTotal.WriteEquationToPicBox(xmlGen.XmlDoc);
           
        }

        private void CreateFormularLeftArrow()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            xmlGen.AddNode(_functionBlock);
            
            m1.X11 = (float.IsNaN(ctlMatrixInputM1.Matrix.X11)) ? 0.0f : ctlMatrixInputM1.Matrix.X11;
            m1.X21 = (float.IsNaN(ctlMatrixInputM1.Matrix.X21)) ? 0.0f : ctlMatrixInputM1.Matrix.X21;
            m1.X12 = (float.IsNaN(ctlMatrixInputM1.Matrix.X12)) ? 0.0f : ctlMatrixInputM1.Matrix.X12;
            m1.X22 = (float.IsNaN(ctlMatrixInputM1.Matrix.X22)) ? 0.0f : ctlMatrixInputM1.Matrix.X22;
           
            x.X1 = (float.IsNaN(ctlVectorInputX.Vector.X1)) ? 0.0f : ctlVectorInputX.Vector.X1;
            x.X2 = (float.IsNaN(ctlVectorInputX.Vector.X2)) ? 0.0f : ctlVectorInputX.Vector.X2;

            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddMatrix(m1, Color.Cyan, Color.Cyan);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mover>\n \t<mi>x</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");

            xmlGen.Finish();
            ctlMathEquLeft.WriteEquationToPicBox(xmlGen.XmlDoc);
        }

        private void CreateFormularRightArrow()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            xmlGen.AddNode(_functionBlock1);

            m2.X11 = (float.IsNaN(ctlMatrixInputM2.Matrix.X11)) ? 0.0f : ctlMatrixInputM2.Matrix.X11;
            m2.X21 = (float.IsNaN(ctlMatrixInputM2.Matrix.X21)) ? 0.0f : ctlMatrixInputM2.Matrix.X21;
            m2.X12 = (float.IsNaN(ctlMatrixInputM2.Matrix.X12)) ? 0.0f : ctlMatrixInputM2.Matrix.X12;
            m2.X22 = (float.IsNaN(ctlMatrixInputM2.Matrix.X22)) ? 0.0f : ctlMatrixInputM2.Matrix.X22;

            x.X1 = (float.IsNaN(ctlVectorInputX.Vector.X1)) ? 0.0f : ctlVectorInputX.Vector.X1;
            x.X2 = (float.IsNaN(ctlVectorInputX.Vector.X2)) ? 0.0f : ctlVectorInputX.Vector.X2;

            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddMatrix(m2, Color.DodgerBlue, Color.DodgerBlue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mover>\n \t<mi>x</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");

            xmlGen.Finish();
            ctlMathEquRight.WriteEquationToPicBox(xmlGen.XmlDoc);
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("MatrixM1", ctlMatrixInputM1.Matrix);
            retVal.Add("MatrixM2", ctlMatrixInputM2.Matrix);
            retVal.Add("VectorX", ctlVectorInputX.Vector);

            return retVal;
        }

        private void dutDeterminante_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosOutput1.ClearLineSegments();
            cosOutput2.ClearLineSegments();

            Console.WriteLine(sender.ToString() + " " + e.ToString());
            ctlVectorOutputX1.Vector = (Vector)e.CalcValues["VectorX1"];
            ctlVectorOutputX2.Vector = (Vector)e.CalcValues["VectorX2"];

            _vectorOutputX1 = new LineSegment(new PointF(0f, 0f), ctlVectorOutputX1.Vector, Pens.Black);
            _vectorOutputX2 = new LineSegment(new PointF(0f, 0f), ctlVectorOutputX2.Vector, Pens.Black);

            cosOutput1.AddLineSegment(_vectorOutputX1);
            cosOutput2.AddLineSegment(_vectorOutputX2);

            if (e.Final)
            {
                this.OnViewChanged(new Classes.EventArguments.ViewEventArgs(Enums.EClickedButton.CloseProgressForm));
            }
        }

        private void butFx_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        private void butDeterminante2_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        private void butGx_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
               this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        private void butGFx_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        protected override bool CheckInputs()
        {
            if (ctlMatrixInputM1.Matrix.IsValid() && ctlMatrixInputM2.Matrix.IsValid() && ctlVectorInputX.Vector.IsValid())
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
            CreateFormularLeftArrow();
            CreateFormularRightArrow();
            CreateFormularTopArrow();
            cosInput.Refresh();
        }

        void ctlMatrixInputM2_TextChanged(object sender, EventArgs e)
        {
            _vectorInputX.Vector = ctlVectorInputX.Vector;
            CreateFormularRightArrow();
            CreateFormularTopArrow();
            cosInput.Refresh();
        }

        public override bool LoadState(Dictionary<string, object> state)
        {
            // state does not exist in workbook.
            if (state == null)
            {
                return false;
            }
            else if (!state.ContainsKey("VectorX"))
            {
                return false;
            }

            ctlVectorInputX.Vector = (Vector)state["VectorX"];
            return true;
        }
    }
}
