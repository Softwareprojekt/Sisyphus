namespace SoftwareProjekt.Forms
{
    partial class FrmDrehLinAbbUrsp
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
            SoftwareProjekt.Classes.Math.Vector VectorInputX = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector VectorEV1 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector VectorEV2 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector VectorOutputX = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector VectorOutputEV1 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector VectorOutputEV2 = new SoftwareProjekt.Classes.Math.Vector();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.butFunctionTransfX = new System.Windows.Forms.Button();
            this.grpDataOutput = new System.Windows.Forms.GroupBox();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picMathEquatCenter = new System.Windows.Forms.PictureBox();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorEV1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorEV2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorOutputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorOutputEV1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorOutputEV2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.grpDataInput.SuspendLayout();
            this.grpDataOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(997, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ausgabekoordinatensystem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.ctlVectorEV2);
            this.grpDataInput.Controls.Add(this.ctlVectorEV1);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Controls.Add(this.txtAngle);
            this.grpDataInput.Controls.Add(this.lblAngle);
            this.grpDataInput.Location = new System.Drawing.Point(32, 63);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Size = new System.Drawing.Size(440, 176);
            this.grpDataInput.TabIndex = 26;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // txtAngle
            // 
            this.txtAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAngle.Location = new System.Drawing.Point(85, 127);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(2);
            this.txtAngle.MaxLength = 3;
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(64, 20);
            this.txtAngle.TabIndex = 15;
            this.txtAngle.TextChanged += new System.EventHandler(this.txtAngle_TextChanged);
            this.txtAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngle_KeyPress);
            // 
            // lblAngle
            // 
            this.lblAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(4, 130);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(80, 13);
            this.lblAngle.TabIndex = 14;
            this.lblAngle.Text = "&Winkel in Grad:";
            // 
            // butFunctionTransfX
            // 
            this.butFunctionTransfX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butFunctionTransfX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionTransfX.Location = new System.Drawing.Point(618, 144);
            this.butFunctionTransfX.Margin = new System.Windows.Forms.Padding(2);
            this.butFunctionTransfX.Name = "butFunctionTransfX";
            this.butFunctionTransfX.Size = new System.Drawing.Size(139, 41);
            this.butFunctionTransfX.TabIndex = 32;
            this.butFunctionTransfX.Text = "&Berechne";
            this.butFunctionTransfX.UseVisualStyleBackColor = true;
            this.butFunctionTransfX.Click += new System.EventHandler(this.butFunctionTransfX_Click);
            // 
            // grpDataOutput
            // 
            this.grpDataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDataOutput.Controls.Add(this.ctlVectorOutputEV2);
            this.grpDataOutput.Controls.Add(this.ctlVectorOutputEV1);
            this.grpDataOutput.Controls.Add(this.ctlVectorOutputX);
            this.grpDataOutput.Controls.Add(this.txtDeterminante);
            this.grpDataOutput.Controls.Add(this.butDeterminante);
            this.grpDataOutput.Location = new System.Drawing.Point(895, 63);
            this.grpDataOutput.Name = "grpDataOutput";
            this.grpDataOutput.Size = new System.Drawing.Size(408, 176);
            this.grpDataOutput.TabIndex = 41;
            this.grpDataOutput.TabStop = false;
            this.grpDataOutput.Text = "Ausgabe";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDeterminante.Location = new System.Drawing.Point(144, 133);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeterminante.MaxLength = 5;
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.ReadOnly = true;
            this.txtDeterminante.Size = new System.Drawing.Size(86, 20);
            this.txtDeterminante.TabIndex = 41;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(54, 130);
            this.butDeterminante.Margin = new System.Windows.Forms.Padding(2);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(86, 24);
            this.butDeterminante.TabIndex = 46;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            this.butDeterminante.Click += new System.EventHandler(this.butDeterminante_Click);
            // 
            // cosInput
            // 
            this.cosInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cosInput.Location = new System.Drawing.Point(32, 285);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(378, 232);
            this.cosInput.TabIndex = 42;
            // 
            // cosOutput
            // 
            this.cosOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput.Location = new System.Drawing.Point(925, 285);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(378, 232);
            this.cosOutput.TabIndex = 43;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(438, 673);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 44;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotes.Location = new System.Drawing.Point(439, 689);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(459, 136);
            this.rtxtNotes.TabIndex = 45;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(524, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(430, 25);
            this.lblHeader.TabIndex = 47;
            this.lblHeader.Text = "Thema: Drehungen um den Ursprung sind linear";
            // 
            // picMathEquatCenter
            // 
            this.picMathEquatCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picMathEquatCenter.Location = new System.Drawing.Point(453, 312);
            this.picMathEquatCenter.Name = "picMathEquatCenter";
            this.picMathEquatCenter.Size = new System.Drawing.Size(433, 166);
            this.picMathEquatCenter.TabIndex = 48;
            this.picMathEquatCenter.TabStop = false;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(7, 24);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorInputX.TabIndex = 16;
            this.ctlVectorInputX.grpVektorInput.Text = "Vektor x";
            VectorInputX.X1 = float.NaN;
            VectorInputX.X2 = float.NaN;
            this.ctlVectorInputX.Vector = VectorInputX;
            // 
            // ctlVectorEV1
            // 
            this.ctlVectorEV1.Location = new System.Drawing.Point(184, 24);
            this.ctlVectorEV1.Name = "ctlVectorEV1";
            this.ctlVectorEV1.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorEV1.TabIndex = 17;
            this.ctlVectorEV1.txtEle11.ReadOnly = true;
            this.ctlVectorEV1.txtEle21.ReadOnly = true;
            this.ctlVectorEV1.grpVektorInput.Text = "Einheitsvektor e1";
            VectorEV1.X1 = float.NaN;
            VectorEV1.X2 = float.NaN;
            this.ctlVectorEV1.Vector = VectorEV1;
            // 
            // ctlVectorEV2
            // 
            this.ctlVectorEV2.Location = new System.Drawing.Point(311, 24);
            this.ctlVectorEV2.Name = "ctlVectorEV2";
            this.ctlVectorEV2.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorEV2.TabIndex = 18;
            this.ctlVectorEV2.txtEle11.ReadOnly = true;
            this.ctlVectorEV2.txtEle21.ReadOnly = true;
            this.ctlVectorEV2.grpVektorInput.Text = "Einheitsvektor e2";
            VectorEV2.X1 = float.NaN;
            VectorEV2.X2 = float.NaN;
            this.ctlVectorEV2.Vector = VectorEV2;
            // 
            // ctlVectorOutputX
            // 
            this.ctlVectorOutputX.Location = new System.Drawing.Point(19, 24);
            this.ctlVectorOutputX.Name = "ctlVectorOutputX";
            this.ctlVectorOutputX.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorOutputX.TabIndex = 47;
            this.ctlVectorOutputX.grpVektorInput.Text = "Vektor x'";
            this.ctlVectorOutputX.txtEle11.ReadOnly = true;
            this.ctlVectorOutputX.txtEle21.ReadOnly = true;
            VectorOutputX.X1 = float.NaN;
            VectorOutputX.X2 = float.NaN;
            this.ctlVectorOutputX.Vector = VectorOutputX;
            // 
            // ctlVectorOutputEV1
            // 
            this.ctlVectorOutputEV1.Location = new System.Drawing.Point(157, 24);
            this.ctlVectorOutputEV1.Name = "ctlVectorOutputEV1";
            this.ctlVectorOutputEV1.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorOutputEV1.TabIndex = 48;
            this.ctlVectorOutputEV1.grpVektorInput.Text = "Vektor e1'";
            this.ctlVectorOutputEV1.txtEle11.ReadOnly = true;
            this.ctlVectorOutputEV1.txtEle21.ReadOnly = true;
            VectorOutputEV1.X1 = float.NaN;
            VectorOutputEV1.X2 = float.NaN;
            this.ctlVectorOutputEV1.Vector = VectorOutputEV1;
            // 
            // ctlVectorOutputEV2
            // 
            this.ctlVectorOutputEV2.Location = new System.Drawing.Point(284, 24);
            this.ctlVectorOutputEV2.Name = "ctlVectorOutputEV2";
            this.ctlVectorOutputEV2.Size = new System.Drawing.Size(121, 83);
            this.ctlVectorOutputEV2.TabIndex = 49;
            this.ctlVectorOutputEV2.grpVektorInput.Text = "Vektor e2'";
            this.ctlVectorOutputEV2.txtEle11.ReadOnly = true;
            this.ctlVectorOutputEV2.txtEle21.ReadOnly = true;
            VectorOutputEV2.X1 = float.NaN;
            VectorOutputEV2.X2 = float.NaN;
            this.ctlVectorOutputEV2.Vector = VectorOutputEV2;
            // 
            // FrmDrehLinAbbUrsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 849);
            this.Controls.Add(this.butFunctionTransfX);
            this.Controls.Add(this.picMathEquatCenter);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.grpDataOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpDataInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1310, 833);
            this.Name = "FrmDrehLinAbbUrsp";
            this.Text = "Drehung linearer Abbildungen am Ursprung";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.grpDataOutput.ResumeLayout(false);
            this.grpDataOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Button butFunctionTransfX;
        private System.Windows.Forms.GroupBox grpDataOutput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Button butDeterminante;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picMathEquatCenter;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private UserControls.CtlVectorInput ctlVectorEV2;
        private UserControls.CtlVectorInput ctlVectorEV1;
        private UserControls.CtlVectorInput ctlVectorOutputEV2;
        private UserControls.CtlVectorInput ctlVectorOutputEV1;
        private UserControls.CtlVectorInput ctlVectorOutputX;

    }
}