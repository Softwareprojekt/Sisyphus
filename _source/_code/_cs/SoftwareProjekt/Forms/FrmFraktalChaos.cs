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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt.Forms
{
    public partial class FrmFraktalChaos : AbstractView
    {
        /// <summary>
        // **** 
        // TODO: fix!!!!
        // No Idea how this works!!!
        /// </summary>

        private List<PointF> _pointList;
        private Vector _point;
        public FrmFraktalChaos()
        {
            InitializeComponent();

            _ctlMatrix1.Matrix = new Matrix(0, 0, 0, 0);
            _ctlMatrix2.Matrix = new Matrix(0, 0, 0, 0);
            _ctlMatrix3.Matrix = new Matrix(0, 0, 0, 0);
            _ctlMatrix4.Matrix = new Matrix(0, 0, 0, 0);

            _ctlVector1.Vector = new Vector(0, 0);
            _ctlVector2.Vector = new Vector(0, 0);
            _ctlVector3.Vector = new Vector(0, 0);
            _ctlVector4.Vector = new Vector(0, 0);

            _txtProp1.Text = "25";
            _txtProp2.Text = "25";
            _txtProp3.Text = "25";
            _txtProp4.Text = "25";

            _txtIterationen.Text = "50000";

            _pointList = new List<PointF>();
            _point = new Vector();
            cosFractal.CoordinateClick += cosFractal_CoordinateClick;
        }

        void cosFractal_CoordinateClick(float x, float y, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _pointList.Add(new PointF(x, y));
                cosFractal.Clear();
                _point = new Vector(x, y);
                cosFractal.AddPixel(new PointF(_point.X1, _point.X2));
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                MenuItem delPoints = new MenuItem("&Punkte löschen", new System.EventHandler(this.deletePoints_Click));
                cm.MenuItems.Add(delPoints);
                this.ContextMenu = cm;
            }
        }

        private void deletePoints_Click(object sender, EventArgs e)
        {
            cosFractal.Clear();
            _pointList.Clear();
            _point = new Vector();
        }

        private void txtProbability_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumIteration_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProbability_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void txtNumIteration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void rtxtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void butStart_Click(object sender, EventArgs e)
        {
            // TODO: fix!!!!
            // TODO: make this via MVC   
            cosFractal.Clear();
            cosFractal.DoNotRefresh = true;
            if (_txtProp1.FloatValue + _txtProp2.FloatValue + _txtProp3.FloatValue + _txtProp4.FloatValue != 100f)
            {
                MessageBox.Show("Die gesammte Wahrscheinlichkeit muss bei 100% liegen");
                return;
            }
            if (!_ctlMatrix1.Matrix.IsContractive())
            {
                MessageBox.Show("Matrix 1 ist nicht kontrahierend");
                return;
            }
            else if (!_ctlMatrix2.Matrix.IsContractive())
            {
                MessageBox.Show("Matrix 2 ist nicht kontrahierend");
                return;
            }
            else if (!_ctlMatrix3.Matrix.IsContractive())
            {
                MessageBox.Show("Matrix 3 ist nicht kontrahierend");
                return;
            }
            else if (!_ctlMatrix4.Matrix.IsContractive())
            {
                MessageBox.Show("Matrix 4 ist nicht kontrahierend");
                return;
            }

            float val1 = _txtProp1.FloatValue;
            float val2 = _txtProp1.FloatValue + _txtProp2.FloatValue;
            float val3 = _txtProp1.FloatValue + _txtProp2.FloatValue + _txtProp3.FloatValue;
            Vector lastPoint = _point;
            int i;
            for (i = 0; i < _txtIterationen.FloatValue; i++)
            {
                int random = new Random((int)DateTime.Now.Ticks).Next(1, 101);
                //cooses the Funciton to calulate
                if (0 <= random && random < val1)
                {
                    lastPoint = Vector.AffineAbbildung(lastPoint, _ctlMatrix1.Matrix, _ctlVector1.Vector);
                    cosFractal.AddPixel(new PointF(lastPoint.X1, lastPoint.X2));
                }
                else if (val1 <= random && random < val2)
                {
                    lastPoint = Vector.AffineAbbildung(lastPoint, _ctlMatrix2.Matrix, _ctlVector2.Vector);
                    cosFractal.AddPixel(new PointF(lastPoint.X1, lastPoint.X2));
                }
                else if (val2 <= random && random < val3)
                {
                    lastPoint = Vector.AffineAbbildung(lastPoint, _ctlMatrix3.Matrix, _ctlVector3.Vector);
                    cosFractal.AddPixel(new PointF(lastPoint.X1, lastPoint.X2));
                }
                else
                {
                    lastPoint = Vector.AffineAbbildung(lastPoint, _ctlMatrix4.Matrix, _ctlVector4.Vector);
                    cosFractal.AddPixel(new PointF(lastPoint.X1, lastPoint.X2));
                }
            }

            cosFractal.DoNotRefresh = false;
            cosFractal.invokeRefresh();
        }

        public override bool LoadState(Dictionary<string, object> state)
        {
            // state does not exist in workbook.
            if (state == null)
            {
                return false;
            }
            else if (!state.ContainsKey("Matrix_w1") || !state.ContainsKey("Matrix_w2") || !state.ContainsKey("Matrix_w3") || !state.ContainsKey("Matrix_w4")
                || !state.ContainsKey("Vector_w1") || !state.ContainsKey("Vector_w2") || !state.ContainsKey("Vector_w3") || !state.ContainsKey("Vector_w4")
                || !state.ContainsKey("Prop1") || !state.ContainsKey("Prop2") || !state.ContainsKey("Prop3") || !state.ContainsKey("Prop4")
                || !state.ContainsKey("Iter") || !state.ContainsKey("Notes"))
            {
                return false;
            }

            _ctlMatrix1.Matrix = (SoftwareProjekt.Classes.Math.Matrix)state["Matrix_w1"];
            _ctlMatrix2.Matrix = (SoftwareProjekt.Classes.Math.Matrix)state["Matrix_w2"];
            _ctlMatrix3.Matrix = (SoftwareProjekt.Classes.Math.Matrix)state["Matrix_w3"];
            _ctlMatrix4.Matrix = (SoftwareProjekt.Classes.Math.Matrix)state["Matrix_w4"];

            _ctlVector1.Vector = (Vector)state["Vector_w1"];
            _ctlVector2.Vector = (Vector)state["Vector_w2"];
            _ctlVector3.Vector = (Vector)state["Vector_w3"];
            _ctlVector4.Vector = (Vector)state["Vector_w4"];

            _txtIterationen.Text = state["Iter"].ToString();

            _txtProp1.Text = (string)state["Prop1"].ToString();
            _txtProp2.Text = (string)state["Prop2"].ToString();
            _txtProp3.Text = (string)state["Prop3"].ToString();
            _txtProp4.Text = (string)state["Prop4"].ToString();

            //rtxtNotes.Text = (string)state["Notes"];
            return true;
        }

        public override Dictionary<string, object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("Matrix_w1", _ctlMatrix1.Matrix);
            retVal.Add("Matrix_w2", _ctlMatrix2.Matrix);
            retVal.Add("Matrix_w3", _ctlMatrix3.Matrix);
            retVal.Add("Matrix_w4", _ctlMatrix4.Matrix);

            retVal.Add("Vector_w1", _ctlVector1.Vector);
            retVal.Add("Vector_w2", _ctlVector2.Vector);
            retVal.Add("Vector_w3", _ctlVector3.Vector);
            retVal.Add("Vector_w4", _ctlVector4.Vector);

            retVal.Add("Iter", _txtIterationen.FloatValue);

            retVal.Add("Prop1", _txtProp1.FloatValue);
            retVal.Add("Prop2", _txtProp2.FloatValue);
            retVal.Add("Prop3", _txtProp3.FloatValue);
            retVal.Add("Prop4", _txtProp4.FloatValue);

            retVal.Add("Notes", rtxtNotes.Text);

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
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR @ Saveing bmp in Chaos game");
                    MessageBox.Show("Das Bild konnte nicht gespeichert werden");
                }
            }
        }

        private void _btnSquere_Click(object sender, EventArgs e)
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
