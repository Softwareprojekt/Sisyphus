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
<<<<<<< HEAD
            this.txtDeterminante2 = new System.Windows.Forms.TextBox();
            this.butDeterminante2 = new System.Windows.Forms.Button();
            this.grpDataInput2 = new System.Windows.Forms.GroupBox();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.grpDataOutput2 = new System.Windows.Forms.GroupBox();
            this.txtFunctionGfx = new System.Windows.Forms.TextBox();
            this.lblFunctionGfx = new System.Windows.Forms.Label();
            this.txtVectorGx = new System.Windows.Forms.TextBox();
            this.lblVectorGx = new System.Windows.Forms.Label();
            this.butGfx = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.CoordinateSystem();
            this.cosOutput1 = new SoftwareProjekt.CoordinateSystem();
            this.cosOutput2 = new SoftwareProjekt.CoordinateSystem();
=======
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVectorGFx = new System.Windows.Forms.TextBox();
            this.lblVectorGFx = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cosInput = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.cosOutput2 = new SoftwareProjekt.UserControls.CoordinateSystem();
>>>>>>> 846a6a4aeea1b30f10d7f3efe8220e9a59087f38
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.ctlMatrixInput1 = new SoftwareProjekt.CtlMatrixInput();
            this.ctlMatrixInput2 = new SoftwareProjekt.CtlMatrixInput();
            this.ctlVektorInput1 = new SoftwareProjekt.CtlVektorInput();
            this.ctlVektorInput2 = new SoftwareProjekt.CtlVektorInput();
            this.ctlMatrixInput3 = new SoftwareProjekt.CtlMatrixInput();
            this.txtVectorGx2 = new System.Windows.Forms.TextBox();
            this.grpDataOutput1.SuspendLayout();
            this.grpDataInput1.SuspendLayout();
            this.grpDataInput2.SuspendLayout();
            this.grpDataOutput2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDataOutput1
            // 
            this.grpDataOutput1.Controls.Add(this.ctlMatrixInput3);
            this.grpDataOutput1.Controls.Add(this.ctlVektorInput2);
            this.grpDataOutput1.Location = new System.Drawing.Point(489, 85);
            this.grpDataOutput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataOutput1.Name = "grpDataOutput1";
            this.grpDataOutput1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataOutput1.Size = new System.Drawing.Size(183, 221);
            this.grpDataOutput1.TabIndex = 41;
            this.grpDataOutput1.TabStop = false;
            this.grpDataOutput1.Text = "Datenausgabe1";
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(415, 111);
            this.butFx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(55, 37);
            this.butFx.TabIndex = 38;
            this.butFx.Text = "f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Location = new System.Drawing.Point(678, 289);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(195, 17);
            this.lblOutput1.TabIndex = 40;
            this.lblOutput1.Text = "Ausgabekoordinatensystem1:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(156, 289);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(183, 17);
            this.lblInput.TabIndex = 37;
            this.lblInput.Text = "Eingabekoordinatensystem:";
            // 
            // grpDataInput1
            // 
            this.grpDataInput1.Controls.Add(this.ctlVektorInput1);
            this.grpDataInput1.Controls.Add(this.ctlMatrixInput1);
            this.grpDataInput1.Controls.Add(this.txtDeterminante1);
            this.grpDataInput1.Controls.Add(this.butDeterminante1);
            this.grpDataInput1.Location = new System.Drawing.Point(13, 40);
            this.grpDataInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Name = "grpDataInput1";
            this.grpDataInput1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput1.Size = new System.Drawing.Size(396, 232);
            this.grpDataInput1.TabIndex = 35;
            this.grpDataInput1.TabStop = false;
            this.grpDataInput1.Text = "Dateneingabe1";
            // 
            // txtDeterminante1
            // 
            this.txtDeterminante1.Location = new System.Drawing.Point(205, 120);
            this.txtDeterminante1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante1.Name = "txtDeterminante1";
            this.txtDeterminante1.Size = new System.Drawing.Size(131, 22);
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
            this.butGx.Location = new System.Drawing.Point(1045, 73);
            this.butGx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGx.Name = "butGx";
            this.butGx.Size = new System.Drawing.Size(108, 47);
            this.butGx.TabIndex = 42;
            this.butGx.Text = "g(x)";
            this.butGx.UseVisualStyleBackColor = true;
            // 
            // txtDeterminante2
            // 
            this.txtDeterminante2.Location = new System.Drawing.Point(213, 79);
            this.txtDeterminante2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante2.Name = "txtDeterminante2";
            this.txtDeterminante2.Size = new System.Drawing.Size(131, 22);
            this.txtDeterminante2.TabIndex = 38;
            // 
            // butDeterminante2
            // 
            this.butDeterminante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante2.Location = new System.Drawing.Point(213, 41);
            this.butDeterminante2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeterminante2.Name = "butDeterminante2";
            this.butDeterminante2.Size = new System.Drawing.Size(131, 34);
            this.butDeterminante2.TabIndex = 37;
            this.butDeterminante2.Text = "Determinante";
            this.butDeterminante2.UseVisualStyleBackColor = true;
            // 
            // grpDataInput2
            // 
            this.grpDataInput2.Controls.Add(this.ctlMatrixInput2);
            this.grpDataInput2.Controls.Add(this.txtDeterminante2);
            this.grpDataInput2.Controls.Add(this.butDeterminante2);
            this.grpDataInput2.Location = new System.Drawing.Point(678, 55);
            this.grpDataInput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Name = "grpDataInput2";
            this.grpDataInput2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataInput2.Size = new System.Drawing.Size(362, 139);
            this.grpDataInput2.TabIndex = 43;
            this.grpDataInput2.TabStop = false;
            this.grpDataInput2.Text = "Dateneingabe2";
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(1106, 289);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(195, 17);
            this.lblOutput2.TabIndex = 45;
            this.lblOutput2.Text = "Ausgabekoordinatensystem2:";
            // 
            // grpDataOutput2
            // 
            this.grpDataOutput2.Controls.Add(this.txtVectorGx2);
            this.grpDataOutput2.Controls.Add(this.txtFunctionGfx);
            this.grpDataOutput2.Controls.Add(this.lblFunctionGfx);
            this.grpDataOutput2.Controls.Add(this.txtVectorGx);
            this.grpDataOutput2.Controls.Add(this.lblVectorGx);
            this.grpDataOutput2.Location = new System.Drawing.Point(1160, 73);
            this.grpDataOutput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataOutput2.Name = "grpDataOutput2";
            this.grpDataOutput2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDataOutput2.Size = new System.Drawing.Size(227, 142);
            this.grpDataOutput2.TabIndex = 42;
            this.grpDataOutput2.TabStop = false;
            this.grpDataOutput2.Text = "Datenausgabe2";
            // 
            // txtFunctionGfx
            // 
            this.txtFunctionGfx.Location = new System.Drawing.Point(75, 99);
            this.txtFunctionGfx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFunctionGfx.Name = "txtFunctionGfx";
            this.txtFunctionGfx.Size = new System.Drawing.Size(136, 22);
            this.txtFunctionGfx.TabIndex = 4;
            // 
            // lblFunctionGfx
            // 
            this.lblFunctionGfx.AutoSize = true;
            this.lblFunctionGfx.Location = new System.Drawing.Point(5, 102);
            this.lblFunctionGfx.Name = "lblFunctionGfx";
            this.lblFunctionGfx.Size = new System.Drawing.Size(50, 17);
            this.lblFunctionGfx.TabIndex = 3;
            this.lblFunctionGfx.Text = "g(f(x)):";
            // 
            // txtVectorGx
            // 
            this.txtVectorGx.Location = new System.Drawing.Point(75, 27);
            this.txtVectorGx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVectorGx.Name = "txtVectorGx";
            this.txtVectorGx.Size = new System.Drawing.Size(52, 22);
            this.txtVectorGx.TabIndex = 2;
            // 
            // lblVectorGx
            // 
            this.lblVectorGx.AutoSize = true;
            this.lblVectorGx.Location = new System.Drawing.Point(5, 30);
            this.lblVectorGx.Name = "lblVectorGx";
            this.lblVectorGx.Size = new System.Drawing.Size(36, 17);
            this.lblVectorGx.TabIndex = 0;
            this.lblVectorGx.Text = "g(x):";
            // 
            // butGfx
            // 
            this.butGfx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGfx.Location = new System.Drawing.Point(1045, 128);
            this.butGfx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGfx.Name = "butGfx";
            this.butGfx.Size = new System.Drawing.Size(108, 47);
            this.butGfx.TabIndex = 46;
            this.butGfx.Text = "g(f(x))";
            this.butGfx.UseVisualStyleBackColor = true;
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(20, 310);
            this.cosInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(436, 373);
            this.cosInput.TabIndex = 47;
            // 
            // cosOutput1
            // 
            this.cosOutput1.Location = new System.Drawing.Point(489, 310);
            this.cosOutput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosOutput1.Name = "cosOutput1";
            this.cosOutput1.Size = new System.Drawing.Size(436, 373);
            this.cosOutput1.TabIndex = 48;
            // 
            // cosOutput2
            // 
            this.cosOutput2.Location = new System.Drawing.Point(951, 310);
            this.cosOutput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cosOutput2.Name = "cosOutput2";
            this.cosOutput2.Size = new System.Drawing.Size(436, 373);
            this.cosOutput2.TabIndex = 49;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(365, 701);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 51;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(367, 722);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 50;
            this.rtxtNotes.Text = "";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(346, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(636, 29);
            this.lblHeader.TabIndex = 52;
            this.lblHeader.Text = "Thema: Hintereinanderausführung linearer Abbildungen";
            // 
            // ctlMatrixInput1
            // 
            this.ctlMatrixInput1.Location = new System.Drawing.Point(7, 117);
            this.ctlMatrixInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlMatrixInput1.Matrix = null;
            this.ctlMatrixInput1.Name = "ctlMatrixInput1";
            this.ctlMatrixInput1.Size = new System.Drawing.Size(167, 104);
            this.ctlMatrixInput1.TabIndex = 37;
            // 
            // ctlMatrixInput2
            // 
            this.ctlMatrixInput2.Location = new System.Drawing.Point(7, 21);
            this.ctlMatrixInput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlMatrixInput2.Matrix = null;
            this.ctlMatrixInput2.Name = "ctlMatrixInput2";
            this.ctlMatrixInput2.Size = new System.Drawing.Size(167, 110);
            this.ctlMatrixInput2.TabIndex = 38;
            // 
            // ctlVektorInput1
            // 
            this.ctlVektorInput1.Location = new System.Drawing.Point(7, 15);
            this.ctlVektorInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVektorInput1.Name = "ctlVektorInput1";
            this.ctlVektorInput1.Size = new System.Drawing.Size(150, 101);
            this.ctlVektorInput1.TabIndex = 53;
            this.ctlVektorInput1.Vector = null;
            // 
            // ctlVektorInput2
            // 
            this.ctlVektorInput2.Location = new System.Drawing.Point(7, 18);
            this.ctlVektorInput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlVektorInput2.Name = "ctlVektorInput2";
            this.ctlVektorInput2.Size = new System.Drawing.Size(160, 101);
            this.ctlVektorInput2.TabIndex = 53;
            this.ctlVektorInput2.Vector = null;
            // 
            // ctlMatrixInput3
            // 
            this.ctlMatrixInput3.Location = new System.Drawing.Point(8, 112);
            this.ctlMatrixInput3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctlMatrixInput3.Matrix = null;
            this.ctlMatrixInput3.Name = "ctlMatrixInput3";
            this.ctlMatrixInput3.Size = new System.Drawing.Size(159, 105);
            this.ctlMatrixInput3.TabIndex = 54;
            // 
            // txtVectorGx2
            // 
            this.txtVectorGx2.Location = new System.Drawing.Point(75, 53);
            this.txtVectorGx2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVectorGx2.Name = "txtVectorGx2";
            this.txtVectorGx2.Size = new System.Drawing.Size(52, 22);
            this.txtVectorGx2.TabIndex = 5;
            // 
            // FrmHinterLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 901);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.cosOutput2);
            this.Controls.Add(this.cosOutput1);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.butGfx);
            this.Controls.Add(this.grpDataOutput2);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.grpDataInput2);
            this.Controls.Add(this.butGx);
            this.Controls.Add(this.grpDataOutput1);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.lblOutput1);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.grpDataInput1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHinterLinAbb";
            this.Text = "Hintereinanderausführung linearer Abbildungen";
            this.grpDataOutput1.ResumeLayout(false);
            this.grpDataInput1.ResumeLayout(false);
            this.grpDataInput1.PerformLayout();
            this.grpDataInput2.ResumeLayout(false);
            this.grpDataInput2.PerformLayout();
            this.grpDataOutput2.ResumeLayout(false);
            this.grpDataOutput2.PerformLayout();
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
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtDeterminante2;
        private System.Windows.Forms.Button butDeterminante2;
        private System.Windows.Forms.GroupBox grpDataInput2;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.GroupBox grpDataOutput2;
        private System.Windows.Forms.TextBox txtFunctionGfx;
        private System.Windows.Forms.Label lblFunctionGfx;
        private System.Windows.Forms.TextBox txtVectorGx;
        private System.Windows.Forms.Label lblVectorGx;
        private System.Windows.Forms.Button butGfx;
        private CoordinateSystem cosInput;
        private CoordinateSystem cosOutput1;
        private CoordinateSystem cosOutput2;
=======
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVectorGFx;
        private System.Windows.Forms.Label lblVectorGFx;
        private System.Windows.Forms.Button button2;
        private SoftwareProjekt.UserControls.CoordinateSystem cosInput;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput1;
        private SoftwareProjekt.UserControls.CoordinateSystem cosOutput2;
>>>>>>> 846a6a4aeea1b30f10d7f3efe8220e9a59087f38
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private CtlMatrixInput ctlMatrixInput3;
        private CtlVektorInput ctlVektorInput2;
        private CtlVektorInput ctlVektorInput1;
        private CtlMatrixInput ctlMatrixInput1;
        private CtlMatrixInput ctlMatrixInput2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtVectorGx2;
    }
}