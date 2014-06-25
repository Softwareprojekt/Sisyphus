
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
using System.Drawing.Drawing2D;
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
            this._cosInput.BackgroundImage = null;
            this._cosOutput.BackgroundImage = null;
            if (_radTriangle.Checked)
            {
                // paint triangle to input cod.
                Console.WriteLine("paint triangle.");

                _cosInput.Clear();
                _cosOutput.Clear();
              
                Triangle tri = new Triangle(new PointF(0, 0), new PointF(2, 0), new PointF(0, 2));

                Triangle tri1 = Triangle.Scale(tri, .5f);
                tri1.Translate(new Vector(1, 0));
                Triangle tri2 = Triangle.Scale(tri, .5f);
                tri2.Translate(new Vector(0, 1));
                Triangle tri3 = Triangle.Scale(tri, .5f);
                tri3.Translate(new Vector(0, 0));


                _cosInput.AddTriangle(tri);

                _cosOutput.AddTriangle(tri1);
                _cosOutput.AddTriangle(tri2);
                _cosOutput.AddTriangle(tri3);


                if (_loadedPic != null)
                {
                    _loadedPic.Dispose();
                    _loadedPic = null;
                }
            }
            else if (_radSquare.Checked)
            {
                Console.WriteLine("paint square.");

                _cosInput.Clear();
                RectangleC r = new RectangleC(new PointF(0, 0), new PointF(2, 0), new PointF(2, 2), new PointF(0, 2), new Pen(Color.Red));
                _cosInput.AddRectangle(r);


                if (_loadedPic != null)
                {
                    _loadedPic.Dispose();
                    _loadedPic = null;
                }
            }
            else if (_radCircle.Checked)
            {
                Console.WriteLine("paint circle.");

                _cosInput.Clear();
                Circle c = new Circle(new PointF(2, 2), 2, new Pen(Color.Green));
                _cosInput.AddCircle(c);

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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "JPG|*.jpg;*.jpeg|BMP|*.bmp|GIF|*.gif|PNG|*.png|TIFF|*.tif;*.tiff|"
                                                        + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap img = new Bitmap(ofd.FileName);
                    Graphics g = Graphics.FromImage((Image)img);
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    g.DrawImage(img, 0, 0, _cosInput.Width, _cosInput.Height);
                    g.Dispose();

                    img.MakeTransparent();


                    _loadedPic = (Image)img;
                    _cosInput.BackgroundImage = _loadedPic;
                    _cosOutput.BackgroundImage = _loadedPic;
                    _cosInput.Clear();
                    _cosOutput.Clear();
                }
                catch
                {
                    MessageBox.Show("Could not load image.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     

            }
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
