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
            SoftwareProjekt.Classes.Math.Matrix matrix2 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector3 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector4 = new SoftwareProjekt.Classes.Math.Vector();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.ctlMatrixInput = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.lblPunktX = new System.Windows.Forms.Label();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.butFx = new System.Windows.Forms.Button();
            this.butUmkehrFx = new System.Windows.Forms.Button();
            this.txtUmkerFx = new System.Windows.Forms.TextBox();
            this.grpDataInRight = new System.Windows.Forms.GroupBox();
            this.lblPunktY = new System.Windows.Forms.Label();
            this.ctlVectorInputY = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.butFunctionEnd = new System.Windows.Forms.Button();
            this.txtUmkehrFy = new System.Windows.Forms.TextBox();
            this.picMathEquatCenter = new System.Windows.Forms.PictureBox();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this.grpDataInput.SuspendLayout();
            this.grpDataInRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(535, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(517, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Umkehrung einer linearen Abbildung";
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(13, 292);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(489, 389);
            this.cosInput.TabIndex = 1;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(1028, 292);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(489, 389);
            this.cosOutput.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(431, 695);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(431, 719);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 8;
            this.rtxtNotes.Text = "";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(155, 271);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(183, 17);
            this.lblInput.TabIndex = 7;
            this.lblInput.Text = "Eingabekoordinatensystem:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(1162, 271);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(187, 17);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Ausgabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.txtDeterminante);
            this.grpDataInput.Controls.Add(this.butDeterminante);
            this.grpDataInput.Controls.Add(this.ctlMatrixInput);
            this.grpDataInput.Controls.Add(this.lblPunktX);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Location = new System.Drawing.Point(104, 80);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Size = new System.Drawing.Size(512, 174);
            this.grpDataInput.TabIndex = 42;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(333, 116);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante.MaxLength = 5;
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.ReadOnly = true;
            this.txtDeterminante.Size = new System.Drawing.Size(162, 22);
            this.txtDeterminante.TabIndex = 66;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(356, 70);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(114, 41);
            this.butDeterminante.TabIndex = 3;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            this.butDeterminante.Click += new System.EventHandler(this.butDeterminante_Click);
            // 
            // ctlMatrixInput
            // 
            this.ctlMatrixInput.Location = new System.Drawing.Point(172, 55);
            this.ctlMatrixInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            matrix2.X11 = float.NaN;
            matrix2.X12 = float.NaN;
            matrix2.X21 = float.NaN;
            matrix2.X22 = float.NaN;
            this.ctlMatrixInput.Matrix = matrix2;
            this.ctlMatrixInput.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInput.Name = "ctlMatrixInput";
            this.ctlMatrixInput.Size = new System.Drawing.Size(154, 107);
            this.ctlMatrixInput.TabIndex = 2;
            // 
            // lblPunktX
            // 
            this.lblPunktX.AutoSize = true;
            this.lblPunktX.Location = new System.Drawing.Point(46, 34);
            this.lblPunktX.Name = "lblPunktX";
            this.lblPunktX.Size = new System.Drawing.Size(54, 17);
            this.lblPunktX.TabIndex = 65;
            this.lblPunktX.Text = "Punkt x";
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(7, 55);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputX.TabIndex = 1;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector3;
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(774, 114);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(106, 60);
            this.butFx.TabIndex = 4;
            this.butFx.Text = "&Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // butUmkehrFx
            // 
            this.butUmkehrFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUmkehrFx.Location = new System.Drawing.Point(774, 180);
            this.butUmkehrFx.Name = "butUmkehrFx";
            this.butUmkehrFx.Size = new System.Drawing.Size(106, 60);
            this.butUmkehrFx.TabIndex = 5;
            this.butUmkehrFx.Text = "&Berechne f^-1(f(x)) ";
            this.butUmkehrFx.UseVisualStyleBackColor = true;
            this.butUmkehrFx.Click += new System.EventHandler(this.butUmkehrFx_Click);
            // 
            // txtUmkerFx
            // 
            this.txtUmkerFx.Location = new System.Drawing.Point(732, 241);
            this.txtUmkerFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUmkerFx.Name = "txtUmkerFx";
            this.txtUmkerFx.Size = new System.Drawing.Size(204, 22);
            this.txtUmkerFx.TabIndex = 67;
            // 
            // grpDataInRight
            // 
            this.grpDataInRight.Controls.Add(this.lblPunktY);
            this.grpDataInRight.Controls.Add(this.ctlVectorInputY);
            this.grpDataInRight.Location = new System.Drawing.Point(1132, 68);
            this.grpDataInRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInRight.Name = "grpDataInRight";
            this.grpDataInRight.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInRight.Size = new System.Drawing.Size(173, 174);
            this.grpDataInRight.TabIndex = 67;
            this.grpDataInRight.TabStop = false;
            this.grpDataInRight.Text = "Dateneingabe";
            // 
            // lblPunktY
            // 
            this.lblPunktY.AutoSize = true;
            this.lblPunktY.Location = new System.Drawing.Point(46, 34);
            this.lblPunktY.Name = "lblPunktY";
            this.lblPunktY.Size = new System.Drawing.Size(55, 17);
            this.lblPunktY.TabIndex = 65;
            this.lblPunktY.Text = "Punkt y";
            // 
            // ctlVectorInputY
            // 
            this.ctlVectorInputY.Location = new System.Drawing.Point(7, 55);
            this.ctlVectorInputY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInputY.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputY.Name = "ctlVectorInputY";
            this.ctlVectorInputY.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputY.TabIndex = 6;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInputY.Vector = vector4;
            // 
            // butFunctionEnd
            // 
            this.butFunctionEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionEnd.Location = new System.Drawing.Point(1311, 145);
            this.butFunctionEnd.Name = "butFunctionEnd";
            this.butFunctionEnd.Size = new System.Drawing.Size(105, 60);
            this.butFunctionEnd.TabIndex = 7;
            this.butFunctionEnd.Text = "&Berechne f^-1(f(y)) ";
            this.butFunctionEnd.UseVisualStyleBackColor = true;
            // 
            // txtUmkehrFy
            // 
            this.txtUmkehrFy.Location = new System.Drawing.Point(1311, 206);
            this.txtUmkehrFy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUmkehrFy.Name = "txtUmkehrFy";
            this.txtUmkehrFy.Size = new System.Drawing.Size(162, 22);
            this.txtUmkehrFy.TabIndex = 69;
            // 
            // picMathEquatCenter
            // 
            this.picMathEquatCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picMathEquatCenter.BackColor = System.Drawing.Color.Transparent;
            this.picMathEquatCenter.Location = new System.Drawing.Point(465, 373);
            this.picMathEquatCenter.Margin = new System.Windows.Forms.Padding(4);
            this.picMathEquatCenter.Name = "picMathEquatCenter";
            this.picMathEquatCenter.Size = new System.Drawing.Size(375, 142);
            this.picMathEquatCenter.TabIndex = 73;
            this.picMathEquatCenter.TabStop = false;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(449, 282);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(572, 346);
            this.picBoxArrow.TabIndex = 74;
            this.picBoxArrow.TabStop = false;
            // 
            // FrmUmkehrungLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 886);
            this.Controls.Add(this.picMathEquatCenter);
            this.Controls.Add(this.picBoxArrow);
            this.Controls.Add(this.txtUmkehrFy);
            this.Controls.Add(this.butFunctionEnd);
            this.Controls.Add(this.grpDataInRight);
            this.Controls.Add(this.txtUmkerFx);
            this.Controls.Add(this.butUmkehrFx);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.grpDataInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUmkehrungLinAbb";
            this.Text = "Umkehrung einer linearen Abbildung";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.grpDataInRight.ResumeLayout(false);
            this.grpDataInRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Button butDeterminante;
        private UserControls.CtlMatrixInput ctlMatrixInput;
        private System.Windows.Forms.Label lblPunktX;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.Button butUmkehrFx;
        private System.Windows.Forms.TextBox txtUmkerFx;
        private System.Windows.Forms.GroupBox grpDataInRight;
        private System.Windows.Forms.Label lblPunktY;
        private UserControls.CtlVectorInput ctlVectorInputY;
        private System.Windows.Forms.Button butFunctionEnd;
        private System.Windows.Forms.TextBox txtUmkehrFy;
        private System.Windows.Forms.PictureBox picMathEquatCenter;
        private System.Windows.Forms.PictureBox picBoxArrow;
    }
}