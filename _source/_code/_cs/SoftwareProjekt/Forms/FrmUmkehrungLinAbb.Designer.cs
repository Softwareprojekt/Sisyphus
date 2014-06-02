namespace SoftwareProjekt
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
            this.picCoSys1 = new System.Windows.Forms.PictureBox();
            this.picCoSys2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCoSys1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoSys2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(291, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(517, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thema: Umkehrung einer linearen Abbildung";
            // 
            // picCoSys1
            // 
            this.picCoSys1.Location = new System.Drawing.Point(12, 126);
            this.picCoSys1.Name = "picCoSys1";
            this.picCoSys1.Size = new System.Drawing.Size(324, 311);
            this.picCoSys1.TabIndex = 1;
            this.picCoSys1.TabStop = false;
            // 
            // picCoSys2
            // 
            this.picCoSys2.Location = new System.Drawing.Point(800, 126);
            this.picCoSys2.Name = "picCoSys2";
            this.picCoSys2.Size = new System.Drawing.Size(324, 311);
            this.picCoSys2.TabIndex = 2;
            this.picCoSys2.TabStop = false;
            // 
            // FrmUmkehrungLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 720);
            this.Controls.Add(this.picCoSys2);
            this.Controls.Add(this.picCoSys1);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUmkehrungLinAbb";
            this.Text = "Umkehrung einer linearen Abbildung";
            ((System.ComponentModel.ISupportInitialize)(this.picCoSys1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoSys2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picCoSys1;
        private System.Windows.Forms.PictureBox picCoSys2;
    }
}