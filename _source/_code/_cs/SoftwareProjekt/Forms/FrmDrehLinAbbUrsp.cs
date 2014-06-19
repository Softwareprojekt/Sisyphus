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
using SoftwareProjekt.Classes.EventArguments;
using SoftwareProjekt.Classes.Math;
using SoftwareProjekt.Enums;
using SoftwareProjekt.Interfaces;

namespace SoftwareProjekt.Forms
{
    public partial class FrmDrehLinAbbUrsp : Form //AbstractView
    {

        private string _sequation;
        private string _sfilepath;

        public FrmDrehLinAbbUrsp()
        {
            InitializeComponent();
            _sequation = "f(x^(->) = ";
            _sfilepath = "";
            //ctlFormular.Equation = _sequation;
            //ctlFormular.Filepath = _sfilepath;
            //ctlFormular.WriteEquationToPicBox(ctlFormular.Equation);
        }


        private void butFunctionTransfX_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
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

        private void butDeterminante_Click(object sender, System.EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

    }
}
