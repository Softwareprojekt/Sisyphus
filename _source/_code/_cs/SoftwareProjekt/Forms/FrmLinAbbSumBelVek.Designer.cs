namespace SoftwareProjekt.Forms
{
    partial class FrmLinAbbSumBelVek
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
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.ctlMaInScaleMat = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.ctlVecInY = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVecInX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.butFuncionXPlusY = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosResult = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this._rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.ctlMathEqu = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.ctlMaInScaleMat);
            this.grpDataInput.Controls.Add(this.ctlVecInY);
            this.grpDataInput.Controls.Add(this.ctlVecInX);
            this.grpDataInput.Location = new System.Drawing.Point(69, 522);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Size = new System.Drawing.Size(262, 214);
            this.grpDataInput.TabIndex = 4;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // ctlMaInScaleMat
            // 
            this.ctlMaInScaleMat.Location = new System.Drawing.Point(53, 116);
            this.ctlMaInScaleMat.Margin = new System.Windows.Forms.Padding(4);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMaInScaleMat.Matrix = matrix1;
            this.ctlMaInScaleMat.MinimumSize = new System.Drawing.Size(98, 76);
            this.ctlMaInScaleMat.Name = "ctlMaInScaleMat";
            this.ctlMaInScaleMat.Size = new System.Drawing.Size(144, 89);
            this.ctlMaInScaleMat.TabIndex = 2;
            // 
            // ctlVecInY
            // 
            this.ctlVecInY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ctlVecInY.Location = new System.Drawing.Point(134, 25);
            this.ctlVecInY.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVecInY.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVecInY.Name = "ctlVecInY";
            this.ctlVecInY.Size = new System.Drawing.Size(121, 83);
            this.ctlVecInY.TabIndex = 2;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVecInY.Vector = vector1;
            // 
            // ctlVecInX
            // 
            this.ctlVecInX.Location = new System.Drawing.Point(6, 25);
            this.ctlVecInX.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVecInX.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVecInX.Name = "ctlVecInX";
            this.ctlVecInX.Size = new System.Drawing.Size(121, 83);
            this.ctlVecInX.TabIndex = 1;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVecInX.Vector = vector2;
            // 
            // butFuncionXPlusY
            // 
            this.butFuncionXPlusY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butFuncionXPlusY.AutoSize = true;
            this.butFuncionXPlusY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFuncionXPlusY.Location = new System.Drawing.Point(620, 548);
            this.butFuncionXPlusY.Margin = new System.Windows.Forms.Padding(2);
            this.butFuncionXPlusY.Name = "butFuncionXPlusY";
            this.butFuncionXPlusY.Size = new System.Drawing.Size(118, 34);
            this.butFuncionXPlusY.TabIndex = 5;
            this.butFuncionXPlusY.Text = "&Berechne f(x+y)";
            this.butFuncionXPlusY.UseVisualStyleBackColor = true;
            this.butFuncionXPlusY.Click += new System.EventHandler(this.butFuncionXPlusY_Click);
            // 
            // cosInput
            // 
            this.cosInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(10, 188);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(403, 303);
            this.cosInput.TabIndex = 1;
            // 
            // cosResult
            // 
            this.cosResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cosResult.DoNotRefresh = false;
            this.cosResult.Location = new System.Drawing.Point(923, 188);
            this.cosResult.Name = "cosResult";
            this.cosResult.Size = new System.Drawing.Size(407, 303);
            this.cosResult.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(490, 663);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notizen:";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(387, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(576, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema:  Jede lin. Abb. verträgt sich mit Summe beliebiger Vektoren";
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(454, 208);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(562, 330);
            this.picBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxArrow.TabIndex = 51;
            this.picBoxArrow.TabStop = false;
            // 
            // _rtxtNotes
            // 
            this._rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._rtxtNotes.Location = new System.Drawing.Point(493, 682);
            this._rtxtNotes.Margin = new System.Windows.Forms.Padding(2);
            this._rtxtNotes.Name = "_rtxtNotes";
            this._rtxtNotes.Size = new System.Drawing.Size(362, 148);
            this._rtxtNotes.TabIndex = 7;
            this._rtxtNotes.Text = "";
            // 
            // ctlMathEqu
            // 
            this.ctlMathEqu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEqu.Equation = "";
            this.ctlMathEqu.Filename = "vl5vwf41.xla.tiff";
            this.ctlMathEqu.Filepath = "";
            this.ctlMathEqu.FontSize = 11;
            this.ctlMathEqu.Location = new System.Drawing.Point(473, 333);
            this.ctlMathEqu.Name = "ctlMathEqu";
            this.ctlMathEqu.Size = new System.Drawing.Size(490, 85);
            this.ctlMathEqu.TabIndex = 3;
            // 
            // FrmLinAbbSumBelVek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 849);
            this.Controls.Add(this.ctlMathEqu);
            this.Controls.Add(this._rtxtNotes);
            this.Controls.Add(this.picBoxArrow);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosResult);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.butFuncionXPlusY);
            this.Controls.Add(this.grpDataInput);
            this.Name = "FrmLinAbbSumBelVek";
            this.Text = "Lineare Abbildungen und Summe von Vektoren";
            this.grpDataInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.Button butFuncionXPlusY;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosResult;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblHeader;
        private UserControls.CtlVectorInput ctlVecInX;
        private UserControls.CtlMatrixInput ctlMaInScaleMat;
        private UserControls.CtlVectorInput ctlVecInY;
        private System.Windows.Forms.PictureBox picBoxArrow;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqu;
#if DEBUG
        private System.Windows.Forms.RichTextBox _rtxtNotes;
#endif
    }
}