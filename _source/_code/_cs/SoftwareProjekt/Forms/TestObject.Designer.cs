using SoftwareProjekt.Enums;
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
            this.coordinateSystem1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.mindMapTopicControl1 = new SoftwareProjekt.UserControls.MindMap.MindMapTopicControl();
            this.mindMap1 = new SoftwareProjekt.UserControls.MindMap.CtlMindMap();
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
            this.mindMapButtonControl1 = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl("Hallo", EExercises.DrehungLinAbbUmUrsprung, EAlignType.AlignRight);
            this.mindMapButtonControl1.BottomAlign = false;
            this.mindMapButtonControl1.ButtonText = "Hallo, hier ist Julian";
            this.mindMapButtonControl1.LeftAlign = false;
            this.mindMapButtonControl1.Location = new System.Drawing.Point(41, 477);
            this.mindMapButtonControl1.Name = "mindMapButtonControl1";
            this.mindMapButtonControl1.RightAlign = true;
            this.mindMapButtonControl1.Size = new System.Drawing.Size(150, 30);
            this.mindMapButtonControl1.TabIndex = 1;
            this.mindMapButtonControl1.TopAlign = false;
            // 
            // mindMapTopicControl1
            // 
            this.mindMapTopicControl1.Location = new System.Drawing.Point(40, 600);
            this.mindMapTopicControl1.Name = "mindMapTopicControl1";
            this.mindMapTopicControl1.Size = new System.Drawing.Size(200, 150);
            this.mindMapTopicControl1.TabIndex = 2;
            this.mindMapTopicControl1.TopicName = "";
            // 
            // mindMap1
            // 
            this.mindMap1.Location = new System.Drawing.Point(430, 48);
            this.mindMap1.Name = "mindMap1";
            this.mindMap1.Size = new System.Drawing.Size(320, 320);
            this.mindMap1.TabIndex = 3;

            // 
            // TestObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 684);
            this.Controls.Add(this.mindMap1);
            this.Controls.Add(this.mindMapButtonControl1);
            this.Controls.Add(this.coordinateSystem1);
            this.Controls.Add(this.mindMapTopicControl1);
            this.Name = "TestObject";
            this.Text = "TestObject";
            this.ResumeLayout(false);

        }

        #endregion

        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem1;
        private SoftwareProjekt.UserControls.MindMap.MindMapButtonControl mindMapButtonControl1;
        private SoftwareProjekt.UserControls.MindMap.MindMapTopicControl mindMapTopicControl1;
        private SoftwareProjekt.UserControls.MindMap.CtlMindMap mindMap1;

    }
}