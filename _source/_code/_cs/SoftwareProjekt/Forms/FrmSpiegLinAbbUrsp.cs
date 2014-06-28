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
    public partial class FrmSpiegLinAbbUrsp : AbstractView 
    {
        private LineSegment _vectorInputX;
        private LineSegment _vectorInputEV1;
        private LineSegment _vectorInputEV2;

        public FrmSpiegLinAbbUrsp()
        {
            InitializeComponent();


            this.ctlVectorInputEV1.txtEle11.Text = "1";
            this.ctlVectorInputEV1.txtEle21.Text = "0";

            this.ctlVectorInputEV2.txtEle11.Text = "0";
            this.ctlVectorInputEV2.txtEle21.Text = "1";

            _vectorInputEV1 = new LineSegment(new PointF(0, 0), ctlVectorInputEV1.Vector, Pens.Blue);
            _vectorInputEV2 = new LineSegment(new PointF(0, 0), ctlVectorInputEV2.Vector, Pens.Red);
            _vectorInputX = new LineSegment(new PointF(0, 0), ctlVectorInputX.Vector);

            cosInput.AddLineSegment(_vectorInputEV1);
            cosInput.AddLineSegment(_vectorInputEV2);
            cosInput.AddLineSegment(_vectorInputX);
        }

        public override Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("EV1", ctlVectorInputEV1.Vector);
            retVal.Add("EV2", ctlVectorInputEV2.Vector);
            retVal.Add("VectorX", ctlVectorInputX.Vector);
            //retVal.Add("Angle", txtAngle.FloatValue);

            return retVal;
        }

        private void butFx_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
            cosOutput.ClearLineSegments();
        }


        private void txtAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        
		protected override bool CheckInputs()
		{
            if (ctlVectorInputEV1.Vector.IsValid() && ctlVectorInputEV2.Vector.IsValid() && ctlVectorInputX.Vector.IsValid())
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

            ctlVectorInputX.Vector = (Vector)state["VectorX"];
            return true;
        }
    }
}
