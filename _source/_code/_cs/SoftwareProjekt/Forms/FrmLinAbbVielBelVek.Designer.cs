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
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this._ctlScalarInput = new SoftwareProjekt.UserControls.FloatInput();
            this.ctlMatrixInput = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this._ctlScalarInput);
            this.grpDataInput.Controls.Add(this.ctlMatrixInput);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Controls.Add(this.lblFactorA);
            this.grpDataInput.Location = new System.Drawing.Point(50, 653);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Size = new System.Drawing.Size(392, 194);
            this.grpDataInput.TabIndex = 4;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // _ctlScalarInput
            // 
            this._ctlScalarInput.BackColor = System.Drawing.Color.Red;
            this._ctlScalarInput.Location = new System.Drawing.Point(111, 151);
            this._ctlScalarInput.Margin = new System.Windows.Forms.Padding(4);
            this._ctlScalarInput.Name = "_ctlScalarInput";
            this._ctlScalarInput.Size = new System.Drawing.Size(89, 22);
            this._ctlScalarInput.TabIndex = 3;
            // 
            // ctlMatrixInput
            // 
            this.ctlMatrixInput.Text = "Matrix Input";
            this.ctlMatrixInput.Location = new System.Drawing.Point(195, 22);
            this.ctlMatrixInput.Margin = new System.Windows.Forms.Padding(5);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMatrixInput.Matrix = matrix1;
            this.ctlMatrixInput.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMatrixInput.Name = "ctlMatrixInput";
            this.ctlMatrixInput.Size = new System.Drawing.Size(164, 127);
            this.ctlMatrixInput.TabIndex = 1;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Text = "Vector Input";
            this.ctlVectorInputX.Location = new System.Drawing.Point(16, 22);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(169, 127);
            this.ctlVectorInputX.TabIndex = 0;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector1;
            // 
            // lblFactorA
            // 
            this.lblFactorA.AutoSize = true;
            this.lblFactorA.Location = new System.Drawing.Point(13, 154);
            this.lblFactorA.Name = "lblFactorA";
            this.lblFactorA.Size = new System.Drawing.Size(91, 17);
            this.lblFactorA.TabIndex = 2;
            this.lblFactorA.Text = "Faktor alpha:";
            // 
            // butFunctionAMultX
            // 
            this.butFunctionAMultX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFunctionAMultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionAMultX.Location = new System.Drawing.Point(857, 653);
            this.butFunctionAMultX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFunctionAMultX.Name = "butFunctionAMultX";
            this.butFunctionAMultX.Size = new System.Drawing.Size(173, 36);
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
            this.coordinateSystem1.DoNotRefresh = false;
            this.coordinateSystem1.Location = new System.Drawing.Point(0, 0);
            this.coordinateSystem1.Name = "coordinateSystem1";
            this.coordinateSystem1.Size = new System.Drawing.Size(150, 150);
            this.coordinateSystem1.TabIndex = 0;
            // 
            // coordinateSystem2
            // 
            this.coordinateSystem2.DoNotRefresh = false;
            this.coordinateSystem2.Location = new System.Drawing.Point(0, 0);
            this.coordinateSystem2.Name = "coordinateSystem2";
            this.coordinateSystem2.Size = new System.Drawing.Size(150, 150);
            this.coordinateSystem2.TabIndex = 0;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(703, 832);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(71, 20);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notizen:";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(507, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(816, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Lineare Abbildung mit vielfachen beliebigen Vektoren studieren";
            // 
            // cosInput
            // 
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(12, 211);
            this.cosInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(493, 402);
            this.cosInput.TabIndex = 1;
            // 
            // cosOutput
            // 
            this.cosOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(1335, 202);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(493, 402);
            this.cosOutput.TabIndex = 3;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(638, 224);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(562, 330);
            this.picBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxArrow.TabIndex = 50;
            this.picBoxArrow.TabStop = false;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rtxtNotes.Location = new System.Drawing.Point(707, 855);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(462, 166);
            this.rtxtNotes.TabIndex = 7;
            this.rtxtNotes.Text = "";
            // 
            // ctlMathEqua
            // 
            this.ctlMathEqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEqua.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEqua.Equation = "";
            this.ctlMathEqua.Filename = "0o3ot0te.0fx.tiff";
            this.ctlMathEqua.Filepath = "";
            this.ctlMathEqua.FontSize = 8;
            this.ctlMathEqua.Location = new System.Drawing.Point(733, 346);
            this.ctlMathEqua.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEqua.Name = "ctlMathEqua";
            this.ctlMathEqua.Size = new System.Drawing.Size(243, 81);
            this.ctlMathEqua.TabIndex = 2;
            // 
            // FrmLinAbbVielBelVek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 1045);
            this.Controls.Add(this.ctlMathEqua);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.butFunctionAMultX);
            this.Controls.Add(this.grpDataInput);
            this.Controls.Add(this.picBoxArrow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLinAbbVielBelVek";
            this.Text = "Lineare Abbildungen und Vielfache beliebiger Vektoren";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.Button butFunctionAMultX;
        private System.Windows.Forms.Label lblFactorA;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox grpAusgabe;
        private System.Windows.Forms.TextBox txtVectorAMultX;
        private System.Windows.Forms.TextBox txtVectorFX;
        private System.Windows.Forms.Label lblVectorAMultX;
        private System.Windows.Forms.Label lblVectorFX;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem1;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblHeader;
        private UserControls.CtlMatrixInput ctlMatrixInput;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private UserControls.CoordinateSystem cosInput;
        private UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.PictureBox picBoxArrow;
        private UserControls.FloatInput _ctlScalarInput;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
    }
}