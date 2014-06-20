namespace SoftwareProjekt.Forms
{
    partial class FrmFraktalErzIFS
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
            this.butSelectPic = new System.Windows.Forms.Button();
            this.butStepFor = new System.Windows.Forms.Button();
            this.butStepBack = new System.Windows.Forms.Button();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picFraktal = new System.Windows.Forms.PictureBox();
            this.grpPics = new System.Windows.Forms.GroupBox();
            this.lblDiffPic = new System.Windows.Forms.Label();
            this.radSquare = new System.Windows.Forms.RadioButton();
            this.radTriangle = new System.Windows.Forms.RadioButton();
            this.radCircle = new System.Windows.Forms.RadioButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblOrigPic = new System.Windows.Forms.Label();
            this.lblFraktal = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.grpSteps = new System.Windows.Forms.GroupBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFraktal)).BeginInit();
            this.grpPics.SuspendLayout();
            this.grpSteps.SuspendLayout();
            this.SuspendLayout();
            // 
            // butSelectPic
            // 
            this.butSelectPic.Location = new System.Drawing.Point(100, 119);
            this.butSelectPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butSelectPic.Name = "butSelectPic";
            this.butSelectPic.Size = new System.Drawing.Size(112, 36);
            this.butSelectPic.TabIndex = 3;
            this.butSelectPic.Text = "Bild wählen";
            this.butSelectPic.UseVisualStyleBackColor = true;
            this.butSelectPic.Click += new System.EventHandler(this.butSelectPic_Click);
            // 
            // butStepFor
            // 
            this.butStepFor.Location = new System.Drawing.Point(33, 80);
            this.butStepFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butStepFor.Name = "butStepFor";
            this.butStepFor.Size = new System.Drawing.Size(92, 36);
            this.butStepFor.TabIndex = 5;
            this.butStepFor.Text = "Schritt vor";
            this.butStepFor.UseVisualStyleBackColor = true;
            this.butStepFor.Click += new System.EventHandler(this.butStepFor_Click);
            // 
            // butStepBack
            // 
            this.butStepBack.Location = new System.Drawing.Point(131, 80);
            this.butStepBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butStepBack.Name = "butStepBack";
            this.butStepBack.Size = new System.Drawing.Size(139, 36);
            this.butStepBack.TabIndex = 6;
            this.butStepBack.Text = "Schritt zurück";
            this.butStepBack.UseVisualStyleBackColor = true;
            this.butStepBack.Click += new System.EventHandler(this.butStepBack_Click);
            // 
            // picOriginal
            // 
            this.picOriginal.Location = new System.Drawing.Point(117, 102);
            this.picOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(360, 366);
            this.picOriginal.TabIndex = 3;
            this.picOriginal.TabStop = false;
            // 
            // picFraktal
            // 
            this.picFraktal.Location = new System.Drawing.Point(980, 102);
            this.picFraktal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFraktal.Name = "picFraktal";
            this.picFraktal.Size = new System.Drawing.Size(360, 366);
            this.picFraktal.TabIndex = 4;
            this.picFraktal.TabStop = false;
            // 
            // grpPics
            // 
            this.grpPics.Controls.Add(this.lblDiffPic);
            this.grpPics.Controls.Add(this.radSquare);
            this.grpPics.Controls.Add(this.radTriangle);
            this.grpPics.Controls.Add(this.radCircle);
            this.grpPics.Controls.Add(this.butSelectPic);
            this.grpPics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPics.Location = new System.Drawing.Point(117, 542);
            this.grpPics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPics.Name = "grpPics";
            this.grpPics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPics.Size = new System.Drawing.Size(233, 175);
            this.grpPics.TabIndex = 5;
            this.grpPics.TabStop = false;
            this.grpPics.Text = "Bild wählen";
            // 
            // lblDiffPic
            // 
            this.lblDiffPic.AutoSize = true;
            this.lblDiffPic.Location = new System.Drawing.Point(3, 129);
            this.lblDiffPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiffPic.Name = "lblDiffPic";
            this.lblDiffPic.Size = new System.Drawing.Size(90, 17);
            this.lblDiffPic.TabIndex = 3;
            this.lblDiffPic.Text = "Eigenes Bild:";
            // 
            // radSquare
            // 
            this.radSquare.AutoSize = true;
            this.radSquare.Location = new System.Drawing.Point(7, 87);
            this.radSquare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSquare.Name = "radSquare";
            this.radSquare.Size = new System.Drawing.Size(88, 21);
            this.radSquare.TabIndex = 2;
            this.radSquare.TabStop = true;
            this.radSquare.Text = "Rechteck";
            this.radSquare.UseVisualStyleBackColor = true;
            // 
            // radTriangle
            // 
            this.radTriangle.AutoSize = true;
            this.radTriangle.Location = new System.Drawing.Point(7, 59);
            this.radTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTriangle.Name = "radTriangle";
            this.radTriangle.Size = new System.Drawing.Size(77, 21);
            this.radTriangle.TabIndex = 1;
            this.radTriangle.TabStop = true;
            this.radTriangle.Text = "Dreieck";
            this.radTriangle.UseVisualStyleBackColor = true;
            // 
            // radCircle
            // 
            this.radCircle.AutoSize = true;
            this.radCircle.Location = new System.Drawing.Point(7, 31);
            this.radCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCircle.Name = "radCircle";
            this.radCircle.Size = new System.Drawing.Size(61, 21);
            this.radCircle.TabIndex = 0;
            this.radCircle.TabStop = true;
            this.radCircle.Text = "Kreis";
            this.radCircle.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(481, 39);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(466, 29);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Thema: Fraktalerzeugung mit einem IFS";
            // 
            // lblOrigPic
            // 
            this.lblOrigPic.AutoSize = true;
            this.lblOrigPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigPic.Location = new System.Drawing.Point(236, 481);
            this.lblOrigPic.Name = "lblOrigPic";
            this.lblOrigPic.Size = new System.Drawing.Size(109, 25);
            this.lblOrigPic.TabIndex = 7;
            this.lblOrigPic.Text = "Originalbild";
            // 
            // lblFraktal
            // 
            this.lblFraktal.AutoSize = true;
            this.lblFraktal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraktal.Location = new System.Drawing.Point(1132, 481);
            this.lblFraktal.Name = "lblFraktal";
            this.lblFraktal.Size = new System.Drawing.Size(71, 25);
            this.lblFraktal.TabIndex = 8;
            this.lblFraktal.Text = "Fraktal";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(391, 769);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 11;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(391, 793);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 7;
            this.rtxtNotes.Text = "";
            this.rtxtNotes.TextChanged += new System.EventHandler(this.rtxtNotes_TextChanged);
            // 
            // grpSteps
            // 
            this.grpSteps.Controls.Add(this.txtSteps);
            this.grpSteps.Controls.Add(this.lblSteps);
            this.grpSteps.Controls.Add(this.butStepFor);
            this.grpSteps.Controls.Add(this.butStepBack);
            this.grpSteps.Location = new System.Drawing.Point(567, 542);
            this.grpSteps.Margin = new System.Windows.Forms.Padding(4);
            this.grpSteps.Name = "grpSteps";
            this.grpSteps.Padding = new System.Windows.Forms.Padding(4);
            this.grpSteps.Size = new System.Drawing.Size(291, 143);
            this.grpSteps.TabIndex = 12;
            this.grpSteps.TabStop = false;
            this.grpSteps.Text = "Schritte";
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(148, 30);
            this.txtSteps.Margin = new System.Windows.Forms.Padding(4);
            this.txtSteps.MaxLength = 4;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(103, 22);
            this.txtSteps.TabIndex = 4;
            this.txtSteps.TextChanged += new System.EventHandler(this.txtSteps_TextChanged);
            this.txtSteps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSteps_KeyPress);
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(8, 36);
            this.lblSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(132, 17);
            this.lblSteps.TabIndex = 0;
            this.lblSteps.Text = "Anzahl der Schritte:";
            // 
            // ctlMathEqua
            // 
            this.ctlMathEqua.Equation = "";
            this.ctlMathEqua.Filename = "expr.gif";
            this.ctlMathEqua.Filepath = "C:\\Program Files (x86)\\Microsoft Visual Studio 11.0\\Common7\\IDE";
            this.ctlMathEqua.FontSize = 8;
            this.ctlMathEqua.Location = new System.Drawing.Point(508, 204);
            this.ctlMathEqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlMathEqua.Name = "ctlMathEqua";
            this.ctlMathEqua.Size = new System.Drawing.Size(439, 194);
            this.ctlMathEqua.TabIndex = 13;
            // 
            // FrmFraktalErzIFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 956);
            this.Controls.Add(this.ctlMathEqua);
            this.Controls.Add(this.grpSteps);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.lblFraktal);
            this.Controls.Add(this.lblOrigPic);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpPics);
            this.Controls.Add(this.picFraktal);
            this.Controls.Add(this.picOriginal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFraktalErzIFS";
            this.Text = "Fraktalerzeugung mit einem IFS";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFraktal)).EndInit();
            this.grpPics.ResumeLayout(false);
            this.grpPics.PerformLayout();
            this.grpSteps.ResumeLayout(false);
            this.grpSteps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSelectPic;
        private System.Windows.Forms.Button butStepFor;
        private System.Windows.Forms.Button butStepBack;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picFraktal;
        private System.Windows.Forms.GroupBox grpPics;
        private System.Windows.Forms.RadioButton radSquare;
        private System.Windows.Forms.RadioButton radTriangle;
        private System.Windows.Forms.RadioButton radCircle;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblOrigPic;
        private System.Windows.Forms.Label lblFraktal;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblDiffPic;
        private System.Windows.Forms.GroupBox grpSteps;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.Label lblSteps;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
    }
}