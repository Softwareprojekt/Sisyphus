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
    public partial class FrmVertrMitLinearkomb : AbstractView
    {
        string _functionBlock;
        string _xVector;

        private LineSegment _vectorInputX;
        private LineSegment _vectorInputM1;
        private LineSegment _vectorInputM2;
        private LineSegment _vectorInputEV1;
        private LineSegment _vectorInputEV2;

        private LineSegment _vectorOutputX;

        public FrmVertrMitLinearkomb()
        {
            InitializeComponent();

            this.ctlVectorInputEV1.txtEle11.Text = "1";
            this.ctlVectorInputEV1.txtEle21.Text = "0";

            this.ctlVectorInputEV2.txtEle11.Text = "0";
            this.ctlVectorInputEV2.txtEle21.Text = "1";

            _vectorInputEV1 = new LineSegment(new PointF(0, 0), ctlVectorInputEV1.Vector, Pens.Red);
            _vectorInputEV2 = new LineSegment(new PointF(0, 0), ctlVectorInputEV2.Vector, Pens.Blue);
            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVectorInputX.Vector, Pens.Black);

            _vectorInputM1 = new LineSegment(new PointF(0, 0), ctlVectorInputM1.Vector, Pens.Red);
            _vectorInputM2 = new LineSegment(new PointF(0, 0), ctlVectorInputM2.Vector, Pens.Blue);

            this.ctlVectorInputX.TextChanged += this.OnTextChanged;
            cosInput.AddLineSegment(_vectorInputX);
            cosInput.AddLineSegment(_vectorInputEV1);
            cosInput.AddLineSegment(_vectorInputEV2);

            this.ctlVectorInputM1.TextChanged += this.OnTextChanged;
            this.ctlVectorInputM2.TextChanged += this.OnTextChanged;
            cosOutput.AddLineSegment(_vectorInputM1);
            cosOutput.AddLineSegment(_vectorInputM2);


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

            _xVector += "<mfenced open='(' close=')' separators=''>\n";
            _xVector += "<mtable>\n";

            _xVector += "\t<mtr>\n";
            _xVector += "\t\t<mtd>\n";
            _xVector += "\t\t\t<msub>\n";
            _xVector += "\t\t\t\t<mi>x</mi>\n";
            _xVector += "\t\t\t\t<mn>1</mn>\n";
            _xVector += "\t\t\t</msub>\n";
            _xVector += "\t\t</mtd>\n";
            _xVector += "\t</mtr>\n";

            _xVector += "\t<mtr>\n";
            _xVector += "\t\t<mtd>\n";
            _xVector += "\t\t\t<msub>\n";
            _xVector += "\t\t\t\t<mi>x</mi>\n";
            _xVector += "\t\t\t\t<mn>2</mn>\n";
            _xVector += "\t\t\t</msub>\n";
            _xVector += "\t\t</mtd>\n";
            _xVector += "\t</mtr>\n";

            _xVector += "</mtable>\n";
            _xVector += "</mfenced>\n";

            CreateFormula();
        }

        private void CreateFormula()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            xmlGen.AddNode(_functionBlock);

            xmlGen.AddSign(EMathSign.Assignment);

            Matrix m = new Matrix();

            m.X11 = (float.IsNaN(ctlVectorInputM1.Vector.X1)) ? 0.0f : ctlVectorInputM1.Vector.X1;
            m.X21 = (float.IsNaN(ctlVectorInputM1.Vector.X2)) ? 0.0f : ctlVectorInputM1.Vector.X2;
            m.X12 = (float.IsNaN(ctlVectorInputM2.Vector.X1)) ? 0.0f : ctlVectorInputM2.Vector.X1;
            m.X22 = (float.IsNaN(ctlVectorInputM2.Vector.X2)) ? 0.0f : ctlVectorInputM2.Vector.X2;



            xmlGen.AddMatrix(m, Color.Purple, Color.Violet);
            xmlGen.AddSign(EMathSign.Multiply);

            xmlGen.AddNode(_xVector);
            xmlGen.AddSign(EMathSign.Assignment);

            List<string> expressions = new List<string>();
            expressions.Add(m.X11.ToString());
            expressions.Add("<msub><mi>x</mi><mn>1</mn></msub>");
            expressions.Add(m.X12.ToString());
            expressions.Add("<msub><mi>x</mi><mn>2</mn></msub>");
            expressions.Add(m.X21.ToString());
            expressions.Add("<msub><mi>x</mi><mn>1</mn></msub>");
            expressions.Add(m.X22.ToString());
            expressions.Add("<msub><mi>x</mi><mn>2</mn></msub>");

            List<Color> colors = new List<Color>();

            colors.Add(Color.Purple);
            colors.Add(Color.Black);
            colors.Add(Color.Violet);
            colors.Add(Color.Black);

            colors.Add(Color.Purple);
            colors.Add(Color.Black);
            colors.Add(Color.Violet);
            colors.Add(Color.Black);

            xmlGen.AddMathExpression(expressions, colors, EMathSign.Plus, EMathType.ComplexVector);
            xmlGen.AddSign(EMathSign.Assignment);

            xmlGen.AddNode("<msub><mi>x</mi><mn>1</mn></msub>");
            xmlGen.AddSign(EMathSign.Multiply);

            Vector v1 = new Vector(m.X11, m.X21);
            xmlGen.AddVector(v1, Color.Purple);

            xmlGen.AddSign(EMathSign.Plus);

            xmlGen.AddNode("<msub><mi>x</mi><mn>2</mn></msub>");
            xmlGen.AddSign(EMathSign.Multiply);

            Vector v2 = new Vector(m.X12, m.X22);
            xmlGen.AddVector(v2, Color.Violet);



            xmlGen.Finish();

            ctlMathEqua.WriteEquationToPicBox(xmlGen.XmlDoc);
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("VectorX", ctlVectorInputX.Vector);
            retVal.Add("VectorM1", ctlVectorInputM1.Vector);
            retVal.Add("VectorM2", ctlVectorInputM2.Vector);
            retVal.Add("EV1", ctlVectorInputEV1.Vector);
            retVal.Add("EV2", ctlVectorInputEV2.Vector);

            return retVal;
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosOutput.ClearLineSegments();

            _vectorOutputX = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorX"], Pens.Black);
            txtDet.Invoke(new Action(() => txtDet.Text = e.CalcValues["detM"].ToString()));

            cosOutput.AddLineSegment(_vectorOutputX);
            cosOutput.AddLineSegment(_vectorInputM1);
            cosOutput.AddLineSegment(_vectorInputM2);

            if (e.Final)
            {
                this.OnViewChanged(new Classes.EventArguments.ViewEventArgs(Enums.EClickedButton.CloseProgressForm));
            }
        }

        private void butFunctionX_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        protected override bool CheckInputs()
        {
            if (ctlVectorInputX.Vector.IsValid() && ctlVectorInputM1.Vector.IsValid() && ctlVectorInputM2.Vector.IsValid() && ctlVectorInputEV1.Vector.IsValid() && ctlVectorInputEV2.Vector.IsValid())
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
            cosInput.ClearLines();
            _vectorInputX.Vector = ctlVectorInputX.Vector;
            _vectorInputM1.Vector = ctlVectorInputM1.Vector;
            _vectorInputM2.Vector = ctlVectorInputM2.Vector;
            cosInput.Refresh();
            cosOutput.Refresh();

            CreateFormula();
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
            else if (!state.ContainsKey("VectorM1"))
            {
                return false;
            }
            else if (!state.ContainsKey("VectorM2"))
            {
                return false;
            }

            ctlVectorInputX.Vector = (Vector)state["VectorX"];
            ctlVectorInputM1.Vector = (Vector)state["VectorM1"];
            ctlVectorInputM2.Vector = (Vector)state["VectorM2"];
            _rtxtNotes.Text = state["Notes"].ToString();

            CreateFormula();

            return true;
        }

        private void txtDet_MouseEnter(object sender, EventArgs e)
        {
            txtDet.UseSystemPasswordChar = false;
        }

        private void txtDet_MouseLeave(object sender, EventArgs e)
        {
            txtDet.UseSystemPasswordChar = true;
        }
    }
}