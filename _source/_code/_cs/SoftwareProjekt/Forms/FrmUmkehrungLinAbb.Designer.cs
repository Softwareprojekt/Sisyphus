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
            SoftwareProjekt.Classes.Math.Matrix matrix1 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector1 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.ctlMatrixInput = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.butFx = new System.Windows.Forms.Button();
            this.butUmkehrFx = new System.Windows.Forms.Button();
            this.grpDataInRight = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputY = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.butFunctionEnd = new System.Windows.Forms.Button();
            this.picArrowToRight = new System.Windows.Forms.PictureBox();
            this.picArrowToLeft = new System.Windows.Forms.PictureBox();
            this._rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.ctlMathEquaToLeft = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.ctlMathEquaToRight = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInput.SuspendLayout();
            this.grpDataInRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(546, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(401, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Umkehrung einer linearen Abbildung";
            // 
            // cosInput
            // 
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(10, 137);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(443, 370);
            this.cosInput.TabIndex = 1;
            // 
            // cosOutput
            // 
            this.cosOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(965, 137);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(430, 370);
            this.cosOutput.TabIndex = 3;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(509, 794);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 9;
            this.lblNotes.Text = "Notizen:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDataInput.Controls.Add(this.txtDeterminante);
            this.grpDataInput.Controls.Add(this.butDeterminante);
            this.grpDataInput.Controls.Add(this.ctlMatrixInput);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Location = new System.Drawing.Point(25, 541);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput.Size = new System.Drawing.Size(267, 191);
            this.grpDataInput.TabIndex = 4;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(102, 147);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeterminante.MaxLength = 5;
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.ReadOnly = true;
            this.txtDeterminante.Size = new System.Drawing.Size(48, 20);
            this.txtDeterminante.TabIndex = 3;
            this.txtDeterminante.UseSystemPasswordChar = true;
            this.txtDeterminante.MouseEnter += new System.EventHandler(this.txtDeterminante_MouseEnter);
            this.txtDeterminante.MouseLeave += new System.EventHandler(this.txtDeterminante_MouseLeave);
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(12, 140);
            this.butDeterminante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(86, 33);
            this.butDeterminante.TabIndex = 2;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            this.butDeterminante.Click += new System.EventHandler(this.butDeterminante_Click);
            // 
            // ctlMatrixInput
            // 
            this.ctlMatrixInput.Location = new System.Drawing.Point(136, 27);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInput.Matrix = matrix1;
            this.ctlMatrixInput.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMatrixInput.Name = "ctlMatrixInput";
            this.ctlMatrixInput.Size = new System.Drawing.Size(116, 87);
            this.ctlMatrixInput.TabIndex = 1;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(5, 27);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(118, 85);
            this.ctlVectorInputX.TabIndex = 0;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector1;
            // 
            // butFx
            // 
            this.butFx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFx.AutoSize = true;
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(475, 722);
            this.butFx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(116, 41);
            this.butFx.TabIndex = 6;
            this.butFx.Text = "Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // butUmkehrFx
            // 
            this.butUmkehrFx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butUmkehrFx.AutoSize = true;
            this.butUmkehrFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUmkehrFx.Location = new System.Drawing.Point(646, 722);
            this.butUmkehrFx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butUmkehrFx.Name = "butUmkehrFx";
            this.butUmkehrFx.Size = new System.Drawing.Size(205, 41);
            this.butUmkehrFx.TabIndex = 7;
            this.butUmkehrFx.Text = "Berechne Inverse von f(x)";
            this.butUmkehrFx.UseVisualStyleBackColor = true;
            this.butUmkehrFx.Click += new System.EventHandler(this.butUmkehrFx_Click);
            // 
            // grpDataInRight
            // 
            this.grpDataInRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataInRight.Controls.Add(this.ctlVectorInputY);
            this.grpDataInRight.Location = new System.Drawing.Point(1124, 541);
            this.grpDataInRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInRight.Name = "grpDataInRight";
            this.grpDataInRight.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInRight.Size = new System.Drawing.Size(130, 124);
            this.grpDataInRight.TabIndex = 11;
            this.grpDataInRight.TabStop = false;
            this.grpDataInRight.Text = "Dateneingabe";
            // 
            // ctlVectorInputY
            // 
            this.ctlVectorInputY.Location = new System.Drawing.Point(7, 25);
            this.ctlVectorInputY.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputY.Name = "ctlVectorInputY";
            this.ctlVectorInputY.Size = new System.Drawing.Size(118, 85);
            this.ctlVectorInputY.TabIndex = 0;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInputY.Vector = vector2;
            // 
            // butFunctionEnd
            // 
            this.butFunctionEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFunctionEnd.AutoSize = true;
            this.butFunctionEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionEnd.Location = new System.Drawing.Point(871, 722);
            this.butFunctionEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butFunctionEnd.Name = "butFunctionEnd";
            this.butFunctionEnd.Size = new System.Drawing.Size(206, 41);
            this.butFunctionEnd.TabIndex = 8;
            this.butFunctionEnd.Text = "Berechne Inverse von f(y)";
            this.butFunctionEnd.UseVisualStyleBackColor = true;
            this.butFunctionEnd.Click += new System.EventHandler(this.butFunctionEnd_Click_1);
            // 
            // picArrowToRight
            // 
            this.picArrowToRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picArrowToRight.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToRight.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowToRight.Location = new System.Drawing.Point(512, 95);
            this.picArrowToRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picArrowToRight.Name = "picArrowToRight";
            this.picArrowToRight.Size = new System.Drawing.Size(562, 330);
            this.picArrowToRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picArrowToRight.TabIndex = 74;
            this.picArrowToRight.TabStop = false;
            // 
            // picArrowToLeft
            // 
            this.picArrowToLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picArrowToLeft.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToLeft.Image = global::SoftwareProjekt.Properties.Resources.arrowToLeft;
            this.picArrowToLeft.Location = new System.Drawing.Point(512, 409);
            this.picArrowToLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picArrowToLeft.Name = "picArrowToLeft";
            this.picArrowToLeft.Size = new System.Drawing.Size(562, 336);
            this.picArrowToLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picArrowToLeft.TabIndex = 75;
            this.picArrowToLeft.TabStop = false;
            // 
            // _rtxtNotes
            // 
            this._rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._rtxtNotes.Location = new System.Drawing.Point(512, 822);
            this._rtxtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._rtxtNotes.Name = "_rtxtNotes";
            this._rtxtNotes.Size = new System.Drawing.Size(470, 101);
            this._rtxtNotes.TabIndex = 10;
            this._rtxtNotes.Text = "";
            // 
            // ctlMathEquaToLeft
            // 
            this.ctlMathEquaToLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEquaToLeft.Equation = "";
            this.ctlMathEquaToLeft.Filename = "ig4xigmq.ub5.tiff";
            this.ctlMathEquaToLeft.Filepath = "";
            this.ctlMathEquaToLeft.FontSize = 11;
            this.ctlMathEquaToLeft.Location = new System.Drawing.Point(682, 532);
            this.ctlMathEquaToLeft.Name = "ctlMathEquaToLeft";
            this.ctlMathEquaToLeft.Size = new System.Drawing.Size(365, 93);
            this.ctlMathEquaToLeft.TabIndex = 5;
            // 
            // ctlMathEquaToRight
            // 
            this.ctlMathEquaToRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEquaToRight.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquaToRight.Equation = "";
            this.ctlMathEquaToRight.Filename = "uwe4hlbl.yip.tiff";
            this.ctlMathEquaToRight.Filepath = "";
            this.ctlMathEquaToRight.FontSize = 11;
            this.ctlMathEquaToRight.Location = new System.Drawing.Point(551, 224);
            this.ctlMathEquaToRight.Name = "ctlMathEquaToRight";
            this.ctlMathEquaToRight.Size = new System.Drawing.Size(415, 93);
            this.ctlMathEquaToRight.TabIndex = 2;
            // 
            // FrmUmkehrungLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 849);
            this.Controls.Add(this.ctlMathEquaToRight);
            this.Controls.Add(this.ctlMathEquaToLeft);
            this.Controls.Add(this._rtxtNotes);
            this.Controls.Add(this.picArrowToRight);
            this.Controls.Add(this.butFunctionEnd);
            this.Controls.Add(this.grpDataInRight);
            this.Controls.Add(this.butUmkehrFx);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.grpDataInput);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picArrowToLeft);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUmkehrungLinAbb";
            this.Text = "Umkehrung einer linearen Abbildung";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.grpDataInRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRight)).EndInit();
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
        private System.Windows.Forms.Button butDeterminante;
        private UserControls.CtlMatrixInput ctlMatrixInput;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.Button butUmkehrFx;
        private System.Windows.Forms.GroupBox grpDataInRight;
        private UserControls.CtlVectorInput ctlVectorInputY;
        private System.Windows.Forms.Button butFunctionEnd;
        private System.Windows.Forms.PictureBox picArrowToRight;
        private System.Windows.Forms.PictureBox picArrowToLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToRight;
#if DEBUG
        private System.Windows.Forms.RichTextBox _rtxtNotes;
#endif
    }
}