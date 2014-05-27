namespace SoftwareProjekt
{
    partial class FrmLinAbbVielBelVek
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
            this.label6 = new System.Windows.Forms.Label();
            this.pbEingabeX = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.txtAMultY = new System.Windows.Forms.TextBox();
            this.lblAMultY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtEV1 = new System.Windows.Forms.TextBox();
            this.lblFactorA = new System.Windows.Forms.Label();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.lblPointX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.butFunctionAMultX = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbAusgabe = new System.Windows.Forms.PictureBox();
            this.grpAusgabe = new System.Windows.Forms.GroupBox();
            this.lblVectorFX = new System.Windows.Forms.Label();
            this.lblVectorAMultX = new System.Windows.Forms.Label();
            this.txtVectorFX = new System.Windows.Forms.TextBox();
            this.txtVectorAMultX = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEingabeX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAusgabe)).BeginInit();
            this.grpAusgabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Eingabekoordinatensystem:";
            // 
            // pbEingabeX
            // 
            this.pbEingabeX.Location = new System.Drawing.Point(15, 267);
            this.pbEingabeX.Name = "pbEingabeX";
            this.pbEingabeX.Size = new System.Drawing.Size(333, 284);
            this.pbEingabeX.TabIndex = 30;
            this.pbEingabeX.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDeterminante);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.butDeterminante);
            this.groupBox1.Controls.Add(this.txtMatrix);
            this.groupBox1.Controls.Add(this.lblMatrix);
            this.groupBox1.Controls.Add(this.txtAMultY);
            this.groupBox1.Controls.Add(this.lblAMultY);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.txtEV1);
            this.groupBox1.Controls.Add(this.lblFactorA);
            this.groupBox1.Controls.Add(this.txtPointX);
            this.groupBox1.Controls.Add(this.lblPointX);
            this.groupBox1.Location = new System.Drawing.Point(15, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 180);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateneingabe";
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(84, 139);
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(84, 22);
            this.txtMatrix.TabIndex = 15;
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(6, 142);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(49, 17);
            this.lblMatrix.TabIndex = 14;
            this.lblMatrix.Text = "Matrix:";
            // 
            // txtAMultY
            // 
            this.txtAMultY.Location = new System.Drawing.Point(84, 111);
            this.txtAMultY.Name = "txtAMultY";
            this.txtAMultY.Size = new System.Drawing.Size(84, 22);
            this.txtAMultY.TabIndex = 13;
            // 
            // lblAMultY
            // 
            this.lblAMultY.AutoSize = true;
            this.lblAMultY.Location = new System.Drawing.Point(6, 114);
            this.lblAMultY.Name = "lblAMultY";
            this.lblAMultY.Size = new System.Drawing.Size(45, 17);
            this.lblAMultY.TabIndex = 12;
            this.lblAMultY.Text = "a*y->:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 88);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(76, 17);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "Vektor x->:";
            // 
            // txtEV1
            // 
            this.txtEV1.Location = new System.Drawing.Point(84, 55);
            this.txtEV1.Name = "txtEV1";
            this.txtEV1.Size = new System.Drawing.Size(84, 22);
            this.txtEV1.TabIndex = 9;
            // 
            // lblFactorA
            // 
            this.lblFactorA.AutoSize = true;
            this.lblFactorA.Location = new System.Drawing.Point(6, 60);
            this.lblFactorA.Name = "lblFactorA";
            this.lblFactorA.Size = new System.Drawing.Size(64, 17);
            this.lblFactorA.TabIndex = 8;
            this.lblFactorA.Text = "Faktor a:";
            // 
            // txtPointX
            // 
            this.txtPointX.Location = new System.Drawing.Point(84, 27);
            this.txtPointX.Name = "txtPointX";
            this.txtPointX.Size = new System.Drawing.Size(84, 22);
            this.txtPointX.TabIndex = 7;
            // 
            // lblPointX
            // 
            this.lblPointX.AutoSize = true;
            this.lblPointX.Location = new System.Drawing.Point(6, 30);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(58, 17);
            this.lblPointX.TabIndex = 0;
            this.lblPointX.Text = "Punkt x:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(84, 83);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(84, 22);
            this.txtX.TabIndex = 32;
            // 
            // butFunctionAMultX
            // 
            this.butFunctionAMultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionAMultX.Location = new System.Drawing.Point(426, 107);
            this.butFunctionAMultX.Name = "butFunctionAMultX";
            this.butFunctionAMultX.Size = new System.Drawing.Size(108, 47);
            this.butFunctionAMultX.TabIndex = 32;
            this.butFunctionAMultX.Text = "f(a*x)";
            this.butFunctionAMultX.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ausgabekoordinatensystem:";
            // 
            // pbAusgabe
            // 
            this.pbAusgabe.Location = new System.Drawing.Point(440, 267);
            this.pbAusgabe.Name = "pbAusgabe";
            this.pbAusgabe.Size = new System.Drawing.Size(330, 284);
            this.pbAusgabe.TabIndex = 32;
            this.pbAusgabe.TabStop = false;
            // 
            // grpAusgabe
            // 
            this.grpAusgabe.Controls.Add(this.txtVectorAMultX);
            this.grpAusgabe.Controls.Add(this.txtVectorFX);
            this.grpAusgabe.Controls.Add(this.lblVectorAMultX);
            this.grpAusgabe.Controls.Add(this.lblVectorFX);
            this.grpAusgabe.Location = new System.Drawing.Point(583, 92);
            this.grpAusgabe.Name = "grpAusgabe";
            this.grpAusgabe.Size = new System.Drawing.Size(226, 105);
            this.grpAusgabe.TabIndex = 34;
            this.grpAusgabe.TabStop = false;
            this.grpAusgabe.Text = "Datenausgabe";
            // 
            // lblVectorFX
            // 
            this.lblVectorFX.AutoSize = true;
            this.lblVectorFX.Location = new System.Drawing.Point(6, 30);
            this.lblVectorFX.Name = "lblVectorFX";
            this.lblVectorFX.Size = new System.Drawing.Size(45, 17);
            this.lblVectorFX.TabIndex = 0;
            this.lblVectorFX.Text = "f(x->):";
            // 
            // lblVectorAMultX
            // 
            this.lblVectorAMultX.AutoSize = true;
            this.lblVectorAMultX.Location = new System.Drawing.Point(6, 58);
            this.lblVectorAMultX.Name = "lblVectorAMultX";
            this.lblVectorAMultX.Size = new System.Drawing.Size(58, 17);
            this.lblVectorAMultX.TabIndex = 1;
            this.lblVectorAMultX.Text = "f(a*x->):";
            // 
            // txtVectorFX
            // 
            this.txtVectorFX.Location = new System.Drawing.Point(76, 27);
            this.txtVectorFX.Name = "txtVectorFX";
            this.txtVectorFX.Size = new System.Drawing.Size(100, 22);
            this.txtVectorFX.TabIndex = 2;
            // 
            // txtVectorAMultX
            // 
            this.txtVectorAMultX.Location = new System.Drawing.Point(76, 55);
            this.txtVectorAMultX.Name = "txtVectorAMultX";
            this.txtVectorAMultX.Size = new System.Drawing.Size(100, 22);
            this.txtVectorAMultX.TabIndex = 3;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(194, 70);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(131, 35);
            this.butDeterminante.TabIndex = 35;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(194, 111);
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.Size = new System.Drawing.Size(131, 22);
            this.txtDeterminante.TabIndex = 36;
            // 
            // FrmLinAbbVielBelVek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 627);
            this.Controls.Add(this.grpAusgabe);
            this.Controls.Add(this.butFunctionAMultX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbAusgabe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbEingabeX);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLinAbbVielBelVek";
            this.Text = "FrmLinAbbVielBelVek";
            ((System.ComponentModel.ISupportInitialize)(this.pbEingabeX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAusgabe)).EndInit();
            this.grpAusgabe.ResumeLayout(false);
            this.grpAusgabe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbEingabeX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butFunctionAMultX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.TextBox txtAMultY;
        private System.Windows.Forms.Label lblAMultY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtEV1;
        private System.Windows.Forms.Label lblFactorA;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbAusgabe;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Button butDeterminante;
        private System.Windows.Forms.GroupBox grpAusgabe;
        private System.Windows.Forms.TextBox txtVectorAMultX;
        private System.Windows.Forms.TextBox txtVectorFX;
        private System.Windows.Forms.Label lblVectorAMultX;
        private System.Windows.Forms.Label lblVectorFX;
    }
}