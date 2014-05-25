/**
 * @title: Vektor Eingabe
 * @author: Michael Eimer
 * @date: 23.05.2014
 * @version: 0.1
 * 
 * 
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public partial class CtlVektorInput : UserControl
    {
        private double[,] _dVektor;
        private string _sName;

        public CtlVektorInput()
        {
            InitializeComponent();
        }       

        public string Name
        {
            get { return _sName; }
            set { _sName = value; }
        }       

        public double[,] MyProperty
        {
            get { return _dVektor; }
            set { _dVektor = value; }
        }       
        
    }
}
