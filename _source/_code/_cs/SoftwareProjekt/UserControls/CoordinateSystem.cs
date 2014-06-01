
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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SoftwareProjekt
{
    public delegate void CoordinateSystemClickHandler (float x, float y);
    public class CoordinateSystem : UserControl
    {
        /// <summary>
        /// </summary>
        private System.Collections.Generic.List<SoftwareProjekt.LineSegment> _lineSegementList;
        private List<Line> _lineList;

        private IAxis _xAxis;
        private IAxis _yAxis;


        public CoordinateSystemClickHandler CoordinateClick;
        private int _pointsList;

        /// <summary>
        /// ctor
        /// </summary>
        public CoordinateSystem()
        {
            _lineList = new List<Line>();
            _lineSegementList = new List<LineSegment>();

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
        public void AddLineSegment(LineSegment lineSegment)
        {
            _lineSegementList.Add(lineSegment);
        }

        /// <summary>
        /// removes a figure from the list, adjust axis
        /// </summary>
        public void RemoveLineSegment(SoftwareProjekt.LineSegment lineSegment)
        {
            _lineSegementList.Remove(lineSegment);
        }

        /// <summary>
        /// iterates the List and draws the figures
        /// </summary>
        private void DrawVector(Graphics g)
        {
                       
            throw new System.NotImplementedException();
        }

        private void DrawLine(Graphics g)
        {
            throw new System.NotImplementedException();
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
            this._xAxis.StartValue = 3.0f;
            this._xAxis.Scale = 0.5f;
            this._xAxis.Legend = "X-axis";


            this._yAxis.EndValue = 5.0f;
            this._yAxis.StartValue = 0.0f;
            this._yAxis.Scale = 0.5f;
            this._yAxis.Legend = "Y-axis";

            this.Paint +=CoordinateSystem_Paint;
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

            if (p.X == -1 || p.Y == -1)
            {
                Console.WriteLine("Outside valid range!\n");
            }
            float roundX = (float)Math.Round(p.X, 1, MidpointRounding.AwayFromZero);
            float roundY = (float)Math.Round(p.Y, 1, MidpointRounding.AwayFromZero);

            
            Console.WriteLine("X: " + roundX.ToString() + "\nY: " + roundY.ToString() + "\n");

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
            DrawAxes(e.Graphics);
        }

        /// <summary>
        /// draws Axis and scale
        /// </summary>
        private void DrawAxes(Graphics g)
        {
            DrawXAxis(g);
            DrawYAxis(g);
        }

        private void DrawXAxis(Graphics g)
        {
            int yCoordinate = this.Height - this.Height / 10;
            int xCoordinateEndPoint = this.Width - this.Width / 10;
            int xCoordinateStartPoint = this.Width / 10;
            Point endPoint = new Point(xCoordinateEndPoint, yCoordinate);
            Point startPoint =  new Point(xCoordinateStartPoint, yCoordinate);

            // draw the arrows
            g.DrawLine(Pens.Black, startPoint, endPoint);
            g.DrawLine(Pens.Black, endPoint, new Point(xCoordinateEndPoint - 10, yCoordinate + 5));
            g.DrawLine(Pens.Black, endPoint, new Point(xCoordinateEndPoint - 10, yCoordinate - 5));

            // calculate all the scaling stuff
            int arrowLength = Math.Abs(endPoint.X - startPoint.X - 20);
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

            int offsetLeft = xCoordinateStartPoint;
            int singleOffset = arrowLength / numberOfValues;

            for (int i = 0; i <= numberOfValues; i++)
            {
                int localXCoordinate = offsetLeft + i * singleOffset;
                float localCoordinateValue = i * rangeLength / numberOfValues + _xAxis.StartValue;
                g.DrawLine(Pens.Black, new Point(localXCoordinate, yCoordinate - 5),
                    new Point(localXCoordinate, yCoordinate + 5));

                g.DrawString(localCoordinateValue.ToString(), new Font("Arial", 9.0f), new SolidBrush(Color.Black),
                    new PointF(localXCoordinate - 5, (float)this.Height - 15));

            }

            g.DrawString(_xAxis.Legend, new Font("Arial", 9.0f), new SolidBrush(Color.Black), new PointF(xCoordinateEndPoint,(float) (this.Height - 25))); 

        }

        private void DrawYAxis(Graphics g)
        {
            int xCoordinate = this.Width / 10;
            int yCoordinateEndPoint = this.Height - this.Height / 10;
            int yCoordinateStartPoint = this.Height / 10;
            Point endPoint = new Point(xCoordinate, yCoordinateEndPoint);
            Point startPoint = new Point(xCoordinate, this.Height / 10);

            // just draw the arrows
            g.DrawLine(Pens.Black, startPoint, endPoint);
            g.DrawLine(Pens.Black, startPoint, new Point(xCoordinate - 5, yCoordinateStartPoint + 10));
            g.DrawLine(Pens.Black, startPoint, new Point(xCoordinate + 5, yCoordinateStartPoint + 10));

            // scale calculating
            int arrowLength = Math.Abs(endPoint.Y - startPoint.Y - 20);
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
            int offsetAbove = yCoordinateStartPoint + 20;
            int singleOffset = arrowLength / numberOfValues;

            // build all the lines and add the strings
            for (int i = 0; i < numberOfValues; i++)
            {
                int localYCoordinate = offsetAbove + i *  singleOffset;
                float localCoordinateValue = i * rangeLength / numberOfValues;
                g.DrawLine(Pens.Black, new Point(xCoordinate - 5, localYCoordinate),
                    new Point(xCoordinate + 5, localYCoordinate));

                string coordinate = (rangeLength + _yAxis.StartValue - localCoordinateValue).ToString();

                g.DrawString(coordinate, new Font("Arial", 9.0f), new SolidBrush(Color.Black),
                    new PointF(0.0f, (float)localYCoordinate - 8));
                
            }

            g.DrawLine(Pens.Black, new Point(xCoordinate - 5, endPoint.Y),
                    new Point(xCoordinate + 5, endPoint.Y));

            g.DrawString((_yAxis.StartValue).ToString(), new Font("Arial", 9.0f), new SolidBrush(Color.Black),
                new PointF(0.0f, (float)endPoint.Y - 8));


            g.DrawString(_yAxis.Legend, new Font("Arial", 9.0f), new SolidBrush(Color.Black), new PointF(0.0f, 10.0f));
        }

        private PointF CalculateExternalCoordinates(int xValue, int yValue)
        {
            float localXValue = xValue;
            float localYValue = yValue;

            int internalAllowedMinRangeX = this.Width / 10;
            int internalAllowedMinRangeY = this.Height / 10 + 15;

            int internalAllowedMaxRangeX = this.Width - this.Width / 10 - 15;
            int internalAllowedMaxRangeY = this.Height - this.Height / 10;

            /* Check if click event was inside valid range */ 
            if (xValue < internalAllowedMinRangeX || xValue > internalAllowedMaxRangeX)
            {
                return new PointF(-1, -1);
            }

            if (yValue < internalAllowedMinRangeY || yValue > internalAllowedMaxRangeY)
            {
                return new PointF(-1, -1);
            }

            /* Calculate y - coordinate */ 

            int arrowLengthY = Math.Abs(this.Height - this.Height / 10 - this.Height / 10 - 20);
            float yRange = _yAxis.EndValue - _yAxis.StartValue;
            int offsetBottomY = this.Height / 10 + 20;

            localYValue = yValue - offsetBottomY;
            float lengthPerUnitY = arrowLengthY / yRange;

            localYValue /= lengthPerUnitY;
            localYValue = _yAxis.EndValue - localYValue;


            /* calculate x - coordinate */

            int arrowLengthX = Math.Abs(this.Width - this.Width / 10 - this.Width / 10 - 20);
            float xRange = _xAxis.EndValue - _xAxis.StartValue;
            int offSetLeftX = this.Width / 10;

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

        private PointF CalculateInternalCoordinates(int xValue, int yValue)
        {
            int localXValue = xValue;
            int localYValue = yValue;

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

        public void AddPoint()
        {
            throw new System.NotImplementedException();
        }

        public void RemovePoint()
        {
            throw new System.NotImplementedException();
        }

    }
}
