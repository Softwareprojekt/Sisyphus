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
            SoftwareProjekt.Classes.Math.Vector vector4 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix3 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Matrix matrix4 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector5 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector6 = new SoftwareProjekt.Classes.Math.Vector();
            this.butFx = new System.Windows.Forms.Button();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.grpDataInput1 = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlMatrixInputM1 = new SoftwareProjekt.UserControls.CtlMatrixInput();
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
            this.lblOutputCos2 = new System.Windows.Forms.Label();
            this.grpDataInput2 = new System.Windows.Forms.GroupBox();
            this.ctlMatrixInputM2 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.butDeterminante2 = new System.Windows.Forms.Button();
            this.txtDeterminante2 = new System.Windows.Forms.TextBox();
            this.butGx = new System.Windows.Forms.Button();
            this.butGFx = new System.Windows.Forms.Button();
            this.txtResultOfTransf = new System.Windows.Forms.Label();
            this.grpDataOutput1 = new System.Windows.Forms.GroupBox();
            this.ctlVectorOutputX1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.grpDataOutput2 = new System.Windows.Forms.GroupBox();
            this.ctlVectorOutputX2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this.picMathEquBig = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpDataInput1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquRight)).BeginInit();
            this.grpDataInput2.SuspendLayout();
            this.grpDataOutput1.SuspendLayout();
            this.grpDataOutput2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquBig)).BeginInit();
            this.SuspendLayout();
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(587, 116);
            this.butFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(107, 59);
            this.butFx.TabIndex = 4;
            this.butFx.Text = "&Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Location = new System.Drawing.Point(1002, 495);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(195, 17);
            this.lblOutput1.TabIndex = 40;
            this.lblOutput1.Text = "Ausgabekoordinatensystem1:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(196, 495);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(183, 17);
            this.lblInput.TabIndex = 37;
            this.lblInput.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput1.Controls.Add(this.ctlMatrixInputM1);
            this.grpDataInput1.Controls.Add(this.dutDeterminante);
            this.grpDataInput1.Controls.Add(this.txtDeterminante1);
            this.grpDataInput1.Location = new System.Drawing.Point(16, 68);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Size = new System.Drawing.Size(565, 137);
            this.grpDataInput1.TabIndex = 35;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe1";
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(7, 31);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(181, 94);
            this.ctlVectorInputX.TabIndex = 38;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector4;
            // 
            // ctlMatrixInputM1
            // 
            this.ctlMatrixInputM1.Location = new System.Drawing.Point(196, 21);
            this.ctlMatrixInputM1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            matrix3.X11 = float.NaN;
            matrix3.X12 = float.NaN;
            matrix3.X21 = float.NaN;
            matrix3.X22 = float.NaN;
            this.ctlMatrixInputM1.Matrix = matrix3;
            this.ctlMatrixInputM1.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInputM1.Name = "ctlMatrixInputM1";
            this.ctlMatrixInputM1.Size = new System.Drawing.Size(167, 110);
            this.ctlMatrixInputM1.TabIndex = 37;
            // 
            // dutDeterminante
            // 
            this.dutDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dutDeterminante.Location = new System.Drawing.Point(385, 31);
            this.dutDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dutDeterminante.Name = "dutDeterminante";
            this.dutDeterminante.Size = new System.Drawing.Size(149, 46);
            this.dutDeterminante.TabIndex = 3;
            this.dutDeterminante.Text = "Determinante";
            this.dutDeterminante.UseVisualStyleBackColor = true;
            this.dutDeterminante.Click += new System.EventHandler(this.dutDeterminante_Click);
            // 
            // txtDeterminante1
            // 
            this.txtDeterminante1.Location = new System.Drawing.Point(383, 82);
            this.txtDeterminante1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante1.MaxLength = 5;
            this.txtDeterminante1.Name = "txtDeterminante1";
            this.txtDeterminante1.ReadOnly = true;
            this.txtDeterminante1.Size = new System.Drawing.Size(151, 22);
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
            this.cosInput.Location = new System.Drawing.Point(37, 516);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(483, 373);
            this.cosInput.TabIndex = 47;
            // 
            // cosOutput1
            // 
            this.cosOutput1.Location = new System.Drawing.Point(792, 516);
            this.cosOutput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosOutput1.Name = "cosOutput1";
            this.cosOutput1.Size = new System.Drawing.Size(475, 373);
            this.cosOutput1.TabIndex = 48;
            // 
            // cosOutput2
            // 
            this.cosOutput2.Location = new System.Drawing.Point(1493, 516);
            this.cosOutput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.picMathEquLeft.Location = new System.Drawing.Point(514, 597);
            this.picMathEquLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picMathEquLeft.Name = "picMathEquLeft";
            this.picMathEquLeft.Size = new System.Drawing.Size(263, 149);
            this.picMathEquLeft.TabIndex = 53;
            this.picMathEquLeft.TabStop = false;
            // 
            // picMathEquRight
            // 
            this.picMathEquRight.Location = new System.Drawing.Point(1222, 597);
            this.picMathEquRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picMathEquRight.Name = "picMathEquRight";
            this.picMathEquRight.Size = new System.Drawing.Size(263, 149);
            this.picMathEquRight.TabIndex = 54;
            this.picMathEquRight.TabStop = false;
            // 
            // lblOutputCos2
            // 
            this.lblOutputCos2.AutoSize = true;
            this.lblOutputCos2.Location = new System.Drawing.Point(1678, 495);
            this.lblOutputCos2.Name = "lblOutputCos2";
            this.lblOutputCos2.Size = new System.Drawing.Size(195, 17);
            this.lblOutputCos2.TabIndex = 56;
            this.lblOutputCos2.Text = "Ausgabekoordinatensystem2:";
            // 
            // grpDataInput2
            // 
            this.grpDataInput2.Controls.Add(this.ctlMatrixInputM2);
            this.grpDataInput2.Controls.Add(this.butDeterminante2);
            this.grpDataInput2.Controls.Add(this.txtDeterminante2);
            this.grpDataInput2.Location = new System.Drawing.Point(16, 223);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Size = new System.Drawing.Size(396, 115);
            this.grpDataInput2.TabIndex = 58;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe2";
            // 
            // ctlMatrixInputM2
            // 
            this.ctlMatrixInputM2.Location = new System.Drawing.Point(7, 21);
            this.ctlMatrixInputM2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            matrix4.X11 = float.NaN;
            matrix4.X12 = float.NaN;
            matrix4.X21 = float.NaN;
            matrix4.X22 = float.NaN;
            this.ctlMatrixInputM2.Matrix = matrix4;
            this.ctlMatrixInputM2.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInputM2.Name = "ctlMatrixInputM2";
            this.ctlMatrixInputM2.Size = new System.Drawing.Size(167, 110);
            this.ctlMatrixInputM2.TabIndex = 37;
            // 
            // butDeterminante2
            // 
            this.butDeterminante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante2.Location = new System.Drawing.Point(199, 31);
            this.butDeterminante2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeterminante2.Name = "butDeterminante2";
            this.butDeterminante2.Size = new System.Drawing.Size(149, 46);
            this.butDeterminante2.TabIndex = 6;
            this.butDeterminante2.Text = "Determinante";
            this.butDeterminante2.UseVisualStyleBackColor = true;
            this.butDeterminante2.Click += new System.EventHandler(this.butDeterminante2_Click);
            // 
            // txtDeterminante2
            // 
            this.txtDeterminante2.Location = new System.Drawing.Point(199, 82);
            this.txtDeterminante2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante2.MaxLength = 5;
            this.txtDeterminante2.Name = "txtDeterminante2";
            this.txtDeterminante2.ReadOnly = true;
            this.txtDeterminante2.Size = new System.Drawing.Size(151, 22);
            this.txtDeterminante2.TabIndex = 36;
            // 
            // butGx
            // 
            this.butGx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGx.Location = new System.Drawing.Point(587, 249);
            this.butGx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGx.Name = "butGx";
            this.butGx.Size = new System.Drawing.Size(107, 59);
            this.butGx.TabIndex = 7;
            this.butGx.Text = "&Berechne g(x)";
            this.butGx.UseVisualStyleBackColor = true;
            this.butGx.Click += new System.EventHandler(this.butGx_Click);
            // 
            // butGFx
            // 
            this.butGFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGFx.Location = new System.Drawing.Point(1147, 89);
            this.butGFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGFx.Name = "butGFx";
            this.butGFx.Size = new System.Drawing.Size(149, 56);
            this.butGFx.TabIndex = 8;
            this.butGFx.Text = "&Berechne g(f(x))";
            this.butGFx.UseVisualStyleBackColor = true;
            this.butGFx.Click += new System.EventHandler(this.butGFx_Click);
            // 
            // txtResultOfTransf
            // 
            this.txtResultOfTransf.AutoSize = true;
            this.txtResultOfTransf.Location = new System.Drawing.Point(1128, 70);
            this.txtResultOfTransf.Name = "txtResultOfTransf";
            this.txtResultOfTransf.Size = new System.Drawing.Size(193, 17);
            this.txtResultOfTransf.TabIndex = 60;
            this.txtResultOfTransf.Text = "Ergebnis der Transformation:";
            // 
            // grpDataOutput1
            // 
            this.grpDataOutput1.Controls.Add(this.ctlVectorOutputX1);
            this.grpDataOutput1.Location = new System.Drawing.Point(700, 68);
            this.grpDataOutput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDataOutput1.Name = "grpDataOutput1";
            this.grpDataOutput1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDataOutput1.Size = new System.Drawing.Size(211, 137);
            this.grpDataOutput1.TabIndex = 61;
            this.grpDataOutput1.TabStop = false;
            this.grpDataOutput1.Text = "Datenausgabe1";
            // 
            // ctlVectorOutputX1
            // 
            this.ctlVectorOutputX1.Location = new System.Drawing.Point(8, 21);
            this.ctlVectorOutputX1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctlVectorOutputX1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputX1.Name = "ctlVectorOutputX1";
            this.ctlVectorOutputX1.Size = new System.Drawing.Size(184, 103);
            this.ctlVectorOutputX1.TabIndex = 0;
            vector5.X1 = float.NaN;
            vector5.X2 = float.NaN;
            this.ctlVectorOutputX1.Vector = vector5;
            // 
            // grpDataOutput2
            // 
            this.grpDataOutput2.Controls.Add(this.ctlVectorOutputX2);
            this.grpDataOutput2.Location = new System.Drawing.Point(703, 223);
            this.grpDataOutput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDataOutput2.Name = "grpDataOutput2";
            this.grpDataOutput2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDataOutput2.Size = new System.Drawing.Size(189, 115);
            this.grpDataOutput2.TabIndex = 62;
            this.grpDataOutput2.TabStop = false;
            this.grpDataOutput2.Text = "Datenausgabe2";
            // 
            // ctlVectorOutputX2
            // 
            this.ctlVectorOutputX2.Location = new System.Drawing.Point(8, 21);
            this.ctlVectorOutputX2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctlVectorOutputX2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputX2.Name = "ctlVectorOutputX2";
            this.ctlVectorOutputX2.Size = new System.Drawing.Size(175, 94);
            this.ctlVectorOutputX2.TabIndex = 0;
            vector6.X1 = float.NaN;
            vector6.X2 = float.NaN;
            this.ctlVectorOutputX2.Vector = vector6;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(943, 163);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(569, 330);
            this.picBoxArrow.TabIndex = 63;
            this.picBoxArrow.TabStop = false;
            // 
            // picMathEquBig
            // 
            this.picMathEquBig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picMathEquBig.BackColor = System.Drawing.Color.Transparent;
            this.picMathEquBig.Location = new System.Drawing.Point(962, 254);
            this.picMathEquBig.Margin = new System.Windows.Forms.Padding(4);
            this.picMathEquBig.Name = "picMathEquBig";
            this.picMathEquBig.Size = new System.Drawing.Size(375, 147);
            this.picMathEquBig.TabIndex = 64;
            this.picMathEquBig.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 885);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Notizen:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(618, 906);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(636, 152);
            this.richTextBox1.TabIndex = 65;
            this.richTextBox1.Text = "";
            // 
            // FrmHinterLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1057);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.picMathEquBig);
            this.Controls.Add(this.picBoxArrow);
            this.Controls.Add(this.grpDataOutput2);
            this.Controls.Add(this.grpDataOutput1);
            this.Controls.Add(this.txtResultOfTransf);
            this.Controls.Add(this.butGFx);
            this.Controls.Add(this.butGx);
            this.Controls.Add(this.grpDataInput2);
            this.Controls.Add(this.lblOutputCos2);
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
            this.grpDataInput2.ResumeLayout(false);
            this.grpDataInput2.PerformLayout();
            this.grpDataOutput1.ResumeLayout(false);
            this.grpDataOutput2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquBig)).EndInit();
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
        private System.Windows.Forms.PictureBox picBoxArrow;
        private System.Windows.Forms.PictureBox picMathEquBig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}