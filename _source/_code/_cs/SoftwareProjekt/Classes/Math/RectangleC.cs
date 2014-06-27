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
        private List<Vector> _vectorList;
        private Vector _a;
        private Vector _b;
        private Vector _c;
        private Vector _d;

        public RectangleF Rectangle
        {
            get
            {
                return new RectangleF(PointList[0].X, PointList[0].Y, _vectorList[0].Length, _vectorList[2].Length);
            }
        }
        public List<PointF> PointList
        {
            get
            {
                List<PointF> list = new List<PointF>();
                foreach (Vector item in _vectorList)
                {
                    list.Add(new PointF(item.X1, item.X2));
                }                
                return list;
            }
        }
        public RectangleC()
        {
            _a = new Vector();
            _b = new Vector();
            _c = new Vector();
            _vectorList = new List<Vector>();
            _vectorList.Add(_a);
            _vectorList.Add(_b);
            _vectorList.Add(_c);
            _vectorList.Add(_d);
            this.Color = new Pen(System.Drawing.Color.Black);
        }
        public RectangleC(PointF a, PointF b, PointF c, PointF d)
        {
            _a = new Vector(a);
            _b = new Vector(b);
            _c = new Vector(c);
            _d = new Vector(d);
            _vectorList = new List<Vector>();
            _vectorList.Add(_a);
            _vectorList.Add(_b);
            _vectorList.Add(_c);
            _vectorList.Add(_d);
            this.Color = new Pen(System.Drawing.Color.Black);
        }

        public RectangleC(PointF a, PointF b, PointF c, PointF d, Pen color)
            : this(a, b, c, d)
        {
            this.Color = color;
        }

        public static RectangleC Multiply(RectangleC rectangle, Matrix matrix)
        {
            RectangleC r = new RectangleC(rectangle.PointList[0], rectangle.PointList[1], rectangle.PointList[2], rectangle.PointList[3], rectangle.Color);
            r.Multiply(matrix);
            return r;
        }

        public void Multiply(Matrix matrix)
        {
            foreach (Vector v in _vectorList)
            {
                v.Multiply(matrix);
            }
        }

        static public RectangleC Add(RectangleC rectangle, Vector vector)
        {
            RectangleC r = new RectangleC(rectangle.PointList[0], rectangle.PointList[1], rectangle.PointList[2], rectangle.PointList[3], rectangle.Color);
            r.Add(vector);
            return r;
        }

        public void Add(Vector vector)
        {
            foreach (Vector v in _vectorList)
            {
                v.Add(vector);
            }
        }

        public Pen Color { get; set; }
    }
}
