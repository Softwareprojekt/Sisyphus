
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
    public class MindMapButtonControl : UserControl
    {
        private EAlignType _alignment;
        private string _buttonText;
<<<<<<< HEAD
        private int _excerciseID;
        private EMachiningCondtion _machiningCondition;
=======
        private int _exerciseID;
>>>>>>> fd4dd7492afb0d6b72945ea892f7f96353eeec03

        public event ExerciseClickEvent ButtonClicked;

        public MindMapButtonControl(string text, int excerciseID, EAlignType alignment)
        {
            _alignment = alignment;
            _buttonText = text;
            _excerciseID = excerciseID;

            _machiningCondition = EMachiningCondtion.NotDone;

            InitializeComponent();
        }

        public string ButtonText
        {
            get
            {
                return _buttonText;
            }
            set
            {
                _buttonText = value;
            }
        }

        public bool LeftAlign
        {
            get
            {
                return (_alignment == EAlignType.AlignLeft);
            }
            set
            {
                _alignment = EAlignType.AlignLeft;
            }
        }
        public bool RightAlign
        {
            get
            {
                return (_alignment == EAlignType.AlignRight);
            }
            set
            {
                _alignment = EAlignType.AlignRight;
            }
        }
        public bool TopAlign
        {
            get
            {
                return (_alignment == EAlignType.AlignTop);
            }
            set
            {
                _alignment = EAlignType.AlignTop;
            }
        }
        public bool BottomAlign
        {
            get
            {
                return (_alignment == EAlignType.AlignBottom);
            }
            set
            {
                _alignment = EAlignType.AlignBottom;
            }
        }

        public int ExerciseID
        {
            get
            {
                return _excerciseID;
            }
            set
            {
                _excerciseID = value;
            }
        }

        public EMachiningCondtion MachiningCondition
        {
            get
            {
                return _machiningCondition;
            }
            set
            {
                _machiningCondition = value;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MindMapButtonControl
            // 
            this.Name = "MindMapButtonControl";
            this.Paint += MindMapButtonControl_Paint;
            this.Click += MindMapButtonControl_Click;
            this.ResumeLayout(false);

        }

        void MindMapButtonControl_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked MindMapButtonControl!");

            if (ButtonClicked != null)
            {
                this.ButtonClicked(_excerciseID);
            }
        }

        void MindMapButtonControl_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(10, this.Height / 2);
            Point endPoint = new Point(this.Width - 10, this.Height / 2);
            Graphics g = e.Graphics;
            Pen linePen = null;

            int innerXValue = 0;

            switch (_machiningCondition)
            {
                case EMachiningCondtion.Aborted:
                    linePen = Pens.Blue;
                    break;

                case EMachiningCondtion.NotDone:
                    linePen = Pens.Black;
                    break;

                case EMachiningCondtion.SaveExists:
                    linePen = Pens.Green;
                    break;
            }
            
            switch (_alignment)
            {
                case EAlignType.AlignBottom:
                    innerXValue = (this.Width - 30) / 2 + 15;
                    g.DrawLine(linePen, new Point(15, 15), new Point (this.Width - 15, 15));
                    g.DrawLine(linePen, new Point(innerXValue, 15), new Point(innerXValue, this.Height));
                    g.DrawString(_buttonText, new Font("Arial", 8.0f), new SolidBrush(linePen.Color), new PointF(innerXValue - (_buttonText.Length * 4.5f) / 2, 1.5f));
                    break;

                case EAlignType.AlignTop:
                    innerXValue = (this.Width - 30) / 2 + 15;
                    g.DrawLine(linePen, new Point(15, this.Height - 15), new Point(this.Width - 15, this.Height - 15));
                    g.DrawLine(linePen, new Point(innerXValue, this.Height - 15), new Point(innerXValue, 0));
                    g.DrawString(_buttonText, new Font("Arial", 8.0f), new SolidBrush(linePen.Color), new PointF(innerXValue - (_buttonText.Length * 4.5f) / 2, this.Height - 14.0f));

                    break;

                case EAlignType.AlignLeft:
                    g.DrawLine(linePen, new Point(0, 15), new Point(this.Width - 30, 15));
                    g.DrawString(_buttonText, new Font("Arial", 8.0f), new SolidBrush(linePen.Color), new PointF(this.Width - 30 - (_buttonText.Length * 4.5f), 1.5f));
                    break;

                case EAlignType.AlignRight:
                    g.DrawLine(linePen, new Point(30, 15), new Point(this.Width, 15));
                    g.DrawString(_buttonText, new Font("Arial", 8.0f), new SolidBrush(linePen.Color), new PointF(30, 1.5f));
                    break;
            }
        }

    }
}
