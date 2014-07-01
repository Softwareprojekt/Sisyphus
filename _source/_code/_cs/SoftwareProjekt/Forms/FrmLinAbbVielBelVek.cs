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
    public partial class FrmLinAbbVielBelVek : AbstractView
    {
        private LineSegment _vectorInputX;
        private LineSegment _vectorOutputX;
        private LineSegment _vectorInputXScaled;
        private LineSegment _vectorOutputXScaled;

        public FrmLinAbbVielBelVek()
        {
            InitializeComponent();

            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVectorInputX.Vector, Pens.Blue);

            cosInput.AddLineSegment(_vectorInputX);
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
            cosOutput.ClearLineSegments();

            Console.WriteLine(sender.ToString() + " " + e.ToString());

            _vectorInputXScaled = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorXScaledInput"], Pens.Black);
            _vectorOutputX = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorX"], Pens.Blue);
            _vectorOutputXScaled = new LineSegment(new PointF(0f, 0f), (Vector)e.CalcValues["VectorXScaledOutput"], Pens.Black);

            cosOutput.AddLineSegment(_vectorInputXScaled);
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
