﻿namespace SoftwareProjekt.Forms
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
            SoftwareProjekt.Classes.Math.Vector vector7 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector8 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector9 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector10 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector11 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector12 = new SoftwareProjekt.Classes.Math.Vector();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.ctlVectorEV2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorEV1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.lblAngle = new System.Windows.Forms.Label();
            this.butFunctionTransfX = new System.Windows.Forms.Button();
            this.grpDataOutput = new System.Windows.Forms.GroupBox();
            this.ctlVectorOutputEV2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorOutputEV1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorOutputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picMathEquatCenter = new System.Windows.Forms.PictureBox();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this.grpDataInput.SuspendLayout();
            this.grpDataOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1410, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ausgabekoordinatensystem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.ctlVectorEV2);
            this.grpDataInput.Controls.Add(this.ctlVectorEV1);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Controls.Add(this.lblAngle);
            this.grpDataInput.Location = new System.Drawing.Point(43, 78);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Size = new System.Drawing.Size(578, 190);
            this.grpDataInput.TabIndex = 26;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // ctlVectorEV2
            // 
            this.ctlVectorEV2.Location = new System.Drawing.Point(390, 33);
            this.ctlVectorEV2.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorEV2.MinimumSize = new System.Drawing.Size(181, 116);
            this.ctlVectorEV2.Name = "ctlVectorEV2";
            this.ctlVectorEV2.Size = new System.Drawing.Size(181, 116);
            this.ctlVectorEV2.TabIndex = 4;
            this.ctlVectorEV2.grpVektorInput.Text = "Einheitsvektor e2";
            this.ctlVectorEV2.txtEle11.ReadOnly = true;
            this.ctlVectorEV2.txtEle21.ReadOnly = true;
            vector7.X1 = float.NaN;
            vector7.X2 = float.NaN;
            this.ctlVectorEV2.Vector = vector7;
            // 
            // ctlVectorEV1
            // 
            this.ctlVectorEV1.Location = new System.Drawing.Point(199, 33);
            this.ctlVectorEV1.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorEV1.MinimumSize = new System.Drawing.Size(181, 116);
            this.ctlVectorEV1.Name = "ctlVectorEV1";
            this.ctlVectorEV1.Size = new System.Drawing.Size(181, 116);
            this.ctlVectorEV1.TabIndex = 3;
            this.ctlVectorEV1.grpVektorInput.Text = "Einheitsvektor e1";
            this.ctlVectorEV1.txtEle11.ReadOnly = true;
            this.ctlVectorEV1.txtEle21.ReadOnly = true;
            vector8.X1 = float.NaN;
            vector8.X2 = float.NaN;
            this.ctlVectorEV1.Vector = vector8;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(8, 24);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(181, 116);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(181, 116);
            this.ctlVectorInputX.TabIndex = 1;
            this.ctlVectorInputX.grpVektorInput.Text = "Vektor x";
            vector9.X1 = float.NaN;
            vector9.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector9;
            // 
            // lblAngle
            // 
            this.lblAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(6, 160);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(105, 17);
            this.lblAngle.TabIndex = 14;
            this.lblAngle.Text = "&Winkel in Grad:";
            // 
            // butFunctionTransfX
            // 
            this.butFunctionTransfX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butFunctionTransfX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionTransfX.Location = new System.Drawing.Point(784, 150);
            this.butFunctionTransfX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFunctionTransfX.Name = "butFunctionTransfX";
            this.butFunctionTransfX.Size = new System.Drawing.Size(185, 50);
            this.butFunctionTransfX.TabIndex = 5;
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
            this.grpDataOutput.Location = new System.Drawing.Point(1193, 78);
            this.grpDataOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grpDataOutput.Name = "grpDataOutput";
            this.grpDataOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grpDataOutput.Size = new System.Drawing.Size(589, 209);
            this.grpDataOutput.TabIndex = 41;
            this.grpDataOutput.TabStop = false;
            this.grpDataOutput.Text = "Ausgabe";
            // 
            // ctlVectorOutputEV2
            // 
            this.ctlVectorOutputEV2.Location = new System.Drawing.Point(391, 24);
            this.ctlVectorOutputEV2.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorOutputEV2.MinimumSize = new System.Drawing.Size(181, 116);
            this.ctlVectorOutputEV2.Name = "ctlVectorOutputEV2";
            this.ctlVectorOutputEV2.Size = new System.Drawing.Size(181, 116);
            this.ctlVectorOutputEV2.TabIndex = 49;
            this.ctlVectorOutputEV2.grpVektorInput.Text = "Vektor e2'";
            this.ctlVectorOutputEV2.txtEle11.ReadOnly = true;
            this.ctlVectorOutputEV2.txtEle21.ReadOnly = true;
            vector10.X1 = float.NaN;
            vector10.X2 = float.NaN;
            this.ctlVectorOutputEV2.Vector = vector10;
            // 
            // ctlVectorOutputEV1
            // 
            this.ctlVectorOutputEV1.Location = new System.Drawing.Point(200, 24);
            this.ctlVectorOutputEV1.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorOutputEV1.MinimumSize = new System.Drawing.Size(181, 116);
            this.ctlVectorOutputEV1.Name = "ctlVectorOutputEV1";
            this.ctlVectorOutputEV1.Size = new System.Drawing.Size(181, 116);
            this.ctlVectorOutputEV1.TabIndex = 48;
            this.ctlVectorOutputEV1.grpVektorInput.Text = "Vektor e1'";
            this.ctlVectorOutputEV1.txtEle11.ReadOnly = true;
            this.ctlVectorOutputEV1.txtEle21.ReadOnly = true;
            vector11.X1 = float.NaN;
            vector11.X2 = float.NaN;
            this.ctlVectorOutputEV1.Vector = vector11;
            // 
            // ctlVectorOutputX
            // 
            this.ctlVectorOutputX.Location = new System.Drawing.Point(9, 24);
            this.ctlVectorOutputX.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorOutputX.MinimumSize = new System.Drawing.Size(181, 116);
            this.ctlVectorOutputX.Name = "ctlVectorOutputX";
            this.ctlVectorOutputX.Size = new System.Drawing.Size(181, 116);
            this.ctlVectorOutputX.TabIndex = 47;
            this.ctlVectorOutputX.grpVektorInput.Text = "Vektor x'";
            this.ctlVectorOutputX.txtEle11.ReadOnly = true;
            this.ctlVectorOutputX.txtEle21.ReadOnly = true;
            vector12.X1 = float.NaN;
            vector12.X2 = float.NaN;
            this.ctlVectorOutputX.Vector = vector12;
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDeterminante.Location = new System.Drawing.Point(130, 152);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante.MaxLength = 5;
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.ReadOnly = true;
            this.txtDeterminante.Size = new System.Drawing.Size(113, 22);
            this.txtDeterminante.TabIndex = 41;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(9, 148);
            this.butDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(115, 30);
            this.butDeterminante.TabIndex = 6;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            this.butDeterminante.Click += new System.EventHandler(this.butDeterminante_Click);
            // 
            // cosInput
            // 
            this.cosInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cosInput.Location = new System.Drawing.Point(43, 351);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(504, 286);
            this.cosInput.TabIndex = 42;
            // 
            // cosOutput
            // 
            this.cosOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput.Location = new System.Drawing.Point(1233, 351);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(504, 286);
            this.cosOutput.TabIndex = 43;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(584, 828);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 44;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotes.Location = new System.Drawing.Point(585, 848);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(611, 166);
            this.rtxtNotes.TabIndex = 7;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(617, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(555, 29);
            this.lblHeader.TabIndex = 47;
            this.lblHeader.Text = "Thema: Drehungen um den Ursprung sind linear";
            // 
            // picMathEquatCenter
            // 
            this.picMathEquatCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picMathEquatCenter.BackColor = System.Drawing.Color.Transparent;
            this.picMathEquatCenter.Location = new System.Drawing.Point(632, 406);
            this.picMathEquatCenter.Margin = new System.Windows.Forms.Padding(4);
            this.picMathEquatCenter.Name = "picMathEquatCenter";
            this.picMathEquatCenter.Size = new System.Drawing.Size(375, 142);
            this.picMathEquatCenter.TabIndex = 48;
            this.picMathEquatCenter.TabStop = false;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(609, 314);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(572, 346);
            this.picBoxArrow.TabIndex = 49;
            this.picBoxArrow.TabStop = false;
            // 
            // FrmDrehLinAbbUrsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 1045);
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
            this.Controls.Add(this.picBoxArrow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1741, 1015);
            this.Name = "FrmDrehLinAbbUrsp";
            this.Text = "Drehung linearer Abbildungen am Ursprung";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.grpDataOutput.ResumeLayout(false);
            this.grpDataOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpDataInput;
        private SoftwareProjekt.UserControls.FloatInput txtAngle;
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
        private System.Windows.Forms.PictureBox picBoxArrow;

    }
}