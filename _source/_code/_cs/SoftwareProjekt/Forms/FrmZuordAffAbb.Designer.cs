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
            this.picArrowToRightBottom = new System.Windows.Forms.PictureBox();
            this.picArrowToRightRight = new System.Windows.Forms.PictureBox();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.ctlMathEquaToLeft = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.ctlMathEquaToRightMiddle = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.ctlFormularDraw1 = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.ctlMathEquaToRightRight = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInput1.SuspendLayout();
            this.grpDataInput2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRightMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRightBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRightRight)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Controls.Add(this.ctlVectorInputC);
            this.grpDataInput1.Controls.Add(this.ctlVectorInputB);
            this.grpDataInput1.Controls.Add(this.ctlVectorInputA);
            this.grpDataInput1.Location = new System.Drawing.Point(12, 841);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Size = new System.Drawing.Size(493, 127);
            this.grpDataInput1.TabIndex = 8;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe";
            // 
            // ctlVectorInputC
            // 
            this.ctlVectorInputC.Text = "Vector Input";
            this.ctlVectorInputC.Location = new System.Drawing.Point(329, 21);
            this.ctlVectorInputC.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputC.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputC.Name = "ctlVectorInputC";
            this.ctlVectorInputC.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInputC.TabIndex = 2;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputC.Vector = vector1;
            // 
            // ctlVectorInputB
            // 
            this.ctlVectorInputB.Text = "Vector Input";
            this.ctlVectorInputB.Location = new System.Drawing.Point(168, 20);
            this.ctlVectorInputB.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputB.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputB.Name = "ctlVectorInputB";
            this.ctlVectorInputB.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInputB.TabIndex = 1;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInputB.Vector = vector2;
            // 
            // ctlVectorInputA
            // 
            this.ctlVectorInputA.Text = "Vector Input";
            this.ctlVectorInputA.Location = new System.Drawing.Point(7, 21);
            this.ctlVectorInputA.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputA.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputA.Name = "ctlVectorInputA";
            this.ctlVectorInputA.Size = new System.Drawing.Size(153, 102);
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
            this.grpDataInput2.Location = new System.Drawing.Point(926, 841);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Size = new System.Drawing.Size(498, 132);
            this.grpDataInput2.TabIndex = 10;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe";
            // 
            // ctlVectorInputC2
            // 
            this.ctlVectorInputC2.Text = "Vector Input";
            this.ctlVectorInputC2.Location = new System.Drawing.Point(329, 21);
            this.ctlVectorInputC2.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputC2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputC2.Name = "ctlVectorInputC2";
            this.ctlVectorInputC2.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInputC2.TabIndex = 2;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInputC2.Vector = vector4;
            // 
            // ctlVectorInputB2
            // 
            this.ctlVectorInputB2.Text = "Vector Input";
            this.ctlVectorInputB2.Location = new System.Drawing.Point(168, 21);
            this.ctlVectorInputB2.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputB2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputB2.Name = "ctlVectorInputB2";
            this.ctlVectorInputB2.Size = new System.Drawing.Size(153, 102);
            this.ctlVectorInputB2.TabIndex = 1;
            vector5.X1 = float.NaN;
            vector5.X2 = float.NaN;
            this.ctlVectorInputB2.Vector = vector5;
            // 
            // ctlVectorInputA2
            // 
            this.ctlVectorInputA2.Text = "Vector Input";
            this.ctlVectorInputA2.Location = new System.Drawing.Point(7, 21);
            this.ctlVectorInputA2.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputA2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputA2.Name = "ctlVectorInputA2";
            this.ctlVectorInputA2.Size = new System.Drawing.Size(153, 102);
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
            this.butFx.Location = new System.Drawing.Point(1030, 1009);
            this.butFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(277, 35);
            this.butFx.TabIndex = 12;
            this.butFx.Text = "Berechne Gesamtergebnis";
            this.butFx.UseVisualStyleBackColor = false;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // cosInputABC
            // 
            this.cosInputABC.DoNotRefresh = false;
            this.cosInputABC.Location = new System.Drawing.Point(2, 349);
            this.cosInputABC.Margin = new System.Windows.Forms.Padding(4);
            this.cosInputABC.Name = "cosInputABC";
            this.cosInputABC.Size = new System.Drawing.Size(508, 464);
            this.cosInputABC.TabIndex = 1;
            // 
            // cosOutput
            // 
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(906, 349);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(508, 464);
            this.cosOutput.TabIndex = 5;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(690, 1178);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(71, 20);
            this.lblNotes.TabIndex = 29;
            this.lblNotes.Text = "Notizen:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(801, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(671, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Zuordnungsvorschrift affine Abbildungen studieren";
            // 
            // butFunction1X
            // 
            this.butFunction1X.AutoSize = true;
            this.butFunction1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunction1X.Location = new System.Drawing.Point(652, 483);
            this.butFunction1X.Name = "butFunction1X";
            this.butFunction1X.Size = new System.Drawing.Size(109, 30);
            this.butFunction1X.TabIndex = 3;
            this.butFunction1X.Text = "Berechnen";
            this.butFunction1X.UseVisualStyleBackColor = true;
            this.butFunction1X.Click += new System.EventHandler(this.butFunction1X_Click);
            // 
            // butInverseFunction1X
            // 
            this.butInverseFunction1X.AutoSize = true;
            this.butInverseFunction1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInverseFunction1X.Location = new System.Drawing.Point(609, 1009);
            this.butInverseFunction1X.Name = "butInverseFunction1X";
            this.butInverseFunction1X.Size = new System.Drawing.Size(169, 35);
            this.butInverseFunction1X.TabIndex = 11;
            this.butInverseFunction1X.Text = "Berechne Inverse";
            this.butInverseFunction1X.UseVisualStyleBackColor = true;
            this.butInverseFunction1X.Click += new System.EventHandler(this.butInverseFunction1X_Click);
            // 
            // butFunction2X
            // 
            this.butFunction2X.AutoSize = true;
            this.butFunction2X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunction2X.Location = new System.Drawing.Point(1529, 1009);
            this.butFunction2X.Name = "butFunction2X";
            this.butFunction2X.Size = new System.Drawing.Size(109, 30);
            this.butFunction2X.TabIndex = 13;
            this.butFunction2X.Text = "Berechnen";
            this.butFunction2X.UseVisualStyleBackColor = true;
            this.butFunction2X.Click += new System.EventHandler(this.butFunction2X_Click);
            // 
            // cosInputA2B2C2
            // 
            this.cosInputA2B2C2.DoNotRefresh = false;
            this.cosInputA2B2C2.Location = new System.Drawing.Point(1786, 349);
            this.cosInputA2B2C2.Margin = new System.Windows.Forms.Padding(4);
            this.cosInputA2B2C2.Name = "cosInputA2B2C2";
            this.cosInputA2B2C2.Size = new System.Drawing.Size(508, 464);
            this.cosInputA2B2C2.TabIndex = 7;
            // 
            // picArrowToLeft
            // 
            this.picArrowToLeft.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToLeft.Image = global::SoftwareProjekt.Properties.Resources.arrowToLeft;
            this.picArrowToLeft.Location = new System.Drawing.Point(517, 263);
            this.picArrowToLeft.Name = "picArrowToLeft";
            this.picArrowToLeft.Size = new System.Drawing.Size(366, 205);
            this.picArrowToLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowToLeft.TabIndex = 43;
            this.picArrowToLeft.TabStop = false;
            // 
            // picArrowToRightMiddle
            // 
            this.picArrowToRightMiddle.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToRightMiddle.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowToRightMiddle.Location = new System.Drawing.Point(517, 537);
            this.picArrowToRightMiddle.Name = "picArrowToRightMiddle";
            this.picArrowToRightMiddle.Size = new System.Drawing.Size(366, 205);
            this.picArrowToRightMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowToRightMiddle.TabIndex = 44;
            this.picArrowToRightMiddle.TabStop = false;
            // 
            // picArrowToRightBottom
            // 
            this.picArrowToRightBottom.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToRightBottom.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowToRightBottom.Location = new System.Drawing.Point(517, 774);
            this.picArrowToRightBottom.Name = "picArrowToRightBottom";
            this.picArrowToRightBottom.Size = new System.Drawing.Size(366, 205);
            this.picArrowToRightBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowToRightBottom.TabIndex = 45;
            this.picArrowToRightBottom.TabStop = false;
            // 
            // picArrowToRightRight
            // 
            this.picArrowToRightRight.BackColor = System.Drawing.Color.Transparent;
            this.picArrowToRightRight.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrowToRightRight.Location = new System.Drawing.Point(1390, 537);
            this.picArrowToRightRight.Name = "picArrowToRightRight";
            this.picArrowToRightRight.Size = new System.Drawing.Size(366, 205);
            this.picArrowToRightRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowToRightRight.TabIndex = 46;
            this.picArrowToRightRight.TabStop = false;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(694, 1201);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(553, 96);
            this.rtxtNotes.TabIndex = 47;
            this.rtxtNotes.Text = "";
            // 
            // ctlMathEquaToLeft
            // 
            this.ctlMathEquaToLeft.Equation = "";
            this.ctlMathEquaToLeft.Filename = "vabtnsuw.jmi.tiff";
            this.ctlMathEquaToLeft.Filepath = "";
            this.ctlMathEquaToLeft.FontSize = 8;
            this.ctlMathEquaToLeft.Location = new System.Drawing.Point(682, 324);
            this.ctlMathEquaToLeft.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEquaToLeft.Name = "ctlMathEquaToLeft";
            this.ctlMathEquaToLeft.Size = new System.Drawing.Size(163, 82);
            this.ctlMathEquaToLeft.TabIndex = 2;
            // 
            // ctlMathEquaToRightMiddle
            // 
            this.ctlMathEquaToRightMiddle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEquaToRightMiddle.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquaToRightMiddle.Equation = "";
            this.ctlMathEquaToRightMiddle.Filename = "2de2yuws.mxz.tiff";
            this.ctlMathEquaToRightMiddle.Filepath = "";
            this.ctlMathEquaToRightMiddle.FontSize = 8;
            this.ctlMathEquaToRightMiddle.Location = new System.Drawing.Point(554, 601);
            this.ctlMathEquaToRightMiddle.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEquaToRightMiddle.Name = "ctlMathEquaToRightMiddle";
            this.ctlMathEquaToRightMiddle.Size = new System.Drawing.Size(144, 65);
            this.ctlMathEquaToRightMiddle.TabIndex = 4;
            // 
            // ctlFormularDraw1
            // 
            this.ctlFormularDraw1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctlFormularDraw1.BackColor = System.Drawing.Color.Transparent;
            this.ctlFormularDraw1.Equation = "";
            this.ctlFormularDraw1.Filename = "2de2yuws.mxz.tiff";
            this.ctlFormularDraw1.Filepath = "";
            this.ctlFormularDraw1.FontSize = 8;
            this.ctlFormularDraw1.Location = new System.Drawing.Point(554, 841);
            this.ctlFormularDraw1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlFormularDraw1.Name = "ctlFormularDraw1";
            this.ctlFormularDraw1.Size = new System.Drawing.Size(144, 65);
            this.ctlFormularDraw1.TabIndex = 9;
            // 
            // ctlMathEquaToRightRight
            // 
            this.ctlMathEquaToRightRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlMathEquaToRightRight.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEquaToRightRight.Equation = "";
            this.ctlMathEquaToRightRight.Filename = "2de2yuws.mxz.tiff";
            this.ctlMathEquaToRightRight.Filepath = "";
            this.ctlMathEquaToRightRight.FontSize = 8;
            this.ctlMathEquaToRightRight.Location = new System.Drawing.Point(1422, 601);
            this.ctlMathEquaToRightRight.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEquaToRightRight.Name = "ctlMathEquaToRightRight";
            this.ctlMathEquaToRightRight.Size = new System.Drawing.Size(144, 65);
            this.ctlMathEquaToRightRight.TabIndex = 6;
            // 
            // FrmZuordAffAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1045);
            this.Controls.Add(this.ctlMathEquaToRightRight);
            this.Controls.Add(this.ctlFormularDraw1);
            this.Controls.Add(this.ctlMathEquaToRightMiddle);
            this.Controls.Add(this.ctlMathEquaToLeft);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.picArrowToRightRight);
            this.Controls.Add(this.picArrowToRightBottom);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmZuordAffAbb";
            this.Text = "Zuordnungsvorschrift einer affinen Abbildung";
            this.grpDataInput1.ResumeLayout(false);
            this.grpDataInput2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRightMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowToRightBottom)).EndInit();
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
        private System.Windows.Forms.PictureBox picArrowToRightBottom;
        private System.Windows.Forms.PictureBox picArrowToRightRight;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToLeft;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToRightMiddle;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlFormularDraw1;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEquaToRightRight;
    }
}