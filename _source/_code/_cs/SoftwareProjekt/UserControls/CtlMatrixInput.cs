
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
        private Matrix _mmatrix;
        private string _sname;

        public CtlMatrixInput()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public Matrix Matrix
        {
            get { return _mmatrix; }
            set { _mmatrix = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _sname; }
            set { _sname = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle11_TextChanged(object sender, EventArgs e)
        {
            Matrix.X11 = float.Parse(txtEle11.Text);

        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 && e.KeyChar != 8))
                e.Handled = true; 
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle12_TextChanged(object sender, EventArgs e)
        {
            Matrix.X12 = float.Parse(txtEle12.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 && e.KeyChar != 8))
                e.Handled = true; 
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle21_TextChanged(object sender, EventArgs e)
        {
            Matrix.X21 = float.Parse(txtEle21.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 && e.KeyChar != 8))
                e.Handled = true; 
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle22_TextChanged(object sender, EventArgs e)
        {
            Matrix.X22 = float.Parse(txtEle22.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 && e.KeyChar != 8))
                e.Handled = true; 
        }   
    }
}
