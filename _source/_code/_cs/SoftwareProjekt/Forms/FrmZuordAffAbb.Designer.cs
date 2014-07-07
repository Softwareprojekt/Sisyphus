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
            this.grpDataInput1 = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputC = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputB = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputA = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.grpDataInput2 = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputC2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputB2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputA2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.butFx = new System.Windows.Forms.Button();
            this.cosInputABC = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.butFunction1X = new System.Windows.Forms.Button();
            this.butInverseFunction1X = new System.Windows.Forms.Button();
            this.butFunction2X = new System.Windows.Forms.Button();
            this.cosInputA2B2C2 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.picArrowToLeft = new System.Windows.Forms.PictureBox();
            this.picArrowToRightMiddle = new System.Windows.Forms.PictureBox();
            this.picArrowToRightRight = new System.Windows.Forms.PictureBox();
            this._rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.ctlMathEquaToLeft = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.ctlMathEquaToRightLeft = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.ctlMathEquaToRightRight = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInput1.SuspendLayout();
            this.grpDataInput2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRightMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRightRight)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Controls.Add(this.ctlVectorInputC);
            this.grpDataInput1.Controls.Add(this.ctlVectorInputB);
            this.grpDataInput1.Controls.Add(this.ctlVectorInputA);
            this.grpDataInput1.Location = new System.Drawing.Point(9, 683);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput1.Size = new System.Drawing.Size(370, 103);
            this.grpDataInput1.TabIndex = 8;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe";
            // 
            // ctlVectorInputC
            // 
            this.ctlVectorInputC.Location = new System.Drawing.Point(247, 17);
            this.ctlVectorInputC.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputC.Name = "ctlVectorInputC";
            this.ctlVectorInputC.Size = new System.Drawing.Size(115, 83);
            this.ctlVectorInputC.TabIndex = 2;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputC.Vector = vector1;
            // 
            // ctlVectorInputB
            // 
            this.ctlVectorInputB.Location = new System.Drawing.Point(126, 16);
            this.ctlVectorInputB.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputB.Name = "ctlVectorInputB";
            this.ctlVectorInputB.Size = new System.Drawing.Size(115, 83);
            this.ctlVectorInputB.TabIndex = 1;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInputB.Vector = vector2;
            // 
            // ctlVectorInputA
            // 
            this.ctlVectorInputA.Location = new System.Drawing.Point(5, 17);
            this.ctlVectorInputA.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputA.Name = "ctlVectorInputA";
            this.ctlVectorInputA.Size = new System.Drawing.Size(115, 83);
            this.ctlVectorInputA.TabIndex = 0;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorInputA.Vector = vector3;
            // 
            // grpDataInput2
            // 
            this.grpDataInput2.Controls.Add(this.ctlVectorInputC2);
            this.grpDataInput2.Controls.Add(this.ctlVectorInputB2);
            this.grpDataInput2.Controls.Add(this.ctlVectorInputA2);
            this.grpDataInput2.Location = new System.Drawing.Point(694, 683);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput2.Size = new System.Drawing.Size(374, 107);
            this.grpDataInput2.TabIndex = 10;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe";
            // 
            // ctlVectorInputC2
            // 
            this.ctlVectorInputC2.Location = new System.Drawing.Point(247, 17);
            this.ctlVectorInputC2.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputC2.Name = "ctlVectorInputC2";
            this.ctlVectorInputC2.Size = new System.Drawing.Size(115, 83);
            this.ctlVectorInputC2.TabIndex = 2;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInputC2.Vector = vector4;
            // 
            // ctlVectorInputB2
            // 
            this.ctlVectorInputB2.Location = new System.Drawing.Point(126, 17);
            this.ctlVectorInputB2.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputB2.Name = "ctlVectorInputB2";
            this.ctlVectorInputB2.Size = new System.Drawing.Size(115, 83);
            this.ctlVectorInputB2.TabIndex = 1;
            vector5.X1 = float.NaN;
            vector5.X2 = float.NaN;
            this.ctlVectorInputB2.Vector = vector5;
            // 
            // ctlVectorInputA2
            // 
            this.ctlVectorInputA2.Location = new System.Drawing.Point(5, 17);
            this.ctlVectorInputA2.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputA2.Name = "ctlVectorInputA2";
            this.ctlVectorInputA2.Size = new System.Drawing.Size(115, 83);
            this.ctlVectorInputA2.TabIndex = 0;
            vector6.X1 = float.NaN;
            vector6.X2 = float.NaN;
            this.ctlVectorInputA2.Vector = vector6;
            // 
            // butFx
            // 
            this.butFx.AutoSize = true;
            this.butFx.BackColor = System.Drawing.SystemColors.Highlight;
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(772, 820);
            this.butFx.Margin = new System.Windows.Forms.Padding(2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(233, 30);
            this.butFx.TabIndex = 12;
            this.butFx.Text = "Berechne Gesamtergebnis";
            this.butFx.UseVisualStyleBackColor = false;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // cosInputABC
            // 
            this.cosInputABC.DoNotRefresh = false;
            this.cosInputABC.Location = new System.Drawing.Point(2, 284);
            this.cosInputABC.Name = "cosInputABC";
            this.cosInputABC.Size = new System.Drawing.Size(381, 377);
            this.cosInputABC.TabIndex = 1;
            // 
            // cosOutput
            // 
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(680, 284);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(381, 377);
            this.cosOutput.TabIndex = 5;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(518, 957);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 29;
            this.lblNotes.Text = "Notizen:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(601, 7);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(520, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Zuordnungsvorschrift affine Abbildungen studieren";
            // 
            // butFunction1X
            // 
            this.butFunction1X.AutoSize = true;
            this.butFunction1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunction1X.Location = new System.Drawing.Point(489, 425);
            this.butFunction1X.Margin = new System.Windows.Forms.Padding(2);
            this.butFunction1X.Name = "butFunction1X";
            this.butFunction1X.Size = new System.Drawing.Size(96, 27);
            this.butFunction1X.TabIndex = 3;
            this.butFunction1X.Text = "Berechnen";
            this.butFunction1X.UseVisualStyleBackColor = true;
            this.butFunction1X.Click += new System.EventHandler(this.butFunction1X_Click);
            // 
            // butInverseFunction1X
            // 
            this.butInverseFunction1X.AutoSize = true;
            this.butInverseFunction1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInverseFunction1X.Location = new System.Drawing.Point(457, 820);
            this.butInverseFunction1X.Margin = new System.Windows.Forms.Padding(2);
            this.butInverseFunction1X.Name = "butInverseFunction1X";
            this.butInverseFunction1X.Size = new System.Drawing.Size(145, 28);
            this.butInverseFunction1X.TabIndex = 11;
            this.butInverseFunction1X.Text = "Berechne Inverse";
            this.butInverseFunction1X.UseVisualStyleBackColor = true;
            this.butInverseFunction1X.Click += new System.EventHandler(this.butInverseFunction1X_Click);
            // 
            // butFunction2X
            // 
            this.butFunction2X.AutoSize = true;
            this.butFunction2X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunction2X.Location = new System.Drawing.Point(1147, 820);
            this.butFunction2X.Margin = new System.Windows.Forms.Padding(2);
            this.butFunction2X.Name = "butFunction2X";
            this.butFunction2X.Size = new System.Drawing.Size(96, 27);
            this.butFunction2X.TabIndex = 13;
            this.butFunction2X.Text = "Berechnen";
            this.butFunction2X.UseVisualStyleBackColor = true;
            this.butFunction2X.Click += new System.EventHandler(this.butFunction2X_Click);
            // 
            // cosInputA2B2C2
            // 
            this.cosInputA2B2C2.DoNotRefresh = false;
            this.cosInputA2B2C2.Location = new System.Drawing.Point(1340, 284);
            this.cosInputA2B2C2.Name = "cosInputA2B2C2";
            this.cosInputA2B2C2.Size = new System.Drawing.Size(381, 377);
            this.cosInputA2B2C2.TabIndex = 7;
            // 
            // picArrowToLeft
            // 
            this.picArrowToLeft.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToLeft.Image = global::SoftwareProjekt.Properties.Resources.arrowToLeft;
            this.picArrowToLeft.Location = new System.Drawing.Point(388, 254);
            this.picArrowToLeft.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowToLeft.Name = "picArrowToLeft";
            this.picArrowToLeft.Size = new System.Drawing.Size(274, 167);
            this.picArrowToLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowToLeft.TabIndex = 43;
            this.picArrowToLeft.TabStop = false;
            // 
            // picArrowToRightMiddle
            // 
            this.picArrowToRightMiddle.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToRightMiddle.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowToRightMiddle.Location = new System.Drawing.Point(388, 466);
            this.picArrowToRightMiddle.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowToRightMiddle.Name = "picArrowToRightMiddle";
            this.picArrowToRightMiddle.Size = new System.Drawing.Size(274, 167);
            this.picArrowToRightMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowToRightMiddle.TabIndex = 44;
            this.picArrowToRightMiddle.TabStop = false;
            // 
            // picArrowToRightRight
            // 
            this.picArrowToRightRight.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToRightRight.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowToRightRight.Location = new System.Drawing.Point(1042, 436);
            this.picArrowToRightRight.Margin = new System.Windows.Forms.Padding(2);
            this.picArrowToRightRight.Name = "picArrowToRightRight";
            this.picArrowToRightRight.Size = new System.Drawing.Size(274, 167);
            this.picArrowToRightRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowToRightRight.TabIndex = 46;
            this.picArrowToRightRight.TabStop = false;
            // 
            // _rtxtNotes
            // 
            this._rtxtNotes.Location = new System.Drawing.Point(520, 976);
            this._rtxtNotes.Margin = new System.Windows.Forms.Padding(2);
            this._rtxtNotes.Name = "_rtxtNotes";
            this._rtxtNotes.Size = new System.Drawing.Size(416, 79);
            this._rtxtNotes.TabIndex = 47;
            this._rtxtNotes.Text = "";
            // 
            // ctlMathEquaToLeft
            // 
            this.ctlMathEquaToLeft.Equation = "";
            this.ctlMathEquaToLeft.Filename = "vabtnsuw.jmi.tiff";
            this.ctlMathEquaToLeft.Filepath = "";
            this.ctlMathEquaToLeft.FontSize = 11;
            this.ctlMathEquaToLeft.Location = new System.Drawing.Point(420, 311);
            this.ctlMathEquaToLeft.Name = "ctlMathEquaToLeft";
            this.ctlMathEquaToLeft.Size = new System.Drawing.Size(231, 57);
            this.ctlMathEquaToLeft.TabIndex = 2;
            // 
            // ctlMathEquaToRightLeft
            // 
            this.ctlMathEquaToRightLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEquaToRightLeft.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquaToRightLeft.Equation = "";
            this.ctlMathEquaToRightLeft.Filename = "2de2yuws.mxz.tiff";
            this.ctlMathEquaToRightLeft.Filepath = "";
            this.ctlMathEquaToRightLeft.FontSize = 8;
            this.ctlMathEquaToRightLeft.Location = new System.Drawing.Point(267, 518);
            this.ctlMathEquaToRightLeft.Name = "ctlMathEquaToRightLeft";
            this.ctlMathEquaToRightLeft.Size = new System.Drawing.Size(358, 64);
            this.ctlMathEquaToRightLeft.TabIndex = 4;
            // 
            // ctlMathEquaToRightRight
            // 
            this.ctlMathEquaToRightRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlMathEquaToRightRight.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquaToRightRight.Equation = "";
            this.ctlMathEquaToRightRight.Filename = "2de2yuws.mxz.tiff";
            this.ctlMathEquaToRightRight.Filepath = "";
            this.ctlMathEquaToRightRight.FontSize = 11;
            this.ctlMathEquaToRightRight.Location = new System.Drawing.Point(1055, 493);
            this.ctlMathEquaToRightRight.Name = "ctlMathEquaToRightRight";
            this.ctlMathEquaToRightRight.Size = new System.Drawing.Size(232, 52);
            this.ctlMathEquaToRightRight.TabIndex = 6;
            // 
            // FrmZuordAffAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 889);
            this.Controls.Add(this.ctlMathEquaToRightRight);
            this.Controls.Add(this.ctlMathEquaToRightLeft);
            this.Controls.Add(this.ctlMathEquaToLeft);
            this.Controls.Add(this._rtxtNotes);
            this.Controls.Add(this.picArrowToRightRight);
            this.Controls.Add(this.picArrowToRightMiddle);
            this.Controls.Add(this.picArrowToLeft);
            this.Controls.Add(this.butFunction2X);
            this.Controls.Add(this.butInverseFunction1X);
            this.Controls.Add(this.butFunction1X);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosInputA2B2C2);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInputABC);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.grpDataInput2);
            this.Controls.Add(this.grpDataInput1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmZuordAffAbb";
            this.Text = "Zuordnungsvorschrift einer affinen Abbildung";
            this.grpDataInput1.ResumeLayout(false);
            this.grpDataInput2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRightMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRightRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataInput1;
        private System.Windows.Forms.GroupBox grpDataInput2;
        private System.Windows.Forms.Button butFx;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInputABC;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblHeader;
        private UserControls.CtlVectorInput ctlVectorInputC;
        private UserControls.CtlVectorInput ctlVectorInputB;
        private UserControls.CtlVectorInput ctlVectorInputA;
        private UserControls.CtlVectorInput ctlVectorInputC2;
        private UserControls.CtlVectorInput ctlVectorInputB2;
        private UserControls.CtlVectorInput ctlVectorInputA2;
        private System.Windows.Forms.Button butFunction1X;
        private System.Windows.Forms.Button butInverseFunction1X;
        private System.Windows.Forms.Button butFunction2X;
        private UserControls.CoordinateSystem cosInputA2B2C2;
        private System.Windows.Forms.PictureBox picArrowToLeft;
        private System.Windows.Forms.PictureBox picArrowToRightMiddle;
        private System.Windows.Forms.PictureBox picArrowToRightRight;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToRightLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToRightRight;
#if DEBUG
        private System.Windows.Forms.RichTextBox _rtxtNotes;
#endif
    }
}