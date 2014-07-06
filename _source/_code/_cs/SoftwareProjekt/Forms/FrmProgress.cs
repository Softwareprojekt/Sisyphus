using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoftwareProjekt.Interfaces;

namespace SoftwareProjekt.Forms
{
    public partial class FrmProgress : Form
    {
        public FrmProgress()
        {
            InitializeComponent();
        }

        public IExercise Exercise { get; set; }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            if (this.Exercise != null)
            {
                this.Exercise.AbortWork();
            }
            this.Close();
        }

        private void FrmProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Exercise != null)
            {
                this.Exercise.AbortWork();
            }
        }
    }
}
