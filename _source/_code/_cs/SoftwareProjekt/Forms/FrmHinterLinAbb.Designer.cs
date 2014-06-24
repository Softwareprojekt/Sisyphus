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
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector3 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix1 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector1 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix2 = new SoftwareProjekt.Classes.Math.Matrix();
            this.butFx = new System.Windows.Forms.Button();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.grpDataInput1 = new System.Windows.Forms.GroupBox();
            this.dutDeterminante = new System.Windows.Forms.Button();
            this.txtDeterminante1 = new System.Windows.Forms.TextBox();
            this.butDeterminante1 = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput2 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtVectorGx2 = new System.Windows.Forms.TextBox();
            this.picMathEquLeft = new System.Windows.Forms.PictureBox();
            this.picMathEquRight = new System.Windows.Forms.PictureBox();
            this.picMathEquBig = new System.Windows.Forms.PictureBox();
            this.lblOutputCos2 = new System.Windows.Forms.Label();
            this.grpDataInput2 = new System.Windows.Forms.GroupBox();
            this.butDeterminante2 = new System.Windows.Forms.Button();
            this.txtDeterminante2 = new System.Windows.Forms.TextBox();
            this.butGx = new System.Windows.Forms.Button();
            this.butGFx = new System.Windows.Forms.Button();
            this.txtResultOfTransf = new System.Windows.Forms.Label();
            this.grpDataOutput1 = new System.Windows.Forms.GroupBox();
            this.ctlVectorOutputX1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.grpDataOutput2 = new System.Windows.Forms.GroupBox();
            this.ctlVectorOutputX2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlMatrixInputM1 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlMatrixInputM2 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.grpDataInput1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquBig)).BeginInit();
            this.grpDataInput2.SuspendLayout();
            this.grpDataOutput1.SuspendLayout();
            this.grpDataOutput2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(440, 94);
            this.butFx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(80, 48);
            this.butFx.TabIndex = 4;
            this.butFx.Text = "f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Location = new System.Drawing.Point(672, 444);
            this.lblOutput1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(146, 13);
            this.lblOutput1.TabIndex = 40;
            this.lblOutput1.Text = "Ausgabekoordinatensystem1:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(136, 444);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(137, 13);
            this.lblInput.TabIndex = 37;
            this.lblInput.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput1.Controls.Add(this.ctlMatrixInputM1);
            this.grpDataInput1.Controls.Add(this.dutDeterminante);
            this.grpDataInput1.Controls.Add(this.txtDeterminante1);
            this.grpDataInput1.Location = new System.Drawing.Point(12, 55);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput1.Size = new System.Drawing.Size(424, 123);
            this.grpDataInput1.TabIndex = 35;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe1";
            // 
            // dutDeterminante
            // 
            this.dutDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dutDeterminante.Location = new System.Drawing.Point(289, 25);
            this.dutDeterminante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dutDeterminante.Name = "dutDeterminante";
            this.dutDeterminante.Size = new System.Drawing.Size(112, 37);
            this.dutDeterminante.TabIndex = 3;
            this.dutDeterminante.Text = "Determinante";
            this.dutDeterminante.UseVisualStyleBackColor = true;
            this.dutDeterminante.Click += new System.EventHandler(this.dutDeterminante_Click);
            // 
            // txtDeterminante1
            // 
            this.txtDeterminante1.Location = new System.Drawing.Point(287, 67);
            this.txtDeterminante1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeterminante1.MaxLength = 5;
            this.txtDeterminante1.Name = "txtDeterminante1";
            this.txtDeterminante1.ReadOnly = true;
            this.txtDeterminante1.Size = new System.Drawing.Size(114, 20);
            this.txtDeterminante1.TabIndex = 36;
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
            this.cosInput.Location = new System.Drawing.Point(12, 460);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(362, 303);
            this.cosInput.TabIndex = 47;
            // 
            // cosOutput1
            // 
            this.cosOutput1.Location = new System.Drawing.Point(583, 460);
            this.cosOutput1.Name = "cosOutput1";
            this.cosOutput1.Size = new System.Drawing.Size(356, 303);
            this.cosOutput1.TabIndex = 48;
            // 
            // cosOutput2
            // 
            this.cosOutput2.Location = new System.Drawing.Point(1127, 460);
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
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(235, 981);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this.rtxtNotes.TabIndex = 50;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(495, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(494, 25);
            this.lblHeader.TabIndex = 52;
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
            // picMathEquLeft
            // 
            this.picMathEquLeft.Location = new System.Drawing.Point(380, 547);
            this.picMathEquLeft.Name = "picMathEquLeft";
            this.picMathEquLeft.Size = new System.Drawing.Size(197, 121);
            this.picMathEquLeft.TabIndex = 53;
            this.picMathEquLeft.TabStop = false;
            // 
            // picMathEquRight
            // 
            this.picMathEquRight.Location = new System.Drawing.Point(924, 547);
            this.picMathEquRight.Name = "picMathEquRight";
            this.picMathEquRight.Size = new System.Drawing.Size(197, 121);
            this.picMathEquRight.TabIndex = 54;
            this.picMathEquRight.TabStop = false;
            // 
            // picMathEquBig
            // 
            this.picMathEquBig.Location = new System.Drawing.Point(224, 309);
            this.picMathEquBig.Name = "picMathEquBig";
            this.picMathEquBig.Size = new System.Drawing.Size(775, 93);
            this.picMathEquBig.TabIndex = 55;
            this.picMathEquBig.TabStop = false;
            // 
            // lblOutputCos2
            // 
            this.lblOutputCos2.AutoSize = true;
            this.lblOutputCos2.Location = new System.Drawing.Point(1263, 444);
            this.lblOutputCos2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputCos2.Name = "lblOutputCos2";
            this.lblOutputCos2.Size = new System.Drawing.Size(146, 13);
            this.lblOutputCos2.TabIndex = 56;
            this.lblOutputCos2.Text = "Ausgabekoordinatensystem2:";
            // 
            // grpDataInput2
            // 
            this.grpDataInput2.Controls.Add(this.ctlMatrixInputM2);
            this.grpDataInput2.Controls.Add(this.butDeterminante2);
            this.grpDataInput2.Controls.Add(this.txtDeterminante2);
            this.grpDataInput2.Location = new System.Drawing.Point(755, 55);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput2.Size = new System.Drawing.Size(297, 123);
            this.grpDataInput2.TabIndex = 58;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe2";
            // 
            // butDeterminante2
            // 
            this.butDeterminante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante2.Location = new System.Drawing.Point(149, 25);
            this.butDeterminante2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDeterminante2.Name = "butDeterminante2";
            this.butDeterminante2.Size = new System.Drawing.Size(112, 37);
            this.butDeterminante2.TabIndex = 6;
            this.butDeterminante2.Text = "Determinante";
            this.butDeterminante2.UseVisualStyleBackColor = true;
            this.butDeterminante2.Click += new System.EventHandler(this.butDeterminante2_Click);
            // 
            // txtDeterminante2
            // 
            this.txtDeterminante2.Location = new System.Drawing.Point(149, 67);
            this.txtDeterminante2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeterminante2.MaxLength = 5;
            this.txtDeterminante2.Name = "txtDeterminante2";
            this.txtDeterminante2.ReadOnly = true;
            this.txtDeterminante2.Size = new System.Drawing.Size(114, 20);
            this.txtDeterminante2.TabIndex = 36;
            // 
            // butGx
            // 
            this.butGx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGx.Location = new System.Drawing.Point(1056, 90);
            this.butGx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butGx.Name = "butGx";
            this.butGx.Size = new System.Drawing.Size(80, 48);
            this.butGx.TabIndex = 7;
            this.butGx.Text = "g(x)";
            this.butGx.UseVisualStyleBackColor = true;
            this.butGx.Click += new System.EventHandler(this.butGx_Click);
            // 
            // butGFx
            // 
            this.butGFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGFx.Location = new System.Drawing.Point(554, 254);
            this.butGFx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butGFx.Name = "butGFx";
            this.butGFx.Size = new System.Drawing.Size(112, 37);
            this.butGFx.TabIndex = 8;
            this.butGFx.Text = "g(f(x))";
            this.butGFx.UseVisualStyleBackColor = true;
            this.butGFx.Click += new System.EventHandler(this.butGFx_Click);
            // 
            // txtResultOfTransf
            // 
            this.txtResultOfTransf.AutoSize = true;
            this.txtResultOfTransf.Location = new System.Drawing.Point(541, 229);
            this.txtResultOfTransf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtResultOfTransf.Name = "txtResultOfTransf";
            this.txtResultOfTransf.Size = new System.Drawing.Size(142, 13);
            this.txtResultOfTransf.TabIndex = 60;
            this.txtResultOfTransf.Text = "Ergebnis der Transformation:";
            // 
            // grpDataOutput1
            // 
            this.grpDataOutput1.Controls.Add(this.ctlVectorOutputX1);
            this.grpDataOutput1.Location = new System.Drawing.Point(525, 55);
            this.grpDataOutput1.Name = "grpDataOutput1";
            this.grpDataOutput1.Size = new System.Drawing.Size(158, 123);
            this.grpDataOutput1.TabIndex = 61;
            this.grpDataOutput1.TabStop = false;
            this.grpDataOutput1.Text = "Datenausgabe1";
            // 
            // ctlVectorOutputX1
            // 
            this.ctlVectorOutputX1.Location = new System.Drawing.Point(6, 17);
            this.ctlVectorOutputX1.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorOutputX1.Name = "ctlVectorOutputX1";
            this.ctlVectorOutputX1.Size = new System.Drawing.Size(138, 84);
            this.ctlVectorOutputX1.TabIndex = 0;
            this.ctlVectorOutputX1.txtEle11.ReadOnly = true;
            this.ctlVectorOutputX1.txtEle21.ReadOnly = true;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorOutputX1.Vector = vector2;
            // 
            // grpDataOutput2
            // 
            this.grpDataOutput2.Controls.Add(this.ctlVectorOutputX2);
            this.grpDataOutput2.Location = new System.Drawing.Point(1141, 55);
            this.grpDataOutput2.Name = "grpDataOutput2";
            this.grpDataOutput2.Size = new System.Drawing.Size(142, 123);
            this.grpDataOutput2.TabIndex = 62;
            this.grpDataOutput2.TabStop = false;
            this.grpDataOutput2.Text = "Datenausgabe2";
            // 
            // ctlVectorOutputX2
            // 
            this.ctlVectorOutputX2.Location = new System.Drawing.Point(6, 17);
            this.ctlVectorOutputX2.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorOutputX2.Name = "ctlVectorOutputX2";
            this.ctlVectorOutputX2.Size = new System.Drawing.Size(131, 76);
            this.ctlVectorOutputX2.TabIndex = 0;
            this.ctlVectorOutputX2.txtEle11.ReadOnly = true;
            this.ctlVectorOutputX2.txtEle21.ReadOnly = true;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorOutputX2.Vector = vector3;
            // 
            // ctlMatrixInputM1
            // 
            this.ctlMatrixInputM1.Location = new System.Drawing.Point(147, 17);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInputM1.Matrix = matrix1;
            this.ctlMatrixInputM1.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMatrixInputM1.Name = "ctlMatrixInputM1";
            this.ctlMatrixInputM1.Size = new System.Drawing.Size(125, 89);
            this.ctlMatrixInputM1.TabIndex = 37;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(5, 25);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(136, 76);
            this.ctlVectorInputX.TabIndex = 38;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector1;
            // 
            // ctlMatrixInputM2
            // 
            this.ctlMatrixInputM2.Location = new System.Drawing.Point(5, 17);
            matrix2.X11 = float.NaN;
            matrix2.X12 = float.NaN;
            matrix2.X21 = float.NaN;
            matrix2.X22 = float.NaN;
            this.ctlMatrixInputM2.Matrix = matrix2;
            this.ctlMatrixInputM2.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMatrixInputM2.Name = "ctlMatrixInputM2";
            this.ctlMatrixInputM2.Size = new System.Drawing.Size(125, 89);
            this.ctlMatrixInputM2.TabIndex = 37;
            // 
            // FrmHinterLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 849);
            this.Controls.Add(this.grpDataOutput2);
            this.Controls.Add(this.grpDataOutput1);
            this.Controls.Add(this.txtResultOfTransf);
            this.Controls.Add(this.butGFx);
            this.Controls.Add(this.butGx);
            this.Controls.Add(this.grpDataInput2);
            this.Controls.Add(this.lblOutputCos2);
            this.Controls.Add(this.picMathEquBig);
            this.Controls.Add(this.picMathEquRight);
            this.Controls.Add(this.picMathEquLeft);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosOutput2);
            this.Controls.Add(this.cosOutput1);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.lblOutput1);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.grpDataInput1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHinterLinAbb";
            this.Text = "Hintereinanderausführung linearer Abbildungen";
            this.grpDataInput1.ResumeLayout(false);
            this.grpDataInput1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquBig)).EndInit();
            this.grpDataInput2.ResumeLayout(false);
            this.grpDataInput2.PerformLayout();
            this.grpDataOutput1.ResumeLayout(false);
            this.grpDataOutput2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.Label lblOutput1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox grpDataInput1;
        private System.Windows.Forms.TextBox txtDeterminante1;
        private System.Windows.Forms.Button butDeterminante1;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput1;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtVectorGx2;
        private System.Windows.Forms.PictureBox picMathEquLeft;
        private System.Windows.Forms.PictureBox picMathEquRight;
        private System.Windows.Forms.PictureBox picMathEquBig;
        private System.Windows.Forms.Label lblOutputCos2;
        private System.Windows.Forms.Button dutDeterminante;
        private System.Windows.Forms.GroupBox grpDataInput2;
        private System.Windows.Forms.Button butDeterminante2;
        private System.Windows.Forms.TextBox txtDeterminante2;
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
    }
}