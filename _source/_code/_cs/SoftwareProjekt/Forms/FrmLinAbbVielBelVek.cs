﻿/**
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
using SoftwareProjekt.Classes.EventArguments;
using SoftwareProjekt.Classes.Math;
using SoftwareProjekt.Enums;
using SoftwareProjekt.Interfaces;
namespace SoftwareProjekt.Forms
{
    public partial class FrmLinAbbVielBelVek : AbstractView //Form
    {
        public FrmLinAbbVielBelVek()
        {
            InitializeComponent();
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            /*retVal.Add("EV1", _vector.Einheitsvector1);
            retVal.Add("EV2", _vector.Einheitsvector2);
            retVal.Add("VectorX", _vector.VectorX);
            retVal.Add("Angle", _vector.Angle);*/

            return retVal;
        }

        private void butDeterminante_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void butFunctionAMultX_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        private void txtFactorA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeterminante_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtNotes_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
