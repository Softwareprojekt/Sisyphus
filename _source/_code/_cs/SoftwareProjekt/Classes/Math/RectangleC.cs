using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SoftwareProjekt.Classes.Math
{
    public class RectangleC : IShape
    {
        private List<LineSegment> _segmentList;
        public LineSegment AB { get; private set; }
        public LineSegment BC { get; private set; }
        public LineSegment CD { get; private set; }
        public LineSegment DA { get; private set; }

        public RectangleF Rectangle
        {
            get
            {
                return new RectangleF(this.AB.StartPoint.X, this.AB.StartPoint.Y, AB.Vector.Length, BC.Vector.Length);
            }
        }
        public List<PointF> PointList
        {
            get
            {
                List<PointF> list = new List<PointF>();
                list.Add(this.AB.StartPoint);
                list.Add(this.BC.StartPoint);
                list.Add(this.CD.StartPoint);
                list.Add(this.DA.StartPoint);
                return list;
            }
        }
        public RectangleC()
        {
            this.AB = new LineSegment();
            this.BC = new LineSegment();
            this.CD = new LineSegment();
            this.DA = new LineSegment();
            _segmentList = new List<LineSegment>();
            _segmentList.Add(AB);
            _segmentList.Add(BC);
            _segmentList.Add(CD);
            _segmentList.Add(DA);
            this.Color = new Pen(System.Drawing.Color.Black);
        }
        public RectangleC(PointF a, PointF b, PointF c, PointF d)
        {
            Vector ab = new Vector(b.X - a.X, b.Y - a.Y);
            this.AB = new LineSegment(a, ab);

            Vector bc = new Vector(c.X - b.X, c.Y - b.Y);
            this.BC = new LineSegment(b, bc);

            Vector cd = new Vector(d.X - c.X, d.Y - c.Y);
            this.CD = new LineSegment(c, cd);

            Vector da = new Vector(a.X - d.X, a.Y - d.Y);
            this.DA = new LineSegment(d, da);

            _segmentList = new List<LineSegment>();
            _segmentList.Add(this.AB);
            _segmentList.Add(this.BC);
            _segmentList.Add(this.CD);
            _segmentList.Add(this.DA);
            this.Color = new Pen(System.Drawing.Color.Black);
        }

        public RectangleC(PointF a, PointF b, PointF c, PointF d, Pen color)
            : this(a, b, c, d)
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

        public Pen Color { get; set; }
    }
}
