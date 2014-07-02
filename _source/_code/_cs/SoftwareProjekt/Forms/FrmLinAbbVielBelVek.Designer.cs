namespace SoftwareProjekt.Forms
{
    partial class FrmLinAbbVielBelVek
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
            this.lblIn = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.ctlMatrixInput = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.lblFactorA = new System.Windows.Forms.Label();
            this.butFunctionAMultX = new System.Windows.Forms.Button();
            this.grpAusgabe = new System.Windows.Forms.GroupBox();
            this.txtVectorAMultX = new System.Windows.Forms.TextBox();
            this.txtVectorFX = new System.Windows.Forms.TextBox();
            this.lblVectorAMultX = new System.Windows.Forms.Label();
            this.lblVectorFX = new System.Windows.Forms.Label();
            this.coordinateSystem1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.coordinateSystem2 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this.picMathEquatCenter = new System.Windows.Forms.PictureBox();
            this._ctlScalarInput = new SoftwareProjekt.UserControls.FloatInput();
            this.grpDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(127, 314);
            this.lblIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(137, 13);
            this.lblIn.TabIndex = 31;
            this.lblIn.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this._ctlScalarInput);
            this.grpDataInput.Controls.Add(this.ctlMatrixInput);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Controls.Add(this.txtDeterminante);
            this.grpDataInput.Controls.Add(this.butDeterminante);
            this.grpDataInput.Controls.Add(this.lblFactorA);
            this.grpDataInput.Location = new System.Drawing.Point(438, 46);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput.Size = new System.Drawing.Size(277, 222);
            this.grpDataInput.TabIndex = 29;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // ctlMatrixInput
            // 
            this.ctlMatrixInput.Location = new System.Drawing.Point(7, 124);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInput.Matrix = matrix1;
            this.ctlMatrixInput.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMatrixInput.Name = "ctlMatrixInput";
            this.ctlMatrixInput.Size = new System.Drawing.Size(123, 76);
            this.ctlMatrixInput.TabIndex = 3;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(7, 15);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(118, 80);
            this.ctlVectorInputX.TabIndex = 1;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector1;
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(154, 167);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeterminante.MaxLength = 5;
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.ReadOnly = true;
            this.txtDeterminante.Size = new System.Drawing.Size(99, 20);
            this.txtDeterminante.TabIndex = 36;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(154, 136);
            this.butDeterminante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(98, 28);
            this.butDeterminante.TabIndex = 4;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            this.butDeterminante.Click += new System.EventHandler(this.butDeterminante_Click);
            // 
            // lblFactorA
            // 
            this.lblFactorA.AutoSize = true;
            this.lblFactorA.Location = new System.Drawing.Point(130, 30);
            this.lblFactorA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactorA.Name = "lblFactorA";
            this.lblFactorA.Size = new System.Drawing.Size(49, 13);
            this.lblFactorA.TabIndex = 8;
            this.lblFactorA.Text = "Faktor a:";
            // 
            // butFunctionAMultX
            // 
            this.butFunctionAMultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionAMultX.Location = new System.Drawing.Point(538, 283);
            this.butFunctionAMultX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butFunctionAMultX.Name = "butFunctionAMultX";
            this.butFunctionAMultX.Size = new System.Drawing.Size(98, 58);
            this.butFunctionAMultX.TabIndex = 5;
            this.butFunctionAMultX.Text = "&Berechne f(a*x)";
            this.butFunctionAMultX.UseVisualStyleBackColor = true;
            this.butFunctionAMultX.Click += new System.EventHandler(this.butFunctionAMultX_Click);
            // 
            // grpAusgabe
            // 
            this.grpAusgabe.Location = new System.Drawing.Point(0, 0);
            this.grpAusgabe.Name = "grpAusgabe";
            this.grpAusgabe.Size = new System.Drawing.Size(200, 100);
            this.grpAusgabe.TabIndex = 0;
            this.grpAusgabe.TabStop = false;
            // 
            // txtVectorAMultX
            // 
            this.txtVectorAMultX.Location = new System.Drawing.Point(0, 0);
            this.txtVectorAMultX.Name = "txtVectorAMultX";
            this.txtVectorAMultX.Size = new System.Drawing.Size(100, 20);
            this.txtVectorAMultX.TabIndex = 0;
            // 
            // txtVectorFX
            // 
            this.txtVectorFX.Location = new System.Drawing.Point(0, 0);
            this.txtVectorFX.Name = "txtVectorFX";
            this.txtVectorFX.Size = new System.Drawing.Size(100, 20);
            this.txtVectorFX.TabIndex = 0;
            // 
            // lblVectorAMultX
            // 
            this.lblVectorAMultX.Location = new System.Drawing.Point(0, 0);
            this.lblVectorAMultX.Name = "lblVectorAMultX";
            this.lblVectorAMultX.Size = new System.Drawing.Size(100, 23);
            this.lblVectorAMultX.TabIndex = 0;
            // 
            // lblVectorFX
            // 
            this.lblVectorFX.Location = new System.Drawing.Point(0, 0);
            this.lblVectorFX.Name = "lblVectorFX";
            this.lblVectorFX.Size = new System.Drawing.Size(100, 23);
            this.lblVectorFX.TabIndex = 0;
            // 
            // coordinateSystem1
            // 
            this.coordinateSystem1.Location = new System.Drawing.Point(0, 0);
            this.coordinateSystem1.Name = "coordinateSystem1";
            this.coordinateSystem1.Size = new System.Drawing.Size(150, 150);
            this.coordinateSystem1.TabIndex = 0;
            // 
            // coordinateSystem2
            // 
            this.coordinateSystem2.Location = new System.Drawing.Point(0, 0);
            this.coordinateSystem2.Name = "coordinateSystem2";
            this.coordinateSystem2.Size = new System.Drawing.Size(150, 150);
            this.coordinateSystem2.TabIndex = 0;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(284, 700);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 38;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(286, 717);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this.rtxtNotes.TabIndex = 6;
            this.rtxtNotes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Thema: Lineare Abbildung mit vielfachen beliebigen Vektoren studieren";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(977, 314);
            this.lblOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(140, 13);
            this.lblOut.TabIndex = 40;
            this.lblOut.Text = "Ausgabekoordinatensystem:";
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(27, 344);
            this.cosInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(370, 327);
            this.cosInput.TabIndex = 41;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(834, 344);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(370, 327);
            this.cosOutput.TabIndex = 42;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(362, 344);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(452, 281);
            this.picBoxArrow.TabIndex = 50;
            this.picBoxArrow.TabStop = false;
            // 
            // picMathEquatCenter
            // 
            this.picMathEquatCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picMathEquatCenter.BackColor = System.Drawing.Color.Transparent;
            this.picMathEquatCenter.Location = new System.Drawing.Point(378, 419);
            this.picMathEquatCenter.Name = "picMathEquatCenter";
            this.picMathEquatCenter.Size = new System.Drawing.Size(281, 115);
            this.picMathEquatCenter.TabIndex = 51;
            this.picMathEquatCenter.TabStop = false;
            // 
            // _ctlScalarInput
            // 
            this._ctlScalarInput.BackColor = System.Drawing.Color.Red;
            this._ctlScalarInput.Location = new System.Drawing.Point(184, 27);
            this._ctlScalarInput.Name = "_ctlScalarInput";
            this._ctlScalarInput.Size = new System.Drawing.Size(68, 20);
            this._ctlScalarInput.TabIndex = 37;
            // 
            // FrmLinAbbVielBelVek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 849);
            this.Controls.Add(this.picMathEquatCenter);
            this.Controls.Add(this.picBoxArrow);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.butFunctionAMultX);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.grpDataInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLinAbbVielBelVek";
            this.Text = "FrmLinAbbVielBelVek";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.Button butFunctionAMultX;
        private System.Windows.Forms.Label lblFactorA;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Button butDeterminante;
        private System.Windows.Forms.GroupBox grpAusgabe;
        private System.Windows.Forms.TextBox txtVectorAMultX;
        private System.Windows.Forms.TextBox txtVectorFX;
        private System.Windows.Forms.Label lblVectorAMultX;
        private System.Windows.Forms.Label lblVectorFX;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem1;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label label1;
        private UserControls.CtlMatrixInput ctlMatrixInput;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private System.Windows.Forms.Label lblOut;
        private UserControls.CoordinateSystem cosInput;
        private UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.PictureBox picBoxArrow;
        private System.Windows.Forms.PictureBox picMathEquatCenter;
        private UserControls.FloatInput _ctlScalarInput;
    }
}