using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SoftwareProjekt
{
    public class CoordinateSystem : UserControl
    {
        /// <summary>
        /// </summary>
        private System.Collections.Generic.List<SoftwareProjekt.LineSegment> _lineSegementList;
        private List<Line> _lineList;
              

        /// <summary>
        /// ctor
        /// </summary>
        public CoordinateSystem()
        {
            InitializeComponent();

            throw new System.NotImplementedException();
        }

        public IAxis XAxis
        {
            get
            {                
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IAxis YAxis
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// </summary>
        public void AddLineSegment(LineSegment lineSegment)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// removes a figure from the list, adjust axis
        /// </summary>
        public void RemoveLineSegment(SoftwareProjekt.LineSegment lineSegment)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// iterates the List and draws the figures
        /// </summary>
        private void DrawVector(System.Drawing.Graphics g)
        {
                       
            throw new System.NotImplementedException();
        }

        private void DrawLine(System.Drawing.Graphics g)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sets Name, Size, Events etc
        /// </summary>
        private void InitializeComponent()
        {
            this.Paint += CoordinateSystem_Paint;
        }

        /// <summary>
        /// Draws Axis, Line Segments and lines
        /// </summary>
        void CoordinateSystem_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// draws Axis and scale
        /// </summary>
        private void DrawAxis(System.Drawing.Graphics g)
        {
            throw new System.NotImplementedException();
        }

        public void AddLine(Line line)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveLine(Line line)
        {
            throw new System.NotImplementedException();
        }
    }
}
