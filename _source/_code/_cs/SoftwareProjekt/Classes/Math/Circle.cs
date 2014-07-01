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
        private Vector _center;
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
            this.Center = new PointF(float.NaN, float.NaN);
            _center = new Vector();
            this.Radius = float.NaN;
            this.Color = new Pen(System.Drawing.Color.Black);
        }
        public Circle(PointF center, float radius)
        {
            this.Center = center;
            _center = new Vector(center.X, center.Y);
            this.Radius = radius;
            this.Color = new Pen(System.Drawing.Color.Black);
        }
        public Circle(PointF center, float radius, Pen color)
            : this(center, radius)
        {
            this.Color = color;
        }

        public static Circle AffineAbbildung(Circle original, Matrix matrix, Vector vector)
        {
            Circle c = new Circle(original.Center, original.Radius, original.Color);
            c.Multiply(matrix);
            c.Add(vector);
            return c;
        }

        public static Circle Multiply(Circle circle, Matrix matrix)
        {
            Circle c = new Circle(circle.Center, circle.Radius, circle.Color);
            c.Multiply(matrix);
            return c;
        }

        public void Multiply(Matrix matrix)
        {
            _center.Multiply(matrix);
            Vector v = new Vector(Center.X + Radius, Center.Y);
            v.Multiply(matrix);
            Radius = System.Math.Abs(v.X2 - v.X1);
            this.Center = new PointF(_center.X1, _center.X2);
        }

        static public Circle Add(Circle circle, Vector vector)
        {
            Circle c = new Circle(circle.Center, circle.Radius, circle.Color);
            c.Add(vector);
            return c;
        }

        public void Add(Vector vector)
        {
            _center.Add(vector);
            this.Center = new PointF(_center.X1, _center.X2);
        }

        public System.Drawing.Pen Color { get; set; }
    }
}
