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
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
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
            this.lblHeader.Location = new System.Drawing.Point(728, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(517, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Umkehrung einer linearen Abbildung";
            // 
            // cosInput
            // 
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(13, 169);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(591, 456);
            this.cosInput.TabIndex = 1;
            // 
            // cosOutput
            // 
            this.cosOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(1287, 169);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(574, 456);
            this.cosOutput.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(679, 977);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(71, 20);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notizen:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDataInput.Controls.Add(this.txtDeterminante);
            this.grpDataInput.Controls.Add(this.butDeterminante);
            this.grpDataInput.Controls.Add(this.ctlMatrixInput);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Location = new System.Drawing.Point(33, 666);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Size = new System.Drawing.Size(356, 235);
            this.grpDataInput.TabIndex = 42;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(136, 181);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante.MaxLength = 5;
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.ReadOnly = true;
            this.txtDeterminante.Size = new System.Drawing.Size(62, 22);
            this.txtDeterminante.TabIndex = 66;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(16, 172);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(114, 41);
            this.butDeterminante.TabIndex = 3;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            this.butDeterminante.Click += new System.EventHandler(this.butDeterminante_Click);
            // 
            // ctlMatrixInput
            // 
            this.ctlMatrixInput.Text = "Matrix M";
            this.ctlMatrixInput.Location = new System.Drawing.Point(181, 33);
            this.ctlMatrixInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInput.Matrix = matrix1;
            this.ctlMatrixInput.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInput.Name = "ctlMatrixInput";
            this.ctlMatrixInput.Size = new System.Drawing.Size(154, 107);
            this.ctlMatrixInput.TabIndex = 2;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Text = "Vektor x";
            this.ctlVectorInputX.Location = new System.Drawing.Point(7, 33);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputX.TabIndex = 1;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector1;
            // 
            // butFx
            // 
            this.butFx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFx.AutoSize = true;
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(633, 888);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(143, 51);
            this.butFx.TabIndex = 4;
            this.butFx.Text = "Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // butUmkehrFx
            // 
            this.butUmkehrFx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butUmkehrFx.AutoSize = true;
            this.butUmkehrFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUmkehrFx.Location = new System.Drawing.Point(861, 888);
            this.butUmkehrFx.Name = "butUmkehrFx";
            this.butUmkehrFx.Size = new System.Drawing.Size(236, 51);
            this.butUmkehrFx.TabIndex = 5;
            this.butUmkehrFx.Text = "Berechne Inverse von f(x)";
            this.butUmkehrFx.UseVisualStyleBackColor = true;
            this.butUmkehrFx.Click += new System.EventHandler(this.butUmkehrFx_Click);
            // 
            // grpDataInRight
            // 
            this.grpDataInRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataInRight.Controls.Add(this.ctlVectorInputY);
            this.grpDataInRight.Location = new System.Drawing.Point(1499, 666);
            this.grpDataInRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInRight.Name = "grpDataInRight";
            this.grpDataInRight.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInRight.Size = new System.Drawing.Size(173, 152);
            this.grpDataInRight.TabIndex = 67;
            this.grpDataInRight.TabStop = false;
            this.grpDataInRight.Text = "Dateneingabe";
            // 
            // ctlVectorInputY
            // 
            this.ctlVectorInputY.Text = "Vektor y";
            this.ctlVectorInputY.Location = new System.Drawing.Point(9, 31);
            this.ctlVectorInputY.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputY.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputY.Name = "ctlVectorInputY";
            this.ctlVectorInputY.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputY.TabIndex = 6;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInputY.Vector = vector2;
            // 
            // butFunctionEnd
            // 
            this.butFunctionEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFunctionEnd.AutoSize = true;
            this.butFunctionEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionEnd.Location = new System.Drawing.Point(1161, 888);
            this.butFunctionEnd.Name = "butFunctionEnd";
            this.butFunctionEnd.Size = new System.Drawing.Size(236, 51);
            this.butFunctionEnd.TabIndex = 7;
            this.butFunctionEnd.Text = "Berechne Inverse von f(y)";
            this.butFunctionEnd.UseVisualStyleBackColor = true;
            this.butFunctionEnd.Click += new System.EventHandler(this.butFunctionEnd_Click_1);
            // 
            // picArrowToRight
            // 
            this.picArrowToRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picArrowToRight.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToRight.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowToRight.Location = new System.Drawing.Point(683, 117);
            this.picArrowToRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.picArrowToLeft.Location = new System.Drawing.Point(683, 503);
            this.picArrowToLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picArrowToLeft.Name = "picArrowToLeft";
            this.picArrowToLeft.Size = new System.Drawing.Size(562, 336);
            this.picArrowToLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picArrowToLeft.TabIndex = 75;
            this.picArrowToLeft.TabStop = false;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rtxtNotes.Location = new System.Drawing.Point(683, 1012);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(626, 123);
            this.rtxtNotes.TabIndex = 77;
            this.rtxtNotes.Text = "";
            // 
            // ctlMathEquaToLeft
            // 
            this.ctlMathEquaToLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEquaToLeft.Equation = "";
            this.ctlMathEquaToLeft.Filename = "ig4xigmq.ub5.tiff";
            this.ctlMathEquaToLeft.Filepath = "";
            this.ctlMathEquaToLeft.FontSize = 8;
            this.ctlMathEquaToLeft.Location = new System.Drawing.Point(847, 614);
            this.ctlMathEquaToLeft.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEquaToLeft.Name = "ctlMathEquaToLeft";
            this.ctlMathEquaToLeft.Size = new System.Drawing.Size(378, 115);
            this.ctlMathEquaToLeft.TabIndex = 78;
            // 
            // ctlMathEquaToRight
            // 
            this.ctlMathEquaToRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEquaToRight.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquaToRight.Equation = "";
            this.ctlMathEquaToRight.Filename = "uwe4hlbl.yip.tiff";
            this.ctlMathEquaToRight.Filepath = "";
            this.ctlMathEquaToRight.FontSize = 8;
            this.ctlMathEquaToRight.Location = new System.Drawing.Point(733, 229);
            this.ctlMathEquaToRight.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEquaToRight.Name = "ctlMathEquaToRight";
            this.ctlMathEquaToRight.Size = new System.Drawing.Size(248, 115);
            this.ctlMathEquaToRight.TabIndex = 79;
            // 
            // FrmUmkehrungLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 1147);
            this.Controls.Add(this.ctlMathEquaToRight);
            this.Controls.Add(this.ctlMathEquaToLeft);
            this.Controls.Add(this.rtxtNotes);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToRight;
    }
}