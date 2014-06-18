using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


/// MimeTex.dll ist eine 32bit dll, vor dem übersetzen von "any cpu" auf x86 umstellen!


namespace SoftwareProjekt.UserControls.FormulaDrawer
{
    public partial class CtlFormularDraw : UserControl
    {
        private string _sequation;
        private string _sfilepath;
        private string _sfilename;      

        public CtlFormularDraw()
        {
            InitializeComponent();
            this.Filename = "expr.gif";
            this.Equation = "";
            this.Filepath = GetGifFilePath();
        }

        public string Equation
        {
            get { return _sequation; }
            set { _sequation = value; }
        }

        public string Filepath
        {
            get { return _sfilepath; }
            set { _sfilepath = value; }
        }

        public string Filename
        {
            get { return _sfilename; }
            set { _sfilename = value; }
        }

        public void WriteEquationToPicBox(string equation)
        {
            this.Equation = equation;
            if (picFormular.Image != null) picFormular.Image.Dispose();

            if (equation.Length > 0)
                try
                {
                    NativeMethods.CreateGifFromEq(this.Equation, this.Filename);
                    picFormular.Image = Image.FromFile(this.Filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            else
            {
                try
                {
                    picFormular.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "error.gif"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
       
        private string GetGifFilePath()
        {
            return Path.GetDirectoryName(Application.ExecutablePath);
        }            
        
        internal class NativeMethods
        {
            private NativeMethods()
            { }

            [System.Runtime.InteropServices.DllImport("MimeTex.dll")]
            internal static extern int CreateGifFromEq(string expr, string fileName);
            [System.Runtime.InteropServices.DllImport("kernel32.dll")]
            internal extern static IntPtr GetModuleHandle(string lpModuleName);
            [System.Runtime.InteropServices.DllImport("kernel32.dll")]
            [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
            internal extern static bool FreeLibrary(IntPtr hLibModule);
        }
    }
}
