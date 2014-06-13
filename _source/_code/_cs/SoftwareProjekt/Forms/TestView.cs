using SoftwareProjekt.Enums;
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
    public partial class TestView : AbstractView
    {
        public TestView()
        {
            InitializeComponent();
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            Console.WriteLine(sender.ToString() + " " + e.ToString());
            _matrix.Matrix = (Matrix)e.CalcValues["Matrix1"];
            _vector.Vector = (Vector)e.CalcValues["Vector1"];
        }

        private void _btnCalc_Click(object sender, EventArgs e)
        {
            this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("Matrix1", _matrix.Matrix);
            retVal.Add("Vector1", _vector.Vector);

            return retVal;
        }
    }
}
