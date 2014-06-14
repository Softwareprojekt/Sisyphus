using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SoftwareProjekt.UserControls.FormulaDrawer
{
    public partial class CtlFormularDraw : UserControl
    {
        private string _seqation;
        private string _sfilepath;

        public string Equation { get; set; }
        public string Filepath{ get; set; }

        public CtlFormularDraw()
        {
            InitializeComponent();
        }

        public void WriteEquationToPicBox(string equation)
        {
            if (equation.Length > 0)
                try
                {
                    NativeMethods.CreateGifFromEq(equation, _sfilepath);
                    picFormular.Image = Image.FromFile(_sfilepath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            else  // TODO: Fehlerbild anzeigen
            {
                picFormular.Image = Image.FromFile("PathToImage");
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
