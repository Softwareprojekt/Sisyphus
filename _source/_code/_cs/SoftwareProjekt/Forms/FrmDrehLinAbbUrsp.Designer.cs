namespace SoftwareProjekt.Forms
{
    partial class FrmDrehLinAbbUrsp
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtVectorX = new System.Windows.Forms.TextBox();
            this.lblVectorX = new System.Windows.Forms.Label();
            this.txtEV2 = new System.Windows.Forms.TextBox();
            this.lblEV2 = new System.Windows.Forms.Label();
            this.txtEV1 = new System.Windows.Forms.TextBox();
            this.lblEV1 = new System.Windows.Forms.Label();
            this.butFunctionTransfX = new System.Windows.Forms.Button();
            this.txtFunctionTransfX = new System.Windows.Forms.TextBox();
            this.txtVectorFunctionX = new System.Windows.Forms.TextBox();
            this.lblVectorFunctionX = new System.Windows.Forms.Label();
            this.lblVectorM1 = new System.Windows.Forms.Label();
            this.txtVectorM1 = new System.Windows.Forms.TextBox();
            this.lblVectorM2 = new System.Windows.Forms.Label();
            this.txtVectorM2 = new System.Windows.Forms.TextBox();
            this.grpDataOutput = new System.Windows.Forms.GroupBox();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
<<<<<<< HEAD
            this.ctlVektorInput1 = new SoftwareProjekt.CtlVektorInput();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
=======
            this.ctlFormular = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
>>>>>>> 846a6a4aeea1b30f10d7f3efe8220e9a59087f38
            this.grpDataInput.SuspendLayout();
            this.grpDataOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(802, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ausgabekoordinatensystem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.ctlVektorInput1);
            this.grpDataInput.Controls.Add(this.txtAngle);
            this.grpDataInput.Controls.Add(this.lblAngle);
            this.grpDataInput.Controls.Add(this.txtVectorX);
            this.grpDataInput.Controls.Add(this.lblVectorX);
            this.grpDataInput.Controls.Add(this.txtEV2);
            this.grpDataInput.Controls.Add(this.lblEV2);
            this.grpDataInput.Controls.Add(this.txtEV1);
            this.grpDataInput.Controls.Add(this.lblEV1);
<<<<<<< HEAD
            this.grpDataInput.Location = new System.Drawing.Point(114, 74);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.grpDataInput.Controls.Add(this.txtPointX);
            this.grpDataInput.Controls.Add(this.lblPointX);
            this.grpDataInput.Location = new System.Drawing.Point(63, 44);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 846a6a4aeea1b30f10d7f3efe8220e9a59087f38
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Size = new System.Drawing.Size(332, 156);
            this.grpDataInput.TabIndex = 26;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(227, 118);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(84, 22);
            this.txtAngle.TabIndex = 15;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(163, 120);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(54, 17);
            this.lblAngle.TabIndex = 14;
            this.lblAngle.Text = "Winkel:";
            // 
            // txtVectorX
            // 
            this.txtVectorX.Location = new System.Drawing.Point(227, 89);
            this.txtVectorX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVectorX.Name = "txtVectorX";
            this.txtVectorX.Size = new System.Drawing.Size(84, 22);
            this.txtVectorX.TabIndex = 13;
            // 
            // lblVectorX
            // 
            this.lblVectorX.AutoSize = true;
            this.lblVectorX.Location = new System.Drawing.Point(163, 92);
            this.lblVectorX.Name = "lblVectorX";
            this.lblVectorX.Size = new System.Drawing.Size(53, 17);
            this.lblVectorX.TabIndex = 12;
            this.lblVectorX.Text = "f(x1->):";
            // 
            // txtEV2
            // 
            this.txtEV2.Location = new System.Drawing.Point(227, 61);
            this.txtEV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEV2.Name = "txtEV2";
            this.txtEV2.Size = new System.Drawing.Size(84, 22);
            this.txtEV2.TabIndex = 11;
            // 
            // lblEV2
            // 
            this.lblEV2.AutoSize = true;
            this.lblEV2.Location = new System.Drawing.Point(163, 65);
            this.lblEV2.Name = "lblEV2";
            this.lblEV2.Size = new System.Drawing.Size(34, 17);
            this.lblEV2.TabIndex = 10;
            this.lblEV2.Text = "EV2";
            // 
            // txtEV1
            // 
            this.txtEV1.Location = new System.Drawing.Point(227, 33);
            this.txtEV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEV1.Name = "txtEV1";
            this.txtEV1.Size = new System.Drawing.Size(84, 22);
            this.txtEV1.TabIndex = 9;
            // 
            // lblEV1
            // 
            this.lblEV1.AutoSize = true;
            this.lblEV1.Location = new System.Drawing.Point(163, 36);
            this.lblEV1.Name = "lblEV1";
            this.lblEV1.Size = new System.Drawing.Size(38, 17);
            this.lblEV1.TabIndex = 8;
            this.lblEV1.Text = "EV1:";
            // 
            // butFunctionTransfX
            // 
            this.butFunctionTransfX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionTransfX.Location = new System.Drawing.Point(9, 25);
            this.butFunctionTransfX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFunctionTransfX.Name = "butFunctionTransfX";
            this.butFunctionTransfX.Size = new System.Drawing.Size(64, 32);
            this.butFunctionTransfX.TabIndex = 32;
            this.butFunctionTransfX.Text = "f(x)";
            this.butFunctionTransfX.UseVisualStyleBackColor = true;
            // 
            // txtFunctionTransfX
            // 
            this.txtFunctionTransfX.Location = new System.Drawing.Point(80, 30);
            this.txtFunctionTransfX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFunctionTransfX.Name = "txtFunctionTransfX";
            this.txtFunctionTransfX.Size = new System.Drawing.Size(84, 22);
            this.txtFunctionTransfX.TabIndex = 34;
            // 
            // txtVectorFunctionX
            // 
            this.txtVectorFunctionX.Location = new System.Drawing.Point(80, 70);
            this.txtVectorFunctionX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVectorFunctionX.Name = "txtVectorFunctionX";
            this.txtVectorFunctionX.Size = new System.Drawing.Size(84, 22);
            this.txtVectorFunctionX.TabIndex = 35;
            // 
            // lblVectorFunctionX
            // 
            this.lblVectorFunctionX.AutoSize = true;
            this.lblVectorFunctionX.Location = new System.Drawing.Point(20, 74);
            this.lblVectorFunctionX.Name = "lblVectorFunctionX";
            this.lblVectorFunctionX.Size = new System.Drawing.Size(45, 17);
            this.lblVectorFunctionX.TabIndex = 36;
            this.lblVectorFunctionX.Text = "f(x->):";
            // 
            // lblVectorM1
            // 
            this.lblVectorM1.AutoSize = true;
            this.lblVectorM1.Location = new System.Drawing.Point(20, 102);
            this.lblVectorM1.Name = "lblVectorM1";
            this.lblVectorM1.Size = new System.Drawing.Size(44, 17);
            this.lblVectorM1.TabIndex = 38;
            this.lblVectorM1.Text = "m1->:";
            // 
            // txtVectorM1
            // 
            this.txtVectorM1.Location = new System.Drawing.Point(80, 98);
            this.txtVectorM1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVectorM1.Name = "txtVectorM1";
            this.txtVectorM1.Size = new System.Drawing.Size(84, 22);
            this.txtVectorM1.TabIndex = 37;
            // 
            // lblVectorM2
            // 
            this.lblVectorM2.AutoSize = true;
            this.lblVectorM2.Location = new System.Drawing.Point(20, 129);
            this.lblVectorM2.Name = "lblVectorM2";
            this.lblVectorM2.Size = new System.Drawing.Size(44, 17);
            this.lblVectorM2.TabIndex = 40;
            this.lblVectorM2.Text = "m2->:";
            // 
            // txtVectorM2
            // 
            this.txtVectorM2.Location = new System.Drawing.Point(80, 127);
            this.txtVectorM2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVectorM2.Name = "txtVectorM2";
            this.txtVectorM2.Size = new System.Drawing.Size(84, 22);
            this.txtVectorM2.TabIndex = 39;
            // 
            // grpDataOutput
            // 
            this.grpDataOutput.Controls.Add(this.butFunctionTransfX);
            this.grpDataOutput.Controls.Add(this.txtDeterminante);
            this.grpDataOutput.Controls.Add(this.lblVectorM2);
            this.grpDataOutput.Controls.Add(this.butDeterminante);
            this.grpDataOutput.Controls.Add(this.txtFunctionTransfX);
            this.grpDataOutput.Controls.Add(this.txtVectorM2);
            this.grpDataOutput.Controls.Add(this.txtVectorFunctionX);
            this.grpDataOutput.Controls.Add(this.lblVectorM1);
            this.grpDataOutput.Controls.Add(this.lblVectorFunctionX);
            this.grpDataOutput.Controls.Add(this.txtVectorM1);
<<<<<<< HEAD
            this.grpDataOutput.Location = new System.Drawing.Point(757, 64);
            this.grpDataOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.grpDataOutput.Location = new System.Drawing.Point(618, 44);
>>>>>>> 846a6a4aeea1b30f10d7f3efe8220e9a59087f38
            this.grpDataOutput.Name = "grpDataOutput";
            this.grpDataOutput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDataOutput.Size = new System.Drawing.Size(324, 166);
            this.grpDataOutput.TabIndex = 41;
            this.grpDataOutput.TabStop = false;
            this.grpDataOutput.Text = "Ausgabe";
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(16, 253);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(504, 347);
            this.cosInput.TabIndex = 42;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(699, 253);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(504, 347);
            this.cosOutput.TabIndex = 43;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(301, 679);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 44;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(305, 699);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(579, 166);
            this.rtxtNotes.TabIndex = 45;
            this.rtxtNotes.Text = "";
            // 
<<<<<<< HEAD
            // ctlVektorInput1
            // 
            this.ctlVektorInput1.Location = new System.Drawing.Point(7, 36);
            this.ctlVektorInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVektorInput1.Name = "ctlVektorInput1";
            this.ctlVektorInput1.Size = new System.Drawing.Size(154, 92);
            this.ctlVektorInput1.TabIndex = 47;
            this.ctlVektorInput1.Vector = null;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(189, 27);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(114, 29);
            this.butDeterminante.TabIndex = 46;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(189, 70);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.Size = new System.Drawing.Size(114, 22);
            this.txtDeterminante.TabIndex = 41;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(300, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(520, 29);
            this.lblHeader.TabIndex = 47;
            this.lblHeader.Text = "Thema: Drehungen um den Urspr. sind linear";
=======
            // ctlFormular
            // 
            this.ctlFormular.Equation = null;
            this.ctlFormular.Filepath = null;
            this.ctlFormular.Location = new System.Drawing.Point(253, 68);
            this.ctlFormular.Name = "ctlFormular";
            this.ctlFormular.Size = new System.Drawing.Size(329, 92);
            this.ctlFormular.TabIndex = 46;
>>>>>>> 846a6a4aeea1b30f10d7f3efe8220e9a59087f38
            // 
            // FrmDrehLinAbbUrsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1251, 881);
            this.Controls.Add(this.lblHeader);
=======
            this.ClientSize = new System.Drawing.Size(938, 716);
            this.Controls.Add(this.ctlFormular);
>>>>>>> 846a6a4aeea1b30f10d7f3efe8220e9a59087f38
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.grpDataOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpDataInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDrehLinAbbUrsp";
            this.Text = "Drehung linearer Abbildungen am Ursprung";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.grpDataOutput.ResumeLayout(false);
            this.grpDataOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TextBox txtVectorX;
        private System.Windows.Forms.Label lblVectorX;
        private System.Windows.Forms.TextBox txtEV2;
        private System.Windows.Forms.Label lblEV2;
        private System.Windows.Forms.TextBox txtEV1;
        private System.Windows.Forms.Label lblEV1;
        private System.Windows.Forms.Button butFunctionTransfX;
        private System.Windows.Forms.TextBox txtFunctionTransfX;
        private System.Windows.Forms.TextBox txtVectorFunctionX;
        private System.Windows.Forms.Label lblVectorFunctionX;
        private System.Windows.Forms.Label lblVectorM1;
        private System.Windows.Forms.TextBox txtVectorM1;
        private System.Windows.Forms.Label lblVectorM2;
        private System.Windows.Forms.TextBox txtVectorM2;
        private System.Windows.Forms.GroupBox grpDataOutput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Button butDeterminante;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Label lblHeader;

    }
}