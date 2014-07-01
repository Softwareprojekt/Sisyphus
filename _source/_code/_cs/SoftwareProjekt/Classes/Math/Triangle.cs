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
        private List<Vector> _vectorList;
        private Vector _a;
        private Vector _b;
        private Vector _c;
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
        public Triangle(PointF a, PointF b, PointF c)
        {
            _a = new Vector(a);
            _b = new Vector(b);
            _c = new Vector(c);
            _vectorList = new List<Vector>();
            _vectorList.Add(_a);
            _vectorList.Add(_b);
            _vectorList.Add(_c);
            this.Color = new Pen(System.Drawing.Color.Black);
        }
        public Triangle(PointF a, PointF b, PointF c, Pen color)
            : this(a, b, c)
        {
            this.Color = color;
        }
        public Triangle()
        {
            _vectorList = new List<Vector>();
            this.Color = new Pen(System.Drawing.Color.Black);
        }

        static public Triangle Multiply(Triangle shape, Matrix matrix)
        {
            Triangle tri = new Triangle(shape.PointList[0], shape.PointList[1], shape.PointList[2], shape.Color);
            tri.Multiply(matrix);
            return tri;
        }
        public void Multiply(Matrix matrix)
        {
            foreach (Vector vector in _vectorList)
            {
                vector.Multiply(matrix);
            }
        }
        public static Triangle AffineAbbildung(Triangle original, Matrix matrix, Vector vector)
        {
            Triangle t = new Triangle(original.PointList[0], original.PointList[1], original.PointList[2], original.Color);
            t.Multiply(matrix);
            t.Add(vector);
            return t;
        }
        static public Triangle Add(Triangle shape, Vector vector)
        {
            Triangle tri = new Triangle(shape.PointList[0], shape.PointList[1], shape.PointList[2], shape.Color);
            tri.Add(vector);
            return tri;
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
