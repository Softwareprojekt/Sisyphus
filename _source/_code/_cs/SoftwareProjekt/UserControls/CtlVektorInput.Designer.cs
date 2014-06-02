namespace SoftwareProjekt
{
    partial class CtlVektorInput
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
            this.grpVektorInput = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpVektorInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVektorInput
            // 
            this.grpVektorInput.Controls.Add(this.textBox2);
            this.grpVektorInput.Controls.Add(this.textBox1);
            this.grpVektorInput.Location = new System.Drawing.Point(4, 4);
            this.grpVektorInput.Name = "grpVektorInput";
            this.grpVektorInput.Size = new System.Drawing.Size(105, 72);
            this.grpVektorInput.TabIndex = 0;
            this.grpVektorInput.TabStop = false;
            this.grpVektorInput.Text = "Vektor Eingabe";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 0;
            // 
            // CtlVektorInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpVektorInput);
            this.Name = "CtlVektorInput";
            this.Size = new System.Drawing.Size(121, 83);
            this.grpVektorInput.ResumeLayout(false);
            this.grpVektorInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVektorInput;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
