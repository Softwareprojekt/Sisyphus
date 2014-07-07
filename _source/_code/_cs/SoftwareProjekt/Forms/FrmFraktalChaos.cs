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

using SoftwareProjekt.Classes.Math;
using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SoftwareProjekt.Forms
{
    public partial class FrmFraktalChaos : AbstractView
    {
        public FrmFraktalChaos()
        {
            InitializeComponent();
            _lblIteration.Text = "";
        }

        private void rtxtNotes_TextChanged(object sender, EventArgs e)
        { }

        private void butStart_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new Classes.EventArguments.ViewEventArgs(Enums.EClickedButton.StartCalculation));
            }
        }

        public override void ExerciseChanged(IExercise sender, Classes.EventArguments.ExerciseEventArgs e)
        {
            cosFractal.Clear();
            cosFractal.DoNotRefresh = true;

            //Get the second half for better looking
            List<PointF> pList = (List<PointF>)e.CalcValues["Points"];
            pList = pList.GetRange(pList.Count / 2, pList.Count / 2);

            cosFractal.AddPixel(pList.ToArray());

            int currentIteration = (int)e.CalcValues["CurrentIteration"];
            string step = "Iteration: " + currentIteration;
            _lblIteration.Invoke(new Action(() => _lblIteration.Text = step));

            cosFractal.DoNotRefresh = false;
            cosFractal.invokeRefresh();

            if (e.Final)
            {
                this.OnViewChanged(new Classes.EventArguments.ViewEventArgs(Enums.EClickedButton.CloseProgressForm));
            }
        }

        protected override bool CheckInputs()
        {
            if (_ctlMatrix1.Matrix.IsValid() && _ctlMatrix2.Matrix.IsValid() && _ctlMatrix3.Matrix.IsValid() && _ctlMatrix4.Matrix.IsValid() &&
                _ctlVector1.Vector.IsValid() && _ctlVector1.Vector.IsValid() && _ctlVector1.Vector.IsValid() && _ctlVector1.Vector.IsValid() &&
                _txtProp1.IsValid() && _txtProp2.IsValid() && _txtProp3.IsValid() && _txtProp4.IsValid() && _txtIterationen.IsValid() && _txtSteps.IsValid())
            {
#if DEBUG
                Console.WriteLine("SUCCESS @ Inputs are valid.");
#endif
                if (_txtProp1.FloatValue + _txtProp2.FloatValue + _txtProp3.FloatValue + _txtProp4.FloatValue != 100f)
                {
                    MessageBox.Show("Die gesamte Wahrscheinlichkeit muss bei 100% liegen.");
                    return false;
                }
                if (!_ctlMatrix1.Matrix.IsContractive())
                {
                    MessageBox.Show("Matrix 1 ist nicht kontrahierend.");
                    return false;
                }
                else if (!_ctlMatrix2.Matrix.IsContractive())
                {
                    MessageBox.Show("Matrix 2 ist nicht kontrahierend.");
                    return false;
                }
                else if (!_ctlMatrix3.Matrix.IsContractive())
                {
                    MessageBox.Show("Matrix 3 ist nicht kontrahierend.");
                    return false;
                }
                else if (!_ctlMatrix4.Matrix.IsContractive())
                {
                    MessageBox.Show("Matrix 4 ist nicht kontrahierend.");
                    return false;
                }

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
            else if (!state.ContainsKey("Matrix1") || !state.ContainsKey("Matrix2") || !state.ContainsKey("Matrix3") || !state.ContainsKey("Matrix4")
                || !state.ContainsKey("Vector1") || !state.ContainsKey("Vector2") || !state.ContainsKey("Vector3") || !state.ContainsKey("Vector4")
                || !state.ContainsKey("Prob1") || !state.ContainsKey("Prob2") || !state.ContainsKey("Prob3") || !state.ContainsKey("Prob4")
                || !state.ContainsKey("Iter") || !state.ContainsKey("Notes") || !state.ContainsKey("Steps"))
            {
                return false;
            }

            _ctlMatrix1.Matrix = (SoftwareProjekt.Classes.Math.Matrix)state["Matrix1"];
            _ctlMatrix2.Matrix = (SoftwareProjekt.Classes.Math.Matrix)state["Matrix2"];
            _ctlMatrix3.Matrix = (SoftwareProjekt.Classes.Math.Matrix)state["Matrix3"];
            _ctlMatrix4.Matrix = (SoftwareProjekt.Classes.Math.Matrix)state["Matrix4"];

            _ctlVector1.Vector = (Vector)state["Vector1"];
            _ctlVector2.Vector = (Vector)state["Vector2"];
            _ctlVector3.Vector = (Vector)state["Vector3"];
            _ctlVector4.Vector = (Vector)state["Vector4"];

            _txtIterationen.Text = state["Iter"].ToString();
            _txtSteps.Text = state["Steps"].ToString();

            _txtProp1.Text = state["Prob1"].ToString();
            _txtProp2.Text = state["Prob2"].ToString();
            _txtProp3.Text = state["Prob3"].ToString();
            _txtProp4.Text = state["Prob4"].ToString();

            _rtxtNotes.Text = state["Notes"].ToString();

            return true;
        }

        public override Dictionary<string, object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("Matrix1", _ctlMatrix1.Matrix);
            retVal.Add("Matrix2", _ctlMatrix2.Matrix);
            retVal.Add("Matrix3", _ctlMatrix3.Matrix);
            retVal.Add("Matrix4", _ctlMatrix4.Matrix);

            retVal.Add("Vector1", _ctlVector1.Vector);
            retVal.Add("Vector2", _ctlVector2.Vector);
            retVal.Add("Vector3", _ctlVector3.Vector);
            retVal.Add("Vector4", _ctlVector4.Vector);

            retVal.Add("Iter", _txtIterationen.FloatValue);

            retVal.Add("Prob1", _txtProp1.FloatValue);
            retVal.Add("Prob2", _txtProp2.FloatValue);
            retVal.Add("Prob3", _txtProp3.FloatValue);
            retVal.Add("Prob4", _txtProp4.FloatValue);

            retVal.Add("Steps", _txtSteps.FloatValue);

            return retVal;
        }

        private void butSaveFractal_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Bitmap pic = new Bitmap(cosFractal.Width, cosFractal.Height);
                Rectangle r = new Rectangle(0, 0, cosFractal.Width, cosFractal.Height);
                cosFractal.DrawToBitmap(pic, r);
                try
                {
                    pic.Save(fileName);
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR @ Saveing bmp in Chaos game");
                    MessageBox.Show("Das Bild konnte nicht gespeichert werden");
                }
            }
        }

        private void _btnSquare_Click(object sender, EventArgs e)
        {
            _ctlMatrix1.Matrix = new Matrix(0.5f, 0, 0, 0.5f);
            _ctlMatrix2.Matrix = new Matrix(0.5f, 0, 0, 0.5f);
            _ctlMatrix3.Matrix = new Matrix(0.5f, 0, 0, 0.5f);
            _ctlMatrix4.Matrix = new Matrix(0.5f, 0, 0, 0.5f);

            _ctlVector1.Vector = new Vector(1, 1);
            _ctlVector2.Vector = new Vector(50, 1);
            _ctlVector3.Vector = new Vector(1, 50);
            _ctlVector4.Vector = new Vector(50, 50);

            _txtProp1.Text = "25";
            _txtProp2.Text = "25";
            _txtProp3.Text = "25";
            _txtProp4.Text = "25";

            _txtIterationen.Text = "50000";
        }

        private void _btnFern_Click(object sender, EventArgs e)
        {
            _ctlMatrix1.Matrix = new Matrix(0, 0, 0, 0.16f);
            _ctlMatrix2.Matrix = new Matrix(0.85f, 0.04f, -0.04f, 0.85f);
            _ctlMatrix3.Matrix = new Matrix(0.2f, -0.26f, 0.23f, 0.22f);
            _ctlMatrix4.Matrix = new Matrix(0.15f, 0.28f, 0.26f, 0.24f);

            _ctlVector1.Vector = new Vector(0, 0);
            _ctlVector2.Vector = new Vector(0, 1.6f);
            _ctlVector3.Vector = new Vector(0, 1.6f);
            _ctlVector4.Vector = new Vector(0, 0.44f);

            _txtProp1.Text = "1";
            _txtProp2.Text = "85";
            _txtProp3.Text = "7";
            _txtProp4.Text = "7";

            _txtIterationen.Text = "50000";
        }

        private void _btnTree_Click(object sender, EventArgs e)
        {
            this.cosFractal.XAxis.EndValue = 0.5f;
            this.cosFractal.YAxis.EndValue = 0.5f;
            _lblIteration.Text = "Iteration: 0";
            this.cosFractal.invokeRefresh();

            _ctlMatrix1.Matrix = new Matrix(0, 0, 0, 0.5f);
            _ctlMatrix2.Matrix = new Matrix(0.42f, -0.42f, 0.42f, 0.42f);
            _ctlMatrix3.Matrix = new Matrix(0.42f, 0.42f, -0.42f, 0.42f);
            _ctlMatrix4.Matrix = new Matrix(0.1f, 0, 0, 0.1f);

            _ctlVector1.Vector = new Vector(0, 0);
            _ctlVector2.Vector = new Vector(0, 0.2f);
            _ctlVector3.Vector = new Vector(0, 0.2f);
            _ctlVector4.Vector = new Vector(0, 0.2f);

            _txtProp1.Text = "5";
            _txtProp2.Text = "40";
            _txtProp3.Text = "40";
            _txtProp4.Text = "15";

            _txtIterationen.Text = "50000";
        }
    }
}
