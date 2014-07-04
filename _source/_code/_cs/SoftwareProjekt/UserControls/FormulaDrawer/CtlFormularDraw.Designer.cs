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
            this.picFormular.InitialImage = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picFormular.Location = new System.Drawing.Point(4, 4);
            this.picFormular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picFormular.Name = "picFormular";
            this.picFormular.Size = new System.Drawing.Size(369, 104);
            this.picFormular.TabIndex = 0;
            this.picFormular.TabStop = false;
            // 
            // CtlFormularDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFormular);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CtlFormularDraw";
            this.Size = new System.Drawing.Size(378, 115);
            ((System.ComponentModel.ISupportInitialize)(this.picFormular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFormular;
    }
}
