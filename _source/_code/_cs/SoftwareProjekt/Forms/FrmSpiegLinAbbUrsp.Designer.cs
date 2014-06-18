namespace SoftwareProjekt.Forms
{
    partial class FrmSpiegLinAbbUrsp
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtFunctionTransfX = new System.Windows.Forms.TextBox();
            this.butFunctionTransfX = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtEV2 = new System.Windows.Forms.TextBox();
            this.lblEV2 = new System.Windows.Forms.Label();
            this.txtEV1 = new System.Windows.Forms.TextBox();
            this.lblEV1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.grpDataOutput = new System.Windows.Forms.GroupBox();
            this.cosInputKoordSystem = new SoftwareProjekt.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.CoordinateSystem();
=======
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.lblPointX = new System.Windows.Forms.Label();
            this.lvlVectorG = new System.Windows.Forms.Label();
            this.txtVectorG = new System.Windows.Forms.TextBox();
            this.grpDatenausgabe = new System.Windows.Forms.GroupBox();
            this.coordinateSystem1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.coordinateSystem2 = new SoftwareProjekt.UserControls.CoordinateSystem();
>>>>>>> 846a6a4aeea1b30f10d7f3efe8220e9a59087f38
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.ctlVektorInput1 = new SoftwareProjekt.CtlVektorInput();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.grpDataInput.SuspendLayout();
            this.grpDataOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(863, 254);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(187, 17);
            this.lblOutput.TabIndex = 45;
            this.lblOutput.Text = "Ausgabekoordinatensystem:";
            // 
            // txtFunctionTransfX
            // 
            this.txtFunctionTransfX.Location = new System.Drawing.Point(107, 32);
            this.txtFunctionTransfX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFunctionTransfX.Name = "txtFunctionTransfX";
            this.txtFunctionTransfX.Size = new System.Drawing.Size(84, 22);
            this.txtFunctionTransfX.TabIndex = 47;
            // 
            // butFunctionTransfX
            // 
            this.butFunctionTransfX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionTransfX.Location = new System.Drawing.Point(36, 27);
            this.butFunctionTransfX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFunctionTransfX.Name = "butFunctionTransfX";
            this.butFunctionTransfX.Size = new System.Drawing.Size(64, 32);
            this.butFunctionTransfX.TabIndex = 46;
            this.butFunctionTransfX.Text = "f(x)";
            this.butFunctionTransfX.UseVisualStyleBackColor = true;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(171, 254);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(183, 17);
            this.lblInput.TabIndex = 43;
            this.lblInput.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.ctlVektorInput1);
            this.grpDataInput.Controls.Add(this.txtAngle);
            this.grpDataInput.Controls.Add(this.lblAngle);
            this.grpDataInput.Controls.Add(this.txtEV2);
            this.grpDataInput.Controls.Add(this.lblEV2);
            this.grpDataInput.Controls.Add(this.txtEV1);
            this.grpDataInput.Controls.Add(this.lblEV1);
            this.grpDataInput.Location = new System.Drawing.Point(88, 79);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Size = new System.Drawing.Size(340, 136);
            this.grpDataInput.TabIndex = 41;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(237, 89);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(84, 22);
            this.txtAngle.TabIndex = 15;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(173, 91);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(54, 17);
            this.lblAngle.TabIndex = 14;
            this.lblAngle.Text = "Winkel:";
            // 
            // txtEV2
            // 
            this.txtEV2.Location = new System.Drawing.Point(237, 63);
            this.txtEV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEV2.Name = "txtEV2";
            this.txtEV2.Size = new System.Drawing.Size(84, 22);
            this.txtEV2.TabIndex = 11;
            // 
            // lblEV2
            // 
            this.lblEV2.AutoSize = true;
            this.lblEV2.Location = new System.Drawing.Point(173, 67);
            this.lblEV2.Name = "lblEV2";
            this.lblEV2.Size = new System.Drawing.Size(34, 17);
            this.lblEV2.TabIndex = 10;
            this.lblEV2.Text = "EV2";
            // 
            // txtEV1
            // 
            this.txtEV1.Location = new System.Drawing.Point(237, 35);
            this.txtEV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEV1.Name = "txtEV1";
            this.txtEV1.Size = new System.Drawing.Size(84, 22);
            this.txtEV1.TabIndex = 9;
            // 
            // lblEV1
            // 
            this.lblEV1.AutoSize = true;
            this.lblEV1.Location = new System.Drawing.Point(173, 38);
            this.lblEV1.Name = "lblEV1";
            this.lblEV1.Size = new System.Drawing.Size(38, 17);
            this.lblEV1.TabIndex = 8;
            this.lblEV1.Text = "EV1:";
            // 
            // grpDataOutput
            // 
            this.grpDataOutput.Controls.Add(this.txtDeterminante);
            this.grpDataOutput.Controls.Add(this.butFunctionTransfX);
            this.grpDataOutput.Controls.Add(this.butDeterminante);
            this.grpDataOutput.Controls.Add(this.txtFunctionTransfX);
            this.grpDataOutput.Location = new System.Drawing.Point(692, 79);
            this.grpDataOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataOutput.Name = "grpDataOutput";
            this.grpDataOutput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataOutput.Size = new System.Drawing.Size(358, 97);
            this.grpDataOutput.TabIndex = 56;
            this.grpDataOutput.TabStop = false;
            this.grpDataOutput.Text = "Datenausgabe";
            // 
            // cosInputKoordSystem
            // 
            this.cosInputKoordSystem.Location = new System.Drawing.Point(16, 273);
            this.cosInputKoordSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosInputKoordSystem.Name = "cosInputKoordSystem";
            this.cosInputKoordSystem.Size = new System.Drawing.Size(492, 348);
            this.cosInputKoordSystem.TabIndex = 57;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(692, 273);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(492, 348);
            this.cosOutput.TabIndex = 58;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(272, 670);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 60;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(272, 693);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 59;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(256, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(589, 29);
            this.lblHeader.TabIndex = 61;
            this.lblHeader.Text = "Thema: Spiegelung lineare Abbildung am Ursprung";
            // 
            // ctlVektorInput1
            // 
            this.ctlVektorInput1.Location = new System.Drawing.Point(7, 21);
            this.ctlVektorInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVektorInput1.Name = "ctlVektorInput1";
            this.ctlVektorInput1.Size = new System.Drawing.Size(163, 101);
            this.ctlVektorInput1.TabIndex = 62;
            this.ctlVektorInput1.Vector = null;
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(197, 63);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.Size = new System.Drawing.Size(131, 22);
            this.txtDeterminante.TabIndex = 63;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(197, 25);
            this.butDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(131, 34);
            this.butDeterminante.TabIndex = 62;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            // 
            // FrmSpiegLinAbbUrsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 855);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInputKoordSystem);
            this.Controls.Add(this.grpDataOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.grpDataInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSpiegLinAbbUrsp";
            this.Text = "Spiegelung lineare Abbildung am Ursprung";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.grpDataOutput.ResumeLayout(false);
            this.grpDataOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtFunctionTransfX;
        private System.Windows.Forms.Button butFunctionTransfX;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TextBox txtEV2;
        private System.Windows.Forms.Label lblEV2;
        private System.Windows.Forms.TextBox txtEV1;
        private System.Windows.Forms.Label lblEV1;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.Label lvlVectorG;
        private System.Windows.Forms.TextBox txtVectorG;
        private System.Windows.Forms.GroupBox grpDatenausgabe;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem1;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Button butDeterminante;
    }
}