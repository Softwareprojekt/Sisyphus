﻿namespace SoftwareProjekt.UserControls
{
    partial class CtlVectorInput
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
            this.txtEle21 = new SoftwareProjekt.UserControls.FloatInput();
            this.txtEle11 = new SoftwareProjekt.UserControls.FloatInput();
            this.grpVektorInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVektorInput
            // 
            this.grpVektorInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVektorInput.Controls.Add(this.txtEle21);
            this.grpVektorInput.Controls.Add(this.txtEle11);
            this.grpVektorInput.Location = new System.Drawing.Point(5, 5);
            this.grpVektorInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpVektorInput.Name = "grpVektorInput";
            this.grpVektorInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpVektorInput.Size = new System.Drawing.Size(127, 85);
            this.grpVektorInput.TabIndex = 0;
            this.grpVektorInput.TabStop = false;
            this.grpVektorInput.Text = "Vektor Eingabe";
            this.grpVektorInput.Resize += new System.EventHandler(this.grpVektorInput_Resize);
            // 
            // txtEle21
            // 
            this.txtEle21.Location = new System.Drawing.Point(34, 53);
            this.txtEle21.Margin = new System.Windows.Forms.Padding(4);
            this.txtEle21.MaxLength = 5;
            this.txtEle21.Name = "txtEle21";
            this.txtEle21.Size = new System.Drawing.Size(45, 22);
            this.txtEle21.TabIndex = 1;
            this.txtEle21.TextChanged += new System.EventHandler(this.txtEle21_TextChanged);
            this.txtEle21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEle21_KeyPress);
            // 
            // txtEle11
            // 
            this.txtEle11.Location = new System.Drawing.Point(34, 23);
            this.txtEle11.Margin = new System.Windows.Forms.Padding(4);
            this.txtEle11.MaxLength = 5;
            this.txtEle11.Name = "txtEle11";
            this.txtEle11.Size = new System.Drawing.Size(45, 22);
            this.txtEle11.TabIndex = 0;
            this.txtEle11.TextChanged += new System.EventHandler(this.txtEle11_TextChanged);
            this.txtEle11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEle11_KeyPress);
            // 
            // CtlVectorInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpVektorInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(136, 94);
            this.Name = "CtlVectorInput";
            this.Size = new System.Drawing.Size(136, 94);
            this.grpVektorInput.ResumeLayout(false);
            this.grpVektorInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpVektorInput;
        public SoftwareProjekt.UserControls.FloatInput txtEle21;
        public SoftwareProjekt.UserControls.FloatInput txtEle11;
    }
}
