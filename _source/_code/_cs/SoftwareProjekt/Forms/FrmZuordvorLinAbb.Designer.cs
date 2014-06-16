namespace SoftwareProjekt.Forms
{
    partial class FrmZuordvorLinAbb
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
            SoftwareProjekt.Classes.Math.Vector vector7 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector8 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector9 = new SoftwareProjekt.Classes.Math.Vector();
            this.lblInputCos = new System.Windows.Forms.Label();
            this.lblOutputCos = new System.Windows.Forms.Label();
            this.grpDataInputRight = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEV1 = new System.Windows.Forms.Label();
            this.txtEV1 = new System.Windows.Forms.TextBox();
            this.lblEV2 = new System.Windows.Forms.Label();
            this.txtEV2 = new System.Windows.Forms.TextBox();
            this.lblVectorX = new System.Windows.Forms.Label();
            this.txVectorX = new System.Windows.Forms.TextBox();
            this.grpDataInputLeft = new System.Windows.Forms.GroupBox();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.ctlVecX1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInput1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInput2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.grpDataInputRight.SuspendLayout();
            this.grpDataInputLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInputCos
            // 
            this.lblInputCos.AutoSize = true;
            this.lblInputCos.Location = new System.Drawing.Point(149, 349);
            this.lblInputCos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputCos.Name = "lblInputCos";
            this.lblInputCos.Size = new System.Drawing.Size(137, 13);
            this.lblInputCos.TabIndex = 22;
            this.lblInputCos.Text = "Eingabekoordinatensystem:";
            // 
            // lblOutputCos
            // 
            this.lblOutputCos.AutoSize = true;
            this.lblOutputCos.Location = new System.Drawing.Point(719, 349);
            this.lblOutputCos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputCos.Name = "lblOutputCos";
            this.lblOutputCos.Size = new System.Drawing.Size(140, 13);
            this.lblOutputCos.TabIndex = 24;
            this.lblOutputCos.Text = "Ausgabekoordinatensystem:";
            // 
            // grpDataInputRight
            // 
            this.grpDataInputRight.Controls.Add(this.ctlVectorInput2);
            this.grpDataInputRight.Controls.Add(this.ctlVectorInput1);
            this.grpDataInputRight.Controls.Add(this.textBox2);
            this.grpDataInputRight.Controls.Add(this.label1);
            this.grpDataInputRight.Controls.Add(this.textBox1);
            this.grpDataInputRight.Controls.Add(this.label2);
            this.grpDataInputRight.Location = new System.Drawing.Point(611, 122);
            this.grpDataInputRight.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInputRight.Name = "grpDataInputRight";
            this.grpDataInputRight.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInputRight.Size = new System.Drawing.Size(248, 167);
            this.grpDataInputRight.TabIndex = 25;
            this.grpDataInputRight.TabStop = false;
            this.grpDataInputRight.Text = "Dateneingabe";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 133);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "f(x1->):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 109);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "f(x1):";
            // 
            // lblEV1
            // 
            this.lblEV1.AutoSize = true;
            this.lblEV1.Location = new System.Drawing.Point(4, 141);
            this.lblEV1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEV1.Name = "lblEV1";
            this.lblEV1.Size = new System.Drawing.Size(77, 13);
            this.lblEV1.TabIndex = 8;
            this.lblEV1.Text = "Einheitsvektor:";
            // 
            // txtEV1
            // 
            this.txtEV1.Location = new System.Drawing.Point(85, 138);
            this.txtEV1.Margin = new System.Windows.Forms.Padding(2);
            this.txtEV1.Name = "txtEV1";
            this.txtEV1.ReadOnly = true;
            this.txtEV1.Size = new System.Drawing.Size(64, 20);
            this.txtEV1.TabIndex = 9;
            // 
            // lblEV2
            // 
            this.lblEV2.AutoSize = true;
            this.lblEV2.Location = new System.Drawing.Point(4, 165);
            this.lblEV2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEV2.Name = "lblEV2";
            this.lblEV2.Size = new System.Drawing.Size(77, 13);
            this.lblEV2.TabIndex = 10;
            this.lblEV2.Text = "Einheitsvektor:";
            // 
            // txtEV2
            // 
            this.txtEV2.Location = new System.Drawing.Point(85, 162);
            this.txtEV2.Margin = new System.Windows.Forms.Padding(2);
            this.txtEV2.Name = "txtEV2";
            this.txtEV2.ReadOnly = true;
            this.txtEV2.Size = new System.Drawing.Size(64, 20);
            this.txtEV2.TabIndex = 11;
            // 
            // lblVectorX
            // 
            this.lblVectorX.AutoSize = true;
            this.lblVectorX.Location = new System.Drawing.Point(4, 115);
            this.lblVectorX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorX.Name = "lblVectorX";
            this.lblVectorX.Size = new System.Drawing.Size(39, 13);
            this.lblVectorX.TabIndex = 12;
            this.lblVectorX.Text = "f(x1->):";
            // 
            // txVectorX
            // 
            this.txVectorX.Location = new System.Drawing.Point(85, 112);
            this.txVectorX.Margin = new System.Windows.Forms.Padding(2);
            this.txVectorX.Name = "txVectorX";
            this.txVectorX.Size = new System.Drawing.Size(64, 20);
            this.txVectorX.TabIndex = 13;
            // 
            // grpDataInputLeft
            // 
            this.grpDataInputLeft.Controls.Add(this.ctlVecX1);
            this.grpDataInputLeft.Controls.Add(this.txVectorX);
            this.grpDataInputLeft.Controls.Add(this.lblVectorX);
            this.grpDataInputLeft.Controls.Add(this.txtEV2);
            this.grpDataInputLeft.Controls.Add(this.lblEV2);
            this.grpDataInputLeft.Controls.Add(this.txtEV1);
            this.grpDataInputLeft.Controls.Add(this.lblEV1);
            this.grpDataInputLeft.Location = new System.Drawing.Point(201, 122);
            this.grpDataInputLeft.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInputLeft.Name = "grpDataInputLeft";
            this.grpDataInputLeft.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInputLeft.Size = new System.Drawing.Size(186, 191);
            this.grpDataInputLeft.TabIndex = 16;
            this.grpDataInputLeft.TabStop = false;
            this.grpDataInputLeft.Text = "Dateneingabe";
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(12, 365);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(428, 341);
            this.cosInput.TabIndex = 26;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(562, 365);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(428, 341);
            this.cosOutput.TabIndex = 27;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(272, 739);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 29;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(272, 758);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this.rtxtNotes.TabIndex = 28;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(216, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(548, 24);
            this.lblHeader.TabIndex = 30;
            this.lblHeader.Text = "Thema: Zuordnugsvorschrift einer linearen Abbildung verstehen";
            // 
            // ctlVecX1
            // 
            this.ctlVecX1.Location = new System.Drawing.Point(52, 24);
            this.ctlVecX1.Name = "ctlVecX1";
            this.ctlVecX1.Size = new System.Drawing.Size(121, 83);
            this.ctlVecX1.TabIndex = 14;
            vector7.X1 = float.NaN;
            vector7.X2 = float.NaN;
            this.ctlVecX1.Vector = vector7;
            // 
            // ctlVectorInput1
            // 
            this.ctlVectorInput1.Location = new System.Drawing.Point(5, 19);
            this.ctlVectorInput1.Name = "ctlVectorInput1";
            this.ctlVectorInput1.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorInput1.TabIndex = 16;
            vector8.X1 = float.NaN;
            vector8.X2 = float.NaN;
            this.ctlVectorInput1.Vector = vector8;
            // 
            // ctlVectorInput2
            // 
            this.ctlVectorInput2.Location = new System.Drawing.Point(127, 19);
            this.ctlVectorInput2.Name = "ctlVectorInput2";
            this.ctlVectorInput2.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorInput2.TabIndex = 17;
            vector9.X1 = float.NaN;
            vector9.X2 = float.NaN;
            this.ctlVectorInput2.Vector = vector9;
            // 
            // FrmZuordvorLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 904);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.grpDataInputRight);
            this.Controls.Add(this.lblOutputCos);
            this.Controls.Add(this.lblInputCos);
            this.Controls.Add(this.grpDataInputLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmZuordvorLinAbb";
            this.Text = "Zuordnungsvorschrift Lineare Abbildung";
            this.grpDataInputRight.ResumeLayout(false);
            this.grpDataInputRight.PerformLayout();
            this.grpDataInputLeft.ResumeLayout(false);
            this.grpDataInputLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputCos;
        private System.Windows.Forms.Label lblOutputCos;
        private System.Windows.Forms.GroupBox grpDataInputRight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEV1;
        private System.Windows.Forms.TextBox txtEV1;
        private System.Windows.Forms.Label lblEV2;
        private System.Windows.Forms.TextBox txtEV2;
        private System.Windows.Forms.Label lblVectorX;
        private System.Windows.Forms.TextBox txVectorX;
        private System.Windows.Forms.GroupBox grpDataInputLeft;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblHeader;
        private UserControls.CtlVectorInput ctlVectorInput2;
        private UserControls.CtlVectorInput ctlVectorInput1;
        private UserControls.CtlVectorInput ctlVecX1;
    }
}