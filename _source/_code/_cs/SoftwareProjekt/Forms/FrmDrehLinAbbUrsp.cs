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
using SoftwareProjekt.UserControls;

namespace SoftwareProjekt.Forms
{
    public partial class FrmDrehLinAbbUrsp : AbstractView
    {
        private LineSegment _vectorInputX;
        private LineSegment _vectorInputEV1;
        private LineSegment _vectorInputEV2;

        private LineSegment _vectorOutputX;
        private LineSegment _vectorOutputEV1;
        private LineSegment _vectorOutputEV2;

        public FrmDrehLinAbbUrsp()
        {
            InitializeComponent();

            MathXmlGenerator xmlGen = new MathXmlGenerator();
            xmlGen.AddNode("<mi>f</mi>");
            xmlGen.AddNode("<mo>(</mo>");
            xmlGen.AddNode("<mover>");
            xmlGen.AddNode("\t<mi>x</mi>");
            xmlGen.AddNode("\t<mo>&rarr;</mo>");
            xmlGen.AddNode("</mover>");
            xmlGen.AddNode("<mo>)</mo>");
            xmlGen.AddSign(EMathSign.Assignment);

            this.ctlVectorEV1.txtEle11.Text = "1";
            this.ctlVectorEV1.txtEle21.Text = "0";

            this.ctlVectorEV2.txtEle11.Text = "0";
            this.ctlVectorEV2.txtEle21.Text = "1";

            _vectorInputEV1 = new LineSegment(new PointF(0, 0), ctlVectorEV1.Vector, Pens.Blue);
            _vectorInputEV2 = new LineSegment(new PointF(0, 0), ctlVectorEV2.Vector, Pens.Red);
            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVectorInputX.Vector);

            this.ctlVectorInputX.TextChanged += this.OnTextChanged;
            cosInput.AddLineSegment(_vectorInputEV1);
            cosInput.AddLineSegment(_vectorInputEV2);
            cosInput.AddLineSegment(_vectorInputX);
        }

        private void butFunctionTransfX_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
               this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("EV1", ctlVectorEV1.Vector);
            retVal.Add("EV2", ctlVectorEV2.Vector);
            retVal.Add("VectorX", ctlVectorInputX.Vector);
            retVal.Add("Angle", _ctlAngle.FloatValue);

            return retVal;
        }

        private void butDeterminante_Click(object sender, System.EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosOutput.ClearLineSegments();

            Console.WriteLine(sender.ToString() + " " + e.ToString());
            ctlVectorOutputEV1.Vector = (Vector)e.CalcValues["EV1"];
            ctlVectorOutputEV2.Vector = (Vector)e.CalcValues["EV2"];
            ctlVectorOutputX.Vector = (Vector)e.CalcValues["VectorX"];

            _vectorOutputEV1 = new LineSegment(new PointF(0f, 0f), ctlVectorOutputEV1.Vector, Pens.Blue);
            _vectorOutputEV2 = new LineSegment(new PointF(0f, 0f), ctlVectorOutputEV2.Vector, Pens.Red);
            _vectorOutputX = new LineSegment(new PointF(0f, 0f), ctlVectorOutputX.Vector, Pens.Black);

            cosOutput.AddLineSegment(_vectorOutputEV1);
            cosOutput.AddLineSegment(_vectorOutputEV2);
            cosOutput.AddLineSegment(_vectorOutputX);
        }

        protected override bool CheckInputs()
        {
            if (ctlVectorEV1.Vector.IsValid() && ctlVectorEV2.Vector.IsValid() && ctlVectorInputX.Vector.IsValid() && _ctlAngle.IsValid())
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
            else if (!state.ContainsKey("VectorX") || !state.ContainsKey("Angle") || !state.ContainsKey("Notes"))
            {
                return false;
            }

            ctlVectorInputX.Vector = (Vector)state["VectorX"];
            _ctlAngle.Text = state["Angle"].ToString();
            rtxtNotes.Text = state["Notes"].ToString();
            return true;
        }

        private void FrmDrehLinAbbUrsp_Shown(object sender, EventArgs e)
        {
            CtlVectorInput[] vectors = { this.ctlVectorInputX, this.ctlVectorEV1, this.ctlVectorEV2 };
            CtlMatrixInput[] matrices = { };
            CtlVectorInput[] vectors2 = { this.ctlVectorOutputX, this.ctlVectorOutputEV1, this.ctlVectorOutputEV2 };
            //CoordinateSystem[] cordsList = { this.cosInput };
            this.ChangeFontColors(vectors, matrices, this.inputColor);
            this.ChangeFontColors(vectors2, matrices, this.resultColor);
        }
    }
}
