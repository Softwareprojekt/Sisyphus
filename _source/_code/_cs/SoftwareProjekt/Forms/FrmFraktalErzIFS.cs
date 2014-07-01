
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
using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;


/* TODO in this form:
 * Openfiledialpg for butSelectPic
 * 
 */

namespace SoftwareProjekt.Forms
{
    public partial class FrmFraktalErzIFS : AbstractView
    {
        private EIFSForms _inputForm;
        private Image _loadedPic = null;
        private List<IShape> _inputForms = null;
        private List<PointF> _pointList;
        private bool _pictureSelected = false;

        public FrmFraktalErzIFS()
        {
            _pointList = new List<PointF>();

            InitializeComponent();

            _inputForms = new List<IShape>();
            _radTriangle.Checked = true;
            _cosInput.CoordinateClick += _cosInput_CoordinateClick;        
        }

        void _cosInput_CoordinateClick(float x, float y, MouseEventArgs e)
        {
            if (_pictureSelected)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    _pointList.Add(new PointF(x, y));
                    _inputForms.Clear();
                    _cosInput.Clear();
                    _cosOutput.Clear();

                    _inputForms.Add(new Polygon(_pointList,Pens.Coral));

                    _cosInput.AddPolygon(_inputForms.ToArray());
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    ContextMenu cm = new ContextMenu();
                    MenuItem delPoints = new MenuItem("&Punkte löschen", new System.EventHandler(this.deletePoints_Click));
                    cm.MenuItems.Add(delPoints);
                    this.ContextMenu = cm;
                }
            }
        }

        private void deletePoints_Click(object sender, EventArgs e)
        {
            _inputForms.Clear();
            _cosInput.Clear();
            _cosOutput.Clear();
            _pointList.Clear();
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            //draw points when picture is selected
            _pictureSelected = !_radTriangle.Checked && !_radSquare.Checked && !_radCircle.Checked;
            if (!_pictureSelected)
            {
                this._cosInput.BackgroundImage = null;
                this._cosOutput.BackgroundImage = null;
                this._pointList.Clear();
            }

            if (_radTriangle.Checked)
            {
                // paint triangle to input cod.
                _inputForm = EIFSForms.Triangle;

                _inputForms.Clear();
                _cosInput.Clear();
                _cosOutput.Clear();

                _inputForms.Add(new Triangle(new PointF(0, 0), new PointF(4, 0), new PointF(0, 4)));

                _cosInput.AddTriangle(_inputForms.ToArray());

                if (_loadedPic != null)
                {
                    _loadedPic.Dispose();
                    _loadedPic = null;
                }
            }
            else if (_radSquare.Checked)
            {
                _inputForm = EIFSForms.Rectangle;

                _inputForms.Clear();
                _cosInput.Clear();
                _cosOutput.Clear();

                _inputForms.Add(new RectangleC(new PointF(0, 0), new PointF(4, 0), new PointF(4, 4), new PointF(0, 4), new Pen(Color.Red)));

                _cosInput.AddRectangle(_inputForms.ToArray());

                if (_loadedPic != null)
                {
                    _loadedPic.Dispose();
                    _loadedPic = null;
                }
            }
            else if (_radCircle.Checked)
            {
                _inputForm = EIFSForms.Circle;

                _inputForms.Clear();
                _cosInput.Clear();
                _cosOutput.Clear();

                _inputForms.Add(new Circle(new PointF(2, 2), 2, new Pen(Color.Green)));

                _cosInput.AddCircle(_inputForms.ToArray());

                if (_loadedPic != null)
                {
                    _loadedPic.Dispose();
                    _loadedPic = null;
                }
            }
            else
            {
                _inputForm = EIFSForms.Picture;

                if (_loadedPic == null)
                {
#if DEBUG
                    Console.WriteLine("ERROR @ CheckedChanged: No RadioButton checked.");
#endif
                }
                else
                {
                    
                }
            }
        }

        private void rtxtNotes_TextChanged(object sender, EventArgs e)
        { }

        private void butSelectPic_Click(object sender, EventArgs e)
        {
            _inputForm = EIFSForms.Picture;

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


                    // Initialize the color matrix. 
                    // Note the value 0.2 in row 4, column 4. 
                    float[][] matrixItems ={ 
                       new float[] {1, 0, 0, 0, 0},
                       new float[] {0, 1, 0, 0, 0},
                       new float[] {0, 0, 1, 0, 0},
                       new float[] {0, 0, 0, 0.3f, 0}, 
                       new float[] {0, 0, 0, 0, 1}};
                    ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

                    // Create an ImageAttributes object and set its color matrix.
                    ImageAttributes imageAtt = new ImageAttributes();
                    imageAtt.SetColorMatrix(
                       colorMatrix,
                       ColorMatrixFlag.Default,
                       ColorAdjustType.Bitmap);

                    Graphics g = Graphics.FromImage((Image)img);
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(img, 0, 0, _cosInput.Width, _cosInput.Height);

                    Bitmap img1 = new Bitmap(_cosInput.Width, _cosInput.Height);
                    Graphics g1 = Graphics.FromImage((Image)img1);
                    // Now draw the semitransparent bitmap image. 

                    g1.DrawImage(
                       img,
                       new Rectangle(0, 0, _cosInput.Width, _cosInput.Height),  // destination rectangle
                       0.0f,                          // source rectangle x 
                       0.0f,                          // source rectangle y
                       _cosInput.Width,                        // source rectangle width
                       _cosInput.Height,                       // source rectangle height
                       GraphicsUnit.Pixel,
                       imageAtt);
                    
                    g.Dispose();

                    //img.MakeTransparent();
                    _loadedPic = (Image)img1;

                    _cosInput.BackgroundImage = _loadedPic;
                    _cosOutput.BackgroundImage = _loadedPic;
                    _cosInput.Clear();
                    _cosOutput.Clear();
                }
                catch
                {
                    MessageBox.Show("Could not load image.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //deactivate radiobuttons.
                _radTriangle.Checked = false;
                _radSquare.Checked = false;
                _radCircle.Checked = false;
            }
            else
            {

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

            _cosOutput.DoNotRefresh = true;
            _inputForms.Clear();
            _cosOutput.Clear();

            Console.WriteLine(sender.ToString() + " " + e.ToString());

            switch ((EIFSForms)e.CalcValues["Form"])
            {
                case EIFSForms.Triangle:
                    _inputForms.AddRange((List<IShape>)e.CalcValues["OutputForms"]);
                    _cosOutput.AddTriangle(_inputForms.ToArray());
                    break;
                case EIFSForms.Rectangle:
                    _inputForms.AddRange((List<IShape>)e.CalcValues["OutputForms"]);
                    _cosOutput.AddRectangle(_inputForms.ToArray());
                    break;
                case EIFSForms.Circle:
                    _inputForms.AddRange((List<IShape>)e.CalcValues["OutputForms"]);
                    _cosOutput.AddCircle(_inputForms.ToArray());
                    break;
                case EIFSForms.Picture:
                    _inputForms.AddRange((List<IShape>)e.CalcValues["OutputForms"]);
                    _cosOutput.AddPolygon(_inputForms.ToArray());
                    break;
                default:
                    break;
            }

            _cosOutput.DoNotRefresh = false;
            _cosOutput.invokeRefresh();
        }

        public override Dictionary<string, object> GetInputData()
        {
            Dictionary<string, Object> retVal = new Dictionary<string, object>();

            retVal.Add("Form", _inputForm);

            
            retVal.Add("InputForms", _inputForms);

            retVal.Add("Steps",
                _rbStep1.Checked ? 1 :
                _rbStep2.Checked ? 2 :
                _rbStep3.Checked ? 3 : 3);
            retVal.Add("Iterations", _nupIteration.Value);

            retVal.Add("Matrix_w1", _matrix_w1.Matrix);
            retVal.Add("Matrix_w2", _matrix_w2.Matrix);
            retVal.Add("Matrix_w3", _matrix_w3.Matrix);

            retVal.Add("Vector_w1", _vector_w1.Vector);
            retVal.Add("Vector_w2", _vector_w2.Vector);
            retVal.Add("Vector_w3", _vector_w3.Vector);

            //retVal.Add("Notes", rtxtNotes.Text);

            return retVal;
        }

        protected override bool CheckInputs()
        {
            if ((_radCircle.Checked || _radSquare.Checked || _radTriangle.Checked || _loadedPic != null)
                && _matrix_w1.Matrix.IsValid() && _matrix_w2.Matrix.IsValid() && _matrix_w3.Matrix.IsValid()
                && _vector_w1.Vector.IsValid() && _vector_w2.Vector.IsValid() && _vector_w3.Vector.IsValid())
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
