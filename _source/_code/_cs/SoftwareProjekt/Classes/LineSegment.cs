
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

namespace SoftwareProjekt
{
    public class LineSegment
    {
        public LineSegment(System.Drawing.PointF startPoint, Vector directionalVector)
        {
            throw new System.NotImplementedException();
        }

        public LineSegment()
        {
            throw new System.NotImplementedException();
        }
    
        public System.Drawing.PointF StartPoint
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Vector Vector
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
        /// Is read-only; calculated from StartPoint and Vector
        /// </summary>
        public System.Drawing.PointF EndPoint
        {
            get
            {
                throw new System.NotImplementedException();
            }           
        }

        public System.Drawing.Pens Color
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool AngleVisible
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Label
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string AngleLabel
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
