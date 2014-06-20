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
            this.butFx = new System.Windows.Forms.Button();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.grpDataInput1 = new System.Windows.Forms.GroupBox();
            this.ctlVecInX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.lblPointX = new System.Windows.Forms.Label();
            this.dutDeterminante = new System.Windows.Forms.Button();
            this.ctlMatrixInput1 = new SoftwareProjekt.UserControls.CtlMatrixInput();
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
            this.ctlMatrixInput2 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.txtDeterminante2 = new System.Windows.Forms.TextBox();
            this.butGx = new System.Windows.Forms.Button();
            this.butGFx = new System.Windows.Forms.Button();
            this.txtGFx = new System.Windows.Forms.TextBox();
            this.txtResultOfTransf = new System.Windows.Forms.Label();
            this.grpDataInput1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquBig)).BeginInit();
            this.grpDataInput2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(417, 152);
            this.butFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(107, 59);
            this.butFx.TabIndex = 4;
            this.butFx.Text = "f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Location = new System.Drawing.Point(896, 546);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(195, 17);
            this.lblOutput1.TabIndex = 40;
            this.lblOutput1.Text = "Ausgabekoordinatensystem1:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(181, 546);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(183, 17);
            this.lblInput.TabIndex = 37;
            this.lblInput.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Controls.Add(this.ctlVecInX);
            this.grpDataInput1.Controls.Add(this.lblPointX);
            this.grpDataInput1.Controls.Add(this.dutDeterminante);
            this.grpDataInput1.Controls.Add(this.ctlMatrixInput1);
            this.grpDataInput1.Controls.Add(this.txtDeterminante1);
            this.grpDataInput1.Location = new System.Drawing.Point(15, 106);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Size = new System.Drawing.Size(396, 218);
            this.grpDataInput1.TabIndex = 35;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe1";
            // 
            // ctlVecInX
            // 
            this.ctlVecInX.Location = new System.Drawing.Point(8, 43);
            this.ctlVecInX.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVecInX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVecInX.Name = "ctlVecInX";
            this.ctlVecInX.Size = new System.Drawing.Size(161, 102);
            this.ctlVecInX.TabIndex = 1;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVecInX.Vector = vector1;
            // 
            // lblPointX
            // 
            this.lblPointX.AutoSize = true;
            this.lblPointX.Location = new System.Drawing.Point(22, 21);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(59, 17);
            this.lblPointX.TabIndex = 58;
            this.lblPointX.Text = "Vektor x";
            // 
            // dutDeterminante
            // 
            this.dutDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dutDeterminante.Location = new System.Drawing.Point(208, 131);
            this.dutDeterminante.Name = "dutDeterminante";
            this.dutDeterminante.Size = new System.Drawing.Size(150, 46);
            this.dutDeterminante.TabIndex = 3;
            this.dutDeterminante.Text = "Determinante";
            this.dutDeterminante.UseVisualStyleBackColor = true;
            this.dutDeterminante.Click += new System.EventHandler(this.dutDeterminante_Click);
            // 
            // ctlMatrixInput1
            // 
            this.ctlMatrixInput1.Location = new System.Drawing.Point(208, 21);
            this.ctlMatrixInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInput1.Matrix = matrix1;
            this.ctlMatrixInput1.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInput1.Name = "ctlMatrixInput1";
            this.ctlMatrixInput1.Size = new System.Drawing.Size(150, 103);
            this.ctlMatrixInput1.TabIndex = 2;
            // 
            // txtDeterminante1
            // 
            this.txtDeterminante1.Location = new System.Drawing.Point(208, 182);
            this.txtDeterminante1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante1.MaxLength = 5;
            this.txtDeterminante1.Name = "txtDeterminante1";
            this.txtDeterminante1.ReadOnly = true;
            this.txtDeterminante1.Size = new System.Drawing.Size(150, 22);
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
            this.cosInput.Location = new System.Drawing.Point(16, 566);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(483, 373);
            this.cosInput.TabIndex = 47;
            // 
            // cosOutput1
            // 
            this.cosOutput1.Location = new System.Drawing.Point(777, 566);
            this.cosOutput1.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput1.Name = "cosOutput1";
            this.cosOutput1.Size = new System.Drawing.Size(475, 373);
            this.cosOutput1.TabIndex = 48;
            // 
            // cosOutput2
            // 
            this.cosOutput2.Location = new System.Drawing.Point(1503, 566);
            this.cosOutput2.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput2.Name = "cosOutput2";
            this.cosOutput2.Size = new System.Drawing.Size(497, 373);
            this.cosOutput2.TabIndex = 49;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(312, 1186);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 51;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(313, 1207);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 50;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(660, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(636, 29);
            this.lblHeader.TabIndex = 52;
            this.lblHeader.Text = "Thema: Hintereinanderausführung linearer Abbildungen";
            // 
            // txtVectorGx2
            // 
            this.txtVectorGx2.Location = new System.Drawing.Point(75, 53);
            this.txtVectorGx2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVectorGx2.Name = "txtVectorGx2";
            this.txtVectorGx2.Size = new System.Drawing.Size(52, 22);
            this.txtVectorGx2.TabIndex = 5;
            // 
            // picMathEquLeft
            // 
            this.picMathEquLeft.Location = new System.Drawing.Point(507, 673);
            this.picMathEquLeft.Margin = new System.Windows.Forms.Padding(4);
            this.picMathEquLeft.Name = "picMathEquLeft";
            this.picMathEquLeft.Size = new System.Drawing.Size(263, 149);
            this.picMathEquLeft.TabIndex = 53;
            this.picMathEquLeft.TabStop = false;
            // 
            // picMathEquRight
            // 
            this.picMathEquRight.Location = new System.Drawing.Point(1232, 673);
            this.picMathEquRight.Margin = new System.Windows.Forms.Padding(4);
            this.picMathEquRight.Name = "picMathEquRight";
            this.picMathEquRight.Size = new System.Drawing.Size(263, 149);
            this.picMathEquRight.TabIndex = 54;
            this.picMathEquRight.TabStop = false;
            // 
            // picMathEquBig
            // 
            this.picMathEquBig.Location = new System.Drawing.Point(299, 380);
            this.picMathEquBig.Margin = new System.Windows.Forms.Padding(4);
            this.picMathEquBig.Name = "picMathEquBig";
            this.picMathEquBig.Size = new System.Drawing.Size(1033, 114);
            this.picMathEquBig.TabIndex = 55;
            this.picMathEquBig.TabStop = false;
            // 
            // lblOutputCos2
            // 
            this.lblOutputCos2.AutoSize = true;
            this.lblOutputCos2.Location = new System.Drawing.Point(1684, 546);
            this.lblOutputCos2.Name = "lblOutputCos2";
            this.lblOutputCos2.Size = new System.Drawing.Size(195, 17);
            this.lblOutputCos2.TabIndex = 56;
            this.lblOutputCos2.Text = "Ausgabekoordinatensystem2:";
            // 
            // grpDataInput2
            // 
            this.grpDataInput2.Controls.Add(this.butDeterminante2);
            this.grpDataInput2.Controls.Add(this.ctlMatrixInput2);
            this.grpDataInput2.Controls.Add(this.txtDeterminante2);
            this.grpDataInput2.Location = new System.Drawing.Point(615, 106);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Size = new System.Drawing.Size(396, 151);
            this.grpDataInput2.TabIndex = 58;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe2";
            // 
            // butDeterminante2
            // 
            this.butDeterminante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante2.Location = new System.Drawing.Point(199, 31);
            this.butDeterminante2.Name = "butDeterminante2";
            this.butDeterminante2.Size = new System.Drawing.Size(150, 46);
            this.butDeterminante2.TabIndex = 6;
            this.butDeterminante2.Text = "Determinante";
            this.butDeterminante2.UseVisualStyleBackColor = true;
            this.butDeterminante2.Click += new System.EventHandler(this.butDeterminante2_Click);
            // 
            // ctlMatrixInput2
            // 
            this.ctlMatrixInput2.Location = new System.Drawing.Point(21, 31);
            this.ctlMatrixInput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            matrix2.X11 = float.NaN;
            matrix2.X12 = float.NaN;
            matrix2.X21 = float.NaN;
            matrix2.X22 = float.NaN;
            this.ctlMatrixInput2.Matrix = matrix2;
            this.ctlMatrixInput2.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInput2.Name = "ctlMatrixInput2";
            this.ctlMatrixInput2.Size = new System.Drawing.Size(150, 103);
            this.ctlMatrixInput2.TabIndex = 5;
            // 
            // txtDeterminante2
            // 
            this.txtDeterminante2.Location = new System.Drawing.Point(199, 82);
            this.txtDeterminante2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante2.MaxLength = 5;
            this.txtDeterminante2.Name = "txtDeterminante2";
            this.txtDeterminante2.ReadOnly = true;
            this.txtDeterminante2.Size = new System.Drawing.Size(150, 22);
            this.txtDeterminante2.TabIndex = 36;
            // 
            // butGx
            // 
            this.butGx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGx.Location = new System.Drawing.Point(1017, 152);
            this.butGx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGx.Name = "butGx";
            this.butGx.Size = new System.Drawing.Size(107, 59);
            this.butGx.TabIndex = 7;
            this.butGx.Text = "g(x)";
            this.butGx.UseVisualStyleBackColor = true;
            this.butGx.Click += new System.EventHandler(this.butGx_Click);
            // 
            // butGFx
            // 
            this.butGFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGFx.Location = new System.Drawing.Point(737, 289);
            this.butGFx.Name = "butGFx";
            this.butGFx.Size = new System.Drawing.Size(150, 46);
            this.butGFx.TabIndex = 8;
            this.butGFx.Text = "g(f(x))";
            this.butGFx.UseVisualStyleBackColor = true;
            this.butGFx.Click += new System.EventHandler(this.butGFx_Click);
            // 
            // txtGFx
            // 
            this.txtGFx.Location = new System.Drawing.Point(705, 340);
            this.txtGFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGFx.Name = "txtGFx";
            this.txtGFx.Size = new System.Drawing.Size(204, 22);
            this.txtGFx.TabIndex = 58;
            this.txtGFx.TextChanged += new System.EventHandler(this.txtGFx_TextChanged);
            // 
            // txtResultOfTransf
            // 
            this.txtResultOfTransf.AutoSize = true;
            this.txtResultOfTransf.Location = new System.Drawing.Point(720, 269);
            this.txtResultOfTransf.Name = "txtResultOfTransf";
            this.txtResultOfTransf.Size = new System.Drawing.Size(193, 17);
            this.txtResultOfTransf.TabIndex = 60;
            this.txtResultOfTransf.Text = "Ergebnis der Transformation:";
            // 
            // FrmHinterLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1045);
            this.Controls.Add(this.txtResultOfTransf);
            this.Controls.Add(this.txtGFx);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHinterLinAbb";
            this.Text = "Hintereinanderausführung linearer Abbildungen";
            this.grpDataInput1.ResumeLayout(false);
            this.grpDataInput1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquBig)).EndInit();
            this.grpDataInput2.ResumeLayout(false);
            this.grpDataInput2.PerformLayout();
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
        private UserControls.CtlMatrixInput ctlMatrixInput1;
        private System.Windows.Forms.GroupBox grpDataInput2;
        private System.Windows.Forms.Button butDeterminante2;
        private UserControls.CtlMatrixInput ctlMatrixInput2;
        private System.Windows.Forms.TextBox txtDeterminante2;
        private System.Windows.Forms.Button butGx;
        private System.Windows.Forms.Button butGFx;
        private System.Windows.Forms.TextBox txtGFx;
        private System.Windows.Forms.Label txtResultOfTransf;
        private UserControls.CtlVectorInput ctlVecInX;
        private System.Windows.Forms.Label lblPointX;
    }
}