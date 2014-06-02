/**
 * @title: Vector Input
 * @author: 
 * @date: 23.05.2014
 * @version: 0.2
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
        private Vector _vVektor;
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

        public Vector MyProperty
        {
            get { return _vVektor; }
            set { _vVektor = value; }
        }       
        
    }
}
