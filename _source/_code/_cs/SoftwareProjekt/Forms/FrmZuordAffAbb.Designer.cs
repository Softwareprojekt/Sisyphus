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
            SoftwareProjekt.Classes.Math.Vector vector1 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector3 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector4 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector5 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector6 = new SoftwareProjekt.Classes.Math.Vector();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInputLeft = new System.Windows.Forms.Label();
            this.grpDataInput1 = new System.Windows.Forms.GroupBox();
            this.ctlVectorInput3 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInput2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInput1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.lblPointC1 = new System.Windows.Forms.Label();
            this.lblPointA1 = new System.Windows.Forms.Label();
            this.lblPointB1 = new System.Windows.Forms.Label();
            this.txtFunction1X = new System.Windows.Forms.TextBox();
            this.txtInverseFunction1X = new System.Windows.Forms.TextBox();
            this.grpDataInput2 = new System.Windows.Forms.GroupBox();
            this.ctlVectorInput6 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInput5 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInput4 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.lblPointC2 = new System.Windows.Forms.Label();
            this.lblPointA2 = new System.Windows.Forms.Label();
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
            this.butFunction1X = new System.Windows.Forms.Button();
            this.butInverseFunction1X = new System.Windows.Forms.Button();
            this.butFunction2X = new System.Windows.Forms.Button();
            this.txtFunction2X = new System.Windows.Forms.TextBox();
            this.grpDataInput1.SuspendLayout();
            this.grpDataInput2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(852, 222);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(187, 17);
            this.lblOutput.TabIndex = 21;
            this.lblOutput.Text = "Ausgabekoordinatensystem:";
            // 
            // lblInputLeft
            // 
            this.lblInputLeft.AutoSize = true;
            this.lblInputLeft.Location = new System.Drawing.Point(181, 222);
            this.lblInputLeft.Name = "lblInputLeft";
            this.lblInputLeft.Size = new System.Drawing.Size(224, 17);
            this.lblInputLeft.TabIndex = 20;
            this.lblInputLeft.Text = "Eingabekoordinatensystem(a,b,c):";
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Controls.Add(this.ctlVectorInput3);
            this.grpDataInput1.Controls.Add(this.ctlVectorInput2);
            this.grpDataInput1.Controls.Add(this.ctlVectorInput1);
            this.grpDataInput1.Controls.Add(this.lblPointC1);
            this.grpDataInput1.Controls.Add(this.lblPointA1);
            this.grpDataInput1.Controls.Add(this.lblPointB1);
            this.grpDataInput1.Location = new System.Drawing.Point(16, 68);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Size = new System.Drawing.Size(508, 152);
            this.grpDataInput1.TabIndex = 15;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe";
            // 
            // ctlVectorInput3
            // 
            this.ctlVectorInput3.Location = new System.Drawing.Point(329, 48);
            this.ctlVectorInput3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInput3.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInput3.Name = "ctlVectorInput3";
            this.ctlVectorInput3.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInput3.TabIndex = 3;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInput3.Vector = vector1;
            // 
            // ctlVectorInput2
            // 
            this.ctlVectorInput2.Location = new System.Drawing.Point(168, 48);
            this.ctlVectorInput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInput2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInput2.Name = "ctlVectorInput2";
            this.ctlVectorInput2.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInput2.TabIndex = 2;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInput2.Vector = vector2;
            // 
            // ctlVectorInput1
            // 
            this.ctlVectorInput1.Location = new System.Drawing.Point(7, 48);
            this.ctlVectorInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInput1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInput1.Name = "ctlVectorInput1";
            this.ctlVectorInput1.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInput1.TabIndex = 1;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorInput1.Vector = vector3;
            // 
            // lblPointC1
            // 
            this.lblPointC1.AutoSize = true;
            this.lblPointC1.Location = new System.Drawing.Point(378, 27);
            this.lblPointC1.Name = "lblPointC1";
            this.lblPointC1.Size = new System.Drawing.Size(59, 17);
            this.lblPointC1.TabIndex = 10;
            this.lblPointC1.Text = "Punkt c:";
            // 
            // lblPointA1
            // 
            this.lblPointA1.AutoSize = true;
            this.lblPointA1.Location = new System.Drawing.Point(49, 27);
            this.lblPointA1.Name = "lblPointA1";
            this.lblPointA1.Size = new System.Drawing.Size(60, 17);
            this.lblPointA1.TabIndex = 0;
            this.lblPointA1.Text = "Punkt a:";
            // 
            // lblPointB1
            // 
            this.lblPointB1.AutoSize = true;
            this.lblPointB1.Location = new System.Drawing.Point(212, 27);
            this.lblPointB1.Name = "lblPointB1";
            this.lblPointB1.Size = new System.Drawing.Size(60, 17);
            this.lblPointB1.TabIndex = 4;
            this.lblPointB1.Text = "Punkt b:";
            // 
            // txtFunction1X
            // 
            this.txtFunction1X.Location = new System.Drawing.Point(629, 90);
            this.txtFunction1X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFunction1X.Name = "txtFunction1X";
            this.txtFunction1X.Size = new System.Drawing.Size(254, 22);
            this.txtFunction1X.TabIndex = 9;
            this.txtFunction1X.TextChanged += new System.EventHandler(this.txtFunction1X_TextChanged);
            // 
            // txtInverseFunction1X
            // 
            this.txtInverseFunction1X.Location = new System.Drawing.Point(629, 151);
            this.txtInverseFunction1X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInverseFunction1X.Name = "txtInverseFunction1X";
            this.txtInverseFunction1X.Size = new System.Drawing.Size(254, 22);
            this.txtInverseFunction1X.TabIndex = 8;
            this.txtInverseFunction1X.TextChanged += new System.EventHandler(this.txtInverseFunction1X_TextChanged);
            // 
            // grpDataInput2
            // 
            this.grpDataInput2.Controls.Add(this.ctlVectorInput6);
            this.grpDataInput2.Controls.Add(this.ctlVectorInput5);
            this.grpDataInput2.Controls.Add(this.ctlVectorInput4);
            this.grpDataInput2.Controls.Add(this.lblPointC2);
            this.grpDataInput2.Controls.Add(this.lblPointA2);
            this.grpDataInput2.Controls.Add(this.lblPointB2);
            this.grpDataInput2.Location = new System.Drawing.Point(906, 68);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Size = new System.Drawing.Size(509, 152);
            this.grpDataInput2.TabIndex = 16;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe";
            // 
            // ctlVectorInput6
            // 
            this.ctlVectorInput6.Location = new System.Drawing.Point(329, 48);
            this.ctlVectorInput6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInput6.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInput6.Name = "ctlVectorInput6";
            this.ctlVectorInput6.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInput6.TabIndex = 8;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInput6.Vector = vector4;
            // 
            // ctlVectorInput5
            // 
            this.ctlVectorInput5.Location = new System.Drawing.Point(168, 48);
            this.ctlVectorInput5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInput5.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInput5.Name = "ctlVectorInput5";
            this.ctlVectorInput5.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInput5.TabIndex = 7;
            vector5.X1 = float.NaN;
            vector5.X2 = float.NaN;
            this.ctlVectorInput5.Vector = vector5;
            // 
            // ctlVectorInput4
            // 
            this.ctlVectorInput4.Location = new System.Drawing.Point(7, 48);
            this.ctlVectorInput4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInput4.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInput4.Name = "ctlVectorInput4";
            this.ctlVectorInput4.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInput4.TabIndex = 6;
            vector6.X1 = float.NaN;
            vector6.X2 = float.NaN;
            this.ctlVectorInput4.Vector = vector6;
            // 
            // lblPointC2
            // 
            this.lblPointC2.AutoSize = true;
            this.lblPointC2.Location = new System.Drawing.Point(373, 27);
            this.lblPointC2.Name = "lblPointC2";
            this.lblPointC2.Size = new System.Drawing.Size(62, 17);
            this.lblPointC2.TabIndex = 10;
            this.lblPointC2.Text = "Punkt c\':";
            // 
            // lblPointA2
            // 
            this.lblPointA2.AutoSize = true;
            this.lblPointA2.Location = new System.Drawing.Point(35, 27);
            this.lblPointA2.Name = "lblPointA2";
            this.lblPointA2.Size = new System.Drawing.Size(63, 17);
            this.lblPointA2.TabIndex = 0;
            this.lblPointA2.Text = "Punkt a\':";
            // 
            // lblPointB2
            // 
            this.lblPointB2.AutoSize = true;
            this.lblPointB2.Location = new System.Drawing.Point(207, 27);
            this.lblPointB2.Name = "lblPointB2";
            this.lblPointB2.Size = new System.Drawing.Size(63, 17);
            this.lblPointB2.TabIndex = 4;
            this.lblPointB2.Text = "Punkt b\':";
            // 
            // lblInputRight
            // 
            this.lblInputRight.AutoSize = true;
            this.lblInputRight.Location = new System.Drawing.Point(1471, 222);
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
            this.butFx.TabIndex = 10;
            this.butFx.Text = "f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // txtFx
            // 
            this.txtFx.Location = new System.Drawing.Point(930, 735);
            this.txtFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(176, 22);
            this.txtFx.TabIndex = 12;
            this.txtFx.TextChanged += new System.EventHandler(this.txtFx_TextChanged);
            // 
            // cosInputLeft
            // 
            this.cosInputLeft.Location = new System.Drawing.Point(16, 236);
            this.cosInputLeft.Margin = new System.Windows.Forms.Padding(4);
            this.cosInputLeft.Name = "cosInputLeft";
            this.cosInputLeft.Size = new System.Drawing.Size(508, 393);
            this.cosInputLeft.TabIndex = 25;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(649, 236);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(508, 393);
            this.cosOutput.TabIndex = 26;
            // 
            // cosInputRight
            // 
            this.cosInputRight.Location = new System.Drawing.Point(1271, 236);
            this.cosInputRight.Margin = new System.Windows.Forms.Padding(4);
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
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 11;
            this.rtxtNotes.Text = "";
            this.rtxtNotes.TextChanged += new System.EventHandler(this.rtxtNotes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 9);
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
            // butFunction1X
            // 
            this.butFunction1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunction1X.Location = new System.Drawing.Point(530, 76);
            this.butFunction1X.Name = "butFunction1X";
            this.butFunction1X.Size = new System.Drawing.Size(93, 53);
            this.butFunction1X.TabIndex = 4;
            this.butFunction1X.Text = "f1(x)";
            this.butFunction1X.UseVisualStyleBackColor = true;
            this.butFunction1X.Click += new System.EventHandler(this.butFunction1X_Click);
            // 
            // butInverseFunction1X
            // 
            this.butInverseFunction1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInverseFunction1X.Location = new System.Drawing.Point(530, 135);
            this.butInverseFunction1X.Name = "butInverseFunction1X";
            this.butInverseFunction1X.Size = new System.Drawing.Size(93, 53);
            this.butInverseFunction1X.TabIndex = 5;
            this.butInverseFunction1X.Text = "f^-1(x)";
            this.butInverseFunction1X.UseVisualStyleBackColor = true;
            this.butInverseFunction1X.Click += new System.EventHandler(this.butInverseFunction1X_Click);
            // 
            // butFunction2X
            // 
            this.butFunction2X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunction2X.Location = new System.Drawing.Point(1426, 121);
            this.butFunction2X.Name = "butFunction2X";
            this.butFunction2X.Size = new System.Drawing.Size(93, 53);
            this.butFunction2X.TabIndex = 9;
            this.butFunction2X.Text = "f2(x)";
            this.butFunction2X.UseVisualStyleBackColor = true;
            this.butFunction2X.Click += new System.EventHandler(this.butFunction2X_Click);
            // 
            // txtFunction2X
            // 
            this.txtFunction2X.Location = new System.Drawing.Point(1525, 135);
            this.txtFunction2X.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFunction2X.Name = "txtFunction2X";
            this.txtFunction2X.Size = new System.Drawing.Size(254, 22);
            this.txtFunction2X.TabIndex = 46;
            this.txtFunction2X.TextChanged += new System.EventHandler(this.txtFunction2X_TextChanged);
            // 
            // FrmZuordAffAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1035);
            this.Controls.Add(this.txtFunction2X);
            this.Controls.Add(this.butFunction2X);
            this.Controls.Add(this.butInverseFunction1X);
            this.Controls.Add(this.butFunction1X);
            this.Controls.Add(this.lblFx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtFunction1X);
            this.Controls.Add(this.txtInverseFunction1X);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosInputRight);
            this.Controls.Add(this.cosOutput);
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
        private System.Windows.Forms.Label lblPointB1;
        private System.Windows.Forms.GroupBox grpDataInput2;
        private System.Windows.Forms.Label lblPointC2;
        private System.Windows.Forms.Label lblPointA2;
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
        private UserControls.CtlVectorInput ctlVectorInput3;
        private UserControls.CtlVectorInput ctlVectorInput2;
        private UserControls.CtlVectorInput ctlVectorInput1;
        private UserControls.CtlVectorInput ctlVectorInput6;
        private UserControls.CtlVectorInput ctlVectorInput5;
        private UserControls.CtlVectorInput ctlVectorInput4;
        private System.Windows.Forms.Button butFunction1X;
        private System.Windows.Forms.Button butInverseFunction1X;
        private System.Windows.Forms.Button butFunction2X;
        private System.Windows.Forms.TextBox txtFunction2X;
    }
}