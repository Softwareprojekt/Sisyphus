namespace SoftwareProjekt.Forms
{
    partial class FrmFraktalChaos
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
            this.grpInputParam = new System.Windows.Forms.GroupBox();
            this.txtNumIteration = new System.Windows.Forms.TextBox();
            this.lblNumIteration = new System.Windows.Forms.Label();
            this.txtProbability = new System.Windows.Forms.TextBox();
            this.lblProbability = new System.Windows.Forms.Label();
            this.butSaveFractal = new System.Windows.Forms.Button();
            this.cosFractal = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.grpIFS = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpInputParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputParam
            // 
            this.grpInputParam.Controls.Add(this.txtNumIteration);
            this.grpInputParam.Controls.Add(this.lblNumIteration);
            this.grpInputParam.Controls.Add(this.txtProbability);
            this.grpInputParam.Controls.Add(this.lblProbability);
            this.grpInputParam.Location = new System.Drawing.Point(108, 102);
            this.grpInputParam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInputParam.Name = "grpInputParam";
            this.grpInputParam.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInputParam.Size = new System.Drawing.Size(240, 114);
            this.grpInputParam.TabIndex = 0;
            this.grpInputParam.TabStop = false;
            this.grpInputParam.Text = "Eingabeparameter";
            // 
            // txtNumIteration
            // 
            this.txtNumIteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumIteration.Location = new System.Drawing.Point(151, 71);
            this.txtNumIteration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumIteration.MaxLength = 5;
            this.txtNumIteration.Name = "txtNumIteration";
            this.txtNumIteration.Size = new System.Drawing.Size(69, 22);
            this.txtNumIteration.TabIndex = 2;
            this.txtNumIteration.TextChanged += new System.EventHandler(this.txtNumIteration_TextChanged);
            this.txtNumIteration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumIteration_KeyPress);
            // 
            // lblNumIteration
            // 
            this.lblNumIteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumIteration.AutoSize = true;
            this.lblNumIteration.Location = new System.Drawing.Point(16, 75);
            this.lblNumIteration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumIteration.Name = "lblNumIteration";
            this.lblNumIteration.Size = new System.Drawing.Size(126, 17);
            this.lblNumIteration.TabIndex = 2;
            this.lblNumIteration.Text = "Anzahl Iterationen:";
            // 
            // txtProbability
            // 
            this.txtProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProbability.Location = new System.Drawing.Point(151, 39);
            this.txtProbability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProbability.MaxLength = 5;
            this.txtProbability.Name = "txtProbability";
            this.txtProbability.Size = new System.Drawing.Size(69, 22);
            this.txtProbability.TabIndex = 1;
            this.txtProbability.TextChanged += new System.EventHandler(this.txtProbability_TextChanged);
            this.txtProbability.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProbability_KeyPress);
            // 
            // lblProbability
            // 
            this.lblProbability.AutoSize = true;
            this.lblProbability.Location = new System.Drawing.Point(9, 43);
            this.lblProbability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProbability.Name = "lblProbability";
            this.lblProbability.Size = new System.Drawing.Size(130, 17);
            this.lblProbability.TabIndex = 0;
            this.lblProbability.Text = "Wahrscheinlichkeit:";
            // 
            // butSaveFractal
            // 
            this.butSaveFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSaveFractal.Location = new System.Drawing.Point(593, 490);
            this.butSaveFractal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butSaveFractal.Name = "butSaveFractal";
            this.butSaveFractal.Size = new System.Drawing.Size(139, 28);
            this.butSaveFractal.TabIndex = 5;
            this.butSaveFractal.Text = "&Fraktal speichern";
            this.butSaveFractal.UseVisualStyleBackColor = true;
            // 
            // cosFractal
            // 
            this.cosFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cosFractal.Location = new System.Drawing.Point(461, 102);
            this.cosFractal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosFractal.Name = "cosFractal";
            this.cosFractal.Size = new System.Drawing.Size(593, 364);
            this.cosFractal.TabIndex = 2;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotes.Location = new System.Drawing.Point(140, 620);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(596, 152);
            this.rtxtNotes.TabIndex = 6;
            this.rtxtNotes.Text = "";
            this.rtxtNotes.TextChanged += new System.EventHandler(this.rtxtNotes_TextChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(140, 597);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notizen:";
            // 
            // butStart
            // 
            this.butStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butStart.Location = new System.Drawing.Point(483, 490);
            this.butStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(100, 28);
            this.butStart.TabIndex = 4;
            this.butStart.Text = "&Start";
            this.butStart.UseVisualStyleBackColor = true;
            // 
            // grpIFS
            // 
            this.grpIFS.Location = new System.Drawing.Point(108, 236);
            this.grpIFS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpIFS.Name = "grpIFS";
            this.grpIFS.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpIFS.Size = new System.Drawing.Size(240, 246);
            this.grpIFS.TabIndex = 3;
            this.grpIFS.TabStop = false;
            this.grpIFS.Text = "IFS";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(280, 11);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(429, 29);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Thema: Fraktal rendern mit Chaosspiel";
            // 
            // FrmFraktalChaos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 832);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpIFS);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosFractal);
            this.Controls.Add(this.butSaveFractal);
            this.Controls.Add(this.grpInputParam);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1063, 870);
            this.Name = "FrmFraktalChaos";
            this.Text = "Fraktal rendern mit Chaosspiel ";
            this.grpInputParam.ResumeLayout(false);
            this.grpInputParam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputParam;
        private System.Windows.Forms.TextBox txtProbability;
        private System.Windows.Forms.Label lblProbability;
        private System.Windows.Forms.TextBox txtNumIteration;
        private System.Windows.Forms.Label lblNumIteration;
        private System.Windows.Forms.Button butSaveFractal;
        private SoftwareProjekt.UserControls.CoordinateSystem cosFractal;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.GroupBox grpIFS;
        private System.Windows.Forms.Label lblHeader;
    }
}