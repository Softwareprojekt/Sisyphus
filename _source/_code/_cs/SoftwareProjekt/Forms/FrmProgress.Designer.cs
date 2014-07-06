namespace SoftwareProjekt.Forms
{
    partial class FrmProgress
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
            this._pbProgessBar = new System.Windows.Forms.ProgressBar();
            this._btnCancel = new System.Windows.Forms.Button();
            this._lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _pbProgessBar
            // 
            this._pbProgessBar.Location = new System.Drawing.Point(12, 46);
            this._pbProgessBar.MarqueeAnimationSpeed = 25;
            this._pbProgessBar.Name = "_pbProgessBar";
            this._pbProgessBar.Size = new System.Drawing.Size(259, 23);
            this._pbProgessBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this._pbProgessBar.TabIndex = 0;
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(196, 84);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "Abbrechen";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _lblText
            // 
            this._lblText.AutoSize = true;
            this._lblText.Location = new System.Drawing.Point(9, 21);
            this._lblText.Name = "_lblText";
            this._lblText.Size = new System.Drawing.Size(65, 13);
            this._lblText.TabIndex = 2;
            this._lblText.Text = "Berechne ...";
            // 
            // FrmProgress
            // 
            this.AcceptButton = this._btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 119);
            this.Controls.Add(this._lblText);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._pbProgessBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProgress";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProgress_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar _pbProgessBar;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label _lblText;
    }
}