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



        }

    }
}
