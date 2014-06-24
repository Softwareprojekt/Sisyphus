using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SoftwareProjekt.Classes.Math
{
    class Triangle : IShape
    {
        public LineSegment AB{ get; private set; }
        public LineSegment BC { get; private set; }
        public LineSegment AC { get; private set; }
        public Triangle(PointF a, PointF b, PointF c)
        {
            Vector ab = new Vector(b.X - a.X, b.Y - a.Y);
            //AB = new LineSegment()
            
        }

        public Triangle()
        {

        }
        static public IShape Translate(IShape shape, Vector vector)
        {
            Triangle tri = new Triangle();
            return tri;
            throw new NotImplementedException();
        }

        static public IShape Scale(IShape shape, float vector)
        {
            throw new NotImplementedException();
        }

        public void Translate(Vector vector)
        {
            throw new NotImplementedException();
        }

        public void Scale(float vector)
        {
            throw new NotImplementedException();
        }

        public Pen Color
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
