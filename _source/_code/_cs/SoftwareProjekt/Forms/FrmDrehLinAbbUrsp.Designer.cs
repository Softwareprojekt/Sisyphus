using System.Drawing;
using System.Windows.Forms;

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
            SoftwareProjekt.Classes.Math.Vector vector7 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector8 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector9 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector10 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector11 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector12 = new SoftwareProjekt.Classes.Math.Vector();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this._ctlAngle = new SoftwareProjekt.UserControls.FloatInput();
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
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblDet = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.picBoxArrow = new System.Windows.Forms.PictureBox();
            this._rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInput.SuspendLayout();
            this.grpDataOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(746, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ausgabekoordinatensystem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this._ctlAngle);
            this.grpDataInput.Controls.Add(this.ctlVectorEV2);
            this.grpDataInput.Controls.Add(this.ctlVectorEV1);
            this.grpDataInput.Controls.Add(this.ctlVectorInputX);
            this.grpDataInput.Controls.Add(this.lblAngle);
            this.grpDataInput.Location = new System.Drawing.Point(12, 63);
            this.grpDataInput.Margin = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Padding = new System.Windows.Forms.Padding(2);
            this.grpDataInput.Size = new System.Drawing.Size(434, 177);
            this.grpDataInput.TabIndex = 26;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Eingabe";
            // 
            // _ctlAngle
            // 
            this._ctlAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._ctlAngle.BackColor = System.Drawing.Color.White;
            this._ctlAngle.Location = new System.Drawing.Point(86, 150);
            this._ctlAngle.Margin = new System.Windows.Forms.Padding(2);
            this._ctlAngle.Name = "_ctlAngle";
            this._ctlAngle.Size = new System.Drawing.Size(42, 20);
            this._ctlAngle.TabIndex = 15;
            this._ctlAngle.Text = "NaN";
            // 
            // ctlVectorEV2
            // 
            this.ctlVectorEV2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctlVectorEV2.Location = new System.Drawing.Point(292, 27);
            this.ctlVectorEV2.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorEV2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorEV2.Name = "ctlVectorEV2";
            this.ctlVectorEV2.Size = new System.Drawing.Size(136, 94);
            this.ctlVectorEV2.TabIndex = 4;
            vector7.X1 = float.NaN;
            vector7.X2 = float.NaN;
            this.ctlVectorEV2.Vector = vector7;
            // 
            // ctlVectorEV1
            // 
            this.ctlVectorEV1.Location = new System.Drawing.Point(149, 27);
            this.ctlVectorEV1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorEV1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorEV1.Name = "ctlVectorEV1";
            this.ctlVectorEV1.Size = new System.Drawing.Size(136, 94);
            this.ctlVectorEV1.TabIndex = 3;
            vector8.X1 = float.NaN;
            vector8.X2 = float.NaN;
            this.ctlVectorEV1.Vector = vector8;
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(6, 27);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.TabIndex = 1;
            vector9.X1 = float.NaN;
            vector9.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector9;
            // 
            // lblAngle
            // 
            this.lblAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(4, 153);
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
            this.butFunctionTransfX.Location = new System.Drawing.Point(496, 131);
            this.butFunctionTransfX.Margin = new System.Windows.Forms.Padding(2);
            this.butFunctionTransfX.Name = "butFunctionTransfX";
            this.butFunctionTransfX.Size = new System.Drawing.Size(78, 33);
            this.butFunctionTransfX.TabIndex = 5;
            this.butFunctionTransfX.Text = "&Berechne";
            this.butFunctionTransfX.UseVisualStyleBackColor = true;
            this.butFunctionTransfX.Click += new System.EventHandler(this.butFunctionTransfX_Click);
            // 
            // grpDataOutput
            // 
            this.grpDataOutput.Controls.Add(this.lblDet);
            this.grpDataOutput.Controls.Add(this.ctlVectorOutputEV2);
            this.grpDataOutput.Controls.Add(this.ctlVectorOutputEV1);
            this.grpDataOutput.Controls.Add(this.ctlVectorOutputX);
            this.grpDataOutput.Controls.Add(this.txtDeterminante);
            this.grpDataOutput.Location = new System.Drawing.Point(635, 63);
            this.grpDataOutput.Name = "grpDataOutput";
            this.grpDataOutput.Size = new System.Drawing.Size(434, 177);
            this.grpDataOutput.TabIndex = 41;
            this.grpDataOutput.TabStop = false;
            this.grpDataOutput.Text = "Ausgabe";
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.Location = new System.Drawing.Point(6, 153);
            this.lblDet.Name = "lblDet";
            this.lblDet.Size = new System.Drawing.Size(73, 13);
            this.lblDet.TabIndex = 50;
            this.lblDet.Text = "Determinante:";
            // 
            // ctlVectorOutputEV2
            // 
            this.ctlVectorOutputEV2.Location = new System.Drawing.Point(293, 20);
            this.ctlVectorOutputEV2.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorOutputEV2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputEV2.Name = "ctlVectorOutputEV2";
            this.ctlVectorOutputEV2.Size = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputEV2.TabIndex = 49;
            vector10.X1 = float.NaN;
            vector10.X2 = float.NaN;
            this.ctlVectorOutputEV2.Vector = vector10;
            // 
            // ctlVectorOutputEV1
            // 
            this.ctlVectorOutputEV1.Location = new System.Drawing.Point(150, 20);
            this.ctlVectorOutputEV1.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorOutputEV1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputEV1.Name = "ctlVectorOutputEV1";
            this.ctlVectorOutputEV1.Size = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputEV1.TabIndex = 48;
            vector11.X1 = float.NaN;
            vector11.X2 = float.NaN;
            this.ctlVectorOutputEV1.Vector = vector11;
            // 
            // ctlVectorOutputX
            // 
            this.ctlVectorOutputX.Location = new System.Drawing.Point(7, 20);
            this.ctlVectorOutputX.Margin = new System.Windows.Forms.Padding(4);
            this.ctlVectorOutputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputX.Name = "ctlVectorOutputX";
            this.ctlVectorOutputX.Size = new System.Drawing.Size(136, 94);
            this.ctlVectorOutputX.TabIndex = 47;
            vector12.X1 = float.NaN;
            vector12.X2 = float.NaN;
            this.ctlVectorOutputX.Vector = vector12;
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDeterminante.Location = new System.Drawing.Point(84, 150);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeterminante.MaxLength = 5;
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.ReadOnly = true;
            this.txtDeterminante.Size = new System.Drawing.Size(96, 20);
            this.txtDeterminante.TabIndex = 41;
            this.txtDeterminante.UseSystemPasswordChar = true;
            this.txtDeterminante.MouseEnter += new System.EventHandler(this.txtDeterminante_MouseEnter);
            this.txtDeterminante.MouseLeave += new System.EventHandler(this.txtDeterminante_MouseLeave);
            // 
            // cosInput
            // 
            this.cosInput.DoNotRefresh = false;
            this.cosInput.Location = new System.Drawing.Point(12, 288);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(320, 274);
            this.cosInput.TabIndex = 42;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(348, 585);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 44;
            this.lblNotes.Text = "Notizen:";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(328, 7);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(430, 25);
            this.lblHeader.TabIndex = 47;
            this.lblHeader.Text = "Thema: Drehungen um den Ursprung sind linear";
            // 
            // cosOutput
            // 
            this.cosOutput.DoNotRefresh = false;
            this.cosOutput.Location = new System.Drawing.Point(749, 288);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(320, 274);
            this.cosOutput.TabIndex = 50;
            // 
            // picBoxArrow
            // 
            this.picBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.picBoxArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picBoxArrow.Location = new System.Drawing.Point(351, 285);
            this.picBoxArrow.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxArrow.Name = "picBoxArrow";
            this.picBoxArrow.Size = new System.Drawing.Size(370, 252);
            this.picBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxArrow.TabIndex = 49;
            this.picBoxArrow.TabStop = false;
            // 
            // _rtxtNotes
            // 
            this._rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._rtxtNotes.Location = new System.Drawing.Point(351, 610);
            this._rtxtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._rtxtNotes.Name = "_rtxtNotes";
            this._rtxtNotes.Size = new System.Drawing.Size(370, 131);
            this._rtxtNotes.TabIndex = 51;
            this._rtxtNotes.Text = "";
            // 
            // ctlMathEqua
            // 
            this.ctlMathEqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctlMathEqua.BackColor = System.Drawing.Color.Transparent;
            this.ctlMathEqua.Equation = "";
            this.ctlMathEqua.Filename = "y4phqryw.pfy.tiff";
            this.ctlMathEqua.Filepath = "";
            this.ctlMathEqua.FontSize = 12;
            this.ctlMathEqua.Location = new System.Drawing.Point(369, 365);
            this.ctlMathEqua.Name = "ctlMathEqua";
            this.ctlMathEqua.Size = new System.Drawing.Size(281, 89);
            this.ctlMathEqua.TabIndex = 52;
            // 
            // FrmDrehLinAbbUrsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 784);
            this.Controls.Add(this.ctlMathEqua);
            this.Controls.Add(this._rtxtNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.butFunctionTransfX);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.grpDataOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpDataInput);
            this.Controls.Add(this.picBoxArrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "FrmDrehLinAbbUrsp";
            this.Text = "Drehung linearer Abbildungen am Ursprung";
            this.Shown += new System.EventHandler(this.FrmDrehLinAbbUrsp_Shown);
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.grpDataOutput.ResumeLayout(false);
            this.grpDataOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Button butFunctionTransfX;
        private System.Windows.Forms.GroupBox grpDataOutput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Label lblHeader;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private UserControls.CtlVectorInput ctlVectorEV2;
        private UserControls.CtlVectorInput ctlVectorEV1;
        private UserControls.CtlVectorInput ctlVectorOutputEV2;
        private UserControls.CtlVectorInput ctlVectorOutputEV1;
        private UserControls.CtlVectorInput ctlVectorOutputX;
        private UserControls.CoordinateSystem cosOutput;
        private UserControls.FloatInput _ctlAngle;
        private PictureBox picBoxArrow;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
        private Label lblDet;
#if DEBUG
        private System.Windows.Forms.RichTextBox _rtxtNotes;
#endif
    }
}