using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SoftwareProjekt.Classes.Math
{
    public class Triangle : IShape
    {
        private List<LineSegment> _segmentList;
        public LineSegment AB { get; private set; }
        public LineSegment BC { get; private set; }
        public LineSegment CA { get; private set; }

        public List<PointF> PointList
        {
            get
            {
                List<PointF> list = new List<PointF>();
                list.Add(this.AB.StartPoint);
                list.Add(this.BC.StartPoint);
                list.Add(this.CA.StartPoint);
                return list;
            }
        }
        public Triangle(PointF a, PointF b, PointF c)
        {
            Vector ab = new Vector(b.X - a.X, b.Y - a.Y);
            this.AB = new LineSegment(a, ab);

            Vector bc = new Vector(c.X - b.X, c.Y - b.Y);
            this.BC = new LineSegment(b, bc);

            Vector ac = new Vector(a.X - c.X, a.Y - c.Y);
            this.CA = new LineSegment(c, ac);

            _segmentList = new List<LineSegment>();
            _segmentList.Add(this.AB);
            _segmentList.Add(this.BC);
            _segmentList.Add(this.CA);
            this.Color = new Pen(System.Drawing.Color.Black);
        }
        public Triangle(PointF a, PointF b, PointF c, Pen color)
            : this(a, b, c)
        {
            this.Color = color;
        }
        public Triangle()
        {
            this.AB = new LineSegment();
            this.BC = new LineSegment();
            this.CA = new LineSegment();
            _segmentList = new List<LineSegment>();
            _segmentList.Add(AB);
            _segmentList.Add(BC);
            _segmentList.Add(CA);
            this.Color = new Pen(System.Drawing.Color.Black);
        }

        static public Triangle Translate(Triangle shape, Vector vector)
        {
            Triangle tri = new Triangle(shape.PointList[0], shape.PointList[1], shape.PointList[2], shape.Color);
            tri.Translate(vector);
            return tri;
        }

        static public Triangle Scale(Triangle shape, float vector)
        {
            Triangle tri = new Triangle(shape.PointList[0],shape.PointList[1],shape.PointList[2],shape.Color);
            tri.Scale(vector);
            return tri;
        }

        public void Translate(Vector vector)
        {
            foreach (LineSegment segment in _segmentList)
            {
                segment.StartPoint = new PointF(vector.X1 + segment.StartPoint.X, vector.X2 + segment.StartPoint.Y);
            }
        }

        /// <summary>
        /// Scales the triganle with the first point as center
        /// </summary>
        /// <param name="vector"></param>
        public void Scale(float scalar)
        {
            foreach (LineSegment segment in _segmentList)
            {
                segment.Vector.Scale(scalar);
            }
            this.BC.StartPoint = this.AB.EndPoint;
            this.CA.StartPoint = this.BC.EndPoint;
        }

        public Pen Color { get; set; }
    }
}
