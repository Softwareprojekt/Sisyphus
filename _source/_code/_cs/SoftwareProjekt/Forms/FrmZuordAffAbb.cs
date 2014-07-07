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

    public partial class FrmZuordAffAbb : AbstractView
    {
        string _functionBlock;
        string _functionBlock1;
        string _functionBlock2;
        string _functionBlock3;
        string _xVector;

        private Vector AB;
        private Vector AC;
        private Vector minusA;
        private Vector minusB;

        private Vector A2B2;
        private Vector A2C2;
        private Vector minusA2;

        private LineSegment _vectorInputA;
        private LineSegment _vectorInputAB;
        private LineSegment _vectorInputAC;

        private LineSegment _vectorInputA2;
        private LineSegment _vectorInputA2B2;
        private LineSegment _vectorInputA2C2;

        private LineSegment _vectorOutputE1;
        private LineSegment _vectorOutputE2;

        private Line LineE1E2;
        private Line LineBC;
        private Line LineB2C2;

        private Matrix MatrixInv;

        public FrmZuordAffAbb()
        {
            InitializeComponent();

            minusA = Vector.Multiply(ctlVectorInputA.Vector, -1f);
            AB = Vector.Add(ctlVectorInputB.Vector, minusA);
            AC = Vector.Add(ctlVectorInputC.Vector, minusA);

            minusA2 = Vector.Multiply(ctlVectorInputA.Vector, -1f);
            A2B2 = Vector.Add(ctlVectorInputB2.Vector, minusA2);
            A2C2 = Vector.Add(ctlVectorInputC2.Vector, minusA2);

            Vector E1 = new Vector(1f, 0f);
            Vector E2 = new Vector(0f, 1f);

            MatrixInv = new Matrix();

            LineE1E2 = new Line(E2, new Vector(1f, -1f));
            LineBC = new Line(AC, AB);
            LineB2C2 = new Line(A2C2, A2B2);

            _vectorInputA = new LineSegment(new PointF(0, 0), ctlVectorInputA.Vector, Pens.Green);
            _vectorInputAB = new LineSegment(new PointF(0, 0), ctlVectorInputB.Vector, Pens.Red);
            _vectorInputAC = new LineSegment(new PointF(0, 0), ctlVectorInputC.Vector, Pens.Blue);

            _vectorInputA2 = new LineSegment(new PointF(0, 0), ctlVectorInputA2.Vector, Pens.Green);
            _vectorInputA2B2 = new LineSegment(new PointF(0, 0), ctlVectorInputB2.Vector, Pens.Red);
            _vectorInputA2C2 = new LineSegment(new PointF(0, 0), ctlVectorInputC2.Vector, Pens.Blue);

            _vectorOutputE1 = new LineSegment(new PointF(0, 0), E1, Pens.Red);
            _vectorOutputE2 = new LineSegment(new PointF(0, 0), E2, Pens.Blue);

            this.ctlVectorInputA.TextChanged += this.OnTextChanged;
            this.ctlVectorInputB.TextChanged += this.OnTextChanged;
            this.ctlVectorInputC.TextChanged += this.OnTextChanged;

            this.ctlVectorInputA2.TextChanged += this.OnTextChanged;
            this.ctlVectorInputB2.TextChanged += this.OnTextChanged;
            this.ctlVectorInputC2.TextChanged += this.OnTextChanged;

            cosInputABC.AddLineSegment(_vectorInputA);
            cosInputABC.AddLineSegment(_vectorInputAB);
            cosInputABC.AddLineSegment(_vectorInputAC);
            cosInputABC.AddLine(LineBC);

            cosInputA2B2C2.AddLineSegment(_vectorInputA2);
            cosInputA2B2C2.AddLineSegment(_vectorInputA2B2);
            cosInputA2B2C2.AddLineSegment(_vectorInputA2C2);

            cosOutput.AddLineSegment(_vectorOutputE1);
            cosOutput.AddLineSegment(_vectorOutputE2);
            cosOutput.AddLine(LineE1E2);

            //f1(x)
            _functionBlock = "<msub><mi>f</mi><mn>1</mn></msub>\n";
            _functionBlock += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock += "<mrow>\n";
            _functionBlock += "<mo>(</mo>\n";
            _functionBlock += "<mover>\n";
            _functionBlock += "\t<mi>x</mi>\n";
            _functionBlock += "\t<mo>&rarr;</mo>\n";
            _functionBlock += "</mover>\n";
            _functionBlock += "<mo>)</mo>\n";
            _functionBlock += "</mrow>\n";

            //f1(y)
            _functionBlock1 = "<msub><mi>f</mi><mn>1</mn></msub>\n";
            _functionBlock1 += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock1 += "<mrow>\n";
            _functionBlock1 += "<mo>(</mo>\n";
            _functionBlock1 += "<mover>\n";
            _functionBlock1 += "\t<mi>y</mi>\n";
            _functionBlock1 += "\t<mo>&rarr;</mo>\n";
            _functionBlock1 += "</mover>\n";
            _functionBlock1 += "<mo>)</mo>\n";
            _functionBlock1 += "</mrow>\n";

            //f2(x)
            _functionBlock2 = "<msub><mi>f</mi><mn>2</mn></msub>\n";
            _functionBlock2 += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock2 += "<mrow>\n";
            _functionBlock2 += "<mo>(</mo>\n";
            _functionBlock2 += "<mover>\n";
            _functionBlock2 += "\t<mi>x</mi>\n";
            _functionBlock2 += "\t<mo>&rarr;</mo>\n";
            _functionBlock2 += "</mover>\n";
            _functionBlock2 += "<mo>)</mo>\n";
            _functionBlock2 += "</mrow>\n";

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

            CreateFormulaEquaToLeft();
            CreateFormulaEquaToRightRight();
            CreateFormulaEquaToRightLeft();

        }


        private void CreateFormulaEquaToRightLeft()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();
            Matrix m = new Matrix();
            m.X11 = AB.X1;
            m.X21 = AB.X2;
            m.X12 = AC.X1;
            m.X22 = AC.X2;

            Vector x = new Vector();
            x.X1 = (float.IsNaN(ctlVectorInputA.Vector.X1)) ? 0.0f : ctlVectorInputA.Vector.X1;
            x.X2 = (float.IsNaN(ctlVectorInputA.Vector.X2)) ? 0.0f : ctlVectorInputA.Vector.X2;
            
            MatrixInv.X11 = 1;
            MatrixInv.X12 = 1;
            MatrixInv.X21 = 1;
            MatrixInv.X22 = 1;

            xmlGen.AddNode(_functionBlock1);
            xmlGen.AddSign(EMathSign.Assignment);      
            xmlGen.AddMatrix(m, Color.Red, Color.Blue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mo>(</mo>");
            xmlGen.AddNode("<mover>\n \t<mi>y</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");
            xmlGen.AddSign(EMathSign.Minus);
            xmlGen.AddVector(x, Color.Green);
            xmlGen.AddNode("<mo>)</mo>");
            xmlGen.AddSign(EMathSign.Assignment);
            xmlGen.AddMatrix(MatrixInv, Color.Black, Color.Black);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mover>\n \t<mi>y</mi>\n \t<mo>&rarr;</mo>\n </mover>\n");
            xmlGen.AddSign(EMathSign.Minus);
            xmlGen.AddMatrix(m, Color.Red, Color.Blue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddVector(x, Color.Green);

            xmlGen.Finish();
            ctlMathEquaToRightLeft.WriteEquationToPicBox(xmlGen.XmlDoc);  
        }

        private void CreateFormulaEquaToRightRight()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            xmlGen.AddNode(_functionBlock2);
            xmlGen.AddSign(EMathSign.Assignment);

            Matrix m = new Matrix();
            m.X11 = AB.X1;
            m.X21 = AB.X2;
            m.X12 = AC.X1;
            m.X22 = AC.X2;

            xmlGen.AddMatrix(m, Color.Red, Color.Blue);
            xmlGen.AddSign(EMathSign.Multiply);
           
            xmlGen.AddNode("<mover>\n\t<mi>x</mi>\n\t<mo>&rarr;</mo>\n</mover>");
            xmlGen.AddSign(EMathSign.Plus);
            xmlGen.AddVector(ctlVectorInputA.Vector, Color.Green);


            xmlGen.Finish();
            ctlMathEquaToRightRight.WriteEquationToPicBox(xmlGen.XmlDoc);  
        }

        private void CreateFormulaEquaToLeft()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            xmlGen.AddNode(_functionBlock);

            xmlGen.AddSign(EMathSign.Assignment);

            Matrix m = new Matrix();
            m.X11 = AB.X1;
            m.X21 = AB.X2;
            m.X12 = AC.X1;
            m.X22 = AC.X2;

            xmlGen.AddMatrix(m, Color.Red, Color.Blue);
            xmlGen.AddSign(EMathSign.Multiply);
            xmlGen.AddNode("<mover>\n\t<mi>x</mi>\n\t<mo>&rarr;</mo>\n</mover>");
            xmlGen.AddSign(EMathSign.Plus);
            xmlGen.AddVector(ctlVectorInputA.Vector, Color.Green);

            xmlGen.Finish();
            ctlMathEquaToLeft.WriteEquationToPicBox(xmlGen.XmlDoc);        
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("VectorA", ctlVectorInputA.Vector);
            retVal.Add("VectorB", ctlVectorInputB.Vector);
            retVal.Add("VectorC", ctlVectorInputC.Vector);
            retVal.Add("VectorA2", ctlVectorInputA2.Vector);
            retVal.Add("VectorB2", ctlVectorInputB2.Vector);
            retVal.Add("VectorC2", ctlVectorInputC2.Vector);


            return retVal;
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosOutput.ClearLineSegments();

            LineBC = new Line(ctlVectorInputB.Vector, (Vector)e.CalcValues["LineBC"]);
            LineB2C2 = new Line(ctlVectorInputB2.Vector, (Vector)e.CalcValues["LineB2C2"]);
            MatrixInv = (Matrix)e.CalcValues["Minv"];
            cosInputABC.AddLine(LineBC);
            cosInputA2B2C2.AddLine(LineB2C2);

            if (e.Final)
            {
                this.OnViewChanged(new Classes.EventArguments.ViewEventArgs(Enums.EClickedButton.CloseProgressForm));
            }
        }

        private void butFunction1X_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            CreateFormulaEquaToLeft();
        }

        private void butInverseFunction1X_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        private void butFunction2X_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        private void butFx_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        protected override bool CheckInputs()
        {
            if (ctlVectorInputA.Vector.IsValid() && ctlVectorInputB.Vector.IsValid() && ctlVectorInputC.Vector.IsValid() && ctlVectorInputA2.Vector.IsValid() && ctlVectorInputB2.Vector.IsValid() && ctlVectorInputC2.Vector.IsValid())
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
            minusA = Vector.Multiply(ctlVectorInputA.Vector, -1f);
            AB = Vector.Add(ctlVectorInputB.Vector, minusA);
            AC = Vector.Add(ctlVectorInputC.Vector, minusA);

            minusA2 = Vector.Multiply(ctlVectorInputA2.Vector, -1f);
            A2B2 = Vector.Add(ctlVectorInputB2.Vector, minusA2);
            A2C2 = Vector.Add(ctlVectorInputC2.Vector, minusA2);

            _vectorInputA.Vector = ctlVectorInputA.Vector;
            _vectorInputAB.StartPoint = new PointF(ctlVectorInputA.Vector.X1, ctlVectorInputA.Vector.X2);
            _vectorInputAB.Vector = AB;
            _vectorInputAC.StartPoint = new PointF(ctlVectorInputA.Vector.X1, ctlVectorInputA.Vector.X2);
            _vectorInputAC.Vector = AC;

            _vectorInputA2.Vector = ctlVectorInputA2.Vector;
            _vectorInputA2B2.StartPoint = new PointF(ctlVectorInputA2.Vector.X1, ctlVectorInputA2.Vector.X2);
            _vectorInputA2B2.Vector = A2B2;
            _vectorInputA2C2.StartPoint = new PointF(ctlVectorInputA2.Vector.X1, ctlVectorInputA2.Vector.X2);
            _vectorInputA2C2.Vector = A2C2;

            cosInputABC.Refresh();
            cosInputA2B2C2.Refresh();
        }

        public override bool LoadState(Dictionary<string, object> state)
        {
            // state does not exist in workbook.
            if (state == null)
            {
                return false;
            }
            else if (!state.ContainsKey("VectorA"))
            {
                return false;
            }
            else if (!state.ContainsKey("VectorB"))
            {
                return false;
            }
            else if (!state.ContainsKey("VectorC"))
            {
                return false;
            }
            else if (!state.ContainsKey("VectorA2"))
            {
                return false;
            }
            else if (!state.ContainsKey("VectorB2"))
            {
                return false;
            }
            else if (!state.ContainsKey("VectorC2"))
            {
                return false;
            }
            else if (!state.ContainsKey("Notes"))
            {
                return false;
            }

            ctlVectorInputA.Vector = (Vector)state["VectorA"];
            ctlVectorInputB.Vector = (Vector)state["VectorB"];
            ctlVectorInputC.Vector = (Vector)state["VectorC"];
            ctlVectorInputA2.Vector = (Vector)state["VectorA2"];
            ctlVectorInputB2.Vector = (Vector)state["VectorB2"];
            ctlVectorInputC2.Vector = (Vector)state["VectorC2"];
            _rtxtNotes.Text = (string)state["Notes"];
            return true;
        }

    }
}
