/**
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
    public partial class FrmLinAbbVielBelVek : AbstractView
    {
        private LineSegment _vectorInputX;

        public FrmLinAbbVielBelVek()
        {
            InitializeComponent();
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("MatrixM1", ctlMatrixInput.Matrix);
            retVal.Add("VectorX", ctlVectorInputX.Vector);
            

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
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }


        private void txtFactorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

		protected override bool CheckInputs()
		{
            if (ctlMatrixInput.Matrix.IsValid() && ctlVectorInputX.Vector.IsValid())
            {
#if DEBUG
                Console.WriteLine("SUCCESS @ Inputs are valid.");
#endif
                return true;
            }
#if DEBUG
            Console.WriteLine("ERROR @ Inputs are not valid.");
#endif
            return false;
		}



        public override bool LoadState(Dictionary<string, object> state)
        {
            // state does not exist in workbook.
            if (state == null)
            {
                return false;
            }
            else if (!state.ContainsKey("VectorX"))
            {
                return false;
            }

            ctlVectorInputX.Vector = (Vector)state["VectorX"];
            return true;
        }
    }
}
