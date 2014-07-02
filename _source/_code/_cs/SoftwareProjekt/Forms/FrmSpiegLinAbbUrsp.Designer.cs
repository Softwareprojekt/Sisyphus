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
            SoftwareProjekt.Classes.Math.Vector vector4 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector5 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector6 = new SoftwareProjekt.Classes.Math.Vector();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtFunctionTransfX = new System.Windows.Forms.TextBox();
            this.butFunctionTransfX = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputEV2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputEV1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.lblPunktX = new System.Windows.Forms.Label();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblEV2 = new System.Windows.Forms.Label();
            this.lblEV1 = new System.Windows.Forms.Label();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.lblPointX = new System.Windows.Forms.Label();
            this.lvlVectorG = new System.Windows.Forms.Label();
            this.txtVectorG = new System.Windows.Forms.TextBox();
            this.grpDatenausgabe = new System.Windows.Forms.GroupBox();
            this.coordinateSystem1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.coordinateSystem2 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.butFx = new System.Windows.Forms.Button();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.picMathEquatCenter = new System.Windows.Forms.PictureBox();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this.grpDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(1160, 344);
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
            this.lblInput.Location = new System.Drawing.Point(165, 344);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(183, 17);
            this.lblInput.TabIndex = 43;
            this.lblInput.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.ctlVectorInputEV2);
            this.grpDataInput.Controls.Add(this.ctlVectorInputEV1);
            this.grpDataInput.Controls.Add(this.lblPunktX);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Controls.Add(this.txtAngle);
            this.grpDataInput.Controls.Add(this.lblAngle);
            this.grpDataInput.Controls.Add(this.lblEV2);
            this.grpDataInput.Controls.Add(this.lblEV1);
            this.grpDataInput.Location = new System.Drawing.Point(12, 66);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput.Size = new System.Drawing.Size(503, 201);
            this.grpDataInput.TabIndex = 41;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // ctlVectorInputEV2
            // 
            this.ctlVectorInputEV2.Location = new System.Drawing.Point(337, 55);
            this.ctlVectorInputEV2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInputEV2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputEV2.Name = "ctlVectorInputEV2";
            this.ctlVectorInputEV2.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputEV2.TabIndex = 3;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInputEV2.Vector = vector4;
            // 
            // ctlVectorInputEV1
            // 
            this.ctlVectorInputEV1.Location = new System.Drawing.Point(172, 55);
            this.ctlVectorInputEV1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInputEV1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputEV1.Name = "ctlVectorInputEV1";
            this.ctlVectorInputEV1.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputEV1.TabIndex = 2;
            vector5.X1 = float.NaN;
            vector5.X2 = float.NaN;
            this.ctlVectorInputEV1.Vector = vector5;
            // 
            // lblPunktX
            // 
            this.lblPunktX.AutoSize = true;
            this.lblPunktX.Location = new System.Drawing.Point(46, 34);
            this.lblPunktX.Name = "lblPunktX";
            this.lblPunktX.Size = new System.Drawing.Size(54, 17);
            this.lblPunktX.TabIndex = 65;
            this.lblPunktX.Text = "Punkt x";
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(7, 55);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputX.TabIndex = 1;
            vector6.X1 = float.NaN;
            vector6.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector6;
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(80, 166);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAngle.MaxLength = 5;
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(84, 22);
            this.txtAngle.TabIndex = 4;
            this.txtAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngle_KeyPress);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(16, 168);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(54, 17);
            this.lblAngle.TabIndex = 14;
            this.lblAngle.Text = "Winkel:";
            // 
            // lblEV2
            // 
            this.lblEV2.AutoSize = true;
            this.lblEV2.Location = new System.Drawing.Point(395, 34);
            this.lblEV2.Name = "lblEV2";
            this.lblEV2.Size = new System.Drawing.Size(34, 17);
            this.lblEV2.TabIndex = 10;
            this.lblEV2.Text = "EV2";
            // 
            // lblEV1
            // 
            this.lblEV1.AutoSize = true;
            this.lblEV1.Location = new System.Drawing.Point(228, 34);
            this.lblEV1.Name = "lblEV1";
            this.lblEV1.Size = new System.Drawing.Size(38, 17);
            this.lblEV1.TabIndex = 8;
            this.lblEV1.Text = "EV1:";
            // 
            // txtPointX
            // 
            this.txtPointX.Location = new System.Drawing.Point(0, 0);
            this.txtPointX.Name = "txtPointX";
            this.txtPointX.Size = new System.Drawing.Size(100, 22);
            this.txtPointX.TabIndex = 0;
            // 
            // lblPointX
            // 
            this.lblPointX.Location = new System.Drawing.Point(0, 0);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(100, 23);
            this.lblPointX.TabIndex = 0;
            // 
            // lvlVectorG
            // 
            this.lvlVectorG.Location = new System.Drawing.Point(0, 0);
            this.lvlVectorG.Name = "lvlVectorG";
            this.lvlVectorG.Size = new System.Drawing.Size(100, 23);
            this.lvlVectorG.TabIndex = 0;
            // 
            // txtVectorG
            // 
            this.txtVectorG.Location = new System.Drawing.Point(0, 0);
            this.txtVectorG.Name = "txtVectorG";
            this.txtVectorG.Size = new System.Drawing.Size(100, 22);
            this.txtVectorG.TabIndex = 0;
            // 
            // grpDatenausgabe
            // 
            this.grpDatenausgabe.Location = new System.Drawing.Point(0, 0);
            this.grpDatenausgabe.Name = "grpDatenausgabe";
            this.grpDatenausgabe.Size = new System.Drawing.Size(200, 100);
            this.grpDatenausgabe.TabIndex = 0;
            this.grpDatenausgabe.TabStop = false;
            // 
            // coordinateSystem1
            // 
            this.coordinateSystem1.Location = new System.Drawing.Point(0, 0);
            this.coordinateSystem1.Name = "coordinateSystem1";
            this.coordinateSystem1.Size = new System.Drawing.Size(150, 150);
            this.coordinateSystem1.TabIndex = 0;
            // 
            // coordinateSystem2
            // 
            this.coordinateSystem2.Location = new System.Drawing.Point(0, 0);
            this.coordinateSystem2.Name = "coordinateSystem2";
            this.coordinateSystem2.Size = new System.Drawing.Size(150, 150);
            this.coordinateSystem2.TabIndex = 0;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(406, 769);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 60;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(407, 790);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 95);
            this.rtxtNotes.TabIndex = 6;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(440, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(589, 29);
            this.lblHeader.TabIndex = 61;
            this.lblHeader.Text = "Thema: Spiegelung lineare Abbildung am Ursprung";
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
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(12, 364);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(454, 368);
            this.cosInput.TabIndex = 62;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(1005, 364);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(454, 368);
            this.cosOutput.TabIndex = 63;
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(670, 239);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(104, 52);
            this.butFx.TabIndex = 5;
            this.butFx.Text = "&Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // txtFx
            // 
            this.txtFx.Location = new System.Drawing.Point(612, 296);
            this.txtFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(221, 22);
            this.txtFx.TabIndex = 68;
            // 
            // ctlMathEqua
            // 
            this.ctlMathEqua.Arrowdirection = SoftwareProjekt.Enums.EArrowDirection.up;
            this.ctlMathEqua.Equation = "";
            this.ctlMathEqua.Filename = "expr.gif";
            this.ctlMathEqua.Filepath = "C:\\Program Files (x86)\\Microsoft Visual Studio 11.0\\Common7\\IDE";
            this.ctlMathEqua.FontSize = 8;
            this.ctlMathEqua.Location = new System.Drawing.Point(517, 493);
            this.ctlMathEqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlMathEqua.Name = "ctlMathEqua";
            this.ctlMathEqua.Size = new System.Drawing.Size(439, 113);
            this.ctlMathEqua.TabIndex = 69;
            // 
            // picMathEquatCenter
            // 
            this.picMathEquatCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.picMathEquatCenter.BackColor = System.Drawing.Color.Transparent;
            this.picMathEquatCenter.Location = new System.Drawing.Point(453, 425);
            this.picMathEquatCenter.Margin = new System.Windows.Forms.Padding(4);
            this.picMathEquatCenter.Name = "picMathEquatCenter";
            this.picMathEquatCenter.Size = new System.Drawing.Size(375, 142);
            this.picMathEquatCenter.TabIndex = 70;
            this.picMathEquatCenter.TabStop = false;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(430, 333);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(572, 346);
            this.picBoxArrow.TabIndex = 71;
            this.picBoxArrow.TabStop = false;
            // 
            // FrmSpiegLinAbbUrsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 898);
            this.Controls.Add(this.picMathEquatCenter);
            this.Controls.Add(this.picBoxArrow);
            this.Controls.Add(this.ctlMathEqua);
            this.Controls.Add(this.txtFx);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.grpDataInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSpiegLinAbbUrsp";
            this.Text = "Spiegelung lineare Abbildung am Ursprung";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEquatCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
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
        private System.Windows.Forms.Label lblEV2;
        private System.Windows.Forms.Label lblEV1;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.Label lvlVectorG;
        private System.Windows.Forms.TextBox txtVectorG;
        private System.Windows.Forms.GroupBox grpDatenausgabe;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem1;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Button butDeterminante;
        private UserControls.CtlVectorInput ctlVectorInputEV2;
        private UserControls.CtlVectorInput ctlVectorInputEV1;
        private System.Windows.Forms.Label lblPunktX;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private UserControls.CoordinateSystem cosInput;
        private UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.TextBox txtFx;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
        private System.Windows.Forms.PictureBox picMathEquatCenter;
        private System.Windows.Forms.PictureBox picBoxArrow;
    }
}