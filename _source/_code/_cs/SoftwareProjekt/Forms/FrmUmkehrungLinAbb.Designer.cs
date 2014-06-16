namespace SoftwareProjekt.Forms
{
    partial class FrmUmkehrungLinAbb
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.cosLeft = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosRight = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.maiMatrix = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(291, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(401, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Umkehrung einer linearen Abbildung";
            // 
            // cosLeft
            // 
            this.cosLeft.Location = new System.Drawing.Point(12, 139);
            this.cosLeft.Name = "cosLeft";
            this.cosLeft.Size = new System.Drawing.Size(367, 316);
            this.cosLeft.TabIndex = 1;
            // 
            // cosRight
            // 
            this.cosRight.Location = new System.Drawing.Point(757, 139);
            this.cosRight.Name = "cosRight";
            this.cosRight.Size = new System.Drawing.Size(367, 316);
            this.cosRight.TabIndex = 2;
            // 
            // maiMatrix
            // 
            this.maiMatrix.Location = new System.Drawing.Point(12, 502);
            this.maiMatrix.Matrix = null;
            this.maiMatrix.Name = "maiMatrix";
            this.maiMatrix.Size = new System.Drawing.Size(125, 89);
            this.maiMatrix.TabIndex = 3;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(323, 565);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(323, 584);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this.rtxtNotes.TabIndex = 5;
            this.rtxtNotes.Text = "";
            // 
            // FrmUmkehrungLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 720);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.maiMatrix);
            this.Controls.Add(this.cosRight);
            this.Controls.Add(this.cosLeft);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUmkehrungLinAbb";
            this.Text = "Umkehrung einer linearen Abbildung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private SoftwareProjekt.UserControls.CoordinateSystem cosLeft;
        private SoftwareProjekt.UserControls.CoordinateSystem cosRight;
        private SoftwareProjekt.UserControls.CtlMatrixInput maiMatrix;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
    }
}