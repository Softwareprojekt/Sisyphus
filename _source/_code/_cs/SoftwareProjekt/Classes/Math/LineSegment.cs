
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
using System.Drawing;

namespace SoftwareProjekt.Classes.Math
{
    public class LineSegment : IComparable
    {
    	public LineSegment(PointF startPoint, Vector directionalVector, Pen color) : this(startPoint, directionalVector)
    	{
    		this.Color = color;
    	}
        public LineSegment(PointF startPoint, Vector directionalVector)
        {
            this.StartPoint = new PointF(startPoint.X, startPoint.Y);
            this.Vector = directionalVector;

            this.AngleVisible = false;
            this.Color = Pens.Black;
        }

        public LineSegment()
        {
            this.StartPoint = new PointF(0.0f, 0.0f);
            this.Vector = new Vector(0.0f, 0.0f);

            this.AngleVisible = false;
            this.Color = Pens.Black;
        }

        public PointF StartPoint { get; private set; }

        public Vector Vector { get; set; }

        /// <summary>
        /// Is read-only; calculated from StartPoint and Vector
        /// </summary>
        public PointF EndPoint
        {
            get
            {
                return new PointF(this.StartPoint.X + this.Vector.X1, this.StartPoint.Y + this.Vector.X2);
            }
        }

        public Pen Color { get; set; }

        public bool AngleVisible { get; set; }

        public string Label { get; set; }

        public string AngleLabel { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is LineSegment))
            {
                return -1;
            }

            LineSegment ls = obj as LineSegment;
            if (this.Label == ls.Label && this.EndPoint == ls.EndPoint && this.AngleLabel == ls.AngleLabel && this.StartPoint == this.StartPoint)
            {
                return 0;
            }

            return -1;
        }

        public override bool Equals(object obj)
        {
            return this.CompareTo(obj) == 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
