namespace SoftwareProjekt.Forms
{
    partial class FrmVertrMitLinearkomb
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
            SoftwareProjekt.Classes.Math.Vector vector4 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector5 = new SoftwareProjekt.Classes.Math.Vector();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this._rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.grpAddInfo = new System.Windows.Forms.GroupBox();
            this.txtDet = new System.Windows.Forms.TextBox();
            this.butFunctionX = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.grpDataInputRight = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputM2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputM1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.grpDataInputLeft = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputEV2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputEV1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.grpAddInfo.SuspendLayout();
            this.grpDataInputRight.SuspendLayout();
            this.grpDataInputLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlMathEqua
            // 
            this.ctlMathEqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEqua.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEqua.Equation = "";
            this.ctlMathEqua.Filename = "teptsgn3.nai.tiff";
            this.ctlMathEqua.Filepath = "";
            this.ctlMathEqua.FontSize = 11;
            this.ctlMathEqua.Location = new System.Drawing.Point(456, 293);
            this.ctlMathEqua.Name = "ctlMathEqua";
            this.ctlMathEqua.Size = new System.Drawing.Size(433, 54);
            this.ctlMathEqua.TabIndex = 2;
            // 
            // _rtxtNotes
            // 
            this._rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._rtxtNotes.Location = new System.Drawing.Point(542, 717);
            this._rtxtNotes.Margin = new System.Windows.Forms.Padding(2);
            this._rtxtNotes.Name = "_rtxtNotes";
            this._rtxtNotes.Size = new System.Drawing.Size(317, 93);
            this._rtxtNotes.TabIndex = 9;
            this._rtxtNotes.Text = "";
            // 
            // grpAddInfo
            // 
            this.grpAddInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAddInfo.Controls.Add(this.txtDet);
            this.grpAddInfo.Location = new System.Drawing.Point(28, 618);
            this.grpAddInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddInfo.Name = "grpAddInfo";
            this.grpAddInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddInfo.Size = new System.Drawing.Size(92, 45);
            this.grpAddInfo.TabIndex = 7;
            this.grpAddInfo.TabStop = false;
            this.grpAddInfo.Text = "Determinante";
            // 
            // txtDet
            // 
            this.txtDet.Location = new System.Drawing.Point(6, 17);
            this.txtDet.Margin = new System.Windows.Forms.Padding(2);
            this.txtDet.MaxLength = 5;
            this.txtDet.Name = "txtDet";
            this.txtDet.ReadOnly = true;
            this.txtDet.Size = new System.Drawing.Size(82, 20);
            this.txtDet.TabIndex = 1;
            this.txtDet.UseSystemPasswordChar = true;
            this.txtDet.MouseEnter += new System.EventHandler(this.txtDet_MouseEnter);
            this.txtDet.MouseLeave += new System.EventHandler(this.txtDet_MouseLeave);
            // 
            // butFunctionX
            // 
            this.butFunctionX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFunctionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionX.Location = new System.Drawing.Point(651, 531);
            this.butFunctionX.Margin = new System.Windows.Forms.Padding(2);
            this.butFunctionX.Name = "butFunctionX";
            this.butFunctionX.Size = new System.Drawing.Size(128, 33);
            this.butFunctionX.TabIndex = 5;
            this.butFunctionX.Text = "&Berechne f(x)";
            this.butFunctionX.UseVisualStyleBackColor = true;
            this.butFunctionX.Click += new System.EventHandler(this.butFunctionX_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(452, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(386, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Verträglichkeit mit Linearkombination";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(538, 698);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "Notizen:";
            // 
            // cosOutput
            // 
            this.cosOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(965, 137);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(428, 341);
            this.cosOutput.TabIndex = 3;
            // 
            // cosInput
            // 
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(10, 137);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(428, 341);
            this.cosInput.TabIndex = 1;
            // 
            // grpDataInputRight
            // 
            this.grpDataInputRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataInputRight.Controls.Add(this.ctlVectorInputM2);
            this.grpDataInputRight.Controls.Add(this.ctlVectorInputM1);
            this.grpDataInputRight.Location = new System.Drawing.Point(965, 504);
            this.grpDataInputRight.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInputRight.Name = "grpDataInputRight";
            this.grpDataInputRight.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInputRight.Size = new System.Drawing.Size(255, 110);
            this.grpDataInputRight.TabIndex = 6;
            this.grpDataInputRight.TabStop = false;
            this.grpDataInputRight.Text = "Dateneingabe";
            // 
            // ctlVectorInputM2
            // 
            this.ctlVectorInputM2.Location = new System.Drawing.Point(129, 19);
            this.ctlVectorInputM2.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputM2.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputM2.Name = "ctlVectorInputM2";
            this.ctlVectorInputM2.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorInputM2.TabIndex = 1;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputM2.Vector = vector1;
            // 
            // ctlVectorInputM1
            // 
            this.ctlVectorInputM1.Location = new System.Drawing.Point(6, 19);
            this.ctlVectorInputM1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputM1.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputM1.Name = "ctlVectorInputM1";
            this.ctlVectorInputM1.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorInputM1.TabIndex = 0;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInputM1.Vector = vector2;
            // 
            // grpDataInputLeft
            // 
            this.grpDataInputLeft.Controls.Add(this.ctlVectorInputEV2);
            this.grpDataInputLeft.Controls.Add(this.ctlVectorInputEV1);
            this.grpDataInputLeft.Controls.Add(this.ctlVectorInputX);
            this.grpDataInputLeft.Location = new System.Drawing.Point(28, 504);
            this.grpDataInputLeft.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInputLeft.Name = "grpDataInputLeft";
            this.grpDataInputLeft.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInputLeft.Size = new System.Drawing.Size(379, 110);
            this.grpDataInputLeft.TabIndex = 4;
            this.grpDataInputLeft.TabStop = false;
            this.grpDataInputLeft.Text = "Dateneingabe";
            // 
            // ctlVectorInputEV2
            // 
            this.ctlVectorInputEV2.Location = new System.Drawing.Point(258, 19);
            this.ctlVectorInputEV2.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputEV2.Name = "ctlVectorInputEV2";
            this.ctlVectorInputEV2.Size = new System.Drawing.Size(118, 85);
            this.ctlVectorInputEV2.TabIndex = 2;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorInputEV2.Vector = vector3;
            // 
            // ctlVectorInputEV1
            // 
            this.ctlVectorInputEV1.Location = new System.Drawing.Point(134, 19);
            this.ctlVectorInputEV1.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputEV1.Name = "ctlVectorInputEV1";
            this.ctlVectorInputEV1.Size = new System.Drawing.Size(118, 85);
            this.ctlVectorInputEV1.TabIndex = 1;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInputEV1.Vector = vector4;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(6, 19);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorInputX.TabIndex = 0;
            vector5.X1 = float.NaN;
            vector5.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector5;
            // 
            // picArrow
            // 
            this.picArrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picArrow.BackColor = System.Drawing.Color.Transparent;
            this.picArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrow.Location = new System.Drawing.Point(435, 172);
            this.picArrow.Margin = new System.Windows.Forms.Padding(2);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(496, 298);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrow.TabIndex = 31;
            this.picArrow.TabStop = false;
            // 
            // FrmVertrMitLinearkomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 820);
            this.Controls.Add(this.ctlMathEqua);
            this.Controls.Add(this._rtxtNotes);
            this.Controls.Add(this.grpAddInfo);
            this.Controls.Add(this.butFunctionX);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.grpDataInputRight);
            this.Controls.Add(this.grpDataInputLeft);
            this.Controls.Add(this.picArrow);
            this.Name = "FrmVertrMitLinearkomb";
            this.Text = "Verträglichkeit mit Linearkombination";
            this.grpAddInfo.ResumeLayout(false);
            this.grpAddInfo.PerformLayout();
            this.grpDataInputRight.ResumeLayout(false);
            this.grpDataInputLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataInputRight;
        private System.Windows.Forms.GroupBox grpDataInputLeft;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblHeader;
        private UserControls.CtlVectorInput ctlVectorInputM2;
        private UserControls.CtlVectorInput ctlVectorInputM1;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private System.Windows.Forms.Button butFunctionX;
        private UserControls.CtlVectorInput ctlVectorInputEV2;
        private UserControls.CtlVectorInput ctlVectorInputEV1;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.GroupBox grpAddInfo;
        private System.Windows.Forms.TextBox txtDet;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
#if DEBUG
        private System.Windows.Forms.RichTextBox _rtxtNotes;
#endif
    }
}