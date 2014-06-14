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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtVectorX = new System.Windows.Forms.TextBox();
            this.lblVectorX = new System.Windows.Forms.Label();
            this.txtEV2 = new System.Windows.Forms.TextBox();
            this.lblEV2 = new System.Windows.Forms.Label();
            this.txtEV1 = new System.Windows.Forms.TextBox();
            this.lblEV1 = new System.Windows.Forms.Label();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.lblPointX = new System.Windows.Forms.Label();
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
            this.ctlFormular = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInput.SuspendLayout();
            this.grpDataOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ausgabekoordinatensystem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.textBox3);
            this.grpDataInput.Controls.Add(this.lblAngle);
            this.grpDataInput.Controls.Add(this.txtVectorX);
            this.grpDataInput.Controls.Add(this.lblVectorX);
            this.grpDataInput.Controls.Add(this.txtEV2);
            this.grpDataInput.Controls.Add(this.lblEV2);
            this.grpDataInput.Controls.Add(this.txtEV1);
            this.grpDataInput.Controls.Add(this.lblEV1);
            this.grpDataInput.Controls.Add(this.txtPointX);
            this.grpDataInput.Controls.Add(this.lblPointX);
            this.grpDataInput.Location = new System.Drawing.Point(63, 44);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Size = new System.Drawing.Size(146, 146);
            this.grpDataInput.TabIndex = 26;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 115);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 15;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(4, 117);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(43, 13);
            this.lblAngle.TabIndex = 14;
            this.lblAngle.Text = "Winkel:";
            // 
            // txtVectorX
            // 
            this.txtVectorX.Location = new System.Drawing.Point(52, 92);
            this.txtVectorX.Margin = new System.Windows.Forms.Padding(2);
            this.txtVectorX.Name = "txtVectorX";
            this.txtVectorX.Size = new System.Drawing.Size(64, 20);
            this.txtVectorX.TabIndex = 13;
            // 
            // lblVectorX
            // 
            this.lblVectorX.AutoSize = true;
            this.lblVectorX.Location = new System.Drawing.Point(4, 94);
            this.lblVectorX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorX.Name = "lblVectorX";
            this.lblVectorX.Size = new System.Drawing.Size(39, 13);
            this.lblVectorX.TabIndex = 12;
            this.lblVectorX.Text = "f(x1->):";
            // 
            // txtEV2
            // 
            this.txtEV2.Location = new System.Drawing.Point(52, 69);
            this.txtEV2.Margin = new System.Windows.Forms.Padding(2);
            this.txtEV2.Name = "txtEV2";
            this.txtEV2.Size = new System.Drawing.Size(64, 20);
            this.txtEV2.TabIndex = 11;
            // 
            // lblEV2
            // 
            this.lblEV2.AutoSize = true;
            this.lblEV2.Location = new System.Drawing.Point(4, 72);
            this.lblEV2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEV2.Name = "lblEV2";
            this.lblEV2.Size = new System.Drawing.Size(27, 13);
            this.lblEV2.TabIndex = 10;
            this.lblEV2.Text = "EV2";
            // 
            // txtEV1
            // 
            this.txtEV1.Location = new System.Drawing.Point(52, 46);
            this.txtEV1.Margin = new System.Windows.Forms.Padding(2);
            this.txtEV1.Name = "txtEV1";
            this.txtEV1.Size = new System.Drawing.Size(64, 20);
            this.txtEV1.TabIndex = 9;
            // 
            // lblEV1
            // 
            this.lblEV1.AutoSize = true;
            this.lblEV1.Location = new System.Drawing.Point(4, 49);
            this.lblEV1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEV1.Name = "lblEV1";
            this.lblEV1.Size = new System.Drawing.Size(30, 13);
            this.lblEV1.TabIndex = 8;
            this.lblEV1.Text = "EV1:";
            // 
            // txtPointX
            // 
            this.txtPointX.Location = new System.Drawing.Point(52, 24);
            this.txtPointX.Margin = new System.Windows.Forms.Padding(2);
            this.txtPointX.Name = "txtPointX";
            this.txtPointX.Size = new System.Drawing.Size(64, 20);
            this.txtPointX.TabIndex = 7;
            // 
            // lblPointX
            // 
            this.lblPointX.AutoSize = true;
            this.lblPointX.Location = new System.Drawing.Point(4, 26);
            this.lblPointX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(46, 13);
            this.lblPointX.TabIndex = 0;
            this.lblPointX.Text = "Punkt x:";
            // 
            // butFunctionTransfX
            // 
            this.butFunctionTransfX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionTransfX.Location = new System.Drawing.Point(7, 20);
            this.butFunctionTransfX.Margin = new System.Windows.Forms.Padding(2);
            this.butFunctionTransfX.Name = "butFunctionTransfX";
            this.butFunctionTransfX.Size = new System.Drawing.Size(48, 26);
            this.butFunctionTransfX.TabIndex = 32;
            this.butFunctionTransfX.Text = "f(x)";
            this.butFunctionTransfX.UseVisualStyleBackColor = true;
            // 
            // txtFunctionTransfX
            // 
            this.txtFunctionTransfX.Location = new System.Drawing.Point(60, 24);
            this.txtFunctionTransfX.Margin = new System.Windows.Forms.Padding(2);
            this.txtFunctionTransfX.Name = "txtFunctionTransfX";
            this.txtFunctionTransfX.Size = new System.Drawing.Size(64, 20);
            this.txtFunctionTransfX.TabIndex = 34;
            // 
            // txtVectorFunctionX
            // 
            this.txtVectorFunctionX.Location = new System.Drawing.Point(60, 57);
            this.txtVectorFunctionX.Margin = new System.Windows.Forms.Padding(2);
            this.txtVectorFunctionX.Name = "txtVectorFunctionX";
            this.txtVectorFunctionX.Size = new System.Drawing.Size(64, 20);
            this.txtVectorFunctionX.TabIndex = 35;
            // 
            // lblVectorFunctionX
            // 
            this.lblVectorFunctionX.AutoSize = true;
            this.lblVectorFunctionX.Location = new System.Drawing.Point(15, 60);
            this.lblVectorFunctionX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorFunctionX.Name = "lblVectorFunctionX";
            this.lblVectorFunctionX.Size = new System.Drawing.Size(33, 13);
            this.lblVectorFunctionX.TabIndex = 36;
            this.lblVectorFunctionX.Text = "f(x->):";
            // 
            // lblVectorM1
            // 
            this.lblVectorM1.AutoSize = true;
            this.lblVectorM1.Location = new System.Drawing.Point(15, 83);
            this.lblVectorM1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorM1.Name = "lblVectorM1";
            this.lblVectorM1.Size = new System.Drawing.Size(33, 13);
            this.lblVectorM1.TabIndex = 38;
            this.lblVectorM1.Text = "m1->:";
            // 
            // txtVectorM1
            // 
            this.txtVectorM1.Location = new System.Drawing.Point(60, 80);
            this.txtVectorM1.Margin = new System.Windows.Forms.Padding(2);
            this.txtVectorM1.Name = "txtVectorM1";
            this.txtVectorM1.Size = new System.Drawing.Size(64, 20);
            this.txtVectorM1.TabIndex = 37;
            // 
            // lblVectorM2
            // 
            this.lblVectorM2.AutoSize = true;
            this.lblVectorM2.Location = new System.Drawing.Point(15, 105);
            this.lblVectorM2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorM2.Name = "lblVectorM2";
            this.lblVectorM2.Size = new System.Drawing.Size(33, 13);
            this.lblVectorM2.TabIndex = 40;
            this.lblVectorM2.Text = "m2->:";
            // 
            // txtVectorM2
            // 
            this.txtVectorM2.Location = new System.Drawing.Point(60, 103);
            this.txtVectorM2.Margin = new System.Windows.Forms.Padding(2);
            this.txtVectorM2.Name = "txtVectorM2";
            this.txtVectorM2.Size = new System.Drawing.Size(64, 20);
            this.txtVectorM2.TabIndex = 39;
            // 
            // grpDataOutput
            // 
            this.grpDataOutput.Controls.Add(this.butFunctionTransfX);
            this.grpDataOutput.Controls.Add(this.lblVectorM2);
            this.grpDataOutput.Controls.Add(this.txtFunctionTransfX);
            this.grpDataOutput.Controls.Add(this.txtVectorM2);
            this.grpDataOutput.Controls.Add(this.txtVectorFunctionX);
            this.grpDataOutput.Controls.Add(this.lblVectorM1);
            this.grpDataOutput.Controls.Add(this.lblVectorFunctionX);
            this.grpDataOutput.Controls.Add(this.txtVectorM1);
            this.grpDataOutput.Location = new System.Drawing.Point(618, 44);
            this.grpDataOutput.Name = "grpDataOutput";
            this.grpDataOutput.Size = new System.Drawing.Size(140, 135);
            this.grpDataOutput.TabIndex = 41;
            this.grpDataOutput.TabStop = false;
            this.grpDataOutput.Text = "Ausgabe";
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(12, 222);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(378, 266);
            this.cosInput.TabIndex = 42;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(524, 222);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(378, 266);
            this.cosOutput.TabIndex = 43;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(226, 552);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 44;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(229, 568);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(435, 136);
            this.rtxtNotes.TabIndex = 45;
            this.rtxtNotes.Text = "";
            // 
            // ctlFormular
            // 
            this.ctlFormular.Equation = null;
            this.ctlFormular.Filename = null;
            this.ctlFormular.Location = new System.Drawing.Point(253, 68);
            this.ctlFormular.Name = "ctlFormular";
            this.ctlFormular.Size = new System.Drawing.Size(329, 92);
            this.ctlFormular.TabIndex = 46;
            // 
            // FrmDrehLinAbbUrsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 716);
            this.Controls.Add(this.ctlFormular);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.grpDataOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpDataInput);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TextBox txtVectorX;
        private System.Windows.Forms.Label lblVectorX;
        private System.Windows.Forms.TextBox txtEV2;
        private System.Windows.Forms.Label lblEV2;
        private System.Windows.Forms.TextBox txtEV1;
        private System.Windows.Forms.Label lblEV1;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.Label lblPointX;
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
        private UserControls.FormulaDrawer.CtlFormularDraw ctlFormular;
    }
}