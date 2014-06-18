namespace SoftwareProjekt.Forms
{
    partial class FrmZuordAffAbb
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInputLeft = new System.Windows.Forms.Label();
            this.grpDataInput1 = new System.Windows.Forms.GroupBox();
            this.lblPointC1 = new System.Windows.Forms.Label();
            this.txtFunction1X = new System.Windows.Forms.TextBox();
            this.txtInverseFunction1X = new System.Windows.Forms.TextBox();
            this.lblPointA1 = new System.Windows.Forms.Label();
            this.lblInverseFunction1X = new System.Windows.Forms.Label();
            this.lblFunction1X = new System.Windows.Forms.Label();
            this.lblPointB1 = new System.Windows.Forms.Label();
            this.grpDataInput2 = new System.Windows.Forms.GroupBox();
            this.lblPointC2 = new System.Windows.Forms.Label();
            this.txtFunction2X = new System.Windows.Forms.TextBox();
            this.lblPointA2 = new System.Windows.Forms.Label();
            this.lblFunction2X = new System.Windows.Forms.Label();
            this.lblPointB2 = new System.Windows.Forms.Label();
            this.lblInputRight = new System.Windows.Forms.Label();
            this.butFx = new System.Windows.Forms.Button();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.cosInputLeft = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosInputRight = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFx = new System.Windows.Forms.Label();
            this.grpDataInput1.SuspendLayout();
            this.grpDataInput2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(792, 217);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(187, 17);
            this.lblOutput.TabIndex = 21;
            this.lblOutput.Text = "Ausgabekoordinatensystem:";
            // 
            // lblInputLeft
            // 
            this.lblInputLeft.AutoSize = true;
            this.lblInputLeft.Location = new System.Drawing.Point(179, 217);
            this.lblInputLeft.Name = "lblInputLeft";
            this.lblInputLeft.Size = new System.Drawing.Size(224, 17);
            this.lblInputLeft.TabIndex = 20;
            this.lblInputLeft.Text = "Eingabekoordinatensystem(a,b,c):";
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Controls.Add(this.lblPointC1);
            this.grpDataInput1.Controls.Add(this.lblPointA1);
            this.grpDataInput1.Controls.Add(this.lblPointB1);
            this.grpDataInput1.Location = new System.Drawing.Point(16, 68);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Size = new System.Drawing.Size(683, 128);
            this.grpDataInput1.TabIndex = 15;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe";
            // 
            // lblPointC1
            // 
            this.lblPointC1.AutoSize = true;
            this.lblPointC1.Location = new System.Drawing.Point(456, 58);
            this.lblPointC1.Name = "lblPointC1";
            this.lblPointC1.Size = new System.Drawing.Size(59, 17);
            this.lblPointC1.TabIndex = 10;
            this.lblPointC1.Text = "Punkt c:";
            // 
            // txtFunction1X
            // 
            this.txtFunction1X.Location = new System.Drawing.Point(774, 106);
            this.txtFunction1X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFunction1X.Name = "txtFunction1X";
            this.txtFunction1X.Size = new System.Drawing.Size(164, 22);
            this.txtFunction1X.TabIndex = 9;
            // 
            // txtInverseFunction1X
            // 
            this.txtInverseFunction1X.Location = new System.Drawing.Point(774, 133);
            this.txtInverseFunction1X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInverseFunction1X.Name = "txtInverseFunction1X";
            this.txtInverseFunction1X.Size = new System.Drawing.Size(164, 22);
            this.txtInverseFunction1X.TabIndex = 8;
            // 
            // lblPointA1
            // 
            this.lblPointA1.AutoSize = true;
            this.lblPointA1.Location = new System.Drawing.Point(10, 58);
            this.lblPointA1.Name = "lblPointA1";
            this.lblPointA1.Size = new System.Drawing.Size(60, 17);
            this.lblPointA1.TabIndex = 0;
            this.lblPointA1.Text = "Punkt a:";
            // 
            // lblInverseFunction1X
            // 
            this.lblInverseFunction1X.AutoSize = true;
            this.lblInverseFunction1X.Location = new System.Drawing.Point(704, 136);
            this.lblInverseFunction1X.Name = "lblInverseFunction1X";
            this.lblInverseFunction1X.Size = new System.Drawing.Size(52, 17);
            this.lblInverseFunction1X.TabIndex = 1;
            this.lblInverseFunction1X.Text = "f^-1(x):";
            // 
            // lblFunction1X
            // 
            this.lblFunction1X.AutoSize = true;
            this.lblFunction1X.Location = new System.Drawing.Point(704, 108);
            this.lblFunction1X.Name = "lblFunction1X";
            this.lblFunction1X.Size = new System.Drawing.Size(40, 17);
            this.lblFunction1X.TabIndex = 2;
            this.lblFunction1X.Text = "f1(x):";
            // 
            // lblPointB1
            // 
            this.lblPointB1.AutoSize = true;
            this.lblPointB1.Location = new System.Drawing.Point(228, 58);
            this.lblPointB1.Name = "lblPointB1";
            this.lblPointB1.Size = new System.Drawing.Size(60, 17);
            this.lblPointB1.TabIndex = 4;
            this.lblPointB1.Text = "Punkt b:";
            // 
            // grpDataInput2
            // 
            this.grpDataInput2.Controls.Add(this.lblPointC2);
            this.grpDataInput2.Controls.Add(this.lblPointA2);
            this.grpDataInput2.Controls.Add(this.lblPointB2);
            this.grpDataInput2.Location = new System.Drawing.Point(970, 68);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Size = new System.Drawing.Size(694, 128);
            this.grpDataInput2.TabIndex = 16;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe";
            // 
            // lblPointC2
            // 
            this.lblPointC2.AutoSize = true;
            this.lblPointC2.Location = new System.Drawing.Point(468, 58);
            this.lblPointC2.Name = "lblPointC2";
            this.lblPointC2.Size = new System.Drawing.Size(62, 17);
            this.lblPointC2.TabIndex = 10;
            this.lblPointC2.Text = "Punkt c\':";
            // 
            // txtFunction2X
            // 
            this.txtFunction2X.Location = new System.Drawing.Point(1710, 105);
            this.txtFunction2X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFunction2X.Name = "txtFunction2X";
            this.txtFunction2X.Size = new System.Drawing.Size(164, 22);
            this.txtFunction2X.TabIndex = 9;
            // 
            // lblPointA2
            // 
            this.lblPointA2.AutoSize = true;
            this.lblPointA2.Location = new System.Drawing.Point(6, 58);
            this.lblPointA2.Name = "lblPointA2";
            this.lblPointA2.Size = new System.Drawing.Size(63, 17);
            this.lblPointA2.TabIndex = 0;
            this.lblPointA2.Text = "Punkt a\':";
            // 
            // lblFunction2X
            // 
            this.lblFunction2X.AutoSize = true;
            this.lblFunction2X.Location = new System.Drawing.Point(1664, 108);
            this.lblFunction2X.Name = "lblFunction2X";
            this.lblFunction2X.Size = new System.Drawing.Size(40, 17);
            this.lblFunction2X.TabIndex = 2;
            this.lblFunction2X.Text = "f2(x):";
            // 
            // lblPointB2
            // 
            this.lblPointB2.AutoSize = true;
            this.lblPointB2.Location = new System.Drawing.Point(237, 58);
            this.lblPointB2.Name = "lblPointB2";
            this.lblPointB2.Size = new System.Drawing.Size(63, 17);
            this.lblPointB2.TabIndex = 4;
            this.lblPointB2.Text = "Punkt b\':";
            // 
            // lblInputRight
            // 
            this.lblInputRight.AutoSize = true;
            this.lblInputRight.Location = new System.Drawing.Point(1421, 217);
            this.lblInputRight.Name = "lblInputRight";
            this.lblInputRight.Size = new System.Drawing.Size(233, 17);
            this.lblInputRight.TabIndex = 23;
            this.lblInputRight.Text = "Eingabekoordinatensystem(a\',b\',c\'):";
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(795, 719);
            this.butFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(129, 49);
            this.butFx.TabIndex = 24;
            this.butFx.Text = "f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            // 
            // txtFx
            // 
            this.txtFx.Location = new System.Drawing.Point(930, 735);
            this.txtFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(176, 22);
            this.txtFx.TabIndex = 12;
            // 
            // cosInputLeft
            // 
            this.cosInputLeft.Location = new System.Drawing.Point(16, 236);
            this.cosInputLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosInputLeft.Name = "cosInputLeft";
            this.cosInputLeft.Size = new System.Drawing.Size(508, 393);
            this.cosInputLeft.TabIndex = 25;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(649, 236);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(508, 393);
            this.cosOutput.TabIndex = 26;
            // 
            // cosInputRight
            // 
            this.cosInputRight.Location = new System.Drawing.Point(1271, 236);
            this.cosInputRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosInputRight.Name = "cosInputRight";
            this.cosInputRight.Size = new System.Drawing.Size(508, 393);
            this.cosInputRight.TabIndex = 27;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(621, 841);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 29;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(621, 864);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 28;
            this.rtxtNotes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thema: Zuordnungsvorschrift affine Abbildungen studieren";
            // 
            // lblFx
            // 
            this.lblFx.AutoSize = true;
            this.lblFx.Location = new System.Drawing.Point(804, 770);
            this.lblFx.Name = "lblFx";
            this.lblFx.Size = new System.Drawing.Size(110, 17);
            this.lblFx.TabIndex = 42;
            this.lblFx.Text = "f(x)= f2(f1^-1(x))";
            // 
            // FrmZuordAffAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1035);
            this.Controls.Add(this.lblFx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtFunction2X);
            this.Controls.Add(this.txtFunction1X);
            this.Controls.Add(this.txtInverseFunction1X);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.lblFunction2X);
            this.Controls.Add(this.cosInputRight);
            this.Controls.Add(this.lblInverseFunction1X);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.lblFunction1X);
            this.Controls.Add(this.cosInputLeft);
            this.Controls.Add(this.txtFx);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.lblInputRight);
            this.Controls.Add(this.grpDataInput2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInputLeft);
            this.Controls.Add(this.grpDataInput1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmZuordAffAbb";
            this.Text = "FrmZuordAffAbb";
            this.grpDataInput1.ResumeLayout(false);
            this.grpDataInput1.PerformLayout();
            this.grpDataInput2.ResumeLayout(false);
            this.grpDataInput2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInputLeft;
        private System.Windows.Forms.GroupBox grpDataInput1;
        private System.Windows.Forms.Label lblPointC1;
        private System.Windows.Forms.TextBox txtFunction1X;
        private System.Windows.Forms.TextBox txtInverseFunction1X;
        private System.Windows.Forms.Label lblPointA1;
        private System.Windows.Forms.Label lblInverseFunction1X;
        private System.Windows.Forms.Label lblFunction1X;
        private System.Windows.Forms.Label lblPointB1;
        private System.Windows.Forms.GroupBox grpDataInput2;
        private System.Windows.Forms.Label lblPointC2;
        private System.Windows.Forms.TextBox txtFunction2X;
        private System.Windows.Forms.Label lblPointA2;
        private System.Windows.Forms.Label lblFunction2X;
        private System.Windows.Forms.Label lblPointB2;
        private System.Windows.Forms.Label lblInputRight;
        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.TextBox txtFx;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInputLeft;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInputRight;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFx;
    }
}