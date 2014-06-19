
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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoftwareProjekt.Classes.Math;

namespace SoftwareProjekt.UserControls
{
    public partial class CtlVectorInput : UserControl
    {
        Vector _vector = null;
        public CtlVectorInput()
        {
            InitializeComponent();

            this.Vector = new Vector();
        }

        /// <summary>
        /// Property for Vector field. 
        /// Setting this invokes a Refresh.
        /// </summary>
        public Vector Vector
        {
            get
            {
                return _vector;
            }
            set
            {
                _vector = value;

                if (this.InvokeRequired)
                {
#if DEBUG
                    Console.WriteLine("Invoking Vector Refresh");
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
            this.Vector.X1 = f;
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
            else if (e.KeyChar == ',' && (txtEle11.Text.Contains(",") || txtEle11.Text == ""))
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
            this.Vector.X2 = f;
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
                Console.WriteLine("SUCCESS @ Vector.Parse => " + f);
#endif
                return true;
            }

            f = float.NaN;
#if DEBUG
            Console.WriteLine("ERROR @ Vector.Parse => " + f);
#endif
            return false;
        }

        /// <summary>
        /// Refreshes TextBoxes with current Vector values.
        /// </summary>
        public override void Refresh()
        {
            txtEle11.Text = _vector.X1.ToString();
            txtEle21.Text = _vector.X2.ToString();

            base.Refresh();
        }

        private void grpVektorInput_Resize(object sender, EventArgs e)
        {
            int newWidth = (int)(grpVektorInput.Size.Width / 2);
            int newX = (int)(grpVektorInput.Size.Width / 4);

            int Ele11_newY =  (int)((grpVektorInput.Size.Height-24)/3);
            int Ele21_newY = (Ele11_newY * 2) + 12;

            txtEle11.Size = new System.Drawing.Size(newWidth,12);
            txtEle11.Location = new Point(newX, Ele11_newY);

            txtEle21.Size = new System.Drawing.Size(newWidth, 12);
            txtEle21.Location = new Point(newX, Ele21_newY);

            grpVektorInput.Refresh();

        }
    }
}
