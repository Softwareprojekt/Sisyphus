namespace SoftwareProjekt.Forms
{
    partial class FrmHinterLinAbb
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
            SoftwareProjekt.Classes.Math.Matrix matrix1 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Matrix matrix2 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector3 = new SoftwareProjekt.Classes.Math.Vector();
            this.butFx = new System.Windows.Forms.Button();
            this.grpDataInput1 = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlMatrixInputM1 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.butDeterminante1 = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput2 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtVectorGx2 = new System.Windows.Forms.TextBox();
            this.grpDataInput2 = new System.Windows.Forms.GroupBox();
            this.ctlMatrixInputM2 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.butGx = new System.Windows.Forms.Button();
            this.butGFx = new System.Windows.Forms.Button();
            this.txtResultOfTransf = new System.Windows.Forms.Label();
            this.grpDataOutput1 = new System.Windows.Forms.GroupBox();
            this.ctlVectorOutputX1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.grpDataOutput2 = new System.Windows.Forms.GroupBox();
            this.ctlVectorOutputX2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this.lblNote = new System.Windows.Forms.Label();
            this._rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.ctlMathEquTotal = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.picArrowLeft = new System.Windows.Forms.PictureBox();
            this.picArrowRight = new System.Windows.Forms.PictureBox();
            this.ctlMathEquLeft = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.ctlMathEquRight = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInput1.SuspendLayout();
            this.grpDataInput2.SuspendLayout();
            this.grpDataOutput1.SuspendLayout();
            this.grpDataOutput2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRight)).BeginInit();
            this.SuspendLayout();
            // 
            // butFx
            // 
            this.butFx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(387, 691);
            this.butFx.Margin = new System.Windows.Forms.Padding(2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(88, 28);
            this.butFx.TabIndex = 7;
            this.butFx.Text = "&Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDataInput1.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput1.Controls.Add(this.ctlMatrixInputM1);
            this.grpDataInput1.Location = new System.Drawing.Point(22, 651);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput1.Size = new System.Drawing.Size(304, 112);
            this.grpDataInput1.TabIndex = 6;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe";
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(6, 24);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(136, 76);
            this.ctlVectorInputX.TabIndex = 1;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector1;
            // 
            // ctlMatrixInputM1
            // 
            this.ctlMatrixInputM1.Location = new System.Drawing.Point(149, 24);
            this.ctlMatrixInputM1.Margin = new System.Windows.Forms.Padding(4);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInputM1.Matrix = matrix1;
            this.ctlMatrixInputM1.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMatrixInputM1.Name = "ctlMatrixInputM1";
            this.ctlMatrixInputM1.Size = new System.Drawing.Size(142, 84);
            this.ctlMatrixInputM1.TabIndex = 1;
            // 
            // butDeterminante1
            // 
            this.butDeterminante1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante1.Location = new System.Drawing.Point(205, 82);
            this.butDeterminante1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeterminante1.Name = "butDeterminante1";
            this.butDeterminante1.Size = new System.Drawing.Size(131, 34);
            this.butDeterminante1.TabIndex = 35;
            this.butDeterminante1.Text = "Determinante";
            this.butDeterminante1.UseVisualStyleBackColor = true;
            // 
            // cosInput
            // 
            this.cosInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(10, 323);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(362, 303);
            this.cosInput.TabIndex = 2;
            // 
            // cosOutput1
            // 
            this.cosOutput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cosOutput1.DoNotRefresh = false;
            this.cosOutput1.Location = new System.Drawing.Point(657, 293);
            this.cosOutput1.Name = "cosOutput1";
            this.cosOutput1.Size = new System.Drawing.Size(356, 332);
            this.cosOutput1.TabIndex = 4;
            // 
            // cosOutput2
            // 
            this.cosOutput2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput2.DoNotRefresh = false;
            this.cosOutput2.Location = new System.Drawing.Point(1324, 323);
            this.cosOutput2.Name = "cosOutput2";
            this.cosOutput2.Size = new System.Drawing.Size(373, 303);
            this.cosOutput2.TabIndex = 49;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(234, 964);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 51;
            this.lblNotes.Text = "Notizen:";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(629, 7);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(494, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Hintereinanderausführung linearer Abbildungen";
            // 
            // txtVectorGx2
            // 
            this.txtVectorGx2.Location = new System.Drawing.Point(75, 53);
            this.txtVectorGx2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVectorGx2.Name = "txtVectorGx2";
            this.txtVectorGx2.Size = new System.Drawing.Size(52, 20);
            this.txtVectorGx2.TabIndex = 5;
            // 
            // grpDataInput2
            // 
            this.grpDataInput2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpDataInput2.Controls.Add(this.ctlMatrixInputM2);
            this.grpDataInput2.Location = new System.Drawing.Point(769, 651);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput2.Size = new System.Drawing.Size(175, 124);
            this.grpDataInput2.TabIndex = 9;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe";
            // 
            // ctlMatrixInputM2
            // 
            this.ctlMatrixInputM2.Location = new System.Drawing.Point(6, 23);
            this.ctlMatrixInputM2.Margin = new System.Windows.Forms.Padding(4);
            matrix2.X11 = float.NaN;
            matrix2.X12 = float.NaN;
            matrix2.X21 = float.NaN;
            matrix2.X22 = float.NaN;
            this.ctlMatrixInputM2.Matrix = matrix2;
            this.ctlMatrixInputM2.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMatrixInputM2.Name = "ctlMatrixInputM2";
            this.ctlMatrixInputM2.Size = new System.Drawing.Size(154, 89);
            this.ctlMatrixInputM2.TabIndex = 0;
            // 
            // butGx
            // 
            this.butGx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butGx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGx.Location = new System.Drawing.Point(1081, 691);
            this.butGx.Margin = new System.Windows.Forms.Padding(2);
            this.butGx.Name = "butGx";
            this.butGx.Size = new System.Drawing.Size(91, 28);
            this.butGx.TabIndex = 10;
            this.butGx.Text = "&Berechne g(x)";
            this.butGx.UseVisualStyleBackColor = true;
            this.butGx.Click += new System.EventHandler(this.butGx_Click);
            // 
            // butGFx
            // 
            this.butGFx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butGFx.BackColor = System.Drawing.SystemColors.Highlight;
            this.butGFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGFx.Location = new System.Drawing.Point(1488, 681);
            this.butGFx.Margin = new System.Windows.Forms.Padding(2);
            this.butGFx.Name = "butGFx";
            this.butGFx.Size = new System.Drawing.Size(130, 37);
            this.butGFx.TabIndex = 8;
            this.butGFx.Text = "&Berechne g(f(x))";
            this.butGFx.UseVisualStyleBackColor = false;
            this.butGFx.Click += new System.EventHandler(this.butGFx_Click);
            // 
            // txtResultOfTransf
            // 
            this.txtResultOfTransf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultOfTransf.AutoSize = true;
            this.txtResultOfTransf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultOfTransf.Location = new System.Drawing.Point(1460, 665);
            this.txtResultOfTransf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtResultOfTransf.Name = "txtResultOfTransf";
            this.txtResultOfTransf.Size = new System.Drawing.Size(208, 15);
            this.txtResultOfTransf.TabIndex = 60;
            this.txtResultOfTransf.Text = "Gesamtergebnis der Transformation:";
            // 
            // grpDataOutput1
            // 
            this.grpDataOutput1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpDataOutput1.Controls.Add(this.ctlVectorOutputX1);
            this.grpDataOutput1.Location = new System.Drawing.Point(481, 651);
            this.grpDataOutput1.Name = "grpDataOutput1";
            this.grpDataOutput1.Size = new System.Drawing.Size(158, 111);
            this.grpDataOutput1.TabIndex = 8;
            this.grpDataOutput1.TabStop = false;
            this.grpDataOutput1.Text = "Zwischenergebnis ";
            // 
            // ctlVectorOutputX1
            // 
            this.ctlVectorOutputX1.Location = new System.Drawing.Point(6, 17);
            this.ctlVectorOutputX1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorOutputX1.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorOutputX1.Name = "ctlVectorOutputX1";
            this.ctlVectorOutputX1.Size = new System.Drawing.Size(138, 84);
            this.ctlVectorOutputX1.TabIndex = 0;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorOutputX1.Vector = vector2;
            // 
            // grpDataOutput2
            // 
            this.grpDataOutput2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataOutput2.Controls.Add(this.ctlVectorOutputX2);
            this.grpDataOutput2.Location = new System.Drawing.Point(1177, 651);
            this.grpDataOutput2.Name = "grpDataOutput2";
            this.grpDataOutput2.Size = new System.Drawing.Size(142, 93);
            this.grpDataOutput2.TabIndex = 12;
            this.grpDataOutput2.TabStop = false;
            this.grpDataOutput2.Text = "Endergebnis";
            // 
            // ctlVectorOutputX2
            // 
            this.ctlVectorOutputX2.Location = new System.Drawing.Point(6, 17);
            this.ctlVectorOutputX2.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorOutputX2.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorOutputX2.Name = "ctlVectorOutputX2";
            this.ctlVectorOutputX2.Size = new System.Drawing.Size(131, 76);
            this.ctlVectorOutputX2.TabIndex = 0;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorOutputX2.Vector = vector3;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(646, 32);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(562, 330);
            this.picBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxArrow.TabIndex = 63;
            this.picBoxArrow.TabStop = false;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(713, 807);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(60, 17);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Notizen:";
            // 
            // _rtxtNotes
            // 
            this._rtxtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._rtxtNotes.Location = new System.Drawing.Point(716, 826);
            this._rtxtNotes.Name = "_rtxtNotes";
            this._rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this._rtxtNotes.TabIndex = 14;
            this._rtxtNotes.Text = "";
            // 
            // ctlMathEquTotal
            // 
            this.ctlMathEquTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlMathEquTotal.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquTotal.Equation = "";
            this.ctlMathEquTotal.Filename = "w5ua4041.efj.tiff";
            this.ctlMathEquTotal.Filepath = "";
            this.ctlMathEquTotal.FontSize = 9;
            this.ctlMathEquTotal.Location = new System.Drawing.Point(668, 145);
            this.ctlMathEquTotal.Name = "ctlMathEquTotal";
            this.ctlMathEquTotal.Size = new System.Drawing.Size(441, 93);
            this.ctlMathEquTotal.TabIndex = 1;
            // 
            // picArrowLeft
            // 
            this.picArrowLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picArrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.picArrowLeft.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowLeft.Location = new System.Drawing.Point(377, 363);
            this.picArrowLeft.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowLeft.Name = "picArrowLeft";
            this.picArrowLeft.Size = new System.Drawing.Size(262, 198);
            this.picArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowLeft.TabIndex = 68;
            this.picArrowLeft.TabStop = false;
            // 
            // picArrowRight
            // 
            this.picArrowRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picArrowRight.BackColor = System.Drawing.Color.Transparent;
            this.picArrowRight.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowRight.Location = new System.Drawing.Point(1026, 363);
            this.picArrowRight.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowRight.Name = "picArrowRight";
            this.picArrowRight.Size = new System.Drawing.Size(262, 198);
            this.picArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowRight.TabIndex = 69;
            this.picArrowRight.TabStop = false;
            // 
            // ctlMathEquLeft
            // 
            this.ctlMathEquLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctlMathEquLeft.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquLeft.Equation = "";
            this.ctlMathEquLeft.Filename = "trjeitwn.3w0.tiff";
            this.ctlMathEquLeft.Filepath = "";
            this.ctlMathEquLeft.FontSize = 11;
            this.ctlMathEquLeft.Location = new System.Drawing.Point(387, 428);
            this.ctlMathEquLeft.Name = "ctlMathEquLeft";
            this.ctlMathEquLeft.Size = new System.Drawing.Size(158, 63);
            this.ctlMathEquLeft.TabIndex = 3;
            // 
            // ctlMathEquRight
            // 
            this.ctlMathEquRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ctlMathEquRight.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquRight.Equation = "";
            this.ctlMathEquRight.Filename = "trjeitwn.3w0.tiff";
            this.ctlMathEquRight.Filepath = "";
            this.ctlMathEquRight.FontSize = 11;
            this.ctlMathEquRight.Location = new System.Drawing.Point(1040, 435);
            this.ctlMathEquRight.Name = "ctlMathEquRight";
            this.ctlMathEquRight.Size = new System.Drawing.Size(183, 53);
            this.ctlMathEquRight.TabIndex = 5;
            // 
            // FrmHinterLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 849);
            this.Controls.Add(this.ctlMathEquRight);
            this.Controls.Add(this.ctlMathEquLeft);
            this.Controls.Add(this.picArrowRight);
            this.Controls.Add(this.picArrowLeft);
            this.Controls.Add(this.ctlMathEquTotal);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this._rtxtNotes);
            this.Controls.Add(this.picBoxArrow);
            this.Controls.Add(this.grpDataOutput2);
            this.Controls.Add(this.grpDataOutput1);
            this.Controls.Add(this.txtResultOfTransf);
            this.Controls.Add(this.butGFx);
            this.Controls.Add(this.butGx);
            this.Controls.Add(this.grpDataInput2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosOutput2);
            this.Controls.Add(this.cosOutput1);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.grpDataInput1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHinterLinAbb";
            this.Text = "Hintereinanderausführung linearer Abbildungen";
            this.grpDataInput1.ResumeLayout(false);
            this.grpDataInput2.ResumeLayout(false);
            this.grpDataOutput1.ResumeLayout(false);
            this.grpDataOutput2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.GroupBox grpDataInput1;
        private System.Windows.Forms.Button butDeterminante1;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput1;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtVectorGx2;
        private System.Windows.Forms.GroupBox grpDataInput2;
        private System.Windows.Forms.Button butGx;
        private System.Windows.Forms.Button butGFx;
        private System.Windows.Forms.Label txtResultOfTransf;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private UserControls.CtlMatrixInput ctlMatrixInputM1;
        private System.Windows.Forms.GroupBox grpDataOutput1;
        private UserControls.CtlVectorInput ctlVectorOutputX1;
        private System.Windows.Forms.GroupBox grpDataOutput2;
        private UserControls.CtlVectorInput ctlVectorOutputX2;
        private UserControls.CtlMatrixInput ctlMatrixInputM2;
        private System.Windows.Forms.PictureBox picBoxArrow;
        private System.Windows.Forms.Label lblNote;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquTotal;
        private System.Windows.Forms.PictureBox picArrowLeft;
        private System.Windows.Forms.PictureBox picArrowRight;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquRight;
#if DEBUG
        private System.Windows.Forms.RichTextBox _rtxtNotes;
#endif
    }
}