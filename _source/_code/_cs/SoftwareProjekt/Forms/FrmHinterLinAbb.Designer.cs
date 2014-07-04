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
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
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
            this.butFx.Location = new System.Drawing.Point(516, 850);
            this.butFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(118, 34);
            this.butFx.TabIndex = 4;
            this.butFx.Text = "&Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDataInput1.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput1.Controls.Add(this.ctlMatrixInputM1);
            this.grpDataInput1.Location = new System.Drawing.Point(30, 801);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Size = new System.Drawing.Size(406, 138);
            this.grpDataInput1.TabIndex = 35;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe";
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Controlname = "Vektor x";
            this.ctlVectorInputX.Location = new System.Drawing.Point(8, 29);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(181, 94);
            this.ctlVectorInputX.TabIndex = 38;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector1;
            // 
            // ctlMatrixInputM1
            // 
            this.ctlMatrixInputM1.Controlname = "Matrix M1";
            this.ctlMatrixInputM1.Location = new System.Drawing.Point(199, 29);
            this.ctlMatrixInputM1.Margin = new System.Windows.Forms.Padding(5);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInputM1.Matrix = matrix1;
            this.ctlMatrixInputM1.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInputM1.Name = "ctlMatrixInputM1";
            this.ctlMatrixInputM1.Size = new System.Drawing.Size(190, 104);
            this.ctlMatrixInputM1.TabIndex = 37;
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
            this.cosInput.Location = new System.Drawing.Point(13, 397);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(483, 373);
            this.cosInput.TabIndex = 47;
            // 
            // cosOutput1
            // 
            this.cosOutput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cosOutput1.DoNotRefresh = false;
            this.cosOutput1.Location = new System.Drawing.Point(876, 361);
            this.cosOutput1.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput1.Name = "cosOutput1";
            this.cosOutput1.Size = new System.Drawing.Size(475, 409);
            this.cosOutput1.TabIndex = 48;
            // 
            // cosOutput2
            // 
            this.cosOutput2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput2.DoNotRefresh = false;
            this.cosOutput2.Location = new System.Drawing.Point(1766, 397);
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
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(839, 9);
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
            // grpDataInput2
            // 
            this.grpDataInput2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpDataInput2.Controls.Add(this.ctlMatrixInputM2);
            this.grpDataInput2.Location = new System.Drawing.Point(1025, 801);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Size = new System.Drawing.Size(233, 153);
            this.grpDataInput2.TabIndex = 58;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe";
            // 
            // ctlMatrixInputM2
            // 
            this.ctlMatrixInputM2.Controlname = "Matrix M2";
            this.ctlMatrixInputM2.Location = new System.Drawing.Point(8, 28);
            this.ctlMatrixInputM2.Margin = new System.Windows.Forms.Padding(5);
            matrix2.X11 = float.NaN;
            matrix2.X12 = float.NaN;
            matrix2.X21 = float.NaN;
            matrix2.X22 = float.NaN;
            this.ctlMatrixInputM2.Matrix = matrix2;
            this.ctlMatrixInputM2.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInputM2.Name = "ctlMatrixInputM2";
            this.ctlMatrixInputM2.Size = new System.Drawing.Size(205, 110);
            this.ctlMatrixInputM2.TabIndex = 37;
            // 
            // butGx
            // 
            this.butGx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butGx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGx.Location = new System.Drawing.Point(1441, 850);
            this.butGx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGx.Name = "butGx";
            this.butGx.Size = new System.Drawing.Size(121, 34);
            this.butGx.TabIndex = 7;
            this.butGx.Text = "&Berechne g(x)";
            this.butGx.UseVisualStyleBackColor = true;
            this.butGx.Click += new System.EventHandler(this.butGx_Click);
            // 
            // butGFx
            // 
            this.butGFx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butGFx.BackColor = System.Drawing.SystemColors.Highlight;
            this.butGFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGFx.Location = new System.Drawing.Point(1984, 838);
            this.butGFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGFx.Name = "butGFx";
            this.butGFx.Size = new System.Drawing.Size(174, 46);
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
            this.txtResultOfTransf.Location = new System.Drawing.Point(1946, 819);
            this.txtResultOfTransf.Name = "txtResultOfTransf";
            this.txtResultOfTransf.Size = new System.Drawing.Size(251, 18);
            this.txtResultOfTransf.TabIndex = 60;
            this.txtResultOfTransf.Text = "Gesamtergebnis der Transformation:";
            // 
            // grpDataOutput1
            // 
            this.grpDataOutput1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpDataOutput1.Controls.Add(this.ctlVectorOutputX1);
            this.grpDataOutput1.Location = new System.Drawing.Point(641, 801);
            this.grpDataOutput1.Margin = new System.Windows.Forms.Padding(4);
            this.grpDataOutput1.Name = "grpDataOutput1";
            this.grpDataOutput1.Padding = new System.Windows.Forms.Padding(4);
            this.grpDataOutput1.Size = new System.Drawing.Size(211, 137);
            this.grpDataOutput1.TabIndex = 61;
            this.grpDataOutput1.TabStop = false;
            this.grpDataOutput1.Text = "Zwischenergebnis ";
            // 
            // ctlVectorOutputX1
            // 
            this.ctlVectorOutputX1.Controlname = "Ergebnisvektor";
            this.ctlVectorOutputX1.Location = new System.Drawing.Point(8, 21);
            this.ctlVectorOutputX1.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorOutputX1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputX1.Name = "ctlVectorOutputX1";
            this.ctlVectorOutputX1.Size = new System.Drawing.Size(184, 103);
            this.ctlVectorOutputX1.TabIndex = 0;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorOutputX1.Vector = vector2;
            // 
            // grpDataOutput2
            // 
            this.grpDataOutput2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataOutput2.Controls.Add(this.ctlVectorOutputX2);
            this.grpDataOutput2.Location = new System.Drawing.Point(1569, 801);
            this.grpDataOutput2.Margin = new System.Windows.Forms.Padding(4);
            this.grpDataOutput2.Name = "grpDataOutput2";
            this.grpDataOutput2.Padding = new System.Windows.Forms.Padding(4);
            this.grpDataOutput2.Size = new System.Drawing.Size(189, 115);
            this.grpDataOutput2.TabIndex = 62;
            this.grpDataOutput2.TabStop = false;
            this.grpDataOutput2.Text = "Endergebnis";
            // 
            // ctlVectorOutputX2
            // 
            this.ctlVectorOutputX2.Controlname = "Ergenisvektor";
            this.ctlVectorOutputX2.Location = new System.Drawing.Point(8, 21);
            this.ctlVectorOutputX2.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorOutputX2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputX2.Name = "ctlVectorOutputX2";
            this.ctlVectorOutputX2.Size = new System.Drawing.Size(175, 94);
            this.ctlVectorOutputX2.TabIndex = 0;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorOutputX2.Vector = vector3;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(861, 40);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblNote.Location = new System.Drawing.Point(951, 993);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(71, 20);
            this.lblNote.TabIndex = 66;
            this.lblNote.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotes.Location = new System.Drawing.Point(955, 1017);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 65;
            this.rtxtNotes.Text = "";
            // 
            // ctlMathEquTotal
            // 
            this.ctlMathEquTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlMathEquTotal.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquTotal.Equation = "";
            this.ctlMathEquTotal.Filename = "w5ua4041.efj.tiff";
            this.ctlMathEquTotal.Filepath = "";
            this.ctlMathEquTotal.FontSize = 8;
            this.ctlMathEquTotal.Location = new System.Drawing.Point(944, 149);
            this.ctlMathEquTotal.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEquTotal.Name = "ctlMathEquTotal";
            this.ctlMathEquTotal.Size = new System.Drawing.Size(256, 115);
            this.ctlMathEquTotal.TabIndex = 67;
            // 
            // picArrowLeft
            // 
            this.picArrowLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picArrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.picArrowLeft.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowLeft.Location = new System.Drawing.Point(503, 447);
            this.picArrowLeft.Name = "picArrowLeft";
            this.picArrowLeft.Size = new System.Drawing.Size(349, 244);
            this.picArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowLeft.TabIndex = 68;
            this.picArrowLeft.TabStop = false;
            // 
            // picArrowRight
            // 
            this.picArrowRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picArrowRight.BackColor = System.Drawing.Color.Transparent;
            this.picArrowRight.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowRight.Location = new System.Drawing.Point(1368, 447);
            this.picArrowRight.Name = "picArrowRight";
            this.picArrowRight.Size = new System.Drawing.Size(349, 244);
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
            this.ctlMathEquLeft.FontSize = 8;
            this.ctlMathEquLeft.Location = new System.Drawing.Point(516, 527);
            this.ctlMathEquLeft.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEquLeft.Name = "ctlMathEquLeft";
            this.ctlMathEquLeft.Size = new System.Drawing.Size(211, 77);
            this.ctlMathEquLeft.TabIndex = 70;
            // 
            // ctlMathEquRight
            // 
            this.ctlMathEquRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ctlMathEquRight.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquRight.Equation = "";
            this.ctlMathEquRight.Filename = "trjeitwn.3w0.tiff";
            this.ctlMathEquRight.Filepath = "";
            this.ctlMathEquRight.FontSize = 8;
            this.ctlMathEquRight.Location = new System.Drawing.Point(1404, 539);
            this.ctlMathEquRight.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEquRight.Name = "ctlMathEquRight";
            this.ctlMathEquRight.Size = new System.Drawing.Size(187, 65);
            this.ctlMathEquRight.TabIndex = 71;
            // 
            // FrmHinterLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2276, 1182);
            this.Controls.Add(this.ctlMathEquRight);
            this.Controls.Add(this.ctlMathEquLeft);
            this.Controls.Add(this.picArrowRight);
            this.Controls.Add(this.picArrowLeft);
            this.Controls.Add(this.ctlMathEquTotal);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.rtxtNotes);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquTotal;
        private System.Windows.Forms.PictureBox picArrowLeft;
        private System.Windows.Forms.PictureBox picArrowRight;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquRight;
    }
}