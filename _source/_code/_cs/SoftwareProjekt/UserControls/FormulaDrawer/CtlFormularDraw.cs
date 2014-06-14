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

        public string Equation { get; set; }
        public string Filepath { get; set; }
        public string Filename { get; set; }

        public CtlFormularDraw()
        {
            InitializeComponent();
            Filename = "expr.gif";
            Filepath = Path.GetDirectoryName(Application.ExecutablePath);
        }

        public void WriteEquationToPicBox(string equation)
        {
            if (picFormular.Image != null) picFormular.Image.Dispose();

            if (equation.Length > 0)
                try
                {
                    NativeMethods.CreateGifFromEq(equation, _sfilename);
                    picFormular.Image = Image.FromFile(_sfilename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            else  
            {
                picFormular.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"error.gif"));
            }
        }

        private string GetGifFilePath()
        {
            return Path.Combine(Path.GetTempPath(), "equation.gif");
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
