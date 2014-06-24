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
            this._txtSteps = new SoftwareProjekt.UserControls.FloatInput();
            this.lblSteps = new System.Windows.Forms.Label();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this._vectorMove_w2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this._cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this._coeff_w2 = new SoftwareProjekt.UserControls.FloatInput();
            this._vectorMove_w3 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._coeff_w3 = new SoftwareProjekt.UserControls.FloatInput();
            this._coeff_w1 = new SoftwareProjekt.UserControls.FloatInput();
            this._vectorMove_w1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.grpPics.SuspendLayout();
            this.grpSteps.SuspendLayout();
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
            this._butCalculation.Location = new System.Drawing.Point(9, 38);
            this._butCalculation.Margin = new System.Windows.Forms.Padding(2);
            this._butCalculation.Name = "_butCalculation";
            this._butCalculation.Size = new System.Drawing.Size(151, 38);
            this._butCalculation.TabIndex = 1;
            this._butCalculation.Text = "Berechnung";
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
            this.grpSteps.Controls.Add(this._txtSteps);
            this.grpSteps.Controls.Add(this.lblSteps);
            this.grpSteps.Controls.Add(this._butCalculation);
            this.grpSteps.Location = new System.Drawing.Point(450, 440);
            this.grpSteps.Name = "grpSteps";
            this.grpSteps.Size = new System.Drawing.Size(171, 90);
            this.grpSteps.TabIndex = 12;
            this.grpSteps.TabStop = false;
            this.grpSteps.Text = "Schritte";
            // 
            // _txtSteps
            // 
            this._txtSteps.BackColor = System.Drawing.Color.Red;
            this._txtSteps.Location = new System.Drawing.Point(111, 13);
            this._txtSteps.Name = "_txtSteps";
            this._txtSteps.Size = new System.Drawing.Size(49, 20);
            this._txtSteps.TabIndex = 0;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(6, 16);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(99, 13);
            this.lblSteps.TabIndex = 0;
            this.lblSteps.Text = "Anzahl der Schritte:";
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
            // _vectorMove_w2
            // 
            this._vectorMove_w2.Location = new System.Drawing.Point(584, 166);
            this._vectorMove_w2.MinimumSize = new System.Drawing.Size(102, 76);
            this._vectorMove_w2.Name = "_vectorMove_w2";
            this._vectorMove_w2.Size = new System.Drawing.Size(102, 76);
            this._vectorMove_w2.TabIndex = 2;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this._vectorMove_w2.Vector = vector1;
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
            // _coeff_w2
            // 
            this._coeff_w2.BackColor = System.Drawing.Color.Red;
            this._coeff_w2.Location = new System.Drawing.Point(496, 194);
            this._coeff_w2.Name = "_coeff_w2";
            this._coeff_w2.Size = new System.Drawing.Size(82, 20);
            this._coeff_w2.TabIndex = 1;
            // 
            // _vectorMove_w3
            // 
            this._vectorMove_w3.Location = new System.Drawing.Point(584, 248);
            this._vectorMove_w3.MinimumSize = new System.Drawing.Size(102, 76);
            this._vectorMove_w3.Name = "_vectorMove_w3";
            this._vectorMove_w3.Size = new System.Drawing.Size(102, 76);
            this._vectorMove_w3.TabIndex = 4;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this._vectorMove_w3.Vector = vector2;
            // 
            // _coeff_w3
            // 
            this._coeff_w3.BackColor = System.Drawing.Color.Red;
            this._coeff_w3.Location = new System.Drawing.Point(496, 279);
            this._coeff_w3.Name = "_coeff_w3";
            this._coeff_w3.Size = new System.Drawing.Size(82, 20);
            this._coeff_w3.TabIndex = 3;
            // 
            // _coeff_w1
            // 
            this._coeff_w1.BackColor = System.Drawing.Color.Red;
            this._coeff_w1.Location = new System.Drawing.Point(496, 100);
            this._coeff_w1.Name = "_coeff_w1";
            this._coeff_w1.Size = new System.Drawing.Size(82, 20);
            this._coeff_w1.TabIndex = 0;
            // 
            // _vectorMove_w1
            // 
            this._vectorMove_w1.Location = new System.Drawing.Point(584, 84);
            this._vectorMove_w1.MinimumSize = new System.Drawing.Size(102, 76);
            this._vectorMove_w1.Name = "_vectorMove_w1";
            this._vectorMove_w1.Size = new System.Drawing.Size(102, 76);
            this._vectorMove_w1.TabIndex = 18;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this._vectorMove_w1.Vector = vector3;
            // 
            // FrmFraktalErzIFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 777);
            this.Controls.Add(this._vectorMove_w1);
            this.Controls.Add(this._coeff_w1);
            this.Controls.Add(this._coeff_w3);
            this.Controls.Add(this._vectorMove_w3);
            this.Controls.Add(this._coeff_w2);
            this.Controls.Add(this._cosOutput);
            this.Controls.Add(this._cosInput);
            this.Controls.Add(this._vectorMove_w2);
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
        private System.Windows.Forms.Label lblSteps;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
        private UserControls.CtlVectorInput _vectorMove_w2;
        private UserControls.CoordinateSystem _cosInput;
        private UserControls.CoordinateSystem _cosOutput;
        private System.Windows.Forms.Label lblPic;
        private UserControls.FloatInput _txtSteps;
        private UserControls.FloatInput _coeff_w2;
        private UserControls.CtlVectorInput _vectorMove_w3;
        private UserControls.FloatInput _coeff_w3;
        private UserControls.FloatInput _coeff_w1;
        private UserControls.CtlVectorInput _vectorMove_w1;
    }
}