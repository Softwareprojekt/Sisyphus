
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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SoftwareProjekt.Classes.Math;

namespace SoftwareProjekt.UserControls
{
    public partial class CtlMatrixInput : UserControl
    {
        Matrix _matrix = null;
        public CtlMatrixInput()
        {
            InitializeComponent();

            this.Matrix = new Matrix();
        }

        /// <summary>
        /// Property for Matrix field. 
        /// Setting this invokes a Refresh.
        /// </summary>
        public Matrix Matrix
        {
            get
            {
                return _matrix;
            }
            set
            {
                _matrix = value;

                if (this.InvokeRequired)
                {
#if DEBUG
                    Console.WriteLine("Invoking Matrix Refresh");
#endif
                    this.BeginInvoke(new Action(() => Refresh()));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle11_TextChanged(object sender, EventArgs e)
        {
            float f;
            this.Parse(txtEle11.Text, out f);
            this.Matrix.X11 = f;
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && (txtEle11.Text.Contains(",") || txtEle11.Text==""))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle12_TextChanged(object sender, EventArgs e)
        {
            float f;
            this.Parse(txtEle12.Text, out f);
            this.Matrix.X12 = f;
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && (txtEle12.Text.Contains(",") || txtEle12.Text == ""))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle21_TextChanged(object sender, EventArgs e)
        {
            float f;
            this.Parse(txtEle21.Text, out f);
            this.Matrix.X21 = f;
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && (txtEle21.Text.Contains(",") || txtEle21.Text == ""))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle22_TextChanged(object sender, EventArgs e)
        {
            float f;
            this.Parse(txtEle22.Text, out f);
            this.Matrix.X22 = f;
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && (txtEle22.Text.Contains(",") || txtEle22.Text == ""))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Parses float value entered in TextBox.
        /// </summary>
        /// <param name="s">String in TextBox.</param>
        /// <param name="f">Out parameter: Parsed float value.</param>
        /// <returns>True and float value if Parse successfull; Otherwise: false and NaN.</returns>
        private bool Parse(string s, out float f)
        {
            float retval = 0f;

            if (float.TryParse(s, out retval))
            {
                f = retval;
#if DEBUG
                Console.WriteLine("SUCCESS @ Matrix.Parse => " + f);
#endif
                return true;
            }

            f = float.NaN;
#if DEBUG
            Console.WriteLine("ERROR @ Matrix.Parse => " + f);
#endif
            return false;
        }

        /// <summary>
        /// Refreshes TextBoxes with current Vector values.
        /// </summary>
        public override void Refresh()
        {
            txtEle11.Text = _matrix.X11.ToString();
            txtEle12.Text = _matrix.X12.ToString();
            txtEle21.Text = _matrix.X21.ToString();
            txtEle22.Text = _matrix.X22.ToString();

            base.Refresh();
        }

        private void grpMatrixEingabe_Resize(object sender, EventArgs e)
        {
            int newWidth = (int)(grpMatrixEingabe.Size.Width / 3);
            int EleX1_newX = (int)(grpMatrixEingabe.Size.Width / 9);
            int EleX2_newX = (int)(grpMatrixEingabe.Size.Width / 9)*5;

            int Ele1X_newY = (int)((grpMatrixEingabe.Size.Height - 24) / 3);
            int Ele2X_newY = (Ele1X_newY * 2) + 12;

            txtEle11.Size = new System.Drawing.Size(newWidth, 12);
            txtEle11.Location = new Point(EleX1_newX, Ele1X_newY);

            txtEle12.Size = new System.Drawing.Size(newWidth, 12);
            txtEle12.Location = new Point(EleX2_newX, Ele1X_newY);

            txtEle21.Size = new System.Drawing.Size(newWidth, 12);
            txtEle21.Location = new Point(EleX1_newX, Ele2X_newY);

            txtEle22.Size = new System.Drawing.Size(newWidth, 12);
            txtEle22.Location = new Point(EleX2_newX, Ele2X_newY);

            grpMatrixEingabe.Refresh();

        }
    }
}
