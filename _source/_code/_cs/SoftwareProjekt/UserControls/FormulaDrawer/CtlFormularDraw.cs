using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MathML;
using System.Drawing.Imaging;
using SoftwareProjekt.Properties;
using SoftwareProjekt.Enums;

namespace SoftwareProjekt.UserControls.FormulaDrawer
{
    public partial class CtlFormularDraw : UserControl
    {
        private string _equation;
        private string _filepath;
        private string _filename;
       
        private MathML.Rendering.MathMLControl _drawer;

        
        public CtlFormularDraw()
        {
            InitializeComponent();
        
            this.Filename = Path.GetRandomFileName() + ".tiff";
            this.Equation = "";
            this.Filepath = GetGifFilePath();
            this._drawer = new MathML.Rendering.MathMLControl();
            this._drawer.Size = new Size(1000, 1000);
            this._drawer.BackColor = this.BackColor;
            this._drawer.ForeColor = System.Drawing.Color.Black;
            this._drawer.HorizontalShift = 0F;
            this._drawer.InputLocation = null;
            this._drawer.MathFontSizeInPoints = 8;
        }

        public string Equation
        {
            get { return _equation; }
            set { _equation = value; }
        }
        public string Filepath
        {
            get { return _filepath; }
            set { _filepath = value; }
        }
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        public int FontSize
        {
            get
            {
                return this._drawer.MathFontSizeInPoints;
            }
            set
            {
                this._drawer.MathFontSizeInPoints = value;
            }
        }
           

        public void WriteEquationToPicBox(string equation)
        {
            try
            {
                this.Equation = equation;

                MathMLDocument mathmlDoc = new MathMLDocument();
                mathmlDoc.LoadXml(equation);

                _drawer.MathElement = (MathMLMathElement)mathmlDoc.DocumentElement;
                _drawer.Save(this.Filepath + this.Filename, ImageFormat.Tiff);

                picFormular.Image = Image.FromFile(this.Filepath + this.Filename);
            }
            catch (Exception ex)
            {
                // GDI+ general error means, the path given path in method _drawer.Save is invalid, not writeable and so on
                // there is no inner exception!

                Console.WriteLine("ERROR @ WriteEquationToPicBox " + ex.Message);
            }

        }
       
        private string GetGifFilePath()
        {
            return Path.GetTempPath();
        }            
    }
}
