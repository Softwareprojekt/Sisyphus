namespace SoftwareProjekt.Forms
{
    partial class FrmFraktalErzIFS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SoftwareProjekt.Classes.Math.Vector vector1 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector3 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix1 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Matrix matrix2 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Matrix matrix3 = new SoftwareProjekt.Classes.Math.Matrix();
            this._butSelectPic = new System.Windows.Forms.Button();
            this._butCalculation = new System.Windows.Forms.Button();
            this.grpPics = new System.Windows.Forms.GroupBox();
            this.lblPic = new System.Windows.Forms.Label();
            this._radSquare = new System.Windows.Forms.RadioButton();
            this._radTriangle = new System.Windows.Forms.RadioButton();
            this._radCircle = new System.Windows.Forms.RadioButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblOrigPic = new System.Windows.Forms.Label();
            this.lblFraktal = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.grpSteps = new System.Windows.Forms.GroupBox();
            this.labIteration = new System.Windows.Forms.Label();
            this._nupIteration = new System.Windows.Forms.NumericUpDown();
            this._rbStep3 = new System.Windows.Forms.RadioButton();
            this._rbStep2 = new System.Windows.Forms.RadioButton();
            this._rbStep1 = new System.Windows.Forms.RadioButton();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this._vector_w2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this._cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this._vector_w3 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._vector_w1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._matrix_w1 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this._matrix_w2 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this._matrix_w3 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.grpPics.SuspendLayout();
            this.grpSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nupIteration)).BeginInit();
            this.SuspendLayout();
            // 
            // _butSelectPic
            // 
            this._butSelectPic.Location = new System.Drawing.Point(80, 73);
            this._butSelectPic.Margin = new System.Windows.Forms.Padding(2);
            this._butSelectPic.Name = "_butSelectPic";
            this._butSelectPic.Size = new System.Drawing.Size(80, 30);
            this._butSelectPic.TabIndex = 4;
            this._butSelectPic.Text = "Bild wählen";
            this._butSelectPic.UseVisualStyleBackColor = true;
            this._butSelectPic.Click += new System.EventHandler(this.butSelectPic_Click);
            // 
            // _butCalculation
            // 
            this._butCalculation.Location = new System.Drawing.Point(9, 60);
            this._butCalculation.Margin = new System.Windows.Forms.Padding(2);
            this._butCalculation.Name = "_butCalculation";
            this._butCalculation.Size = new System.Drawing.Size(105, 38);
            this._butCalculation.TabIndex = 1;
            this._butCalculation.Text = "Fraktal erzeugen";
            this._butCalculation.UseVisualStyleBackColor = true;
            this._butCalculation.Click += new System.EventHandler(this.butCalc_Click);
            // 
            // grpPics
            // 
            this.grpPics.Controls.Add(this.lblPic);
            this.grpPics.Controls.Add(this._radSquare);
            this.grpPics.Controls.Add(this._radTriangle);
            this.grpPics.Controls.Add(this._radCircle);
            this.grpPics.Controls.Add(this._butSelectPic);
            this.grpPics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPics.Location = new System.Drawing.Point(88, 440);
            this.grpPics.Margin = new System.Windows.Forms.Padding(2);
            this.grpPics.Name = "grpPics";
            this.grpPics.Padding = new System.Windows.Forms.Padding(2);
            this.grpPics.Size = new System.Drawing.Size(167, 111);
            this.grpPics.TabIndex = 5;
            this.grpPics.TabStop = false;
            this.grpPics.Text = "Bild wählen";
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(5, 82);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(68, 13);
            this.lblPic.TabIndex = 3;
            this.lblPic.Text = "Eigenes Bild:";
            // 
            // _radSquare
            // 
            this._radSquare.AutoSize = true;
            this._radSquare.Location = new System.Drawing.Point(4, 59);
            this._radSquare.Margin = new System.Windows.Forms.Padding(2);
            this._radSquare.Name = "_radSquare";
            this._radSquare.Size = new System.Drawing.Size(72, 17);
            this._radSquare.TabIndex = 2;
            this._radSquare.Text = "Rechteck";
            this._radSquare.UseVisualStyleBackColor = true;
            this._radSquare.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // _radTriangle
            // 
            this._radTriangle.AutoSize = true;
            this._radTriangle.Location = new System.Drawing.Point(4, 38);
            this._radTriangle.Margin = new System.Windows.Forms.Padding(2);
            this._radTriangle.Name = "_radTriangle";
            this._radTriangle.Size = new System.Drawing.Size(62, 17);
            this._radTriangle.TabIndex = 1;
            this._radTriangle.Text = "Dreieck";
            this._radTriangle.UseVisualStyleBackColor = true;
            this._radTriangle.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // _radCircle
            // 
            this._radCircle.AutoSize = true;
            this._radCircle.Location = new System.Drawing.Point(4, 17);
            this._radCircle.Margin = new System.Windows.Forms.Padding(2);
            this._radCircle.Name = "_radCircle";
            this._radCircle.Size = new System.Drawing.Size(48, 17);
            this._radCircle.TabIndex = 0;
            this._radCircle.Text = "Kreis";
            this._radCircle.UseVisualStyleBackColor = true;
            this._radCircle.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(361, 32);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(361, 25);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Thema: Fraktalerzeugung mit einem IFS";
            // 
            // lblOrigPic
            // 
            this.lblOrigPic.AutoSize = true;
            this.lblOrigPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigPic.Location = new System.Drawing.Point(177, 391);
            this.lblOrigPic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrigPic.Name = "lblOrigPic";
            this.lblOrigPic.Size = new System.Drawing.Size(78, 20);
            this.lblOrigPic.TabIndex = 7;
            this.lblOrigPic.Text = "Original D";
            // 
            // lblFraktal
            // 
            this.lblFraktal.AutoSize = true;
            this.lblFraktal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraktal.Location = new System.Drawing.Point(849, 391);
            this.lblFraktal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFraktal.Name = "lblFraktal";
            this.lblFraktal.Size = new System.Drawing.Size(103, 20);
            this.lblFraktal.TabIndex = 8;
            this.lblFraktal.Text = "Collage W(D)";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(293, 625);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 11;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(293, 644);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this.rtxtNotes.TabIndex = 7;
            this.rtxtNotes.Text = "";
            this.rtxtNotes.TextChanged += new System.EventHandler(this.rtxtNotes_TextChanged);
            // 
            // grpSteps
            // 
            this.grpSteps.Controls.Add(this.labIteration);
            this.grpSteps.Controls.Add(this._nupIteration);
            this.grpSteps.Controls.Add(this._rbStep3);
            this.grpSteps.Controls.Add(this._rbStep2);
            this.grpSteps.Controls.Add(this._rbStep1);
            this.grpSteps.Controls.Add(this._butCalculation);
            this.grpSteps.Location = new System.Drawing.Point(496, 429);
            this.grpSteps.Name = "grpSteps";
            this.grpSteps.Size = new System.Drawing.Size(128, 106);
            this.grpSteps.TabIndex = 12;
            this.grpSteps.TabStop = false;
            this.grpSteps.Text = "Berechnungsschritte";
            // 
            // labIteration
            // 
            this.labIteration.AutoSize = true;
            this.labIteration.Location = new System.Drawing.Point(6, 37);
            this.labIteration.Name = "labIteration";
            this.labIteration.Size = new System.Drawing.Size(57, 13);
            this.labIteration.TabIndex = 6;
            this.labIteration.Text = "Iterationen";
            // 
            // _nupIteration
            // 
            this._nupIteration.Location = new System.Drawing.Point(69, 35);
            this._nupIteration.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._nupIteration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nupIteration.Name = "_nupIteration";
            this._nupIteration.Size = new System.Drawing.Size(45, 20);
            this._nupIteration.TabIndex = 5;
            this._nupIteration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _rbStep3
            // 
            this._rbStep3.AutoSize = true;
            this._rbStep3.Checked = true;
            this._rbStep3.Location = new System.Drawing.Point(83, 16);
            this._rbStep3.Name = "_rbStep3";
            this._rbStep3.Size = new System.Drawing.Size(31, 17);
            this._rbStep3.TabIndex = 4;
            this._rbStep3.TabStop = true;
            this._rbStep3.Text = "3";
            this._rbStep3.UseVisualStyleBackColor = true;
            // 
            // _rbStep2
            // 
            this._rbStep2.AutoSize = true;
            this._rbStep2.Location = new System.Drawing.Point(46, 16);
            this._rbStep2.Name = "_rbStep2";
            this._rbStep2.Size = new System.Drawing.Size(31, 17);
            this._rbStep2.TabIndex = 3;
            this._rbStep2.TabStop = true;
            this._rbStep2.Text = "2";
            this._rbStep2.UseVisualStyleBackColor = true;
            // 
            // _rbStep1
            // 
            this._rbStep1.AutoSize = true;
            this._rbStep1.Location = new System.Drawing.Point(9, 16);
            this._rbStep1.Name = "_rbStep1";
            this._rbStep1.Size = new System.Drawing.Size(31, 17);
            this._rbStep1.TabIndex = 2;
            this._rbStep1.TabStop = true;
            this._rbStep1.Text = "1";
            this._rbStep1.UseVisualStyleBackColor = true;
            // 
            // ctlMathEqua
            // 
            this.ctlMathEqua.Arrowdirection = SoftwareProjekt.Enums.EArrowDirection.up;
            this.ctlMathEqua.Equation = "";
            this.ctlMathEqua.Filename = "expr.gif";
            this.ctlMathEqua.Filepath = "C:\\Program Files (x86)\\Microsoft Visual Studio 11.0\\Common7\\IDE";
            this.ctlMathEqua.FontSize = 8;
            this.ctlMathEqua.Location = new System.Drawing.Point(381, 166);
            this.ctlMathEqua.Name = "ctlMathEqua";
            this.ctlMathEqua.Size = new System.Drawing.Size(361, 158);
            this.ctlMathEqua.TabIndex = 13;
            // 
            // _vector_w2
            // 
            this._vector_w2.Location = new System.Drawing.Point(561, 166);
            this._vector_w2.MinimumSize = new System.Drawing.Size(102, 76);
            this._vector_w2.Name = "_vector_w2";
            this._vector_w2.Size = new System.Drawing.Size(125, 89);
            this._vector_w2.TabIndex = 2;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this._vector_w2.Vector = vector1;
            // 
            // _cosInput
            // 
            this._cosInput.Location = new System.Drawing.Point(88, 84);
            this._cosInput.Name = "_cosInput";
            this._cosInput.Size = new System.Drawing.Size(287, 288);
            this._cosInput.TabIndex = 16;
            // 
            // _cosOutput
            // 
            this._cosOutput.Location = new System.Drawing.Point(748, 84);
            this._cosOutput.Name = "_cosOutput";
            this._cosOutput.Size = new System.Drawing.Size(287, 288);
            this._cosOutput.TabIndex = 17;
            // 
            // _vector_w3
            // 
            this._vector_w3.Location = new System.Drawing.Point(561, 261);
            this._vector_w3.MinimumSize = new System.Drawing.Size(102, 76);
            this._vector_w3.Name = "_vector_w3";
            this._vector_w3.Size = new System.Drawing.Size(125, 89);
            this._vector_w3.TabIndex = 4;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this._vector_w3.Vector = vector2;
            // 
            // _vector_w1
            // 
            this._vector_w1.Location = new System.Drawing.Point(561, 71);
            this._vector_w1.MinimumSize = new System.Drawing.Size(102, 76);
            this._vector_w1.Name = "_vector_w1";
            this._vector_w1.Size = new System.Drawing.Size(125, 89);
            this._vector_w1.TabIndex = 18;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this._vector_w1.Vector = vector3;
            // 
            // _matrix_w1
            // 
            this._matrix_w1.Location = new System.Drawing.Point(430, 71);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this._matrix_w1.Matrix = matrix1;
            this._matrix_w1.MinimumSize = new System.Drawing.Size(98, 76);
            this._matrix_w1.Name = "_matrix_w1";
            this._matrix_w1.Size = new System.Drawing.Size(125, 89);
            this._matrix_w1.TabIndex = 19;
            // 
            // _matrix_w2
            // 
            this._matrix_w2.Location = new System.Drawing.Point(430, 166);
            matrix2.X11 = float.NaN;
            matrix2.X12 = float.NaN;
            matrix2.X21 = float.NaN;
            matrix2.X22 = float.NaN;
            this._matrix_w2.Matrix = matrix2;
            this._matrix_w2.MinimumSize = new System.Drawing.Size(98, 76);
            this._matrix_w2.Name = "_matrix_w2";
            this._matrix_w2.Size = new System.Drawing.Size(125, 89);
            this._matrix_w2.TabIndex = 19;
            // 
            // _matrix_w3
            // 
            this._matrix_w3.Location = new System.Drawing.Point(430, 261);
            matrix3.X11 = float.NaN;
            matrix3.X12 = float.NaN;
            matrix3.X21 = float.NaN;
            matrix3.X22 = float.NaN;
            this._matrix_w3.Matrix = matrix3;
            this._matrix_w3.MinimumSize = new System.Drawing.Size(98, 76);
            this._matrix_w3.Name = "_matrix_w3";
            this._matrix_w3.Size = new System.Drawing.Size(125, 89);
            this._matrix_w3.TabIndex = 19;
            // 
            // FrmFraktalErzIFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 777);
            this.Controls.Add(this._matrix_w3);
            this.Controls.Add(this._matrix_w2);
            this.Controls.Add(this._matrix_w1);
            this.Controls.Add(this._vector_w1);
            this.Controls.Add(this._vector_w3);
            this.Controls.Add(this._cosOutput);
            this.Controls.Add(this._cosInput);
            this.Controls.Add(this._vector_w2);
            this.Controls.Add(this.ctlMathEqua);
            this.Controls.Add(this.grpSteps);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.lblFraktal);
            this.Controls.Add(this.lblOrigPic);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpPics);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFraktalErzIFS";
            this.Text = "Fraktalerzeugung mit einem IFS";
            this.grpPics.ResumeLayout(false);
            this.grpPics.PerformLayout();
            this.grpSteps.ResumeLayout(false);
            this.grpSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nupIteration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _butSelectPic;
        private System.Windows.Forms.Button _butCalculation;
        private System.Windows.Forms.GroupBox grpPics;
        private System.Windows.Forms.RadioButton _radSquare;
        private System.Windows.Forms.RadioButton _radTriangle;
        private System.Windows.Forms.RadioButton _radCircle;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblOrigPic;
        private System.Windows.Forms.Label lblFraktal;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.GroupBox grpSteps;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
        private UserControls.CtlVectorInput _vector_w2;
        private UserControls.CoordinateSystem _cosInput;
        private UserControls.CoordinateSystem _cosOutput;
        private System.Windows.Forms.Label lblPic;
        private UserControls.CtlVectorInput _vector_w3;
        private UserControls.CtlVectorInput _vector_w1;
        private UserControls.CtlMatrixInput _matrix_w1;
        private UserControls.CtlMatrixInput _matrix_w2;
        private UserControls.CtlMatrixInput _matrix_w3;
        private System.Windows.Forms.Label labIteration;
        private System.Windows.Forms.NumericUpDown _nupIteration;
        private System.Windows.Forms.RadioButton _rbStep3;
        private System.Windows.Forms.RadioButton _rbStep2;
        private System.Windows.Forms.RadioButton _rbStep1;
    }
}