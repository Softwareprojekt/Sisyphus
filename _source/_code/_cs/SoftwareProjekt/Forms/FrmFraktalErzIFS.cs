
#region LicenseHeader
/*
 * Copyright (C) 2014 Technische Hochschule Amberg
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
#endregion

using SoftwareProjekt.Classes.EventArguments;
using SoftwareProjekt.Classes.Math;
using SoftwareProjekt.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


/* TODO in this form:
 * Openfiledialpg for butSelectPic
 * 
 */

namespace SoftwareProjekt.Forms
{
    public partial class FrmFraktalErzIFS : AbstractView
    {
        private Image _loadedPic = null;
        private List<Object> _inputForms = null;

        public FrmFraktalErzIFS()
        {
            InitializeComponent();

            _inputForms = new List<Object>();
            _radTriangle.Checked = true;
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if (_radTriangle.Checked)
            {
                // paint triangle to input cod.
                Console.WriteLine("paint triangle.");

                _cosInput.ClearLineSegments();

                //LineSegment ls1 = new LineSegment(new PointF(0, 0), new Vector(2, 0), Pens.Red);
                //LineSegment ls2 = new LineSegment(new PointF(2, 0), new Vector(-2, 2), Pens.Red);
                //LineSegment ls3 = new LineSegment(new PointF(0, 2), new Vector(0, -2), Pens.Red);

                Triangle tri = new Triangle(new PointF(1, 1), new PointF(3, 1), new PointF(2, 2));
                tri.Translate(new Vector(1, 0)); //move one right
                tri.Scale(1.5f); //make 50% bigger

                _cosInput.AddLineSegment(tri.AB);
                _cosInput.AddLineSegment(tri.BC);
                _cosInput.AddLineSegment(tri.CA);

                _cosInput.Refresh();

                if (_loadedPic != null)
                {
                    _loadedPic.Dispose();
                    _loadedPic = null;
                }
            }
            else if (_radSquare.Checked)
            {
                Console.WriteLine("paint square.");

                _cosInput.ClearLineSegments();

                LineSegment ls1 = new LineSegment(new PointF(0, 0), new Vector(2, 0), Pens.Red);
                LineSegment ls2 = new LineSegment(new PointF(2, 0), new Vector(0, 2), Pens.Red);
                LineSegment ls3 = new LineSegment(new PointF(2, 2), new Vector(-2, 0), Pens.Red);
                LineSegment ls4 = new LineSegment(new PointF(0, 2), new Vector(0, -2), Pens.Red);

                _cosInput.AddLineSegment(ls1);
                _cosInput.AddLineSegment(ls2);
                _cosInput.AddLineSegment(ls3);
                _cosInput.AddLineSegment(ls4);

                _cosInput.Refresh();

                if (_loadedPic != null)
                {
                    _loadedPic.Dispose();
                    _loadedPic = null;
                }
            }
            else if (_radCircle.Checked)
            {
                Console.WriteLine("paint circle.");

                _cosInput.ClearLineSegments();

                //TODO: add circle?!

                _cosInput.Refresh();

                if (_loadedPic != null)
                {
                    _loadedPic.Dispose();
                    _loadedPic = null;
                }
            }
            else
            {
                if (_loadedPic == null)
                {
#if DEBUG
                    Console.WriteLine("ERROR @ CheckedChanged: No RadioButton checked.");
#endif
                }
            }
        }

        private void rtxtNotes_TextChanged(object sender, EventArgs e)
        { }

        private void butSelectPic_Click(object sender, EventArgs e)
        {
            //deactivate radiobuttons.
            _radTriangle.Checked = false;
            _radSquare.Checked = false;
            _radCircle.Checked = false;

            //show picture selection dialog.
        }

        private void butCalc_Click(object sender, EventArgs e)
        {
            if (this.CheckInputs())
            {
                this.OnViewChanged(new ViewEventArgs(EClickedButton.StartCalculation));
            }
        }

        public override void ExerciseChanged(Interfaces.IExercise sender, ExerciseEventArgs e)
        {
            _cosOutput.ClearLineSegments();

            Console.WriteLine(sender.ToString() + " " + e.ToString());
        }

        public override Dictionary<string, object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("Form", _radTriangle.Checked ? EInputForms.Triangle : _radSquare.Checked ? EInputForms.Square : _radCircle.Checked ? EInputForms.Circle : EInputForms.Picture);
            if (_loadedPic != null)
            {
                retVal.Add("Picture", _loadedPic);
            }

            retVal.Add("InputForms", _inputForms);

            retVal.Add("Coefficient_w1", _coeff_w1.FloatValue);
            retVal.Add("Coefficient_w2", _coeff_w2.FloatValue);
            retVal.Add("Coefficient_w3", _coeff_w3.FloatValue);

            retVal.Add("MoveVector_w2", _vectorMove_w2.Vector);
            retVal.Add("MoveVector_w3", _vectorMove_w3.Vector);

            retVal.Add("Notes", rtxtNotes.Text);

            return retVal;
        }

        protected override bool CheckInputs()
        {
            if ((_radCircle.Checked || _radSquare.Checked || _radTriangle.Checked || _loadedPic != null) && _coeff_w2.IsValid() && _vectorMove_w2.Vector.IsValid())
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

        //TODO: What to load in this exercise?
        public override bool LoadState(Dictionary<string, object> state)
        {
            // state does not exist in workbook.
            if (state == null)
            {
                return false;
            }

            return true;
        }
    }
}
