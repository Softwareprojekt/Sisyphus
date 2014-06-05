
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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public class WorkBookView : UserControl
    {
        private int _excerciseID;
        private string _imagePath;
        private string _notices;
        private Image _savedImage;
        private string _dateTime;

         /// <summary>
        /// ctor
        /// </summary>
        public WorkBookView()
        {
            InitializeComponent();

            throw new System.NotImplementedException();
        }

        public int CreationDate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Notizen
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int ExcerciseID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WorkBookView
            // 
            this.Name = "WorkBookView";
            this.Paint += WorkBookControl_Paint;
            this.ResumeLayout(false);

        }

        void WorkBookControl_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ForceRefresh()
        {
            throw new System.NotImplementedException();
        }

    }
}
