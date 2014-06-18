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
            this.lblInput = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.lblAMultX = new System.Windows.Forms.Label();
            this.txtFactorA = new System.Windows.Forms.TextBox();
            this.lblFactorA = new System.Windows.Forms.Label();
            this.butFunctionAMultX = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.lblOutput = new System.Windows.Forms.Label();
            this.cosInput = new SoftwareProjekt.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.CoordinateSystem();
=======
            this.label7 = new System.Windows.Forms.Label();
            this.grpAusgabe = new System.Windows.Forms.GroupBox();
            this.txtVectorAMultX = new System.Windows.Forms.TextBox();
            this.txtVectorFX = new System.Windows.Forms.TextBox();
            this.lblVectorAMultX = new System.Windows.Forms.Label();
            this.lblVectorFX = new System.Windows.Forms.Label();
            this.coordinateSystem1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.coordinateSystem2 = new SoftwareProjekt.UserControls.CoordinateSystem();
>>>>>>> 846a6a4aeea1b30f10d7f3efe8220e9a59087f38
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlVektorInput1 = new SoftwareProjekt.CtlVektorInput();
            this.ctlMatrixInput1 = new SoftwareProjekt.CtlMatrixInput();
            this.ctlVektorInput2 = new SoftwareProjekt.CtlVektorInput();
            this.grpDataInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(169, 386);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(183, 17);
            this.lblInput.TabIndex = 31;
            this.lblInput.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.ctlVektorInput2);
            this.grpDataInput.Controls.Add(this.ctlMatrixInput1);
            this.grpDataInput.Controls.Add(this.ctlVektorInput1);
            this.grpDataInput.Controls.Add(this.txtDeterminante);
            this.grpDataInput.Controls.Add(this.butDeterminante);
            this.grpDataInput.Controls.Add(this.lblAMultX);
            this.grpDataInput.Controls.Add(this.txtFactorA);
            this.grpDataInput.Controls.Add(this.lblFactorA);
            this.grpDataInput.Location = new System.Drawing.Point(103, 74);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Size = new System.Drawing.Size(460, 288);
            this.grpDataInput.TabIndex = 29;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(298, 161);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.Size = new System.Drawing.Size(131, 22);
            this.txtDeterminante.TabIndex = 36;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(298, 123);
            this.butDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(131, 34);
            this.butDeterminante.TabIndex = 35;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            // 
            // lblAMultX
            // 
            this.lblAMultX.AutoSize = true;
            this.lblAMultX.Location = new System.Drawing.Point(6, 220);
            this.lblAMultX.Name = "lblAMultX";
            this.lblAMultX.Size = new System.Drawing.Size(79, 17);
            this.lblAMultX.TabIndex = 12;
            this.lblAMultX.Text = "a*Vektor X:";
            // 
            // txtFactorA
            // 
            this.txtFactorA.Location = new System.Drawing.Point(76, 123);
            this.txtFactorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFactorA.Name = "txtFactorA";
            this.txtFactorA.Size = new System.Drawing.Size(76, 22);
            this.txtFactorA.TabIndex = 9;
            // 
            // lblFactorA
            // 
            this.lblFactorA.AutoSize = true;
            this.lblFactorA.Location = new System.Drawing.Point(6, 126);
            this.lblFactorA.Name = "lblFactorA";
            this.lblFactorA.Size = new System.Drawing.Size(64, 17);
            this.lblFactorA.TabIndex = 8;
            this.lblFactorA.Text = "Faktor a:";
            // 
            // butFunctionAMultX
            // 
            this.butFunctionAMultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionAMultX.Location = new System.Drawing.Point(640, 162);
            this.butFunctionAMultX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFunctionAMultX.Name = "butFunctionAMultX";
            this.butFunctionAMultX.Size = new System.Drawing.Size(131, 55);
            this.butFunctionAMultX.TabIndex = 32;
            this.butFunctionAMultX.Text = "f(a*x)";
            this.butFunctionAMultX.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(972, 386);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(187, 17);
            this.lblOutput.TabIndex = 33;
            this.lblOutput.Text = "Ausgabekoordinatensystem:";
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(36, 407);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(480, 428);
            this.cosInput.TabIndex = 35;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(818, 407);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(480, 428);
            this.cosOutput.TabIndex = 36;
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
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 37;
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
            // ctlVektorInput1
            // 
            this.ctlVektorInput1.Location = new System.Drawing.Point(7, 23);
            this.ctlVektorInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVektorInput1.Name = "ctlVektorInput1";
            this.ctlVektorInput1.Size = new System.Drawing.Size(153, 104);
            this.ctlVektorInput1.TabIndex = 40;
            this.ctlVektorInput1.Vector = null;
            // 
            // ctlMatrixInput1
            // 
            this.ctlMatrixInput1.Location = new System.Drawing.Point(285, 23);
            this.ctlMatrixInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlMatrixInput1.Matrix = null;
            this.ctlMatrixInput1.Name = "ctlMatrixInput1";
            this.ctlMatrixInput1.Size = new System.Drawing.Size(159, 96);
            this.ctlMatrixInput1.TabIndex = 40;
            // 
            // ctlVektorInput2
            // 
            this.ctlVektorInput2.Location = new System.Drawing.Point(92, 186);
            this.ctlVektorInput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVektorInput2.Name = "ctlVektorInput2";
            this.ctlVektorInput2.Size = new System.Drawing.Size(161, 96);
            this.ctlVektorInput2.TabIndex = 40;
            this.ctlVektorInput2.Vector = null;
            // 
            // FrmLinAbbVielBelVek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 1048);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.butFunctionAMultX);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.grpDataInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLinAbbVielBelVek";
            this.Text = "FrmLinAbbVielBelVek";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.Button butFunctionAMultX;
        private System.Windows.Forms.Label lblAMultX;
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
    }
}