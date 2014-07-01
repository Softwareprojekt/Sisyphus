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
            SoftwareProjekt.Classes.Math.Matrix matrix4 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector4 = new SoftwareProjekt.Classes.Math.Vector();
            this.lblIn = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.ctlMatrixInput = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.txtFactorA = new System.Windows.Forms.TextBox();
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
            this.grpDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(169, 386);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(183, 17);
            this.lblIn.TabIndex = 31;
            this.lblIn.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.ctlMatrixInput);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Controls.Add(this.txtDeterminante);
            this.grpDataInput.Controls.Add(this.butDeterminante);
            this.grpDataInput.Controls.Add(this.txtFactorA);
            this.grpDataInput.Controls.Add(this.lblFactorA);
            this.grpDataInput.Location = new System.Drawing.Point(584, 57);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Size = new System.Drawing.Size(369, 273);
            this.grpDataInput.TabIndex = 29;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // ctlMatrixInput
            // 
            this.ctlMatrixInput.Location = new System.Drawing.Point(9, 153);
            this.ctlMatrixInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            matrix4.X11 = float.NaN;
            matrix4.X12 = float.NaN;
            matrix4.X21 = float.NaN;
            matrix4.X22 = float.NaN;
            this.ctlMatrixInput.Matrix = matrix4;
            this.ctlMatrixInput.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInput.Name = "ctlMatrixInput";
            this.ctlMatrixInput.Size = new System.Drawing.Size(164, 94);
            this.ctlMatrixInput.TabIndex = 3;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(9, 19);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(158, 98);
            this.ctlVectorInputX.TabIndex = 1;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector4;
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(205, 206);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante.MaxLength = 5;
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.ReadOnly = true;
            this.txtDeterminante.Size = new System.Drawing.Size(131, 22);
            this.txtDeterminante.TabIndex = 36;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(205, 168);
            this.butDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(131, 34);
            this.butDeterminante.TabIndex = 4;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            this.butDeterminante.Click += new System.EventHandler(this.butDeterminante_Click);
            // 
            // txtFactorA
            // 
            this.txtFactorA.Location = new System.Drawing.Point(244, 34);
            this.txtFactorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFactorA.Name = "txtFactorA";
            this.txtFactorA.Size = new System.Drawing.Size(76, 22);
            this.txtFactorA.TabIndex = 2;
            this.txtFactorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactorA_KeyPress);
            // 
            // lblFactorA
            // 
            this.lblFactorA.AutoSize = true;
            this.lblFactorA.Location = new System.Drawing.Point(174, 37);
            this.lblFactorA.Name = "lblFactorA";
            this.lblFactorA.Size = new System.Drawing.Size(64, 17);
            this.lblFactorA.TabIndex = 8;
            this.lblFactorA.Text = "Faktor a:";
            // 
            // butFunctionAMultX
            // 
            this.butFunctionAMultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionAMultX.Location = new System.Drawing.Point(717, 348);
            this.butFunctionAMultX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFunctionAMultX.Name = "butFunctionAMultX";
            this.butFunctionAMultX.Size = new System.Drawing.Size(131, 72);
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
            this.txtVectorAMultX.Size = new System.Drawing.Size(100, 22);
            this.txtVectorAMultX.TabIndex = 0;
            // 
            // txtVectorFX
            // 
            this.txtVectorFX.Location = new System.Drawing.Point(0, 0);
            this.txtVectorFX.Name = "txtVectorFX";
            this.txtVectorFX.Size = new System.Drawing.Size(100, 22);
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
            this.lblNotes.Location = new System.Drawing.Point(379, 862);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 38;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(382, 883);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 6;
            this.rtxtNotes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Thema: Lineare Abbildung mit vielfachen beliebigen Vektoren studieren";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(1303, 386);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(187, 17);
            this.lblOut.TabIndex = 40;
            this.lblOut.Text = "Ausgabekoordinatensystem:";
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(36, 424);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(493, 402);
            this.cosInput.TabIndex = 41;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(1112, 424);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(493, 402);
            this.cosOutput.TabIndex = 42;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(482, 424);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(603, 346);
            this.picBoxArrow.TabIndex = 50;
            this.picBoxArrow.TabStop = false;
            // 
            // picMathEquatCenter
            // 
            this.picMathEquatCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picMathEquatCenter.BackColor = System.Drawing.Color.Transparent;
            this.picMathEquatCenter.Location = new System.Drawing.Point(504, 516);
            this.picMathEquatCenter.Margin = new System.Windows.Forms.Padding(4);
            this.picMathEquatCenter.Name = "picMathEquatCenter";
            this.picMathEquatCenter.Size = new System.Drawing.Size(375, 142);
            this.picMathEquatCenter.TabIndex = 51;
            this.picMathEquatCenter.TabStop = false;
            // 
            // FrmLinAbbVielBelVek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 1045);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtFactorA;
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
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label label1;
        private UserControls.CtlMatrixInput ctlMatrixInput;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private System.Windows.Forms.Label lblOut;
        private UserControls.CoordinateSystem cosInput;
        private UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.PictureBox picBoxArrow;
        private System.Windows.Forms.PictureBox picMathEquatCenter;
    }
}