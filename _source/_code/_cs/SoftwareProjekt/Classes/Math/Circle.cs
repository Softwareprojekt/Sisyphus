using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SoftwareProjekt.Classes.Math
{
    public class Circle : IShape
    {
        public float Radius { get; set; }
        public float Diameter
        {
            get
            {
                return Radius * 2;
            }
        }

        public PointF Center { get; set; }

        public RectangleF Rectangle
        {
            get
            {
                return new RectangleF(Center.X - Radius, Center.Y - Radius, Diameter, Diameter);
            }
        }
        public Circle()
        {
            this.Center = new PointF(float.NaN,float.NaN);
            this.Radius = float.NaN;
            this.Color = new Pen(System.Drawing.Color.Black);
        }
        public Circle(PointF center, float radius)
        {
            this.Center = center;
            this.Radius = radius;
            this.Color = new Pen(System.Drawing.Color.Black);
        }
        public Circle(PointF center, float radius, Pen color) : this(center, radius)
        {
            this.Color = color;
        }
        public void Translate(Vector vector)
        {
            throw new NotImplementedException();
        }

        public void Scale(float scalar)
        {
            throw new NotImplementedException();
        }

        public System.Drawing.Pen Color{ get;set;}
    }
}
