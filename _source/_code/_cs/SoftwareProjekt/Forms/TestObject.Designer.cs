namespace SoftwareProjekt.Forms
{
    partial class TestObject
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
            this.coordinateSystem1 = new SoftwareProjekt.CoordinateSystem();
            this.mindMapButtonControl1 = new MindMapButtonControl("Hallo, hier ist Julian", 2, EAlignType.AlignRight);
            this.SuspendLayout();
            // 
            // coordinateSystem1
            // 
            this.coordinateSystem1.Location = new System.Drawing.Point(1, -1);
            this.coordinateSystem1.Name = "coordinateSystem1";
            this.coordinateSystem1.Size = new System.Drawing.Size(398, 387);
            this.coordinateSystem1.TabIndex = 0;
            // 
            // mindMapButtonControl1
            // 
            this.mindMapButtonControl1.Location = new System.Drawing.Point(41, 477);
            this.mindMapButtonControl1.Name = "mindMapButtonControl1";
            this.mindMapButtonControl1.Size = new System.Drawing.Size(150, 30);
            this.mindMapButtonControl1.TabIndex = 1;
            // 
            // TestObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 778);
            this.Controls.Add(this.mindMapButtonControl1);
            this.Controls.Add(this.coordinateSystem1);
            this.Name = "TestObject";
            this.Text = "TestObject";
            this.ResumeLayout(false);

        }

        #endregion

        private CoordinateSystem coordinateSystem1;
        private MindMapButtonControl mindMapButtonControl1;

    }
}