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
        /// List of figures to Draw
        /// </summary>
        private System.Collections.Generic.List<IGeometricFigure> _geometricFigureList;

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
        /// gets type of IGeometricFigure and adds it to the list, draws it and adjusts the axis
        /// </summary>
        public void AddGeometricFigure(Arrow geometricFigure)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// removes a figure from the list, adjust axis
        /// </summary>
        public void RemoveGeometricFigure(IGeometricFigure geometricFigure)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// iterates the figureList and draws the figures
        /// </summary>
        public void Draw()
        {
            for (int i = 0; i < _geometricFigureList.Count; i++)
            {
                Type t = _geometricFigureList[i].GetType();

            }
            
            throw new System.NotImplementedException();
        }
    }
}
