namespace SoftwareProjekt.UserControls.FormulaDrawer
{
    partial class CtlFormularDraw
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.picFormular = new System.Windows.Forms.PictureBox();
            this.picArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFormular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // picFormular
            // 
            this.picFormular.InitialImage = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picFormular.Location = new System.Drawing.Point(144, 96);
            this.picFormular.Name = "picFormular";
            this.picFormular.Size = new System.Drawing.Size(322, 100);
            this.picFormular.TabIndex = 0;
            this.picFormular.TabStop = false;
            // 
            // picArrow
            // 
            this.picArrow.BackColor = System.Drawing.Color.Transparent;
            this.picArrow.Location = new System.Drawing.Point(6, 3);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(573, 250);
            this.picArrow.TabIndex = 1;
            this.picArrow.TabStop = false;
            // 
            // CtlFormularDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFormular);
            this.Controls.Add(this.picArrow);
            this.Name = "CtlFormularDraw";
            this.Size = new System.Drawing.Size(579, 261);
            ((System.ComponentModel.ISupportInitialize)(this.picFormular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFormular;
        private System.Windows.Forms.PictureBox picArrow;
    }
}
