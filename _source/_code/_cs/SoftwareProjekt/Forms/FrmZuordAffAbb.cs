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
       
    public partial class FrmZuordAffAbb : AbstractView 
    {
        private LineSegment _vectorInputA;
        private LineSegment _vectorInputB;
        private LineSegment _vectorInputC;

        private LineSegment _vectorInputA2;
        private LineSegment _vectorInputB2;
        private LineSegment _vectorInputC2;

        public FrmZuordAffAbb()
        {
            InitializeComponent();
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
        }

        private void butFunction1X_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
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

            ctlVectorInputA.Vector = (Vector)state["VectorA"];
            ctlVectorInputB.Vector = (Vector)state["VectorB"];
            ctlVectorInputC.Vector = (Vector)state["VectorC"];
            ctlVectorInputA2.Vector = (Vector)state["VectorA2"];
            ctlVectorInputB2.Vector = (Vector)state["VectorB2"];
            ctlVectorInputC2.Vector = (Vector)state["VectorC2"];
            return true;
        }
    }
}
