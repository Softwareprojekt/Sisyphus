using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class DrawingPoint
    {
        public PointF BaseCoordinate { get; set; }
        public Pen Color { get; set; }

        public DrawingPoint(PointF p)
        {
            Color = Pens.Black;
            BaseCoordinate = p;
        }

    }
}
