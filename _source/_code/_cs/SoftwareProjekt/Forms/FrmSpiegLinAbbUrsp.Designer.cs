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
            SoftwareProjekt.Classes.Math.Vector vector1 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector3 = new SoftwareProjekt.Classes.Math.Vector();
            this.txtFunctionTransfX = new System.Windows.Forms.TextBox();
            this.butFunctionTransfX = new System.Windows.Forms.Button();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputEV2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputEV1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.lblPointX = new System.Windows.Forms.Label();
            this.lvlVectorG = new System.Windows.Forms.Label();
            this.txtVectorG = new System.Windows.Forms.TextBox();
            this.grpDatenausgabe = new System.Windows.Forms.GroupBox();
            this.coordinateSystem1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.coordinateSystem2 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.butFx = new System.Windows.Forms.Button();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.ftxtAngle = new SoftwareProjekt.UserControls.FloatInput();
            this.grpDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFunctionTransfX
            // 
            this.txtFunctionTransfX.Location = new System.Drawing.Point(107, 32);
            this.txtFunctionTransfX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFunctionTransfX.Name = "txtFunctionTransfX";
            this.txtFunctionTransfX.Size = new System.Drawing.Size(84, 20);
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
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.ftxtAngle);
            this.grpDataInput.Controls.Add(this.ctlVectorInputEV2);
            this.grpDataInput.Controls.Add(this.ctlVectorInputEV1);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Controls.Add(this.lblAngle);
            this.grpDataInput.Location = new System.Drawing.Point(25, 489);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDataInput.Size = new System.Drawing.Size(377, 154);
            this.grpDataInput.TabIndex = 41;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Dateneingabe";
            // 
            // ctlVectorInputEV2
            // 
            this.ctlVectorInputEV2.Controlname = "Vector Input";
            this.ctlVectorInputEV2.Location = new System.Drawing.Point(253, 24);
            this.ctlVectorInputEV2.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputEV2.Name = "ctlVectorInputEV2";
            this.ctlVectorInputEV2.Size = new System.Drawing.Size(118, 85);
            this.ctlVectorInputEV2.TabIndex = 3;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputEV2.Vector = vector1;
            // 
            // ctlVectorInputEV1
            // 
            this.ctlVectorInputEV1.Controlname = "Vector Input";
            this.ctlVectorInputEV1.Location = new System.Drawing.Point(129, 24);
            this.ctlVectorInputEV1.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputEV1.Name = "ctlVectorInputEV1";
            this.ctlVectorInputEV1.Size = new System.Drawing.Size(118, 85);
            this.ctlVectorInputEV1.TabIndex = 2;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInputEV1.Vector = vector2;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Controlname = "Vector Input";
            this.ctlVectorInputX.Location = new System.Drawing.Point(5, 24);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(102, 76);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(118, 85);
            this.ctlVectorInputX.TabIndex = 1;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector3;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(4, 123);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(43, 13);
            this.lblAngle.TabIndex = 14;
            this.lblAngle.Text = "Winkel:";
            // 
            // txtPointX
            // 
            this.txtPointX.Location = new System.Drawing.Point(0, 0);
            this.txtPointX.Name = "txtPointX";
            this.txtPointX.Size = new System.Drawing.Size(100, 20);
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
            this.txtVectorG.Size = new System.Drawing.Size(100, 20);
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
            this.coordinateSystem1.DoNotRefresh = false;
            this.coordinateSystem1.Location = new System.Drawing.Point(0, 0);
            this.coordinateSystem1.Name = "coordinateSystem1";
            this.coordinateSystem1.Size = new System.Drawing.Size(150, 150);
            this.coordinateSystem1.TabIndex = 0;
            // 
            // coordinateSystem2
            // 
            this.coordinateSystem2.DoNotRefresh = false;
            this.coordinateSystem2.Location = new System.Drawing.Point(0, 0);
            this.coordinateSystem2.Name = "coordinateSystem2";
            this.coordinateSystem2.Size = new System.Drawing.Size(150, 150);
            this.coordinateSystem2.TabIndex = 0;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(501, 656);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 60;
            this.lblNotes.Text = "Notizen:";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(446, 7);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(457, 25);
            this.lblHeader.TabIndex = 61;
            this.lblHeader.Text = "Thema: Spiegelung lineare Abbildung am Ursprung";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(197, 63);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.Size = new System.Drawing.Size(131, 20);
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
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(9, 117);
            this.cosInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(413, 344);
            this.cosInput.TabIndex = 62;
            // 
            // cosOutput
            // 
            this.cosOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(976, 117);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(382, 344);
            this.cosOutput.TabIndex = 63;
            // 
            // butFx
            // 
            this.butFx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butFx.AutoSize = true;
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(651, 514);
            this.butFx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(116, 27);
            this.butFx.TabIndex = 5;
            this.butFx.Text = "&Berechne f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            this.butFx.Click += new System.EventHandler(this.butFx_Click);
            // 
            // ctlMathEqua
            // 
            this.ctlMathEqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEqua.Equation = "";
            this.ctlMathEqua.Filename = "expr.gif";
            this.ctlMathEqua.Filepath = "";
            this.ctlMathEqua.FontSize = 8;
            this.ctlMathEqua.Location = new System.Drawing.Point(529, 281);
            this.ctlMathEqua.Name = "ctlMathEqua";
            this.ctlMathEqua.Size = new System.Drawing.Size(235, 92);
            this.ctlMathEqua.TabIndex = 69;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(485, 193);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(562, 330);
            this.picBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxArrow.TabIndex = 71;
            this.picBoxArrow.TabStop = false;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rtxtNotes.Location = new System.Drawing.Point(504, 675);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(344, 140);
            this.rtxtNotes.TabIndex = 72;
            this.rtxtNotes.Text = "";
            // 
            // ftxtAngle
            // 
            this.ftxtAngle.BackColor = System.Drawing.Color.Red;
            this.ftxtAngle.Location = new System.Drawing.Point(53, 123);
            this.ftxtAngle.MaxLength = 5;
            this.ftxtAngle.Name = "ftxtAngle";
            this.ftxtAngle.Size = new System.Drawing.Size(46, 20);
            this.ftxtAngle.TabIndex = 15;
            // 
            // FrmSpiegLinAbbUrsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 840);
            this.Controls.Add(this.ctlMathEqua);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.grpDataInput);
            this.Controls.Add(this.picBoxArrow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSpiegLinAbbUrsp";
            this.Text = "Spiegelung lineare Abbildung am Ursprung";
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFunctionTransfX;
        private System.Windows.Forms.Button butFunctionTransfX;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.Label lblAngle;
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
        private UserControls.CtlVectorInput ctlVectorInputX;
        private UserControls.CoordinateSystem cosInput;
        private UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Button butFx;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
        private System.Windows.Forms.PictureBox picBoxArrow;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private UserControls.FloatInput ftxtAngle;
    }
}