/**
 * @title: Matrix Eingabe
 * @author: Michael Eimer
 * @date: 23.05.2014
 * @version: 0.2
 * 
 */ 
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public partial class CtlMatrixInput : UserControl
    {
        private Matrix _mmatrix;
        private string _sname;

        public CtlMatrixInput()
        {
            InitializeComponent();
        }           

        public Matrix Matrix
        {
            get { return _mmatrix; }
            set { _mmatrix = value; }
        }        

        public string Name
        {
            get { return _sname; }
            set { _sname = value; }
        }
        

    }
}
