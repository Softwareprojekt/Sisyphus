
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

using SoftwareProjekt.Classes.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt.Forms
{
    public partial class TestObject : Form
    {
        public TestObject()
        {
            InitializeComponent();

            
            
            LineSegment ls1 = new LineSegment(new PointF(1.0f, 1.5f), new Vector(4.0f, 1.0f));
            ls1.Color = Pens.Blue;
            ls1.Label = "ls1";

            LineSegment ls2 = new LineSegment(new PointF(0.5f, 0.5f), new Vector(1.0f, 4.0f));
            ls2.Color = Pens.Red;
            ls2.Label = "ls2";

            LineSegment ls3 = new LineSegment(new PointF(4.0f, 5.0f), new Vector(-4.0f, -1.0f));
            ls3.Color = Pens.Green;
            ls3.Label = "ls3";

            LineSegment ls4 = new LineSegment(new PointF(0.0f, 0.0f), new Vector(1.0f, 0.0f));
            ls4.Color = Pens.Orange;
            ls4.Label = "e0";


            LineSegment ls5 = new LineSegment(new PointF(0.0f, 0.0f), new Vector(0.0f, 1.0f));
            ls5.Color = Pens.Orange;
            ls5.Label = "e1";

            LineSegment ls6 = new LineSegment(new PointF(3.0f, 5.0f), new Vector(1.0f, -3.0f));
            ls6.Label = "ls6";
            ls6.Color = Pens.Orange;

            coordinateSystem1.AddLineSegment(ls1);
            coordinateSystem1.AddLineSegment(ls2);
            coordinateSystem1.AddLineSegment(ls3);
            coordinateSystem1.AddLineSegment(ls4);
            coordinateSystem1.AddLineSegment(ls5);
            coordinateSystem1.AddLineSegment(ls6);


            Line l1 = new Line(new LineSegment(new PointF(0.0f, 0.0f), new Vector(2.0f, 4.0f)));
            l1.InnerLineSegment.Color = Pens.YellowGreen;
            coordinateSystem1.AddLine(l1);

            PointF point = new PointF(1.0f, 1.5f);
            coordinateSystem1.AddPoint(point);
            
            this.coordinateSystem1.CoordinateClick += CoordinateClickHandler;
        }

		void CoordinateClickHandler(float x, float y, MouseEventArgs e)
		{
			//this.OnViewChanged(new ViewEventArgs(x, y));
		}
		
		/*public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
		{
			throw new NotImplementedException();
		}*/
    }
}
