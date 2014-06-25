
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
        private Vector _vector = null;
        public CtlVectorInput()
        {
            InitializeComponent();

            this.Vector = new Vector();
        }

        /// <summary>
        /// Property for Vector None. 
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
                    return;
                }
                this.Refresh();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle11_TextChanged(object sender, EventArgs e)
        {
            float f = (sender as SoftwareProjekt.UserControls.FloatInput).FloatValue;
            this.Vector.X1 = f;
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle11_KeyPress(object sender, KeyPressEventArgs e)
        { }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle21_TextChanged(object sender, EventArgs e)
        {
            float f = (sender as SoftwareProjekt.UserControls.FloatInput).FloatValue;
            this.Vector.X2 = f;
        }

        /// <summary>
        /// 
        /// </summary>
        private void txtEle21_KeyPress(object sender, KeyPressEventArgs e)
        { }

   

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
