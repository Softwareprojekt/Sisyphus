namespace SoftwareProjekt
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
            this.radSquare = new System.Windows.Forms.RadioButton();
            this.radTriangle = new System.Windows.Forms.RadioButton();
            this.radCircle = new System.Windows.Forms.RadioButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblOrigPic = new System.Windows.Forms.Label();
            this.lblFraktal = new System.Windows.Forms.Label();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFraktal)).BeginInit();
            this.grpPics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // butSelectPic
            // 
            this.butSelectPic.Location = new System.Drawing.Point(88, 447);
            this.butSelectPic.Margin = new System.Windows.Forms.Padding(2);
            this.butSelectPic.Name = "butSelectPic";
            this.butSelectPic.Size = new System.Drawing.Size(84, 29);
            this.butSelectPic.TabIndex = 0;
            this.butSelectPic.Text = "Bild wählen";
            this.butSelectPic.UseVisualStyleBackColor = true;
            // 
            // butStepFor
            // 
            this.butStepFor.Location = new System.Drawing.Point(478, 447);
            this.butStepFor.Margin = new System.Windows.Forms.Padding(2);
            this.butStepFor.Name = "butStepFor";
            this.butStepFor.Size = new System.Drawing.Size(69, 29);
            this.butStepFor.TabIndex = 1;
            this.butStepFor.Text = "Schritt vor";
            this.butStepFor.UseVisualStyleBackColor = true;
            // 
            // butStepBack
            // 
            this.butStepBack.Location = new System.Drawing.Point(551, 447);
            this.butStepBack.Margin = new System.Windows.Forms.Padding(2);
            this.butStepBack.Name = "butStepBack";
            this.butStepBack.Size = new System.Drawing.Size(104, 29);
            this.butStepBack.TabIndex = 2;
            this.butStepBack.Text = "Schritt zurück";
            this.butStepBack.UseVisualStyleBackColor = true;
            // 
            // picOriginal
            // 
            this.picOriginal.Location = new System.Drawing.Point(88, 83);
            this.picOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(270, 297);
            this.picOriginal.TabIndex = 3;
            this.picOriginal.TabStop = false;
            // 
            // picFraktal
            // 
            this.picFraktal.Location = new System.Drawing.Point(735, 83);
            this.picFraktal.Margin = new System.Windows.Forms.Padding(2);
            this.picFraktal.Name = "picFraktal";
            this.picFraktal.Size = new System.Drawing.Size(270, 297);
            this.picFraktal.TabIndex = 4;
            this.picFraktal.TabStop = false;
            // 
            // grpPics
            // 
            this.grpPics.Controls.Add(this.radSquare);
            this.grpPics.Controls.Add(this.radTriangle);
            this.grpPics.Controls.Add(this.radCircle);
            this.grpPics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPics.Location = new System.Drawing.Point(88, 503);
            this.grpPics.Margin = new System.Windows.Forms.Padding(2);
            this.grpPics.Name = "grpPics";
            this.grpPics.Padding = new System.Windows.Forms.Padding(2);
            this.grpPics.Size = new System.Drawing.Size(127, 101);
            this.grpPics.TabIndex = 5;
            this.grpPics.TabStop = false;
            this.grpPics.Text = "Standard-Bilder";
            // 
            // radSquare
            // 
            this.radSquare.AutoSize = true;
            this.radSquare.Location = new System.Drawing.Point(5, 71);
            this.radSquare.Margin = new System.Windows.Forms.Padding(2);
            this.radSquare.Name = "radSquare";
            this.radSquare.Size = new System.Drawing.Size(72, 17);
            this.radSquare.TabIndex = 2;
            this.radSquare.TabStop = true;
            this.radSquare.Text = "Rechteck";
            this.radSquare.UseVisualStyleBackColor = true;
            // 
            // radTriangle
            // 
            this.radTriangle.AutoSize = true;
            this.radTriangle.Location = new System.Drawing.Point(5, 48);
            this.radTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.radTriangle.Name = "radTriangle";
            this.radTriangle.Size = new System.Drawing.Size(62, 17);
            this.radTriangle.TabIndex = 1;
            this.radTriangle.TabStop = true;
            this.radTriangle.Text = "Dreieck";
            this.radTriangle.UseVisualStyleBackColor = true;
            // 
            // radCircle
            // 
            this.radCircle.AutoSize = true;
            this.radCircle.Location = new System.Drawing.Point(5, 25);
            this.radCircle.Margin = new System.Windows.Forms.Padding(2);
            this.radCircle.Name = "radCircle";
            this.radCircle.Size = new System.Drawing.Size(48, 17);
            this.radCircle.TabIndex = 0;
            this.radCircle.TabStop = true;
            this.radCircle.Text = "Kreis";
            this.radCircle.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(361, 32);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(361, 25);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Thema: Fraktalerzeugung mit einem IFS";
            // 
            // lblOrigPic
            // 
            this.lblOrigPic.AutoSize = true;
            this.lblOrigPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigPic.Location = new System.Drawing.Point(177, 391);
            this.lblOrigPic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrigPic.Name = "lblOrigPic";
            this.lblOrigPic.Size = new System.Drawing.Size(86, 20);
            this.lblOrigPic.TabIndex = 7;
            this.lblOrigPic.Text = "Originalbild";
            // 
            // lblFraktal
            // 
            this.lblFraktal.AutoSize = true;
            this.lblFraktal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraktal.Location = new System.Drawing.Point(849, 391);
            this.lblFraktal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFraktal.Name = "lblFraktal";
            this.lblFraktal.Size = new System.Drawing.Size(58, 20);
            this.lblFraktal.TabIndex = 8;
            this.lblFraktal.Text = "Fraktal";
            // 
            // picArrow
            // 
            this.picArrow.Location = new System.Drawing.Point(363, 83);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(367, 297);
            this.picArrow.TabIndex = 9;
            this.picArrow.TabStop = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(293, 625);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 11;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(293, 644);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this.rtxtNotes.TabIndex = 10;
            this.rtxtNotes.Text = "";
            // 
            // FrmFraktalErzIFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 777);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.lblFraktal);
            this.Controls.Add(this.lblOrigPic);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpPics);
            this.Controls.Add(this.picFraktal);
            this.Controls.Add(this.picOriginal);
            this.Controls.Add(this.butStepBack);
            this.Controls.Add(this.butStepFor);
            this.Controls.Add(this.butSelectPic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFraktalErzIFS";
            this.Text = "Fraktalerzeugung mit einem IFS";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFraktal)).EndInit();
            this.grpPics.ResumeLayout(false);
            this.grpPics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
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
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
    }
}