
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

namespace SoftwareProjekt
{
    public partial class CtlMatrixInput : UserControl
    {
        public CtlMatrixInput()
        {
            InitializeComponent();

            this.Matrix = new Matrix();
        }

        /// <summary>
        /// 
        /// </summary>
        private Matrix Matrix
        {
            get;
            set;
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
            if (e.KeyChar == ',')
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
            if (e.KeyChar == ',')
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
            if (e.KeyChar == ',')
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
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

        private bool Parse(string s, out float f)
        {
            float retval = 0f;

            if (float.TryParse(s, out retval))
            {
                f = retval;
                Console.WriteLine("SUCCESS @ Matrix.Parse => " + f);
                return true;
            }

            f = float.NaN;
            Console.WriteLine("ERROR @ Matrix.Parse => " + f);
            return false;
        }
    }
}
