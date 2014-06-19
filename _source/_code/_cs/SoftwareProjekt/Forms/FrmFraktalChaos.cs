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
    public partial class FrmFraktalChaos : Form // AbstractView
    {
        public FrmFraktalChaos()
        {
            InitializeComponent();
        }

        private void txtProbability_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumIteration_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProbability_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void txtNumIteration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void rtxtNotes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
