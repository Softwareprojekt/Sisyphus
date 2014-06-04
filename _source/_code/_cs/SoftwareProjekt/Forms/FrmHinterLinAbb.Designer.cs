namespace SoftwareProjekt
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
            this.grpAusgabe = new System.Windows.Forms.GroupBox();
            this.txtVectorFX = new System.Windows.Forms.TextBox();
            this.lblVectorFX = new System.Windows.Forms.Label();
            this.butFx = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.lblPointX = new System.Windows.Forms.Label();
            this.butGx = new System.Windows.Forms.Button();
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
            this.cosInput = new SoftwareProjekt.CoordinateSystem();
            this.cosOutput1 = new SoftwareProjekt.CoordinateSystem();
            this.cosOutput2 = new SoftwareProjekt.CoordinateSystem();
            this.grpAusgabe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAusgabe
            // 
            this.grpAusgabe.Controls.Add(this.txtVectorFX);
            this.grpAusgabe.Controls.Add(this.lblVectorFX);
            this.grpAusgabe.Location = new System.Drawing.Point(367, 69);
            this.grpAusgabe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAusgabe.Name = "grpAusgabe";
            this.grpAusgabe.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAusgabe.Size = new System.Drawing.Size(170, 62);
            this.grpAusgabe.TabIndex = 41;
            this.grpAusgabe.TabStop = false;
            this.grpAusgabe.Text = "Datenausgabe1";
            // 
            // txtVectorFX
            // 
            this.txtVectorFX.Location = new System.Drawing.Point(43, 23);
            this.txtVectorFX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVectorFX.Name = "txtVectorFX";
            this.txtVectorFX.Size = new System.Drawing.Size(116, 20);
            this.txtVectorFX.TabIndex = 2;
            // 
            // lblVectorFX
            // 
            this.lblVectorFX.AutoSize = true;
            this.lblVectorFX.Location = new System.Drawing.Point(4, 24);
            this.lblVectorFX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorFX.Name = "lblVectorFX";
            this.lblVectorFX.Size = new System.Drawing.Size(33, 13);
            this.lblVectorFX.TabIndex = 0;
            this.lblVectorFX.Text = "f(x->):";
            // 
            // butFx
            // 
            this.butFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFx.Location = new System.Drawing.Point(281, 81);
            this.butFx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butFx.Name = "butFx";
            this.butFx.Size = new System.Drawing.Size(81, 38);
            this.butFx.TabIndex = 38;
            this.butFx.Text = "f(x)";
            this.butFx.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ausgabekoordinatensystem1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Eingabekoordinatensystem:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDeterminante);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.butDeterminante);
            this.groupBox1.Controls.Add(this.txtMatrix);
            this.groupBox1.Controls.Add(this.lblMatrix);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.txtPointX);
            this.groupBox1.Controls.Add(this.lblPointX);
            this.groupBox1.Location = new System.Drawing.Point(10, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(267, 107);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateneingabe1";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(130, 67);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.Size = new System.Drawing.Size(99, 20);
            this.txtDeterminante.TabIndex = 36;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(63, 45);
            this.txtX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(64, 20);
            this.txtX.TabIndex = 32;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(130, 34);
            this.butDeterminante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(98, 28);
            this.butDeterminante.TabIndex = 35;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(63, 67);
            this.txtMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(64, 20);
            this.txtMatrix.TabIndex = 15;
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(4, 70);
            this.lblMatrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(38, 13);
            this.lblMatrix.TabIndex = 14;
            this.lblMatrix.Text = "Matrix:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(4, 47);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(58, 13);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "Vektor x->:";
            // 
            // txtPointX
            // 
            this.txtPointX.Location = new System.Drawing.Point(63, 22);
            this.txtPointX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPointX.Name = "txtPointX";
            this.txtPointX.Size = new System.Drawing.Size(64, 20);
            this.txtPointX.TabIndex = 7;
            // 
            // lblPointX
            // 
            this.lblPointX.AutoSize = true;
            this.lblPointX.Location = new System.Drawing.Point(4, 24);
            this.lblPointX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(46, 13);
            this.lblPointX.TabIndex = 0;
            this.lblPointX.Text = "Punkt x:";
            // 
            // butGx
            // 
            this.butGx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGx.Location = new System.Drawing.Point(784, 59);
            this.butGx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butGx.Name = "butGx";
            this.butGx.Size = new System.Drawing.Size(81, 38);
            this.butGx.TabIndex = 42;
            this.butGx.Text = "g(x)";
            this.butGx.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Matrix:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 48);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(113, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 37;
            this.button1.Text = "Determinante";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(541, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(239, 107);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dateneingabe2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ausgabekoordinatensystem2:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtVectorGFx);
            this.groupBox3.Controls.Add(this.lblVectorGFx);
            this.groupBox3.Location = new System.Drawing.Point(870, 59);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(170, 83);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datenausgabe2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 45);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "g(f(x)):";
            // 
            // txtVectorGFx
            // 
            this.txtVectorGFx.Location = new System.Drawing.Point(56, 22);
            this.txtVectorGFx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVectorGFx.Name = "txtVectorGFx";
            this.txtVectorGFx.Size = new System.Drawing.Size(103, 20);
            this.txtVectorGFx.TabIndex = 2;
            // 
            // lblVectorGFx
            // 
            this.lblVectorGFx.AutoSize = true;
            this.lblVectorGFx.Location = new System.Drawing.Point(4, 24);
            this.lblVectorGFx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorGFx.Name = "lblVectorGFx";
            this.lblVectorGFx.Size = new System.Drawing.Size(45, 13);
            this.lblVectorGFx.TabIndex = 0;
            this.lblVectorGFx.Text = "g(f(x->)):";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(784, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 38);
            this.button2.TabIndex = 46;
            this.button2.Text = "g(f(x))";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cosInput
            // 
            this.cosInput.Location = new System.Drawing.Point(13, 175);
            this.cosInput.Name = "cosInput";
            this.cosInput.Size = new System.Drawing.Size(327, 303);
            this.cosInput.TabIndex = 47;
            // 
            // cosOutput1
            // 
            this.cosOutput1.Location = new System.Drawing.Point(367, 175);
            this.cosOutput1.Name = "cosOutput1";
            this.cosOutput1.Size = new System.Drawing.Size(327, 303);
            this.cosOutput1.TabIndex = 48;
            // 
            // cosOutput2
            // 
            this.cosOutput2.Location = new System.Drawing.Point(713, 175);
            this.cosOutput2.Name = "cosOutput2";
            this.cosOutput2.Size = new System.Drawing.Size(327, 303);
            this.cosOutput2.TabIndex = 49;
            // 
            // FrmHinterLinAbb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 506);
            this.Controls.Add(this.cosOutput2);
            this.Controls.Add(this.cosOutput1);
            this.Controls.Add(this.cosInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.butGx);
            this.Controls.Add(this.grpAusgabe);
            this.Controls.Add(this.butFx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHinterLinAbb";
            this.Text = "FrmHinterLinAbb";
            this.grpAusgabe.ResumeLayout(false);
            this.grpAusgabe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAusgabe;
        private System.Windows.Forms.TextBox txtVectorFX;
        private System.Windows.Forms.Label lblVectorFX;
        private System.Windows.Forms.Button butFx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button butDeterminante;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.Button butGx;
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
        private CoordinateSystem cosInput;
        private CoordinateSystem cosOutput1;
        private CoordinateSystem cosOutput2;
    }
}