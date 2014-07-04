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
    public partial class FrmHinterLinAbb : AbstractView
    {

        private LineSegment _vectorInputX;
        private LineSegment _vectorOutputX1;
        private LineSegment _vectorOutputX2;

        public FrmHinterLinAbb()
        {
            InitializeComponent();

            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVectorInputX.Vector);

            this.ctlVectorInputX.TextChanged += this.OnTextChanged;
            cosInput.AddLineSegment(_vectorInputX);
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
            //this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
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
            //this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
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
            //this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
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
