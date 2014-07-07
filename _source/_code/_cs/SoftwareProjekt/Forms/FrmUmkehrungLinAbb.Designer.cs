namespace SoftwareProjekt.Forms
{
    partial class FrmUmkehrungLinAbb
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
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            this.ctlMathEquaToRight = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.ctlMathEquaToLeft = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this._rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.picArrowToRight = new System.Windows.Forms.PictureBox();
            this.grpDataInRight = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputY = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.butFx = new System.Windows.Forms.Button();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this._lblDeterminate = new System.Windows.Forms.Label();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.ctlMatrixInput = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picArrowToLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRight)).BeginInit();
            this.grpDataInRight.SuspendLayout();
            this.grpDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlMathEquaToRight
            // 
            this.ctlMathEquaToRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEquaToRight.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquaToRight.Equation = "";
            this.ctlMathEquaToRight.Filename = "uwe4hlbl.yip.tiff";
            this.ctlMathEquaToRight.Filepath = "";
            this.ctlMathEquaToRight.FontSize = 11;
            this.ctlMathEquaToRight.Location = new System.Drawing.Point(505, 127);
            this.ctlMathEquaToRight.Name = "ctlMathEquaToRight";
            this.ctlMathEquaToRight.Size = new System.Drawing.Size(351, 63);
            this.ctlMathEquaToRight.TabIndex = 2;
            // 
            // ctlMathEquaToLeft
            // 
            this.ctlMathEquaToLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEquaToLeft.Equation = "";
            this.ctlMathEquaToLeft.Filename = "ig4xigmq.ub5.tiff";
            this.ctlMathEquaToLeft.Filepath = "";
            this.ctlMathEquaToLeft.FontSize = 11;
            this.ctlMathEquaToLeft.Location = new System.Drawing.Point(539, 401);
            this.ctlMathEquaToLeft.Name = "ctlMathEquaToLeft";
            this.ctlMathEquaToLeft.Size = new System.Drawing.Size(363, 67);
            this.ctlMathEquaToLeft.TabIndex = 5;
            // 
            // _rtxtNotes
            // 
            this._rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._rtxtNotes.Location = new System.Drawing.Point(442, 657);
            this._rtxtNotes.Margin = new System.Windows.Forms.Padding(2);
            this._rtxtNotes.Name = "_rtxtNotes";
            this._rtxtNotes.Size = new System.Drawing.Size(524, 115);
            this._rtxtNotes.TabIndex = 10;
            this._rtxtNotes.Text = "";
            // 
            // picArrowToRight
            // 
            this.picArrowToRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picArrowToRight.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToRight.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowToRight.Location = new System.Drawing.Point(481, 36);
            this.picArrowToRight.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowToRight.Name = "picArrowToRight";
            this.picArrowToRight.Size = new System.Drawing.Size(440, 245);
            this.picArrowToRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrowToRight.TabIndex = 74;
            this.picArrowToRight.TabStop = false;
            // 
            // grpDataInRight
            // 
            this.grpDataInRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataInRight.Controls.Add(this.ctlVectorInputY);
            this.grpDataInRight.Location = new System.Drawing.Point(1134, 464);
            this.grpDataInRight.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInRight.Name = "grpDataInRight";
            this.grpDataInRight.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInRight.Size = new System.Drawing.Size(130, 124);
            this.grpDataInRight.TabIndex = 11;
            this.grpDataInRight.TabStop = false;
            this.grpDataInRight.Text = "Dateneingabe";
            // 
            // ctlVectorInputY
            // 
            this.ctlVectorInputY.EnableText = true;
            this.ctlVectorInputY.Location = new System.Drawing.Point(7, 25);
            this.ctlVectorInputY.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputY.Name = "ctlVectorInputY";
            this.ctlVectorInputY.ReadOnly = false;
            this.ctlVectorInputY.Size = new System.Drawing.Size(118, 85);
            this.ctlVectorInputY.TabIndex = 0;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputY.Vector = vector1;
            // 
            // butFx
            // 
            this.butFx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFx.AutoSize = true;
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(671, 594);
            this.butFx.Margin = new System.Windows.Forms.Padding(2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(116, 41);
            this.butFx.TabIndex = 6;
            this.butFx.Text = "Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // grpDataInput
            // 
            this.grpDataInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDataInput.Controls.Add(this._lblDeterminate);
            this.grpDataInput.Controls.Add(this.txtDeterminante);
            this.grpDataInput.Controls.Add(this.ctlMatrixInput);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Location = new System.Drawing.Point(57, 476);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Size = new System.Drawing.Size(266, 151);
            this.grpDataInput.TabIndex = 4;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // _lblDeterminate
            // 
            this._lblDeterminate.AutoSize = true;
            this._lblDeterminate.Location = new System.Drawing.Point(17, 121);
            this._lblDeterminate.Name = "_lblDeterminate";
            this._lblDeterminate.Size = new System.Drawing.Size(73, 13);
            this._lblDeterminate.TabIndex = 4;
            this._lblDeterminate.Text = "Determinante:";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(106, 118);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeterminante.MaxLength = 5;
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.ReadOnly = true;
            this.txtDeterminante.Size = new System.Drawing.Size(48, 20);
            this.txtDeterminante.TabIndex = 3;
            this.txtDeterminante.UseSystemPasswordChar = true;
            this.txtDeterminante.MouseEnter += new System.EventHandler(this.txtDeterminante_MouseEnter);
            this.txtDeterminante.MouseLeave += new System.EventHandler(this.txtDeterminante_MouseLeave);
            // 
            // ctlMatrixInput
            // 
            this.ctlMatrixInput.EnableText = true;
            this.ctlMatrixInput.Location = new System.Drawing.Point(136, 27);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInput.Matrix = matrix1;
            this.ctlMatrixInput.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMatrixInput.Name = "ctlMatrixInput";
            this.ctlMatrixInput.ReadOnly = false;
            this.ctlMatrixInput.Size = new System.Drawing.Size(116, 87);
            this.ctlMatrixInput.TabIndex = 1;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.EnableText = true;
            this.ctlVectorInputX.Location = new System.Drawing.Point(5, 27);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.ReadOnly = false;
            this.ctlVectorInputX.Size = new System.Drawing.Size(118, 85);
            this.ctlVectorInputX.TabIndex = 0;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector2;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(439, 638);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 9;
            this.lblNotes.Text = "Notizen:";
            // 
            // cosOutput
            // 
            this.cosOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(975, 76);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(430, 370);
            this.cosOutput.TabIndex = 3;
            // 
            // cosInput
            // 
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(21, 80);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(443, 370);
            this.cosInput.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(476, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(401, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Umkehrung einer linearen Abbildung";
            // 
            // picArrowToLeft
            // 
            this.picArrowToLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picArrowToLeft.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToLeft.Image = global::SoftwareProjekt.Properties.Resources.arrowToLeft;
            this.picArrowToLeft.Location = new System.Drawing.Point(481, 299);
            this.picArrowToLeft.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowToLeft.Name = "picArrowToLeft";
            this.picArrowToLeft.Size = new System.Drawing.Size(440, 276);
            this.picArrowToLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrowToLeft.TabIndex = 75;
            this.picArrowToLeft.TabStop = false;
            // 
            // FrmUmkehrungLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 783);
            this.Controls.Add(this.ctlMathEquaToRight);
            this.Controls.Add(this.ctlMathEquaToLeft);
            this.Controls.Add(this._rtxtNotes);
            this.Controls.Add(this.picArrowToRight);
            this.Controls.Add(this.grpDataInRight);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.grpDataInput);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picArrowToLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUmkehrungLinAbb";
            this.Text = "Umkehrung einer linearen Abbildung";
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRight)).EndInit();
            this.grpDataInRight.ResumeLayout(false);
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.TextBox txtDeterminante;
        private UserControls.CtlMatrixInput ctlMatrixInput;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.GroupBox grpDataInRight;
        private UserControls.CtlVectorInput ctlVectorInputY;
        private System.Windows.Forms.PictureBox picArrowToRight;
        private System.Windows.Forms.PictureBox picArrowToLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToRight;
        private System.Windows.Forms.Label _lblDeterminate;
#if DEBUG
        private System.Windows.Forms.RichTextBox _rtxtNotes;
#endif
    }
}