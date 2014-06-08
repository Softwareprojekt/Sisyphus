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
            this.lblProbability = new System.Windows.Forms.Label();
            this.txtProbability = new System.Windows.Forms.TextBox();
            this.lblNumIteration = new System.Windows.Forms.Label();
            this.txtNumIteration = new System.Windows.Forms.TextBox();
            this.butSaveFractal = new System.Windows.Forms.Button();
            this.cosFractal = new SoftwareProjekt.CoordinateSystem();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.grpIFS = new System.Windows.Forms.GroupBox();
            this.grpInputParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputParam
            // 
            this.grpInputParam.Controls.Add(this.txtNumIteration);
            this.grpInputParam.Controls.Add(this.lblNumIteration);
            this.grpInputParam.Controls.Add(this.txtProbability);
            this.grpInputParam.Controls.Add(this.lblProbability);
            this.grpInputParam.Location = new System.Drawing.Point(81, 83);
            this.grpInputParam.Name = "grpInputParam";
            this.grpInputParam.Size = new System.Drawing.Size(200, 104);
            this.grpInputParam.TabIndex = 0;
            this.grpInputParam.TabStop = false;
            this.grpInputParam.Text = "Eingabe Parameter";
            // 
            // lblProbability
            // 
            this.lblProbability.AutoSize = true;
            this.lblProbability.Location = new System.Drawing.Point(7, 35);
            this.lblProbability.Name = "lblProbability";
            this.lblProbability.Size = new System.Drawing.Size(100, 13);
            this.lblProbability.TabIndex = 0;
            this.lblProbability.Text = "Wahrscheinlichkeit:";
            // 
            // txtProbability
            // 
            this.txtProbability.Location = new System.Drawing.Point(113, 32);
            this.txtProbability.MaxLength = 5;
            this.txtProbability.Name = "txtProbability";
            this.txtProbability.Size = new System.Drawing.Size(53, 20);
            this.txtProbability.TabIndex = 1;
            // 
            // lblNumIteration
            // 
            this.lblNumIteration.AutoSize = true;
            this.lblNumIteration.Location = new System.Drawing.Point(7, 61);
            this.lblNumIteration.Name = "lblNumIteration";
            this.lblNumIteration.Size = new System.Drawing.Size(95, 13);
            this.lblNumIteration.TabIndex = 2;
            this.lblNumIteration.Text = "Anzahl Iterationen:";
            // 
            // txtNumIteration
            // 
            this.txtNumIteration.Location = new System.Drawing.Point(113, 58);
            this.txtNumIteration.MaxLength = 5;
            this.txtNumIteration.Name = "txtNumIteration";
            this.txtNumIteration.Size = new System.Drawing.Size(53, 20);
            this.txtNumIteration.TabIndex = 3;
            // 
            // butSaveFractal
            // 
            this.butSaveFractal.Location = new System.Drawing.Point(424, 477);
            this.butSaveFractal.Name = "butSaveFractal";
            this.butSaveFractal.Size = new System.Drawing.Size(104, 23);
            this.butSaveFractal.TabIndex = 1;
            this.butSaveFractal.Text = "&Fraktal speichern";
            this.butSaveFractal.UseVisualStyleBackColor = true;
            // 
            // cosFractal
            // 
            this.cosFractal.Location = new System.Drawing.Point(341, 83);
            this.cosFractal.Name = "cosFractal";
            this.cosFractal.Size = new System.Drawing.Size(480, 371);
            this.cosFractal.TabIndex = 2;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(105, 596);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this.rtxtNotes.TabIndex = 3;
            this.rtxtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(105, 577);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notizen:";
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(341, 477);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 5;
            this.butStart.Text = "&Start";
            this.butStart.UseVisualStyleBackColor = true;
            // 
            // grpIFS
            // 
            this.grpIFS.Location = new System.Drawing.Point(81, 219);
            this.grpIFS.Name = "grpIFS";
            this.grpIFS.Size = new System.Drawing.Size(200, 200);
            this.grpIFS.TabIndex = 6;
            this.grpIFS.TabStop = false;
            this.grpIFS.Text = "IFS";
            // 
            // FrmFraktalChaos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 732);
            this.Controls.Add(this.grpIFS);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosFractal);
            this.Controls.Add(this.butSaveFractal);
            this.Controls.Add(this.grpInputParam);
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
        private CoordinateSystem cosFractal;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.GroupBox grpIFS;
    }
}