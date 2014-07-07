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
    public partial class FrmLinAbbSumBelVek : AbstractView
    {
        private Vector XplusY;

        private LineSegment _vectorInputX;
        private LineSegment _vectorInputY;
        private LineSegment _vectorInputXplusY;

        private LineSegment _vectorOutputX;
        private LineSegment _vectorOutputY;
        private LineSegment _vectorOutputXplusY;

        private string _functionBlock1;
        private string _functionBlock2;
        private string _functionBlock3;

        public FrmLinAbbSumBelVek()
        {
            InitializeComponent();

            XplusY = Vector.Add(ctlVecInX.Vector, ctlVecInY.Vector);

            ctlVecInX.TextChanged += this.OnTextChanged;
            ctlVecInY.TextChanged += this.OnTextChanged;
            ctlMaInScaleMat.TextChanged += this.OnTextChanged;

            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVecInX.Vector, Pens.Black);
            _vectorInputY = new LineSegment(new PointF(0, 0), ctlVecInY.Vector, Pens.Blue);
            _vectorInputXplusY = new LineSegment(new PointF(0, 0), XplusY, Pens.Green);

            cosInput.AddLineSegment(_vectorInputX);
            cosInput.AddLineSegment(_vectorInputY);
            cosInput.AddLineSegment(_vectorInputXplusY);

            ctlVecInX.Text = "Vector x";
            ctlVecInY.Text = "Vector y";
            ctlMaInScaleMat.Text = "Matrix M";

            // f(x + y) mit Pfeilen
            _functionBlock1 = "<mn>f</mn>\n";
            _functionBlock1 += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock1 += "<mrow>\n";
            _functionBlock1 += "<mo>(</mo>\n";
            _functionBlock1 += "<mover>\n";
            _functionBlock1 += "\t<mi>x</mi>\n";
            _functionBlock1 += "\t<mo>&rarr;</mo>\n";
            _functionBlock1 += "<mo>+</mo>\n";
            _functionBlock1 += "\t<mi>y</mi>\n";
            _functionBlock1 += "\t<mo>&rarr;</mo>\n";
            _functionBlock1 += "</mover>\n";
            _functionBlock1 += "<mo>)</mo>\n";
            _functionBlock1 += "</mrow>\n";

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

            // f(y)
            _functionBlock3 = "<mn>f</mn>\n";
            _functionBlock3 += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock3 += "<mrow>\n";
            _functionBlock3 += "<mo>(</mo>\n";
            _functionBlock3 += "<mover>\n";
            _functionBlock3 += "\t<mi>y</mi>\n";
            _functionBlock3 += "\t<mo>&rarr;</mo>\n";
            _functionBlock3 += "</mover>\n";
            _functionBlock3 += "<mo>)</mo>\n";
            _functionBlock3 += "</mrow>\n";

            CreateFormula();
        }

        private void CreateFormula()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            xmlGen.AddNode(_functionBlock1);

            Matrix m = new Matrix();
            m.X11 = (float.IsNaN(ctlMaInScaleMat.Matrix.X11)) ? 0.0f : ctlMaInScaleMat.Matrix.X11;
            m.X21 = (float.IsNaN(ctlMaInScaleMat.Matrix.X21)) ? 0.0f : ctlMaInScaleMat.Matrix.X21;
            m.X12 = (float.IsNaN(ctlMaInScaleMat.Matrix.X12)) ? 0.0f : ctlMaInScaleMat.Matrix.X12;
            m.X22 = (float.IsNaN(ctlMaInScaleMat.Matrix.X22)) ? 0.0f : ctlMaInScaleMat.Matrix.X22;

            Vector x = new Vector();
            x.X1 = (float.IsNaN(ctlVecInX.Vector.X1)) ? 0.0f : ctlVecInX.Vector.X1;
            x.X2 = (float.IsNaN(ctlVecInX.Vector.X2)) ? 0.0f : ctlVecInX.Vector.X2;

            Vector y = new Vector();
            y.X1 = (float.IsNaN(ctlVecInY.Vector.X1)) ? 0.0f : ctlVecInY.Vector.X1;
            y.X2 = (float.IsNaN(ctlVecInY.Vector.X2)) ? 0.0f : ctlVecInY.Vector.X2;

            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddNode("<mo>M</mo> \n");
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mo>(</mo> \n");
            xmlGen.AddNode("<mover>\n \t<mi>x</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");
            xmlGen.AddSign(EMathSign.Plus);
            xmlGen.AddNode("<mover>\n \t<mi>y</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");
            xmlGen.AddNode("<mo>)</mo>");
            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddMatrix(m, Color.Blue, Color.Blue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddVector(x, Color.Red);
            xmlGen.AddSign(EMathSign.Plus);
            xmlGen.AddMatrix(m, Color.Blue, Color.Blue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddVector(y, Color.Green);
            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddNode(_functionBlock2);
            xmlGen.AddSign(EMathSign.Plus);
            xmlGen.AddNode(_functionBlock3);

            xmlGen.Finish();
            ctlMathEqu.WriteEquationToPicBox(xmlGen.XmlDoc);

        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("MatrixM1", ctlMaInScaleMat.Matrix);
            retVal.Add("VectorX", ctlVecInX.Vector);
            retVal.Add("VectorY", ctlVecInY.Vector);

            return retVal;
        }

        private void butFuncionXPlusY_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosResult.ClearLineSegments();

            Console.WriteLine(sender.ToString() + " " + e.ToString());
            txtDet.Invoke(new Action(() => txtDet.Text = e.CalcValues["M1Det"].ToString()));

            _vectorOutputX = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["OutputX"], Pens.Black);
            _vectorOutputY = new LineSegment(new PointF(_vectorOutputX.Vector.X1, _vectorOutputX.Vector.X2), (Vector)e.CalcValues["OutputY"], Pens.Blue);
            _vectorOutputXplusY = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["OutputXplusY"], Pens.Green);

            cosResult.AddLineSegment(_vectorOutputX);
            cosResult.AddLineSegment(_vectorOutputY);
            cosResult.AddLineSegment(_vectorOutputXplusY);

            if (e.Final)
            {
                this.OnViewChanged(new Classes.EventArguments.ViewEventArgs(Enums.EClickedButton.CloseProgressForm));
            }
        }

        protected override bool CheckInputs()
        {
            if (ctlMaInScaleMat.Matrix.Determinant == 0)
            {
                MessageBox.Show("Die Determinante der Matrix ist 0.");
                return false;
            }
            if (ctlMaInScaleMat.Matrix.IsValid() && ctlVecInX.Vector.IsValid() && ctlVecInY.Vector.IsValid())
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
            _vectorInputX.Vector = ctlVecInX.Vector;
            _vectorInputY.StartPoint = new PointF(ctlVecInX.Vector.X1, ctlVecInX.Vector.X2);
            _vectorInputY.Vector = ctlVecInY.Vector;
            _vectorInputXplusY.Vector = Vector.Add(ctlVecInX.Vector, ctlVecInY.Vector);

            cosInput.Refresh();
            this.CreateFormula();
        }

        public override bool LoadState(Dictionary<string, object> state)
        {
            // state does not exist in workbook.
            if (state == null)
            {
                return false;
            }
            else if (!state.ContainsKey("VectorX") || !state.ContainsKey("VectorY"))
            {
                return false;
            }

            ctlVecInX.Vector = (Vector)state["VectorX"];
            ctlVecInY.Vector = (Vector)state["VectorY"];
            ctlMaInScaleMat.Matrix = (Matrix)state["MatrixM1"];

            _rtxtNotes.Text = state["Notes"].ToString();

            return true;
        }
        private void txtDeterminante_MouseEnter(object sender, EventArgs e)
        {
            txtDet.UseSystemPasswordChar = false;
        }

        private void txtDeterminante_MouseLeave(object sender, EventArgs e)
        {
            txtDet.UseSystemPasswordChar = true;
        }
    }
}
