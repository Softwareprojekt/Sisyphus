using System;
using System.Windows.Forms;


/* TODO in this form:
 * 1. Events
 * 2. Openfiledialpg for butSelectPic
 * 3. Add license header
 * 4. Coordinate Systems needed?
 * 
 */

namespace SoftwareProjekt.Forms
{
    public partial class FrmFraktalErzIFS : AbstractView
    {
        public FrmFraktalErzIFS()
        {
            InitializeComponent();
        }

        private void txtSteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSteps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void rtxtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void butSelectPic_Click(object sender, EventArgs e)
        {

        }

        private void butStepFor_Click(object sender, EventArgs e)
        {

        }

        private void butStepBack_Click(object sender, EventArgs e)
        {

        }

        public override void ExerciseChanged(Interfaces.IExercise sender, Classes.EventArguments.ExerciseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override System.Collections.Generic.Dictionary<string, object> GetInputData()
        {
            throw new NotImplementedException();
        }
    }
}
