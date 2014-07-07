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
            SoftwareProjekt.Classes.Math.Vector vector7 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix5 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Matrix matrix6 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector8 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector9 = new SoftwareProjekt.Classes.Math.Vector();
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
            this.butFx = new System.Windows.Forms.Button();
            this.grpDataInput1.SuspendLayout();
            this.grpDataInput2.SuspendLayout();
            this.grpDataOutput1.SuspendLayout();
            this.grpDataOutput2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRight)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDataInput1.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput1.Controls.Add(this.ctlMatrixInputM1);
            this.grpDataInput1.Location = new System.Drawing.Point(43, 688);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput1.Size = new System.Drawing.Size(350, 124);
            this.grpDataInput1.TabIndex = 6;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe";
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.EnableText = true;
            this.ctlVectorInputX.Location = new System.Drawing.Point(18, 24);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.ReadOnly = false;
            this.ctlVectorInputX.Size = new System.Drawing.Size(142, 84);
            this.ctlVectorInputX.TabIndex = 1;
            vector7.X1 = float.NaN;
            vector7.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector7;
            // 
            // ctlMatrixInputM1
            // 
            this.ctlMatrixInputM1.EnableText = true;
            this.ctlMatrixInputM1.Location = new System.Drawing.Point(180, 24);
            this.ctlMatrixInputM1.Margin = new System.Windows.Forms.Padding(4);
            matrix5.X11 = float.NaN;
            matrix5.X12 = float.NaN;
            matrix5.X21 = float.NaN;
            matrix5.X22 = float.NaN;
            this.ctlMatrixInputM1.Matrix = matrix5;
            this.ctlMatrixInputM1.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMatrixInputM1.Name = "ctlMatrixInputM1";
            this.ctlMatrixInputM1.ReadOnly = false;
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
            this.cosInput.Location = new System.Drawing.Point(12, 323);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(320, 274);
            this.cosInput.TabIndex = 2;
            // 
            // cosOutput1
            // 
            this.cosOutput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cosOutput1.DoNotRefresh = false;
            this.cosOutput1.Location = new System.Drawing.Point(597, 323);
            this.cosOutput1.Name = "cosOutput1";
            this.cosOutput1.Size = new System.Drawing.Size(320, 274);
            this.cosOutput1.TabIndex = 4;
            // 
            // cosOutput2
            // 
            this.cosOutput2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput2.DoNotRefresh = false;
            this.cosOutput2.Location = new System.Drawing.Point(1185, 323);
            this.cosOutput2.Name = "cosOutput2";
            this.cosOutput2.Size = new System.Drawing.Size(320, 274);
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
            this.lblHeader.Location = new System.Drawing.Point(467, 9);
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
            this.grpDataInput2.Location = new System.Drawing.Point(578, 688);
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
            this.ctlMatrixInputM2.EnableText = true;
            this.ctlMatrixInputM2.Location = new System.Drawing.Point(19, 24);
            this.ctlMatrixInputM2.Margin = new System.Windows.Forms.Padding(4);
            matrix6.X11 = float.NaN;
            matrix6.X12 = float.NaN;
            matrix6.X21 = float.NaN;
            matrix6.X22 = float.NaN;
            this.ctlMatrixInputM2.Matrix = matrix6;
            this.ctlMatrixInputM2.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMatrixInputM2.Name = "ctlMatrixInputM2";
            this.ctlMatrixInputM2.ReadOnly = false;
            this.ctlMatrixInputM2.Size = new System.Drawing.Size(142, 84);
            this.ctlMatrixInputM2.TabIndex = 0;
            // 
            // txtResultOfTransf
            // 
            this.txtResultOfTransf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultOfTransf.AutoSize = true;
            this.txtResultOfTransf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultOfTransf.Location = new System.Drawing.Point(1541, 702);
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
            this.grpDataOutput1.Location = new System.Drawing.Point(398, 688);
            this.grpDataOutput1.Name = "grpDataOutput1";
            this.grpDataOutput1.Size = new System.Drawing.Size(175, 124);
            this.grpDataOutput1.TabIndex = 8;
            this.grpDataOutput1.TabStop = false;
            this.grpDataOutput1.Text = "Zwischenergebnis ";
            // 
            // ctlVectorOutputX1
            // 
            this.ctlVectorOutputX1.EnableText = false;
            this.ctlVectorOutputX1.Location = new System.Drawing.Point(16, 24);
            this.ctlVectorOutputX1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorOutputX1.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorOutputX1.Name = "ctlVectorOutputX1";
            this.ctlVectorOutputX1.ReadOnly = false;
            this.ctlVectorOutputX1.Size = new System.Drawing.Size(142, 84);
            this.ctlVectorOutputX1.TabIndex = 0;
            vector8.X1 = float.NaN;
            vector8.X2 = float.NaN;
            this.ctlVectorOutputX1.Vector = vector8;
            // 
            // grpDataOutput2
            // 
            this.grpDataOutput2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataOutput2.Controls.Add(this.ctlVectorOutputX2);
            this.grpDataOutput2.Location = new System.Drawing.Point(850, 688);
            this.grpDataOutput2.Name = "grpDataOutput2";
            this.grpDataOutput2.Size = new System.Drawing.Size(175, 124);
            this.grpDataOutput2.TabIndex = 12;
            this.grpDataOutput2.TabStop = false;
            this.grpDataOutput2.Text = "Endergebnis";
            // 
            // ctlVectorOutputX2
            // 
            this.ctlVectorOutputX2.EnableText = false;
            this.ctlVectorOutputX2.Location = new System.Drawing.Point(19, 24);
            this.ctlVectorOutputX2.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorOutputX2.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorOutputX2.Name = "ctlVectorOutputX2";
            this.ctlVectorOutputX2.ReadOnly = false;
            this.ctlVectorOutputX2.Size = new System.Drawing.Size(142, 84);
            this.ctlVectorOutputX2.TabIndex = 0;
            vector9.X1 = float.NaN;
            vector9.X2 = float.NaN;
            this.ctlVectorOutputX2.Vector = vector9;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(306, 54);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(838, 217);
            this.picBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxArrow.TabIndex = 63;
            this.picBoxArrow.TabStop = false;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(1028, 670);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(60, 17);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Notizen:";
            // 
            // _rtxtNotes
            // 
            this._rtxtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._rtxtNotes.Location = new System.Drawing.Point(1031, 688);
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
            this.ctlMathEquTotal.Location = new System.Drawing.Point(386, 134);
            this.ctlMathEquTotal.Name = "ctlMathEquTotal";
            this.ctlMathEquTotal.Size = new System.Drawing.Size(625, 66);
            this.ctlMathEquTotal.TabIndex = 1;
            // 
            // picArrowLeft
            // 
            this.picArrowLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picArrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.picArrowLeft.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowLeft.Location = new System.Drawing.Point(348, 363);
            this.picArrowLeft.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowLeft.Name = "picArrowLeft";
            this.picArrowLeft.Size = new System.Drawing.Size(225, 194);
            this.picArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowLeft.TabIndex = 68;
            this.picArrowLeft.TabStop = false;
            // 
            // picArrowRight
            // 
            this.picArrowRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picArrowRight.BackColor = System.Drawing.Color.Transparent;
            this.picArrowRight.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowRight.Location = new System.Drawing.Point(943, 363);
            this.picArrowRight.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowRight.Name = "picArrowRight";
            this.picArrowRight.Size = new System.Drawing.Size(225, 194);
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
            this.ctlMathEquLeft.Location = new System.Drawing.Point(364, 437);
            this.ctlMathEquLeft.Name = "ctlMathEquLeft";
            this.ctlMathEquLeft.Size = new System.Drawing.Size(169, 44);
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
            this.ctlMathEquRight.Location = new System.Drawing.Point(960, 437);
            this.ctlMathEquRight.Name = "ctlMathEquRight";
            this.ctlMathEquRight.Size = new System.Drawing.Size(169, 44);
            this.ctlMathEquRight.TabIndex = 5;
            // 
            // butFx
            // 
            this.butFx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(757, 730);
            this.butFx.Margin = new System.Windows.Forms.Padding(2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(88, 28);
            this.butFx.TabIndex = 7;
            this.butFx.Text = "&Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // FrmHinterLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 886);
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
            this.Controls.Add(this.grpDataInput2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosOutput2);
            this.Controls.Add(this.cosOutput1);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.grpDataInput1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
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

        private System.Windows.Forms.GroupBox grpDataInput1;
        private System.Windows.Forms.Button butDeterminante1;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput1;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtVectorGx2;
        private System.Windows.Forms.GroupBox grpDataInput2;
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
        private System.Windows.Forms.Button butFx;
#if DEBUG
        private System.Windows.Forms.RichTextBox _rtxtNotes;
#endif
    }
}