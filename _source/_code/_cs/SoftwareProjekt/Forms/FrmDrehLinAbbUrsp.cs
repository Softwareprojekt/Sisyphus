/**
 * 
 * 
 * 
 * 
 * 
 * 
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SoftwareProjekt.Forms
{
    public partial class FrmDrehLinAbbUrsp : Form
    {
        private string _sequation;
        private string _sfilepath;

        public FrmDrehLinAbbUrsp()
        {
            InitializeComponent();
            _sequation = "f(x^(->) = ";
            _sfilepath = "";
            ctlFormular.Equation = _sequation;
            ctlFormular.Filepath = _sfilepath;
            ctlFormular.WriteEquationToPicBox(ctlFormular.Equation);
        }
       

    }
}
