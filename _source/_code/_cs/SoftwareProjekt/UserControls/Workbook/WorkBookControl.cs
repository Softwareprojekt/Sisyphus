
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
using SoftwareProjekt.Classes.Math;

namespace SoftwareProjekt.UserControls.Workbook
{
    public class WorkbookEntry : UserControl
    {
        private Dictionary<string, Object> _state;
        /// <summary>
        /// ctor
        /// </summary>
        public WorkbookEntry()
        {
            InitializeComponent();
            CreationDate = DateTime.Now;
            Started = false;
            _state = new Dictionary<string, object>();
        }

        public DateTime CreationDate
        {
            get;
            set;
        }

        public Enums.EExercises ExerciseID
        {
            get;
            set;
        }

        /// <summary>
        /// Values and notes
        /// </summary>
        public Dictionary<string, Object> State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                this.Started = true;
                this.CreationDate = DateTime.Now;
            }
        }

        /// <summary>
        /// flag if exercise was started
        /// </summary>
        public bool Started
        {
            get;
            set;
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
            string firstHalf = this.ExerciseID.ToString();
            string secondHalf = this.CreationDate.ToString();
            if (this.State != null)
            {
                Dictionary<string, object>.Enumerator enumerator = this.State.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    if (enumerator.Current.Value.GetType() == (typeof(string)))
                    {
                        firstHalf += "\n" + "Notizen:\n" + (string)enumerator.Current.Value;
                    }
                    if (enumerator.Current.Value.GetType() == (typeof(Matrix)))
                    {
                        Matrix m = (Matrix)enumerator.Current.Value;
                        secondHalf += "\n" + "Matrix: (" + m.X11 + ", " + m.X12 + ", " + m.X21 + ", " + m.X22 + ")\n";
                    }
                    if (enumerator.Current.Value.GetType() == (typeof(Vector)))
                    {
                        Vector v = (Vector)enumerator.Current.Value;
                        secondHalf += "\n" + "Vector: (" + v.X1 + ", " + v.X2 + ")\n";
                    }

                    if (enumerator.Current.Value.GetType() == (typeof(float)))
                    {
                        secondHalf += "\n" + "Value:\n" + (float)enumerator.Current.Value;
                    }
                }
            }
            Graphics g = e.Graphics;
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            this.Width = this.Parent.Width - 100;
            g.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1); //draw a frame
            g.DrawString(firstHalf, drawFont, drawBrush, new Rectangle(10, 10, this.Width / 2, this.Height - 1)); //draw Exercisename (first half of control)
            g.DrawString(secondHalf, drawFont, drawBrush, new Rectangle(this.Width / 2 + 1, 10, this.Width - 1, this.Height - 1));    //draw Date (second half of control)
        }

    }
}
