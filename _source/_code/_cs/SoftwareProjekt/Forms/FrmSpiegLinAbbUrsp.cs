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

namespace SoftwareProjekt.Forms
{
    public partial class FrmSpiegLinAbbUrsp : AbstractView
    {
        private LineSegment _vectorInputX;
        private LineSegment _vectorInputEV1;
        private LineSegment _vectorInputEV2;

        private LineSegment _vectorOutputX;
        private LineSegment _vectorOutputEV1;
        private LineSegment _vectorOutputEV2;

        private Line _MirrorLine;
        private Line _MirrorLineOutput;

        public FrmSpiegLinAbbUrsp()
        {
            InitializeComponent();


            this.ctlVectorInputEV1.txtEle11.Text = "1";
            this.ctlVectorInputEV1.txtEle21.Text = "0";

            this.ctlVectorInputEV2.txtEle11.Text = "0";
            this.ctlVectorInputEV2.txtEle21.Text = "1";

            _vectorInputEV1 = new LineSegment(new PointF(0, 0), ctlVectorInputEV1.Vector, Pens.Red);
            _vectorInputEV2 = new LineSegment(new PointF(0, 0), ctlVectorInputEV2.Vector, Pens.Blue);
            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVectorInputX.Vector);

            _MirrorLine = new Line(ftxtAngle.FloatValue);

            this.ctlVectorInputX.TextChanged += this.OnTextChanged;
            this.ftxtAngle.TextChanged += this.OnTextChanged;
            cosInput.AddLineSegment(_vectorInputEV1);
            cosInput.AddLineSegment(_vectorInputEV2);
            cosInput.AddLineSegment(_vectorInputX);
            cosInput.AddLine(_MirrorLine);
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("EV1", ctlVectorInputEV1.Vector);
            retVal.Add("EV2", ctlVectorInputEV2.Vector);
            retVal.Add("VectorX", ctlVectorInputX.Vector);
            retVal.Add("Angle", ftxtAngle.FloatValue);

            return retVal;
        }

        private void butFx_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosOutput.ClearLineSegments();

            Console.WriteLine(sender.ToString() + " " + e.ToString());

            _vectorOutputX = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorX"], Pens.Black);
            _vectorOutputEV1 = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["EV1"], Pens.Red);
            _vectorOutputEV2 = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["EV2"], Pens.Blue);

            _MirrorLineOutput = (Line)e.CalcValues["Mirror"];

            cosOutput.AddLineSegment(_vectorOutputX);
            cosOutput.AddLineSegment(_vectorOutputEV1);
            cosOutput.AddLineSegment(_vectorOutputEV2);
            cosOutput.AddLine(_MirrorLineOutput);
        }

        protected override bool CheckInputs()
        {
            if (ctlVectorInputEV1.Vector.IsValid() && ctlVectorInputEV2.Vector.IsValid() && ctlVectorInputX.Vector.IsValid() && ftxtAngle.IsValid())
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
            _MirrorLine = new Line(ftxtAngle.FloatValue);
            cosInput.AddLine(_MirrorLine);
            cosInput.Refresh();
        }

        public override bool LoadState(Dictionary<string, object> state)
        {
            // state does not exist in workbook.
            if (state == null)
            {
                return false;
            }
            else if (!state.ContainsKey("VectorX") || !state.ContainsKey("Angle"))
            {
                return false;
            }

            ctlVectorInputX.Vector = (Vector)state["VectorX"];
            ftxtAngle.Text = state["Angle"].ToString();
            return true;
        }
    }
}
