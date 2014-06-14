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
            ((System.ComponentModel.ISupportInitialize)(this.picFormular)).BeginInit();
            this.SuspendLayout();
            // 
            // picFormular
            // 
            this.picFormular.Location = new System.Drawing.Point(3, 3);
            this.picFormular.Name = "picFormular";
            this.picFormular.Size = new System.Drawing.Size(322, 85);
            this.picFormular.TabIndex = 0;
            this.picFormular.TabStop = false;
            // 
            // CtlFormularDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFormular);
            this.Name = "CtlFormularDraw";
            this.Size = new System.Drawing.Size(329, 92);
            ((System.ComponentModel.ISupportInitialize)(this.picFormular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFormular;
    }
}
