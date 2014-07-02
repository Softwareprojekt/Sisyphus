namespace SoftwareProjekt.Forms
{
    partial class FrmZuordvorLinAbb
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
            SoftwareProjekt.Classes.Math.Vector vector4 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector5 = new SoftwareProjekt.Classes.Math.Vector();
            this.lblInputCos = new System.Windows.Forms.Label();
            this.lblOutputCos = new System.Windows.Forms.Label();
            this.grpDataInputRight = new System.Windows.Forms.GroupBox();
            this.lblPointM2 = new System.Windows.Forms.Label();
            this.lblPointM1 = new System.Windows.Forms.Label();
            this.ctlVectorInputM2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputM1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVectorX = new System.Windows.Forms.Label();
            this.txVectorX = new System.Windows.Forms.TextBox();
            this.grpDataInputLeft = new System.Windows.Forms.GroupBox();
            this.ctlVectorInputEV2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVectorInputEV1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPointX = new System.Windows.Forms.Label();
            this.ctlVectorInputX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.butFunctionX = new System.Windows.Forms.Button();
            this.ctlMathEqua = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.grpDataInputRight.SuspendLayout();
            this.grpDataInputLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInputCos
            // 
            this.lblInputCos.AutoSize = true;
            this.lblInputCos.Location = new System.Drawing.Point(199, 430);
            this.lblInputCos.Name = "lblInputCos";
            this.lblInputCos.Size = new System.Drawing.Size(183, 17);
            this.lblInputCos.TabIndex = 22;
            this.lblInputCos.Text = "Eingabekoordinatensystem:";
            // 
            // lblOutputCos
            // 
            this.lblOutputCos.AutoSize = true;
            this.lblOutputCos.Location = new System.Drawing.Point(1301, 430);
            this.lblOutputCos.Name = "lblOutputCos";
            this.lblOutputCos.Size = new System.Drawing.Size(187, 17);
            this.lblOutputCos.TabIndex = 24;
            this.lblOutputCos.Text = "Ausgabekoordinatensystem:";
            // 
            // grpDataInputRight
            // 
            this.grpDataInputRight.Controls.Add(this.lblPointM2);
            this.grpDataInputRight.Controls.Add(this.lblPointM1);
            this.grpDataInputRight.Controls.Add(this.ctlVectorInputM2);
            this.grpDataInputRight.Controls.Add(this.ctlVectorInputM1);
            this.grpDataInputRight.Controls.Add(this.textBox2);
            this.grpDataInputRight.Controls.Add(this.label1);
            this.grpDataInputRight.Controls.Add(this.textBox1);
            this.grpDataInputRight.Controls.Add(this.label2);
            this.grpDataInputRight.Location = new System.Drawing.Point(850, 137);
            this.grpDataInputRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInputRight.Name = "grpDataInputRight";
            this.grpDataInputRight.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInputRight.Size = new System.Drawing.Size(341, 239);
            this.grpDataInputRight.TabIndex = 25;
            this.grpDataInputRight.TabStop = false;
            this.grpDataInputRight.Text = "Dateneingabe";
            // 
            // lblPointM2
            // 
            this.lblPointM2.AutoSize = true;
            this.lblPointM2.Location = new System.Drawing.Point(211, 32);
            this.lblPointM2.Name = "lblPointM2";
            this.lblPointM2.Size = new System.Drawing.Size(67, 17);
            this.lblPointM2.TabIndex = 33;
            this.lblPointM2.Text = "Punkt m2";
            // 
            // lblPointM1
            // 
            this.lblPointM1.AutoSize = true;
            this.lblPointM1.Location = new System.Drawing.Point(42, 32);
            this.lblPointM1.Name = "lblPointM1";
            this.lblPointM1.Size = new System.Drawing.Size(67, 17);
            this.lblPointM1.TabIndex = 32;
            this.lblPointM1.Text = "Punkt m1";
            // 
            // ctlVectorInputM2
            // 
            this.ctlVectorInputM2.Location = new System.Drawing.Point(170, 54);
            this.ctlVectorInputM2.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorInputM2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputM2.Name = "ctlVectorInputM2";
            this.ctlVectorInputM2.Size = new System.Drawing.Size(161, 102);
            this.ctlVectorInputM2.TabIndex = 6;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVectorInputM2.Vector = vector1;
            // 
            // ctlVectorInputM1
            // 
            this.ctlVectorInputM1.Location = new System.Drawing.Point(9, 54);
            this.ctlVectorInputM1.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorInputM1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputM1.Name = "ctlVectorInputM1";
            this.ctlVectorInputM1.Size = new System.Drawing.Size(161, 102);
            this.ctlVectorInputM1.TabIndex = 5;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVectorInputM1.Vector = vector2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 204);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "f(x1->):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 178);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "f(x1):";
            // 
            // lblVectorX
            // 
            this.lblVectorX.AutoSize = true;
            this.lblVectorX.Location = new System.Drawing.Point(8, 173);
            this.lblVectorX.Name = "lblVectorX";
            this.lblVectorX.Size = new System.Drawing.Size(53, 17);
            this.lblVectorX.TabIndex = 12;
            this.lblVectorX.Text = "f(x1->):";
            // 
            // txVectorX
            // 
            this.txVectorX.Location = new System.Drawing.Point(116, 169);
            this.txVectorX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txVectorX.Name = "txVectorX";
            this.txVectorX.Size = new System.Drawing.Size(84, 22);
            this.txVectorX.TabIndex = 2;
            // 
            // grpDataInputLeft
            // 
            this.grpDataInputLeft.Controls.Add(this.ctlVectorInputEV2);
            this.grpDataInputLeft.Controls.Add(this.ctlVectorInputEV1);
            this.grpDataInputLeft.Controls.Add(this.label3);
            this.grpDataInputLeft.Controls.Add(this.label4);
            this.grpDataInputLeft.Controls.Add(this.lblPointX);
            this.grpDataInputLeft.Controls.Add(this.ctlVectorInputX);
            this.grpDataInputLeft.Controls.Add(this.txVectorX);
            this.grpDataInputLeft.Controls.Add(this.lblVectorX);
            this.grpDataInputLeft.Location = new System.Drawing.Point(251, 137);
            this.grpDataInputLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInputLeft.Name = "grpDataInputLeft";
            this.grpDataInputLeft.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInputLeft.Size = new System.Drawing.Size(511, 210);
            this.grpDataInputLeft.TabIndex = 16;
            this.grpDataInputLeft.TabStop = false;
            this.grpDataInputLeft.Text = "Dateneingabe";
            // 
            // ctlVectorInputEV2
            // 
            this.ctlVectorInputEV2.Location = new System.Drawing.Point(346, 54);
            this.ctlVectorInputEV2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInputEV2.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputEV2.Name = "ctlVectorInputEV2";
            this.ctlVectorInputEV2.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputEV2.TabIndex = 33;
            vector3.X1 = float.NaN;
            vector3.X2 = float.NaN;
            this.ctlVectorInputEV2.Vector = vector3;
            // 
            // ctlVectorInputEV1
            // 
            this.ctlVectorInputEV1.Location = new System.Drawing.Point(181, 54);
            this.ctlVectorInputEV1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVectorInputEV1.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputEV1.Name = "ctlVectorInputEV1";
            this.ctlVectorInputEV1.Size = new System.Drawing.Size(157, 105);
            this.ctlVectorInputEV1.TabIndex = 32;
            vector4.X1 = float.NaN;
            vector4.X2 = float.NaN;
            this.ctlVectorInputEV1.Vector = vector4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "EV2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "EV1:";
            // 
            // lblPointX
            // 
            this.lblPointX.AutoSize = true;
            this.lblPointX.Location = new System.Drawing.Point(55, 33);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(54, 17);
            this.lblPointX.TabIndex = 31;
            this.lblPointX.Text = "Punkt x";
            // 
            // ctlVectorInputX
            // 
            this.ctlVectorInputX.Location = new System.Drawing.Point(11, 54);
            this.ctlVectorInputX.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVectorInputX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVectorInputX.Name = "ctlVectorInputX";
            this.ctlVectorInputX.Size = new System.Drawing.Size(161, 102);
            this.ctlVectorInputX.TabIndex = 1;
            vector5.X1 = float.NaN;
            vector5.X2 = float.NaN;
            this.ctlVectorInputX.Vector = vector5;
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(16, 449);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(571, 420);
            this.cosInput.TabIndex = 26;
            // 
            // cosOutput
            // 
            this.cosOutput.Location = new System.Drawing.Point(1122, 451);
            this.cosOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cosOutput.Name = "cosOutput";
            this.cosOutput.Size = new System.Drawing.Size(571, 420);
            this.cosOutput.TabIndex = 27;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(508, 898);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 29;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(507, 919);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 136);
            this.rtxtNotes.TabIndex = 10;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(531, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(692, 29);
            this.lblHeader.TabIndex = 30;
            this.lblHeader.Text = "Thema: Zuordnugsvorschrift einer linearen Abbildung verstehen";
            // 
            // butFunctionX
            // 
            this.butFunctionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionX.Location = new System.Drawing.Point(741, 449);
            this.butFunctionX.Name = "butFunctionX";
            this.butFunctionX.Size = new System.Drawing.Size(105, 66);
            this.butFunctionX.TabIndex = 9;
            this.butFunctionX.Text = "&Berechne f(x)";
            this.butFunctionX.UseVisualStyleBackColor = true;
            this.butFunctionX.Click += new System.EventHandler(this.butFunctionX_Click);
            // 
            // ctlMathEqua
            // 
            this.ctlMathEqua.Arrowdirection = SoftwareProjekt.Enums.EArrowDirection.up;
            this.ctlMathEqua.Equation = "";
            this.ctlMathEqua.Filename = "hqztxpdc.cg1.tiff";
            this.ctlMathEqua.Filepath = "C:\\Users\\Markus\\AppData\\Local\\Temp\\";
            this.ctlMathEqua.FontSize = 8;
            this.ctlMathEqua.Location = new System.Drawing.Point(623, 590);
            this.ctlMathEqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlMathEqua.Name = "ctlMathEqua";
            this.ctlMathEqua.Size = new System.Drawing.Size(439, 113);
            this.ctlMathEqua.TabIndex = 32;
            // 
            // FrmZuordvorLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 1041);
            this.Controls.Add(this.ctlMathEqua);
            this.Controls.Add(this.butFunctionX);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosOutput);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.grpDataInputRight);
            this.Controls.Add(this.lblOutputCos);
            this.Controls.Add(this.lblInputCos);
            this.Controls.Add(this.grpDataInputLeft);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmZuordvorLinAbb";
            this.Text = "Zuordnungsvorschrift Lineare Abbildung";
            this.grpDataInputRight.ResumeLayout(false);
            this.grpDataInputRight.PerformLayout();
            this.grpDataInputLeft.ResumeLayout(false);
            this.grpDataInputLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputCos;
        private System.Windows.Forms.Label lblOutputCos;
        private System.Windows.Forms.GroupBox grpDataInputRight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVectorX;
        private System.Windows.Forms.TextBox txVectorX;
        private System.Windows.Forms.GroupBox grpDataInputLeft;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblHeader;
        private UserControls.CtlVectorInput ctlVectorInputM2;
        private UserControls.CtlVectorInput ctlVectorInputM1;
        private UserControls.CtlVectorInput ctlVectorInputX;
        private System.Windows.Forms.Label lblPointM2;
        private System.Windows.Forms.Label lblPointM1;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.Button butFunctionX;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlMathEqua;
        private UserControls.CtlVectorInput ctlVectorInputEV2;
        private UserControls.CtlVectorInput ctlVectorInputEV1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}