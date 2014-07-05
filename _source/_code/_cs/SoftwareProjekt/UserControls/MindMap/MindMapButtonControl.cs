
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

using SoftwareProjekt.Delegates;
using SoftwareProjekt.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt.UserControls.MindMap
{
    public class MindMapButtonControl : UserControl
    {
        private EAlignType _alignment;
        private string _buttonText;

        public event ExerciseClickEvent ButtonClicked;

        public MindMapButtonControl()
        {
            _alignment = EAlignType.AlignLeft;
            ExerciseID = EExercises.DrehungLinAbbUmUrsprung;
            _buttonText = "Hallo Welt";
            InitializeComponent();

        }

        public MindMapButtonControl(string text, EExercises excerciseID, EAlignType alignment)
        {
            _alignment = alignment;
            _buttonText = text;
            this.ExerciseID = excerciseID;

            this.MachiningCondition = EMachiningCondition.NotDone;

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
                if (value)
                {
                    _alignment = EAlignType.AlignLeft;
                }
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
                if (value)
                {
                    _alignment = EAlignType.AlignRight;
                }
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
                if (value)
                {
                    _alignment = EAlignType.AlignTop;
                }
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
                if (value)
                {
                    _alignment = EAlignType.AlignBottom;
                }
            }
        }

        public EExercises ExerciseID
        {
            get;
            set;
        }

        public EMachiningCondition MachiningCondition
        {
            get;
            set;
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
                this.ButtonClicked(this.ExerciseID);
            }
        }

        void MindMapButtonControl_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(10, this.Height / 2);
            Point endPoint = new Point(this.Width - 10, this.Height / 2);
            Graphics g = e.Graphics;
            Pen linePen = null;

            int innerXValue = 0;

            switch (this.MachiningCondition)
            {
                case EMachiningCondition.Aborted:
                    linePen = Pens.Blue;
                    break;

                case EMachiningCondition.NotDone:
                    linePen = Pens.Black;
                    break;

                case EMachiningCondition.SaveExists:
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
                    g.DrawString(_buttonText, new Font("Arial", 8.0f), new SolidBrush(linePen.Color), new PointF(this.Width - 40 - (_buttonText.Length * 5f), 1.5f));
                    break;

                case EAlignType.AlignRight:
                    g.DrawLine(linePen, new Point(30, 15), new Point(this.Width, 15));
                    g.DrawString(_buttonText, new Font("Arial", 8.0f), new SolidBrush(linePen.Color), new PointF(30, 1.5f));
                    break;
            }
        }

    }
}
