
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
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SoftwareProjekt
{
    public class CoordinateSystem : UserControl
    {
        /// <summary>
        /// </summary>
        private System.Collections.Generic.List<SoftwareProjekt.LineSegment> _lineSegementList;
        private List<Line> _lineList;
              

        /// <summary>
        /// ctor
        /// </summary>
        public CoordinateSystem()
        {
            InitializeComponent();

            throw new System.NotImplementedException();
        }

        public IAxis XAxis
        {
            get
            {                
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IAxis YAxis
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// </summary>
        public void AddLineSegment(LineSegment lineSegment)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// removes a figure from the list, adjust axis
        /// </summary>
        public void RemoveLineSegment(SoftwareProjekt.LineSegment lineSegment)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// iterates the List and draws the figures
        /// </summary>
        private void DrawVector(System.Drawing.Graphics g)
        {
                       
            throw new System.NotImplementedException();
        }

        private void DrawLine(System.Drawing.Graphics g)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sets Name, Size, Events etc
        /// </summary>
        private void InitializeComponent()
        {
            this.Paint += CoordinateSystem_Paint;
        }

        /// <summary>
        /// Draws Axis, Line Segments and lines
        /// </summary>
        void CoordinateSystem_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// draws Axis and scale
        /// </summary>
        private void DrawAxis(System.Drawing.Graphics g)
        {
            throw new System.NotImplementedException();
        }

        public void AddLine(Line line)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveLine(Line line)
        {
            throw new System.NotImplementedException();
        }
    }
}
