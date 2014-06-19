namespace SoftwareProjekt.Forms
{
    partial class FrmHinterLinAbb
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
            this.grpDataOutput1 = new System.Windows.Forms.GroupBox();
            this.butFx = new System.Windows.Forms.Button();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.grpDataInput1 = new System.Windows.Forms.GroupBox();
            this.txtDeterminante1 = new System.Windows.Forms.TextBox();
            this.butDeterminante1 = new System.Windows.Forms.Button();
            this.butGx = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput2 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtVectorGx2 = new System.Windows.Forms.TextBox();
            this.picMathEquLeft = new System.Windows.Forms.PictureBox();
            this.picMathEquRight = new System.Windows.Forms.PictureBox();
            this.picMathEquBig = new System.Windows.Forms.PictureBox();
            this.lblOutputCos2 = new System.Windows.Forms.Label();
            this.grpDataInput1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquBig)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDataOutput1
            // 
            this.grpDataOutput1.Location = new System.Drawing.Point(695, 70);
            this.grpDataOutput1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataOutput1.Name = "grpDataOutput1";
            this.grpDataOutput1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataOutput1.Size = new System.Drawing.Size(137, 176);
            this.grpDataOutput1.TabIndex = 41;
            this.grpDataOutput1.TabStop = false;
            this.grpDataOutput1.Text = "Datenausgabe1";
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(610, 57);
            this.butFx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(41, 30);
            this.butFx.TabIndex = 38;
            this.butFx.Text = "f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Location = new System.Drawing.Point(672, 444);
            this.lblOutput1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(146, 13);
            this.lblOutput1.TabIndex = 40;
            this.lblOutput1.Text = "Ausgabekoordinatensystem1:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(136, 444);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(137, 13);
            this.lblInput.TabIndex = 37;
            this.lblInput.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Controls.Add(this.txtDeterminante1);
            this.grpDataInput1.Location = new System.Drawing.Point(11, 86);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput1.Size = new System.Drawing.Size(297, 188);
            this.grpDataInput1.TabIndex = 35;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe1";
            // 
            // txtDeterminante1
            // 
            this.txtDeterminante1.Location = new System.Drawing.Point(154, 98);
            this.txtDeterminante1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeterminante1.Name = "txtDeterminante1";
            this.txtDeterminante1.Size = new System.Drawing.Size(99, 20);
            this.txtDeterminante1.TabIndex = 36;
            // 
            // butDeterminante1
            // 
            this.butDeterminante1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante1.Location = new System.Drawing.Point(205, 82);
            this.butDeterminante1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeterminante1.Name = "butDeterminante1";
            this.butDeterminante1.Size = new System.Drawing.Size(131, 34);
            this.butDeterminante1.TabIndex = 35;
            this.butDeterminante1.Text = "Determinante";
            this.butDeterminante1.UseVisualStyleBackColor = true;
            // 
            // butGx
            // 
            this.butGx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGx.Location = new System.Drawing.Point(924, 70);
            this.butGx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butGx.Name = "butGx";
            this.butGx.Size = new System.Drawing.Size(81, 38);
            this.butGx.TabIndex = 42;
            this.butGx.Text = "g(x)";
            this.butGx.UseVisualStyleBackColor = true;
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(12, 460);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(362, 303);
            this.cosInput.TabIndex = 47;
            // 
            // cosOutput1
            // 
            this.cosOutput1.Location = new System.Drawing.Point(583, 460);
            this.cosOutput1.Name = "cosOutput1";
            this.cosOutput1.Size = new System.Drawing.Size(356, 303);
            this.cosOutput1.TabIndex = 48;
            // 
            // cosOutput2
            // 
            this.cosOutput2.Location = new System.Drawing.Point(1148, 460);
            this.cosOutput2.Name = "cosOutput2";
            this.cosOutput2.Size = new System.Drawing.Size(373, 303);
            this.cosOutput2.TabIndex = 49;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(234, 964);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 51;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(235, 981);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this.rtxtNotes.TabIndex = 50;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(495, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(494, 25);
            this.lblHeader.TabIndex = 52;
            this.lblHeader.Text = "Thema: Hintereinanderausführung linearer Abbildungen";
            // 
            // txtVectorGx2
            // 
            this.txtVectorGx2.Location = new System.Drawing.Point(75, 53);
            this.txtVectorGx2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVectorGx2.Name = "txtVectorGx2";
            this.txtVectorGx2.Size = new System.Drawing.Size(52, 20);
            this.txtVectorGx2.TabIndex = 5;
            // 
            // picMathEquLeft
            // 
            this.picMathEquLeft.Location = new System.Drawing.Point(380, 547);
            this.picMathEquLeft.Name = "picMathEquLeft";
            this.picMathEquLeft.Size = new System.Drawing.Size(197, 121);
            this.picMathEquLeft.TabIndex = 53;
            this.picMathEquLeft.TabStop = false;
            // 
            // picMathEquRight
            // 
            this.picMathEquRight.Location = new System.Drawing.Point(945, 547);
            this.picMathEquRight.Name = "picMathEquRight";
            this.picMathEquRight.Size = new System.Drawing.Size(197, 121);
            this.picMathEquRight.TabIndex = 54;
            this.picMathEquRight.TabStop = false;
            // 
            // picMathEquBig
            // 
            this.picMathEquBig.Location = new System.Drawing.Point(224, 309);
            this.picMathEquBig.Name = "picMathEquBig";
            this.picMathEquBig.Size = new System.Drawing.Size(1169, 93);
            this.picMathEquBig.TabIndex = 55;
            this.picMathEquBig.TabStop = false;
            // 
            // lblOutputCos2
            // 
            this.lblOutputCos2.AutoSize = true;
            this.lblOutputCos2.Location = new System.Drawing.Point(1263, 444);
            this.lblOutputCos2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputCos2.Name = "lblOutputCos2";
            this.lblOutputCos2.Size = new System.Drawing.Size(146, 13);
            this.lblOutputCos2.TabIndex = 56;
            this.lblOutputCos2.Text = "Ausgabekoordinatensystem1:";
            // 
            // FrmHinterLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 941);
            this.Controls.Add(this.lblOutputCos2);
            this.Controls.Add(this.picMathEquBig);
            this.Controls.Add(this.picMathEquRight);
            this.Controls.Add(this.picMathEquLeft);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosOutput2);
            this.Controls.Add(this.cosOutput1);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.butGx);
            this.Controls.Add(this.grpDataOutput1);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.lblOutput1);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.grpDataInput1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHinterLinAbb";
            this.Text = "Hintereinanderausführung linearer Abbildungen";
            this.grpDataInput1.ResumeLayout(false);
            this.grpDataInput1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataOutput1;
        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.Label lblOutput1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox grpDataInput1;
        private System.Windows.Forms.TextBox txtDeterminante1;
        private System.Windows.Forms.Button butDeterminante1;
        private System.Windows.Forms.Button butGx;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput1;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtVectorGx2;
        private System.Windows.Forms.PictureBox picMathEquLeft;
        private System.Windows.Forms.PictureBox picMathEquRight;
        private System.Windows.Forms.PictureBox picMathEquBig;
        private System.Windows.Forms.Label lblOutputCos2;
    }
}