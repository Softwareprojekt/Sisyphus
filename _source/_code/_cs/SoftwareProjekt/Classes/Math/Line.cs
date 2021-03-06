﻿
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
    public class Line : IComparable
    {
        public Line(LineSegment lineSegment)
        {
            InnerLineSegment = lineSegment;
        }

        public Line(float angle)
        {
            double t = System.Math.Tan(angle * System.Math.PI  / 180.0 ); 
            Vector v = new Vector(1f, (float) t);
            this.InnerLineSegment = new LineSegment(new PointF(0.0f, 0.0f), v);
        }
        public Line(Vector firstVector, Vector secondVector)
        {
            InnerLineSegment = new LineSegment(new PointF(firstVector.X1, firstVector.X2), secondVector);
        }

        public LineSegment InnerLineSegment { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Line))
            {
                return -1;
            }

            return InnerLineSegment.CompareTo((obj as Line).InnerLineSegment);
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
