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
            SoftwareProjekt.Classes.Math.Vector vector1 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector3 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector4 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector5 = new SoftwareProjekt.Classes.Math.Vector();
            this.grpDataInputRight = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputM2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputM1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.grpDataInputLeft = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputEV2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputEV1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.butFunctionX = new System.Windows.Forms.Button();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.grpAddInfo = new System.Windows.Forms.GroupBox();
            this.txtDet = new System.Windows.Forms.TextBox();
            this.butDet = new System.Windows.Forms.Button();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInputRight.SuspendLayout();
            this.grpDataInputLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.grpAddInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDataInputRight
            // 
            this.grpDataInputRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataInputRight.Controls.Add(this.ctlVectorInputM2);
            this.grpDataInputRight.Controls.Add(this.ctlVectorInputM1);
            this.grpDataInputRight.Location = new System.Drawing.Point(1332, 637);
            this.grpDataInputRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInputRight.Name = "grpDataInputRight";
            this.grpDataInputRight.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInputRight.Size = new System.Drawing.Size(341, 138);
            this.grpDataInputRight.TabIndex = 25;
            this.grpDataInputRight.TabStop = false;
            this.grpDataInputRight.Text = "Dateneingabe";
            // 
            // ctlVectorInputM2
            // 
            this.ctlVectorInputM2.Controlname = "Vektor m2";
            this.ctlVectorInputM2.Location = new System.Drawing.Point(172, 22);
            this.ctlVectorInputM2.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorInputM2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputM2.Name = "ctlVectorInputM2";
            this.ctlVectorInputM2.Size = new System.Drawing.Size(161, 102);
            this.ctlVectorInputM2.TabIndex = 6;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputM2.Vector = vector1;
            // 
            // ctlVectorInputM1
            // 
            this.ctlVectorInputM1.Controlname = "Vektor m1";
            this.ctlVectorInputM1.Location = new System.Drawing.Point(8, 22);
            this.ctlVectorInputM1.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorInputM1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputM1.Name = "ctlVectorInputM1";
            this.ctlVectorInputM1.Size = new System.Drawing.Size(161, 102);
            this.ctlVectorInputM1.TabIndex = 5;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInputM1.Vector = vector2;
            // 
            // grpDataInputLeft
            // 
            this.grpDataInputLeft.Controls.Add(this.ctlVectorInputEV2);
            this.grpDataInputLeft.Controls.Add(this.ctlVectorInputEV1);
            this.grpDataInputLeft.Controls.Add(this.ctlVectorInputX);
            this.grpDataInputLeft.Location = new System.Drawing.Point(37, 620);
            this.grpDataInputLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInputLeft.Name = "grpDataInputLeft";
            this.grpDataInputLeft.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInputLeft.Size = new System.Drawing.Size(511, 155);
            this.grpDataInputLeft.TabIndex = 16;
            this.grpDataInputLeft.TabStop = false;
            this.grpDataInputLeft.Text = "Dateneingabe";
            // 
            // ctlVectorInputEV2
            // 
            this.ctlVectorInputEV2.Controlname = "Einheitsvektor 2";
            this.ctlVectorInputEV2.Location = new System.Drawing.Point(343, 34);
            this.ctlVectorInputEV2.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputEV2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputEV2.Name = "ctlVectorInputEV2";
            this.ctlVectorInputEV2.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputEV2.TabIndex = 33;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorInputEV2.Vector = vector3;
            // 
            // ctlVectorInputEV1
            // 
            this.ctlVectorInputEV1.Controlname = "Einheitsvektor 1";
            this.ctlVectorInputEV1.Location = new System.Drawing.Point(178, 34);
            this.ctlVectorInputEV1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputEV1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputEV1.Name = "ctlVectorInputEV1";
            this.ctlVectorInputEV1.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputEV1.TabIndex = 32;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInputEV1.Vector = vector4;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Controlname = "Vektor x";
            this.ctlVectorInputX.Location = new System.Drawing.Point(8, 34);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(161, 102);
            this.ctlVectorInputX.TabIndex = 1;
            vector5.X1 = float.NaN;
            vector5.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector5;
            // 
            // cosInput
            // 
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(13, 169);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(571, 420);
            this.cosInput.TabIndex = 26;
            // 
            // cosOutput
            // 
            this.cosOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(1287, 169);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(571, 420);
            this.cosOutput.TabIndex = 27;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(718, 859);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(71, 20);
            this.lblNotes.TabIndex = 29;
            this.lblNotes.Text = "Notizen:";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(602, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(692, 29);
            this.lblHeader.TabIndex = 30;
            this.lblHeader.Text = "Thema: Zuordnugsvorschrift einer linearen Abbildung verstehen";
            // 
            // butFunctionX
            // 
            this.butFunctionX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFunctionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionX.Location = new System.Drawing.Point(868, 654);
            this.butFunctionX.Name = "butFunctionX";
            this.butFunctionX.Size = new System.Drawing.Size(170, 41);
            this.butFunctionX.TabIndex = 9;
            this.butFunctionX.Text = "&Berechne f(x)";
            this.butFunctionX.UseVisualStyleBackColor = true;
            this.butFunctionX.Click += new System.EventHandler(this.butFunctionX_Click);
            // 
            // picArrow
            // 
            this.picArrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picArrow.BackColor = System.Drawing.Color.Transparent;
            this.picArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrow.Location = new System.Drawing.Point(661, 212);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(562, 330);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picArrow.TabIndex = 31;
            this.picArrow.TabStop = false;
            // 
            // grpAddInfo
            // 
            this.grpAddInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAddInfo.Controls.Add(this.txtDet);
            this.grpAddInfo.Controls.Add(this.butDet);
            this.grpAddInfo.Location = new System.Drawing.Point(37, 780);
            this.grpAddInfo.Name = "grpAddInfo";
            this.grpAddInfo.Size = new System.Drawing.Size(204, 79);
            this.grpAddInfo.TabIndex = 32;
            this.grpAddInfo.TabStop = false;
            this.grpAddInfo.Text = "Zusatzinfos";
            // 
            // txtDet
            // 
            this.txtDet.Location = new System.Drawing.Point(115, 36);
            this.txtDet.MaxLength = 5;
            this.txtDet.Name = "txtDet";
            this.txtDet.ReadOnly = true;
            this.txtDet.Size = new System.Drawing.Size(55, 22);
            this.txtDet.TabIndex = 1;
            // 
            // butDet
            // 
            this.butDet.AutoSize = true;
            this.butDet.Location = new System.Drawing.Point(6, 34);
            this.butDet.Name = "butDet";
            this.butDet.Size = new System.Drawing.Size(103, 27);
            this.butDet.TabIndex = 0;
            this.butDet.Text = "&Determinante";
            this.butDet.UseVisualStyleBackColor = true;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rtxtNotes.Location = new System.Drawing.Point(722, 882);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(421, 113);
            this.rtxtNotes.TabIndex = 33;
            this.rtxtNotes.Text = "";
            // 
            // ctlMathEqua
            // 
            this.ctlMathEqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEqua.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEqua.Equation = "";
            this.ctlMathEqua.Filename = "teptsgn3.nai.tiff";
            this.ctlMathEqua.Filepath = "";
            this.ctlMathEqua.FontSize = 8;
            this.ctlMathEqua.Location = new System.Drawing.Point(691, 321);
            this.ctlMathEqua.Margin = new System.Windows.Forms.Padding(4);
            this.ctlMathEqua.Name = "ctlMathEqua";
            this.ctlMathEqua.Size = new System.Drawing.Size(378, 115);
            this.ctlMathEqua.TabIndex = 34;
            // 
            // FrmZuordvorLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 1009);
            this.Controls.Add(this.ctlMathEqua);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.grpAddInfo);
            this.Controls.Add(this.butFunctionX);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.grpDataInputRight);
            this.Controls.Add(this.grpDataInputLeft);
            this.Controls.Add(this.picArrow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZuordvorLinAbb";
            this.Text = "Zuordnungsvorschrift Lineare Abbildung";
            this.grpDataInputRight.ResumeLayout(false);
            this.grpDataInputLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.grpAddInfo.ResumeLayout(false);
            this.grpAddInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataInputRight;
        private System.Windows.Forms.GroupBox grpDataInputLeft;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblHeader;
        private UserControls.CtlVectorInput ctlVectorInputM2;
        private UserControls.CtlVectorInput ctlVectorInputM1;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private System.Windows.Forms.Button butFunctionX;
        private UserControls.CtlVectorInput ctlVectorInputEV2;
        private UserControls.CtlVectorInput ctlVectorInputEV1;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.GroupBox grpAddInfo;
        private System.Windows.Forms.Button butDet;
        private System.Windows.Forms.TextBox txtDet;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
    }
}