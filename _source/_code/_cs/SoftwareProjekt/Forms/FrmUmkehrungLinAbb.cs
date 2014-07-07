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
    public partial class FrmUmkehrungLinAbb : AbstractView
    {
        string _functionBlock;
        string _functionBlock2;

        private LineSegment _vectorInputX;
        private LineSegment _vectorInputY;

        private LineSegment _vectorOutputX;
        private LineSegment _vectorOutputY;

        private Matrix _invMatrix; 
        public FrmUmkehrungLinAbb()
        {
            InitializeComponent();

            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVectorInputX.Vector, Pens.Black);
            _vectorInputY = new LineSegment(new PointF(0, 0), ctlVectorInputY.Vector, Pens.Black);
            _invMatrix = new Matrix();

            ctlVectorInputX.Text = "Vektor x";
            ctlMatrixInput.Text = "Matrix M";
            ctlVectorInputY.Text = "Vektor y";

            ctlVectorInputX.TextChanged += this.OnTextChanged;
            ctlVectorInputY.TextChanged += this.OnTextChanged;
            ctlMatrixInput.TextChanged += this.OnTextChanged;

            cosInput.AddLineSegment(_vectorInputX);
            cosOutput.AddLineSegment(_vectorInputY);

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

            // f(y)^-1
            _functionBlock2 = "<mn>f</mn>\n";
            _functionBlock2 += "<mo>&ApplyFunction;</mo>\n";
            _functionBlock2 += "<mrow>\n";
            _functionBlock2 += "<mo>(</mo>\n";
            _functionBlock2 += "<mover>\n";
            _functionBlock2 += "\t<mi>y</mi>\n";
            _functionBlock2 += "\t<mo>&rarr;</mo>\n";
            _functionBlock2 += "</mover>\n";
            _functionBlock2 += "<mo>)</mo>\n";
            _functionBlock2 += "</mrow>\n";

            // Erzeugt Formel für "Pfeil nach rechts"
            CreateFormularToRight();
            // Erzeugt Formel für "Pfeil nach rechts"
            CreateFormularToLeft();

        }

        private void CreateFormularToRight()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            // f(x)
            xmlGen.AddNode(_functionBlock);

            // =
            xmlGen.AddSign(EMathSign.Assignment);

            // Matrix
            Matrix m = new Matrix();
            m.X11 = (float.IsNaN(ctlMatrixInput.Matrix.X11)) ? 0.0f : ctlMatrixInput.Matrix.X11;
            m.X21 = (float.IsNaN(ctlMatrixInput.Matrix.X21)) ? 0.0f : ctlMatrixInput.Matrix.X21;
            m.X12 = (float.IsNaN(ctlMatrixInput.Matrix.X12)) ? 0.0f : ctlMatrixInput.Matrix.X12;
            m.X22 = (float.IsNaN(ctlMatrixInput.Matrix.X22)) ? 0.0f : ctlMatrixInput.Matrix.X22;

            // Vektoren
            Vector x = new Vector();
            x.X1 = (float.IsNaN(ctlVectorInputX.Vector.X1)) ? 0.0f : ctlVectorInputX.Vector.X1;
            x.X2 = (float.IsNaN(ctlVectorInputX.Vector.X2)) ? 0.0f : ctlVectorInputX.Vector.X2;

            // Matrix hinzufügen
            xmlGen.AddMatrix(m, Color.Blue, Color.Blue);

            // Malzeichen
            xmlGen.AddSign(EMathSign.Multiply);

            // Vektor x hinzufügen
            xmlGen.AddVector(x, Color.Red);

            // = Zeichen
            xmlGen.AddSign(EMathSign.Assignment);

            // Matrixelemente einfügen
            List<string> expressions = new List<string>();
            expressions.Add(m.X11.ToString());
            expressions.Add(x.X1.ToString());
            expressions.Add(m.X12.ToString());
            expressions.Add(x.X2.ToString());
            expressions.Add(m.X21.ToString());
            expressions.Add(x.X1.ToString());
            expressions.Add(m.X22.ToString());
            expressions.Add(x.X2.ToString());

            // Liste mit Farben
            List<Color> colors = new List<Color>();
            colors.Add(Color.Blue);
            colors.Add(Color.Red);
            colors.Add(Color.Blue);
            colors.Add(Color.Red);
            colors.Add(Color.Blue);
            colors.Add(Color.Red);
            colors.Add(Color.Blue);
            colors.Add(Color.Red);

            // alles zusammenbauen
            xmlGen.AddMathExpression(expressions, colors, EMathSign.Plus, EMathType.ComplexVector);

            // abschließen
            xmlGen.Finish();

            // tiff erstellen und auf picbox platzieren
            ctlMathEquaToRight.WriteEquationToPicBox(xmlGen.XmlDoc);
        }


        private void CreateFormularToLeft()
        {
            MathXmlGenerator xmlGen = new MathXmlGenerator();

            xmlGen.AddNode(_functionBlock2);

            // =
            xmlGen.AddSign(EMathSign.Assignment);

            // Matrix
            Matrix m = new Matrix();
            m.X11 = (float.IsNaN(ctlMatrixInput.Matrix.X11)) ? 0.0f : ctlMatrixInput.Matrix.X11;
            m.X21 = (float.IsNaN(ctlMatrixInput.Matrix.X21)) ? 0.0f : ctlMatrixInput.Matrix.X21;
            m.X12 = (float.IsNaN(ctlMatrixInput.Matrix.X12)) ? 0.0f : ctlMatrixInput.Matrix.X12;
            m.X22 = (float.IsNaN(ctlMatrixInput.Matrix.X22)) ? 0.0f : ctlMatrixInput.Matrix.X22;


            // Vektoren
            Vector y = new Vector();
            y.X1 = (float.IsNaN(ctlVectorInputY.Vector.X1)) ? 0.0f : ctlVectorInputY.Vector.X1;
            y.X2 = (float.IsNaN(ctlVectorInputY.Vector.X2)) ? 0.0f : ctlVectorInputY.Vector.X2;

            // Matrix hinzufügen
            xmlGen.AddMatrix(m, Color.Blue, Color.Blue);

            // Malzeichen
            xmlGen.AddSign(EMathSign.Multiply);

            // Vektor y hinzufügen
            xmlGen.AddVector(y, Color.Violet);

            // = Zeichen
            xmlGen.AddSign(EMathSign.Assignment);

            // Matrixelemente einfügen
            List<string> expressions = new List<string>();
            expressions.Add(m.X11.ToString());
            expressions.Add(y.X1.ToString());
            expressions.Add(m.X12.ToString());
            expressions.Add(y.X2.ToString());
            expressions.Add(m.X21.ToString());
            expressions.Add(y.X1.ToString());
            expressions.Add(m.X22.ToString());
            expressions.Add(y.X2.ToString());


            // Liste mit Farben
            List<Color> colors = new List<Color>();
            colors.Add(Color.Blue);
            colors.Add(Color.Violet);
            colors.Add(Color.Blue);
            colors.Add(Color.Violet);
            colors.Add(Color.Blue);
            colors.Add(Color.Violet);
            colors.Add(Color.Blue);
            colors.Add(Color.Violet);

            xmlGen.AddMatrix(_invMatrix, Color.Red, Color.Red);

            // Malzeichen
            xmlGen.AddSign(EMathSign.Multiply);

            // Vektor y hinzufügen
            xmlGen.AddVector(y, Color.Violet);

            // abschließen
            xmlGen.Finish();

            // tiff erstellen und auf picbox platzieren
            ctlMathEquaToLeft.WriteEquationToPicBox(xmlGen.XmlDoc);

        }


        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("VectorX", ctlVectorInputX.Vector);
            retVal.Add("VectorY", ctlVectorInputY.Vector);
            retVal.Add("Matrix", ctlMatrixInput.Matrix);

            return retVal;
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosOutput.ClearLineSegments();
            cosInput.ClearLineSegments();

            Console.WriteLine(sender.ToString() + " " + e.ToString());

            _vectorOutputX = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorX"], Pens.Blue);
            _vectorOutputY = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorY"], Pens.Green);
            _invMatrix = (Matrix)e.CalcValues["invMatrix"];
            txtDeterminante.Invoke(new Action(() => txtDeterminante.Text = e.CalcValues["MatrixDet"].ToString()));

            cosInput.AddLineSegment(_vectorOutputY);
            cosInput.AddLineSegment(_vectorInputX);
            cosOutput.AddLineSegment(_vectorOutputX);
            cosOutput.AddLineSegment(_vectorInputY);

            this.CreateFormularToLeft();

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
        protected override bool CheckInputs()
        {
            if (ctlMatrixInput.Matrix.Determinant == 0)
            {
                MessageBox.Show("Die Determinante der Matrix ist 0.");
                return false;
            }

            if (ctlVectorInputX.Vector.IsValid() && ctlVectorInputY.Vector.IsValid() && ctlMatrixInput.Matrix.IsValid())
            {
#if DEBUG
                Console.WriteLine("SUCCESS @ Inputs are valid.");
#endif
                return true;
            }

            MessageBox.Show("Nicht alle Daten sind gültig oder eingegeben.");
#if DEBUG
            Console.WriteLine("ERROR @ Inputs are not valid.");
#endif
            return false;
        }

        public void OnTextChanged(object sender, EventArgs e)
        {
            _vectorInputX.Vector = ctlVectorInputX.Vector;
            _vectorInputY.Vector = ctlVectorInputY.Vector;
            this.CreateFormularToLeft();
            this.CreateFormularToRight();
            cosInput.Refresh();
            cosOutput.Refresh();
        }

        public override bool LoadState(Dictionary<string, object> state)
        {
            // state does not exist in workbook.
            if (state == null)
            {
                return false;
            }
            else if (!state.ContainsKey("VectorX") || !state.ContainsKey("VectorY") || !state.ContainsKey("Notes") || !state.ContainsKey("Matrix"))
            {
                return false;
            }

            ctlVectorInputX.Vector = (Vector)state["VectorX"];
            ctlVectorInputY.Vector = (Vector)state["VectorY"];
            ctlMatrixInput.Matrix = (Matrix)state["Matrix"];
            _rtxtNotes.Text = (string)state["Notes"];
            return true;
        }


        private void txtDeterminante_MouseEnter(object sender, EventArgs e)
        {
            txtDeterminante.UseSystemPasswordChar = false;
        }

        private void txtDeterminante_MouseLeave(object sender, EventArgs e)
        {
            txtDeterminante.UseSystemPasswordChar = true;
        }
    }
}
