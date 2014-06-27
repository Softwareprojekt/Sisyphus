
#region LicenseHeader
/*
 * Copyright (C) 2014 Technische Hochschule Amberg
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
#endregion

using SoftwareProjekt.Classes.Math;
using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SoftwareProjekt.UserControls
{
    public delegate void CoordinateSystemClickHandler(float x, float y);
    public class CoordinateSystem : UserControl
    {
        /// <summary>
        /// </summary>
        private List<LineSegment> _lineSegmentList;
        private List<Line> _lineList;
        private List<Triangle> _triangleList;
        private List<RectangleC> _rectangleList;
        private List<Circle> _circleList;

        private IAxis _xAxis;
        private IAxis _yAxis;


        public CoordinateSystemClickHandler CoordinateClick;
        private List<PointF> _pointsList;

        /// <summary>
        /// ctor
        /// </summary>
        public CoordinateSystem()
        {
            _lineList = new List<Line>();
            _lineSegmentList = new List<LineSegment>();
            _pointsList = new List<PointF>();
            _rectangleList = new List<RectangleC>();
            _circleList = new List<Circle>();
            _triangleList = new List<Triangle>();


            InitializeComponent();
        }

        public IAxis XAxis
        {
            get
            {
                return _xAxis;
            }
            set
            {
                _xAxis = value;
            }
        }

        public IAxis YAxis
        {
            get
            {
                return _yAxis;
            }
            set
            {
                _yAxis = value;
            }
        }

        /// <summary>
        /// </summary>
        
        private void invokeRefresh()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => this.invokeRefresh()));
                return;
            }
            this.Refresh();    
        }

        public void AddLineSegment(LineSegment lineSegment)
        {
            _lineSegmentList.Add(lineSegment);
            this.invokeRefresh();
        }

        public void AddTriangle(Triangle triangle)
        {
            _triangleList.Add(triangle);
            this.invokeRefresh();
        }

        public void AddRectangle(RectangleC rectangle)
        {
            _rectangleList.Add(rectangle);
            this.invokeRefresh();
        }
        public void AddCircle(Circle circle)
        {
            _circleList.Add(circle);
            this.invokeRefresh();
        }

        public void RemoveTriangle(Triangle triangle)
        {
            _triangleList.Remove(triangle);
            this.invokeRefresh();
        }

        public void RemoveRectangle(RectangleC rectangle)
        {
            _rectangleList.Remove(rectangle);
            this.invokeRefresh();
        }
        public void RemoveCircle(Circle circle)
        {
            _circleList.Remove(circle);
            this.invokeRefresh();
        }

        public void ClearTriangles()
        {
            _triangleList.Clear();
            this.invokeRefresh();
        }

        public void ClearRectangles()
        {
            _rectangleList.Clear();
            this.invokeRefresh();
        }
        public void ClearCircles()
        {
            _circleList.Clear();
            this.invokeRefresh();
        }

        /// <summary>
        /// Removes all drawings in the CoordinateSystem
        /// </summary>
        public void Clear()
        {
            _pointsList.Clear();
            _lineList.Clear();
            _lineSegmentList.Clear();
            _triangleList.Clear();
            _rectangleList.Clear();
            _circleList.Clear();
            this.invokeRefresh();
        }

        /// <summary>
        /// removes a figure from the list, adjust axis
        /// </summary>
        public void RemoveLineSegment(LineSegment lineSegment)
        {
            _lineSegmentList.Remove(lineSegment);
        }

        public void ClearLineSegments()
        {
        	_lineSegmentList.Clear();
        }
        
        /// <summary>
        /// iterates the List and draws the figures
        /// </summary>
        private void DrawVector(Graphics g)
        {
            foreach (LineSegment ls in _lineSegmentList)
            {
                if (ls.StartPoint.X == ls.EndPoint.X && ls.StartPoint.Y == ls.EndPoint.Y)
                {
                    DrawSinglePoint(new PointF(ls.StartPoint.X, ls.StartPoint.Y), g);
                }
                else
                {
                    DrawSingleVector(ls, g);
                }
            }
        }

        private void DrawZeroVector(LineSegment ls, Graphics g)
        {
            PointF internalStartPoint = CalculateInternalCoordinates(ls.StartPoint.X, ls.EndPoint.Y);

            if (float.IsNaN(internalStartPoint.X) || float.IsNaN(internalStartPoint.Y))
            {
                return;
            }

            float internalEndpointX = internalStartPoint.X + 2;
            float internalEndpointY = internalStartPoint.Y - 2;

            g.DrawLine(ls.Color, new PointF(internalStartPoint.X, internalStartPoint.Y), 
                new PointF(internalEndpointX, internalEndpointY));

            g.DrawLine(ls.Color, new PointF(internalEndpointX, internalEndpointY), 
                new PointF(internalEndpointX - 10, internalEndpointY));

            g.DrawLine(ls.Color, new PointF(internalEndpointX, internalEndpointY),
                new PointF(internalEndpointX, internalEndpointY + 10));

            if (!String.IsNullOrEmpty(ls.Label))
            {
                float steigung = (float)Math.Abs(ls.EndPoint.Y - ls.StartPoint.Y) / (float)Math.Abs(ls.StartPoint.X - ls.EndPoint.X);

                if ((ls.EndPoint.Y - ls.StartPoint.Y) < 0 && (ls.StartPoint.X - ls.EndPoint.X) < 0)
                {
                    steigung *= -1;
                }

                float printPointX = internalStartPoint.X + (internalEndpointX - internalStartPoint.X) / 2;
                float printPointYPart1 = (printPointX - internalStartPoint.X);
                float printPointYPart2 = steigung * printPointYPart1;
                float printPointY = internalStartPoint.Y - printPointYPart2 + 10;

                if (float.IsInfinity(steigung))
                {
                    printPointY = internalStartPoint.Y - ((internalStartPoint.Y - internalEndpointY) / 2);
                }

                PointF printPoint = new PointF(printPointX, printPointY);
                g.DrawString(ls.Label, new Font("Arial", 9.0f), new SolidBrush(ls.Color.Color), printPoint);

            }
        }

        private void DrawSingleVector(LineSegment ls, Graphics g)
        {
            PointF internalStartPoint = CalculateInternalCoordinates(ls.StartPoint.X, ls.StartPoint.Y);
            PointF internalEndPoint = CalculateInternalCoordinates(ls.EndPoint.X, ls.EndPoint.Y);

            if (float.IsNaN(internalEndPoint.X) || float.IsNaN(internalEndPoint.Y))
            {
                return;
            }

            if (float.IsNaN(internalStartPoint.X) || float.IsNaN(internalStartPoint.Y))
            {
                return;
            }

            g.DrawLine(ls.Color, internalStartPoint, internalEndPoint);

            // calculate 45° angle to line at endpoint
            float deltaY = Math.Abs(ls.EndPoint.Y - ls.StartPoint.Y);
            float deltaX = Math.Abs(ls.EndPoint.X - ls.StartPoint.X);
            float tan = 0;

            if (deltaX == 0)
            {
                tan = float.MaxValue;
            }
            else
            {
                tan = deltaY / deltaX;
            }

            float piAngle = (float)Math.Atan(tan);
            float angle = 360 - (piAngle / (float)Math.PI) * 180;


            System.Drawing.Drawing2D.Matrix mRot = new System.Drawing.Drawing2D.Matrix();
            mRot.RotateAt(45, new PointF(internalEndPoint.X, internalEndPoint.Y), MatrixOrder.Append);

            g.Transform = mRot;

            Pen localPen = new Pen(ls.Color.Color, 0.4f);            
            float lengthOfLine = (float)Math.Sqrt((float)Math.Pow(Math.Abs(internalEndPoint.X - internalStartPoint.X), 2.0f) + Math.Pow(Math.Abs(internalEndPoint.Y - internalStartPoint.Y), 2.0f));

            localPen.DashPattern = new float[] { 10.0f, lengthOfLine - 10.0f };
            localPen.DashStyle = DashStyle.Custom;

            g.DrawLine(localPen, internalEndPoint, internalStartPoint);


            mRot.RotateAt(-90, new PointF(internalEndPoint.X, internalEndPoint.Y), MatrixOrder.Append);
            g.Transform = mRot;

            localPen.DashPattern = new float[] { 10.0f, lengthOfLine - 10.0f };
            localPen.DashStyle = DashStyle.Custom;

            g.DrawLine(localPen, internalEndPoint, internalStartPoint);

            mRot.RotateAt(45, new PointF(internalEndPoint.X, internalEndPoint.Y), MatrixOrder.Append);

            g.Transform = mRot;

            if (!String.IsNullOrEmpty(ls.Label))
            {
                float steigung = (float)Math.Abs(ls.EndPoint.Y - ls.StartPoint.Y) / (float)Math.Abs(ls.StartPoint.X - ls.EndPoint.X);

                if ((ls.EndPoint.Y - ls.StartPoint.Y) < 0 && (ls.StartPoint.X - ls.EndPoint.X) < 0)
                {
                    steigung *= -1;
                }

                float printPointX = internalStartPoint.X + (internalEndPoint.X - internalStartPoint.X) / 2;
                float printPointYPart1 = (printPointX - internalStartPoint.X);
                float printPointYPart2 = steigung * printPointYPart1;
                float printPointY = internalStartPoint.Y - printPointYPart2 + 10;

                if (float.IsInfinity(steigung))
                {
                    printPointY = internalStartPoint.Y - ((internalStartPoint.Y - internalEndPoint.Y) / 2);
                }

                PointF printPoint = new PointF(printPointX, printPointY);
                g.DrawString(ls.Label, new Font("Arial", 9.0f), new SolidBrush(ls.Color.Color), printPoint);

            }


        }

        private void DrawSingleLine(Line l, Graphics g)
        {
            Pen dashingPen = new Pen(l.InnerLineSegment.Color.Color);
            dashingPen.DashStyle = DashStyle.Dash;

            PointF internalStartPoint = CalculateInternalCoordinates(l.InnerLineSegment.StartPoint.X, l.InnerLineSegment.StartPoint.Y);
            PointF internalEndPoint = CalculateInternalCoordinates(l.InnerLineSegment.EndPoint.X, l.InnerLineSegment.EndPoint.Y);

            if (float.IsNaN(internalEndPoint.X) || float.IsNaN(internalEndPoint.Y))
            {
                return;
            }

            if (float.IsNaN(internalStartPoint.X) || float.IsNaN(internalStartPoint.Y))
            {
                return;
            }

            Pen localPen = new Pen(l.InnerLineSegment.Color.Color, 0.4f);
            localPen.DashPattern = new float[] { 10.0f, 5.0f };
            localPen.DashStyle = DashStyle.Custom;

            g.DrawLine(localPen, internalStartPoint, internalEndPoint);
        }

        private void DrawLine(Graphics g)
        {
            foreach (Line l in _lineList)
            {
                DrawSingleLine(l, g);
            }
        }

        /// <summary>
        /// Sets Name, Size, Events etc
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();

            this._xAxis = new Axis(true);
            this._yAxis = new Axis(false);
            this._xAxis.EndValue = 5.0f;
            this._xAxis.StartValue = 0.0f;
            this._xAxis.Scale = 0.5f;
            this._xAxis.Legend = "X-axis";



            this._yAxis.EndValue = 5.0f;
            this._yAxis.StartValue = 0.0f;
            this._yAxis.Scale = 0.5f;
            this._yAxis.Legend = "Y-axis";

            this.Paint += CoordinateSystem_Paint;
            this.Resize += CoordinateSystem_Resize;
            this.MouseClick += CoordinateSystem_MouseClick;


            // 
            // CoordinateSystem
            // 
            this.Name = "CoordinateSystem";
            this.ResumeLayout(false);



        }

        void CoordinateSystem_MouseClick(object sender, MouseEventArgs e)
        {
            PointF p = CalculateExternalCoordinates(e.X, e.Y);

            if (float.IsNaN(p.X) || float.IsNaN(p.Y))
            {
#if DEBUG
                Console.WriteLine("INFO @ CoordinateSystem_MouseClick: Outside valid range!\n");
#endif
                return;
            }
            float roundX = (float)Math.Round(p.X, 1, MidpointRounding.AwayFromZero);
            float roundY = (float)Math.Round(p.Y, 1, MidpointRounding.AwayFromZero);

#if DEBUG            
            Console.WriteLine("SUCCESS @ CoordinateSystem_MouseClick: X: " + roundX.ToString() + "\tY: " + roundY.ToString() + "\n");
#endif

            if (this.CoordinateClick != null)
            {
                this.CoordinateClick(roundX, roundY);
            }
        }

        void CoordinateSystem_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        /// <summary>
        /// Draws Axis, Line Segments and lines
        /// </summary>
        void CoordinateSystem_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.White);
            DrawAxes(e.Graphics);
            DrawVector(e.Graphics);
            DrawLine(e.Graphics);
            DrawPoints(e.Graphics);
            DrawRectangle(e.Graphics);
            DrawTriangle(e.Graphics);
            DrawCircle(e.Graphics);

        }

        private void DrawCircle(Graphics graphics)
        {
            foreach (Circle c in _circleList)
            {
                PointF f = CalculateInternalCoordinates(c.Rectangle.X, c.Rectangle.Y);
                Point p = new Point((int)f.X, (int)f.Y);
                //calc distance between two points in pixel (for x and y)
                PointF pf = CalculateInternalCoordinates(0, 0);
                PointF pf1 = CalculateInternalCoordinates(1f, 1f);
                int x = (int)pf1.X - (int)pf.X;
                int y = (int)pf1.Y - (int)pf.Y;
                float xWidth = x * c.Rectangle.Width;
                float yHeight = y * c.Rectangle.Height;

                Rectangle r = new Rectangle(p.X, p.Y, (int)xWidth, (int)yHeight); 
                graphics.FillEllipse(c.Color.Brush, r);
            }
        }

        private void DrawTriangle(Graphics graphics)
        {
            foreach (Triangle t in _triangleList)
            {
                List<PointF> l = new List<PointF>();
                foreach (PointF item in t.PointList)
                {
                    l.Add(CalculateInternalCoordinates(item.X, item.Y));
                }
                graphics.FillPolygon(t.Color.Brush, l.ToArray());
            }
        }

        private void DrawRectangle(Graphics graphics)
        {
            foreach (RectangleC r in _rectangleList)
            {
                List<PointF> l = new List<PointF>();
                foreach (PointF item in r.PointList)
                {
                    l.Add(CalculateInternalCoordinates(item.X, item.Y));
                }
                graphics.FillPolygon(r.Color.Brush, l.ToArray());
            }
        }

        /// <summary>
        /// draws Axis and scale
        /// </summary>
        private void DrawAxes(Graphics g)
        {
            DrawXAxis(g);
            DrawYAxis(g);
        }


        private void DrawPoints(Graphics g)
        {
            foreach (PointF p in _pointsList)
            {
                DrawSinglePoint(p, g);
            }
        }

        private void DrawSinglePoint(PointF p, Graphics g)
        {
            PointF internalPoint = CalculateInternalCoordinates(p.X, p.Y);


            if (float.IsNaN(internalPoint.X) || float.IsNaN(internalPoint.Y))
            {
                return;
            }

            g.DrawLine(Pens.Black, new PointF(internalPoint.X - 3, internalPoint.Y - 3), new PointF(internalPoint.X + 3, internalPoint.Y + 3));
            g.DrawLine(Pens.Black, new PointF(internalPoint.X - 3, internalPoint.Y + 3), new PointF(internalPoint.X + 3, internalPoint.Y - 3));
        }

        private void DrawXAxis(Graphics g)
        {
            float yCoordinate = this.Height - this.Height / 10;
            float xCoordinateEndPoint = this.Width - this.Width / 10;
            float xCoordinateStartPoint = this.Width / 10;
            PointF endPoint = new PointF(xCoordinateEndPoint, yCoordinate);
            PointF startPoint = new PointF(xCoordinateStartPoint, yCoordinate);

            // draw the arrows
            g.DrawLine(Pens.Black, startPoint, endPoint);
            g.DrawLine(Pens.Black, endPoint, new PointF(xCoordinateEndPoint - 10, yCoordinate + 5));
            g.DrawLine(Pens.Black, endPoint, new PointF(xCoordinateEndPoint - 10, yCoordinate - 5));

            // calculate all the scaling stuff
            float arrowLength = Math.Abs(endPoint.X - startPoint.X - 20);
            float rangeLength = Math.Abs(_xAxis.StartValue - _xAxis.EndValue);

            if (_xAxis.Scale == 0.0f)
            {
                return;
            }

            int numberOfValues = (int)(rangeLength / _xAxis.Scale);

            if (numberOfValues == 0)
            {
                return;
            }

            float offsetLeft = xCoordinateStartPoint;
            float singleOffset = arrowLength / numberOfValues;

            for (int i = 0; i <= numberOfValues; i++)
            {
                float localXCoordinate = offsetLeft + i * singleOffset;
                float localCoordinateValue = i * rangeLength / numberOfValues + _xAxis.StartValue;
                g.DrawLine(Pens.Black, new PointF(localXCoordinate, yCoordinate - 5),
                    new PointF(localXCoordinate, yCoordinate + 5));

                g.DrawString(localCoordinateValue.ToString(), new Font("Arial", 9.0f), new SolidBrush(Color.Black),
                    new PointF(localXCoordinate - 5, (float)this.Height - 15));

            }

            g.DrawString(_xAxis.Legend, new Font("Arial", 9.0f), new SolidBrush(Color.Black), new PointF(xCoordinateEndPoint, (float)(this.Height - 25)));

        }

        private void DrawYAxis(Graphics g)
        {
            float xCoordinate = this.Width / 10;
            float yCoordinateEndPoint = this.Height - this.Height / 10;
            float yCoordinateStartPoint = this.Height / 10;
            PointF endPoint = new PointF(xCoordinate, yCoordinateEndPoint);
            PointF startPoint = new PointF(xCoordinate, this.Height / 10);

            // just draw the arrows
            g.DrawLine(Pens.Black, startPoint, endPoint);
            g.DrawLine(Pens.Black, startPoint, new PointF(xCoordinate - 5, yCoordinateStartPoint + 10));
            g.DrawLine(Pens.Black, startPoint, new PointF(xCoordinate + 5, yCoordinateStartPoint + 10));

            // scale calculating
            float arrowLength = Math.Abs(endPoint.Y - startPoint.Y - 20);
            float rangeLength = Math.Abs(_yAxis.StartValue - _yAxis.EndValue);

            if (_yAxis.Scale == 0.0f)
            {
                return;
            }

            int numberOfValues = (int)(rangeLength / _yAxis.Scale);

            if (numberOfValues == 0)
            {
                return;
            }
            float offsetAbove = yCoordinateStartPoint + 20;
            float singleOffset = arrowLength / numberOfValues;

            // build all the lines and add the strings
            for (int i = 0; i < numberOfValues; i++)
            {
                float localYCoordinate = offsetAbove + i * singleOffset;
                float localCoordinateValue = i * rangeLength / numberOfValues;
                g.DrawLine(Pens.Black, new PointF(xCoordinate - 5, localYCoordinate),
                    new PointF(xCoordinate + 5, localYCoordinate));

                string coordinate = (rangeLength + _yAxis.StartValue - localCoordinateValue).ToString();

                g.DrawString(coordinate, new Font("Arial", 9.0f), new SolidBrush(Color.Black),
                    new PointF(0.0f, (float)localYCoordinate - 8));

            }

            g.DrawLine(Pens.Black, new PointF(xCoordinate - 5, endPoint.Y),
                    new PointF(xCoordinate + 5, endPoint.Y));

            g.DrawString((_yAxis.StartValue).ToString(), new Font("Arial", 9.0f), new SolidBrush(Color.Black),
                new PointF(0.0f, (float)endPoint.Y - 8));


            g.DrawString(_yAxis.Legend, new Font("Arial", 9.0f), new SolidBrush(Color.Black), new PointF(0.0f, 10.0f));
        }

        private PointF CalculateExternalCoordinates(int xValue, int yValue)
        {
            float localXValue = xValue;
            float localYValue = yValue;

            float internalAllowedMinRangeX = this.Width / 10;
            float internalAllowedMinRangeY = this.Height / 10 + 15;

            float internalAllowedMaxRangeX = this.Width - this.Width / 10 - 15;
            float internalAllowedMaxRangeY = this.Height - this.Height / 10;

            /* Check if click event was inside valid range */
            if (xValue < internalAllowedMinRangeX || xValue > internalAllowedMaxRangeX)
            {
                return new PointF(float.NaN, float.NaN);
            }

            if (yValue < internalAllowedMinRangeY || yValue > internalAllowedMaxRangeY)
            {
                return new PointF(float.NaN, float.NaN);
            }

            /* Calculate y - coordinate */

            float arrowLengthY = Math.Abs(this.Height - this.Height / 10 - this.Height / 10 - 20);
            float yRange = _yAxis.EndValue - _yAxis.StartValue;
            float offsetBottomY = this.Height / 10 + 20;

            localYValue = yValue - offsetBottomY;
            float lengthPerUnitY = arrowLengthY / yRange;

            localYValue /= lengthPerUnitY;
            localYValue = _yAxis.EndValue - localYValue;


            /* calculate x - coordinate */

            float arrowLengthX = Math.Abs(this.Width - this.Width / 10 - this.Width / 10 - 20);
            float xRange = _xAxis.EndValue - _xAxis.StartValue;
            float offSetLeftX = this.Width / 10;

            localXValue = xValue - offSetLeftX;
            float lengthPerUnitX = arrowLengthX / xRange;

            localXValue /= lengthPerUnitX;
            localXValue += _xAxis.StartValue;

            if (localXValue > _xAxis.EndValue)
            {
                localXValue = _xAxis.EndValue;
            }

            if (localYValue > _yAxis.EndValue)
            {
                localYValue = _yAxis.EndValue;
            }

            return new PointF(localXValue, localYValue);
        }

        private PointF CalculateInternalCoordinates(float xValue, float yValue)
        {
            float localXValue = 0;
            float localYValue = 0;

            if (float.IsNaN(xValue) || float.IsNaN(yValue))
            {
            	return new PointF(float.NaN, float.NaN);
            }
            
            if (xValue > _xAxis.EndValue || xValue < _xAxis.StartValue)
            {
                return new PointF(float.NaN, float.NaN);
            }

            if (yValue > _yAxis.EndValue || yValue < _yAxis.StartValue)
            {
                return new PointF(float.NaN, float.NaN);
            }

            // calculate X

            float numericOffsetX = xValue - _xAxis.StartValue;
            float rangeX = _xAxis.EndValue - _xAxis.StartValue;
            float localOffsetPixelX = this.Width / 10;

            float numericArrowLengthX = this.Width - 2 * (this.Width / 10) - 20;
            float rangePerValueX = numericArrowLengthX / rangeX;

            localXValue = (int)(numericOffsetX * rangePerValueX) + localOffsetPixelX;

            // calculate Y
            float numericOffsetY = yValue - _yAxis.StartValue;
            float rangeY = _yAxis.EndValue - _yAxis.StartValue;
            float localOffsetPixelY = this.Height - this.Height / 10;

            float numericArrowLengthY = this.Height - 2 * (this.Height / 10) - 20;
            float rangePerValueY = numericArrowLengthY / rangeY;

            localYValue = localOffsetPixelY - (int)(numericOffsetY * rangePerValueY);


            return new PointF(localXValue, localYValue);
        }

        public void AddLine(Line line)
        {
            _lineList.Add(line);
        }

        public void RemoveLine(Line line)
        {
            _lineList.Remove(line);
        }
        
        public void ClearLines()
        {
        	_lineList.Clear();
        }

        public void AddPoint(PointF p)
        {
            _pointsList.Add(p);
        }

        public void RemovePoint(PointF p)
        {
            _pointsList.Remove(p);
        }

        public void ClearPoints()
        {
        	_pointsList.Clear();
        }
    }
}
