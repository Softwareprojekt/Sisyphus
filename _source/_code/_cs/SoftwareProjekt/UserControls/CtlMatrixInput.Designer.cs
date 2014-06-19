namespace SoftwareProjekt.UserControls
{
    partial class CtlMatrixInput
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
            this.grpMatrixEingabe = new System.Windows.Forms.GroupBox();
            this.txtEle22 = new System.Windows.Forms.TextBox();
            this.txtEle21 = new System.Windows.Forms.TextBox();
            this.txtEle12 = new System.Windows.Forms.TextBox();
            this.txtEle11 = new System.Windows.Forms.TextBox();
            this.grpMatrixEingabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMatrixEingabe
            // 
            this.grpMatrixEingabe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMatrixEingabe.Controls.Add(this.txtEle22);
            this.grpMatrixEingabe.Controls.Add(this.txtEle21);
            this.grpMatrixEingabe.Controls.Add(this.txtEle12);
            this.grpMatrixEingabe.Controls.Add(this.txtEle11);
            this.grpMatrixEingabe.Location = new System.Drawing.Point(3, 3);
            this.grpMatrixEingabe.Name = "grpMatrixEingabe";
            this.grpMatrixEingabe.Size = new System.Drawing.Size(119, 83);
            this.grpMatrixEingabe.TabIndex = 0;
            this.grpMatrixEingabe.TabStop = false;
            this.grpMatrixEingabe.Text = "Matrix Eingabe";
            this.grpMatrixEingabe.Resize += new System.EventHandler(this.grpMatrixEingabe_Resize);
            // 
            // txtEle22
            // 
            this.txtEle22.Location = new System.Drawing.Point(54, 45);
            this.txtEle22.MaxLength = 5;
            this.txtEle22.Name = "txtEle22";
            this.txtEle22.Size = new System.Drawing.Size(42, 20);
            this.txtEle22.TabIndex = 3;
            this.txtEle22.TextChanged += new System.EventHandler(this.txtEle22_TextChanged);
            this.txtEle22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEle22_KeyPress);
            // 
            // txtEle21
            // 
            this.txtEle21.Location = new System.Drawing.Point(6, 45);
            this.txtEle21.MaxLength = 5;
            this.txtEle21.Name = "txtEle21";
            this.txtEle21.Size = new System.Drawing.Size(42, 20);
            this.txtEle21.TabIndex = 2;
            this.txtEle21.TextChanged += new System.EventHandler(this.txtEle21_TextChanged);
            this.txtEle21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEle21_KeyPress);
            // 
            // txtEle12
            // 
            this.txtEle12.Location = new System.Drawing.Point(54, 19);
            this.txtEle12.MaxLength = 5;
            this.txtEle12.Name = "txtEle12";
            this.txtEle12.Size = new System.Drawing.Size(42, 20);
            this.txtEle12.TabIndex = 1;
            this.txtEle12.TextChanged += new System.EventHandler(this.txtEle12_TextChanged);
            this.txtEle12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEle12_KeyPress);
            // 
            // txtEle11
            // 
            this.txtEle11.Location = new System.Drawing.Point(6, 19);
            this.txtEle11.MaxLength = 5;
            this.txtEle11.Name = "txtEle11";
            this.txtEle11.Size = new System.Drawing.Size(42, 20);
            this.txtEle11.TabIndex = 0;
            this.txtEle11.TextChanged += new System.EventHandler(this.txtEle11_TextChanged);
            this.txtEle11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEle11_KeyPress);
            // 
            // CtlMatrixInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpMatrixEingabe);
            this.MinimumSize = new System.Drawing.Size(98, 76);
            this.Name = "CtlMatrixInput";
            this.Size = new System.Drawing.Size(125, 89);
            this.grpMatrixEingabe.ResumeLayout(false);
            this.grpMatrixEingabe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMatrixEingabe;
        private System.Windows.Forms.TextBox txtEle22;
        private System.Windows.Forms.TextBox txtEle21;
        private System.Windows.Forms.TextBox txtEle12;
        private System.Windows.Forms.TextBox txtEle11;
    }
}
