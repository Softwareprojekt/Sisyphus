using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SoftwareProjekt.Classes.Math
{
    public class Polygon : Interfaces.IShape
    {
        private List<Vector> _vectorList;
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
        public Polygon(List<PointF> list)
        {
            _vectorList = new List<Vector>();
            foreach (PointF p in list)
            {
                _vectorList.Add(new Vector(p));
            }
            this.Color = new Pen(System.Drawing.Color.Black);
        }
        public Polygon(List<PointF> list, Pen color)
            : this(list)
        {
            this.Color = color;
        }
        public Polygon()
        {
            _vectorList = new List<Vector>();
            this.Color = new Pen(System.Drawing.Color.Black);
        }

        static public Polygon AffineAbbildung(Polygon shape, Matrix matrix, Vector vector)
        {
            Polygon pol = new Polygon(shape.PointList, shape.Color);
            pol.Multiply(matrix);
            pol.Add(vector);
            return pol;
        }

        static public Polygon Multiply(Polygon shape, Matrix matrix)
        {
            Polygon pol = new Polygon(shape.PointList, shape.Color);
            pol.Multiply(matrix);
            return pol;
        }
        public void Multiply(Matrix matrix)
        {
            foreach (Vector vector in _vectorList)
            {
                vector.Multiply(matrix);
            }
        }
        static public Polygon Add(Polygon shape, Vector vector)
        {
            Polygon pol = new Polygon(shape.PointList, shape.Color);
            pol.Add(vector);
            return pol;
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
