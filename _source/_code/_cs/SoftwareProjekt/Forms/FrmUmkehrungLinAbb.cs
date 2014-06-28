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
    public partial class FrmUmkehrungLinAbb : AbstractView 
    {
        private LineSegment _vectorInputX;
        private LineSegment _vectorInputY;

        public FrmUmkehrungLinAbb()
        {
            InitializeComponent();
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("VectorX", ctlVectorInputX.Vector);
            retVal.Add("VectorY", ctlVectorInputY.Vector);
            retVal.Add("Matrix", ctlMatrixInput.Matrix);

            return retVal;
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosOutput.ClearLineSegments();
        }

        private void butDeterminante_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        private void butFx_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        private void butUmkehrFx_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        private void butFunctionEnd_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

		protected override bool CheckInputs()
		{
            if (ctlVectorInputX.Vector.IsValid() && ctlVectorInputY.Vector.IsValid() && ctlMatrixInput.Matrix.IsValid())
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

        public void OnTextChanged(object sender, EventArgs e)
        {
            _vectorInputX.Vector = ctlVectorInputX.Vector;
            cosInput.Refresh();
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
            else if (!state.ContainsKey("Vectory"))
            {
                return false;
            }

            ctlVectorInputX.Vector = (Vector)state["VectorX"];
            ctlVectorInputY.Vector = (Vector)state["VectorY"];
            return true;
        }
    }
}
