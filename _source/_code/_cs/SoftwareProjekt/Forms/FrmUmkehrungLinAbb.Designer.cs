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
            this.cosLeft = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosRight = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.ctlMatrixInput1 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.lblPunktX = new System.Windows.Forms.Label();
            this.ctlVectorInput1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.butFx = new System.Windows.Forms.Button();
            this.butUmkehrFx = new System.Windows.Forms.Button();
            this.txtUmkerFx = new System.Windows.Forms.TextBox();
            this.grpDataInRight = new System.Windows.Forms.GroupBox();
            this.lblPunktY = new System.Windows.Forms.Label();
            this.ctlVectorInput2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUmkehrFy = new System.Windows.Forms.TextBox();
            this.ctlMathEquaRi2Le = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.ctlMathEquaLe2Ri = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInput.SuspendLayout();
            this.grpDataInRight.SuspendLayout();
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
            // cosLeft
            // 
            this.cosLeft.Location = new System.Drawing.Point(13, 292);
            this.cosLeft.Margin = new System.Windows.Forms.Padding(4);
            this.cosLeft.Name = "cosLeft";
            this.cosLeft.Size = new System.Drawing.Size(489, 389);
            this.cosLeft.TabIndex = 1;
            // 
            // cosRight
            // 
            this.cosRight.Location = new System.Drawing.Point(1028, 292);
            this.cosRight.Margin = new System.Windows.Forms.Padding(4);
            this.cosRight.Name = "cosRight";
            this.cosRight.Size = new System.Drawing.Size(489, 389);
            this.cosRight.TabIndex = 2;
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
            this.rtxtNotes.TextChanged += new System.EventHandler(this.rtxtNotes_TextChanged);
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
            this.lblOutput.Location = new System.Drawing.Point(958, 271);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(187, 17);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Ausgabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.txtDeterminante);
            this.grpDataInput.Controls.Add(this.butDeterminante);
            this.grpDataInput.Controls.Add(this.ctlMatrixInput1);
            this.grpDataInput.Controls.Add(this.lblPunktX);
            this.grpDataInput.Controls.Add(this.ctlVectorInput1);
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
            this.txtDeterminante.TextChanged += new System.EventHandler(this.txtDeterminante_TextChanged);
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
            // ctlMatrixInput1
            // 
            this.ctlMatrixInput1.Location = new System.Drawing.Point(172, 55);
            this.ctlMatrixInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInput1.Matrix = matrix1;
            this.ctlMatrixInput1.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInput1.Name = "ctlMatrixInput1";
            this.ctlMatrixInput1.Size = new System.Drawing.Size(154, 107);
            this.ctlMatrixInput1.TabIndex = 2;
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
            // ctlVectorInput1
            // 
            this.ctlVectorInput1.Location = new System.Drawing.Point(7, 55);
            this.ctlVectorInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInput1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInput1.Name = "ctlVectorInput1";
            this.ctlVectorInput1.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInput1.TabIndex = 1;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInput1.Vector = vector1;
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(901, 93);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(96, 60);
            this.butFx.TabIndex = 4;
            this.butFx.Text = "f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // butUmkehrFx
            // 
            this.butUmkehrFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUmkehrFx.Location = new System.Drawing.Point(901, 159);
            this.butUmkehrFx.Name = "butUmkehrFx";
            this.butUmkehrFx.Size = new System.Drawing.Size(96, 60);
            this.butUmkehrFx.TabIndex = 5;
            this.butUmkehrFx.Text = "f^-1(f(x)) ";
            this.butUmkehrFx.UseVisualStyleBackColor = true;
            this.butUmkehrFx.Click += new System.EventHandler(this.butUmkehrFx_Click);
            // 
            // txtUmkerFx
            // 
            this.txtUmkerFx.Location = new System.Drawing.Point(901, 220);
            this.txtUmkerFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUmkerFx.Name = "txtUmkerFx";
            this.txtUmkerFx.Size = new System.Drawing.Size(162, 22);
            this.txtUmkerFx.TabIndex = 67;
            this.txtUmkerFx.TextChanged += new System.EventHandler(this.txtUmkerFx_TextChanged);
            // 
            // grpDataInRight
            // 
            this.grpDataInRight.Controls.Add(this.lblPunktY);
            this.grpDataInRight.Controls.Add(this.ctlVectorInput2);
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
            // ctlVectorInput2
            // 
            this.ctlVectorInput2.Location = new System.Drawing.Point(7, 55);
            this.ctlVectorInput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInput2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInput2.Name = "ctlVectorInput2";
            this.ctlVectorInput2.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInput2.TabIndex = 6;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInput2.Vector = vector2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1311, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "f^-1(f(y)) ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUmkehrFy
            // 
            this.txtUmkehrFy.Location = new System.Drawing.Point(1311, 206);
            this.txtUmkehrFy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUmkehrFy.Name = "txtUmkehrFy";
            this.txtUmkehrFy.Size = new System.Drawing.Size(162, 22);
            this.txtUmkehrFy.TabIndex = 69;
            this.txtUmkehrFy.TextChanged += new System.EventHandler(this.txtUmkehrFy_TextChanged);
            // 
            // ctlMathEquaRi2Le
            // 
            this.ctlMathEquaRi2Le.Equation = "";
            this.ctlMathEquaRi2Le.Filename = "expr.gif";
            this.ctlMathEquaRi2Le.Filepath = "C:\\Program Files (x86)\\Microsoft Visual Studio 11.0\\Common7\\IDE";
            this.ctlMathEquaRi2Le.FontSize = 8;
            this.ctlMathEquaRi2Le.Location = new System.Drawing.Point(540, 340);
            this.ctlMathEquaRi2Le.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlMathEquaRi2Le.Name = "ctlMathEquaRi2Le";
            this.ctlMathEquaRi2Le.Size = new System.Drawing.Size(439, 113);
            this.ctlMathEquaRi2Le.TabIndex = 70;
            // 
            // ctlMathEquaLe2Ri
            // 
            this.ctlMathEquaLe2Ri.Equation = "";
            this.ctlMathEquaLe2Ri.Filename = "expr.gif";
            this.ctlMathEquaLe2Ri.Filepath = "C:\\Program Files (x86)\\Microsoft Visual Studio 11.0\\Common7\\IDE";
            this.ctlMathEquaLe2Ri.FontSize = 8;
            this.ctlMathEquaLe2Ri.Location = new System.Drawing.Point(540, 461);
            this.ctlMathEquaLe2Ri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlMathEquaLe2Ri.Name = "ctlMathEquaLe2Ri";
            this.ctlMathEquaLe2Ri.Size = new System.Drawing.Size(439, 113);
            this.ctlMathEquaLe2Ri.TabIndex = 71;
            // 
            // FrmUmkehrungLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 886);
            this.Controls.Add(this.ctlMathEquaLe2Ri);
            this.Controls.Add(this.ctlMathEquaRi2Le);
            this.Controls.Add(this.txtUmkehrFy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpDataInRight);
            this.Controls.Add(this.txtUmkerFx);
            this.Controls.Add(this.butUmkehrFx);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.grpDataInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosRight);
            this.Controls.Add(this.cosLeft);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUmkehrungLinAbb";
            this.Text = "Umkehrung einer linearen Abbildung";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.grpDataInRight.ResumeLayout(false);
            this.grpDataInRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private SoftwareProjekt.UserControls.CoordinateSystem cosLeft;
        private SoftwareProjekt.UserControls.CoordinateSystem cosRight;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Button butDeterminante;
        private UserControls.CtlMatrixInput ctlMatrixInput1;
        private System.Windows.Forms.Label lblPunktX;
        private UserControls.CtlVectorInput ctlVectorInput1;
        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.Button butUmkehrFx;
        private System.Windows.Forms.TextBox txtUmkerFx;
        private System.Windows.Forms.GroupBox grpDataInRight;
        private System.Windows.Forms.Label lblPunktY;
        private UserControls.CtlVectorInput ctlVectorInput2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUmkehrFy;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaRi2Le;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaLe2Ri;
    }
}