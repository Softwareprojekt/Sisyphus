/**
 * @title: Matrix Eingabe
 * @author: Michael Eimer
 * @date: 23.05.2014
 * @version: 0.1
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
    public partial class CtlMatrixEingabe : UserControl
    {
        private double[,] _dmatrix;
        private string _sname;

        public CtlMatrixEingabe()
        {
            InitializeComponent();
        }           

        public double[,] Matrix
        {
            get { return _dmatrix; }
            set { _dmatrix = value; }
        }        

        public string Name
        {
            get { return _sname; }
            set { _sname = value; }
        }
          




    }
}
