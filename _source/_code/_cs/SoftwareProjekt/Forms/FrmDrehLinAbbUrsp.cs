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
    public partial class FrmDrehLinAbbUrsp : AbstractView
    {

        private string _sequation;
        private string _sfilepath;

        public FrmDrehLinAbbUrsp()
        {
            InitializeComponent();
            _sequation = "f(x^(->) = ";
            _sfilepath = "";
            //ctlFormular.Equation = _sequation;
            //ctlFormular.Filepath = _sfilepath;
            //ctlFormular.WriteEquationToPicBox(ctlFormular.Equation);
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
        }


        private void butFunctionTransfX_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();
            double Angle;

            retVal.Add("EV1", ctlVectorEV1.Vector);
            retVal.Add("EV2", ctlVectorEV2.Vector);
            retVal.Add("VectorX", ctlVectorInputX.Vector);

            if (double.TryParse(txtAngle.Text, out Angle))
            {
                retVal.Add("Angle", Angle);
            }
            else
            {
                retVal.Add("Angle", null);
            }

            return retVal;
        }

        private void butDeterminante_Click(object sender, System.EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            Console.WriteLine(sender.ToString() + " " + e.ToString());
            ctlVectorOutputEV1.Vector = (Vector)e.CalcValues["EV1"];
            ctlVectorOutputEV2.Vector = (Vector)e.CalcValues["EV2"];
            ctlVectorOutputX.Vector = (Vector)e.CalcValues["VectorX"];
        }

        private void txtAngle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && (txtAngle.Text.Contains(",") || txtAngle.Text == ""))
            {
                e.Handled = true;
            }
        }

		protected override bool CheckInputs()
		{
			throw new NotImplementedException();
		}
    }
}
