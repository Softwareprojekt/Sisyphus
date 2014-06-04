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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.butDeterminante = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.txtAMultY = new System.Windows.Forms.TextBox();
            this.lblAMultY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtEV1 = new System.Windows.Forms.TextBox();
            this.lblFactorA = new System.Windows.Forms.Label();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.lblPointX = new System.Windows.Forms.Label();
            this.butFunctionAMultX = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grpAusgabe = new System.Windows.Forms.GroupBox();
            this.txtVectorAMultX = new System.Windows.Forms.TextBox();
            this.txtVectorFX = new System.Windows.Forms.TextBox();
            this.lblVectorAMultX = new System.Windows.Forms.Label();
            this.lblVectorFX = new System.Windows.Forms.Label();
            this.coordinateSystem1 = new SoftwareProjekt.CoordinateSystem();
            this.coordinateSystem2 = new SoftwareProjekt.CoordinateSystem();
            this.groupBox1.SuspendLayout();
            this.grpAusgabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Eingabekoordinatensystem:";
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
            this.groupBox1.Location = new System.Drawing.Point(84, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(267, 146);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateneingabe";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(146, 90);
            this.txtDeterminante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.Size = new System.Drawing.Size(99, 20);
            this.txtDeterminante.TabIndex = 36;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(63, 67);
            this.txtX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(64, 20);
            this.txtX.TabIndex = 32;
            // 
            // butDeterminante
            // 
            this.butDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeterminante.Location = new System.Drawing.Point(146, 57);
            this.butDeterminante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDeterminante.Name = "butDeterminante";
            this.butDeterminante.Size = new System.Drawing.Size(98, 28);
            this.butDeterminante.TabIndex = 35;
            this.butDeterminante.Text = "Determinante";
            this.butDeterminante.UseVisualStyleBackColor = true;
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(63, 113);
            this.txtMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(64, 20);
            this.txtMatrix.TabIndex = 15;
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(4, 115);
            this.lblMatrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(38, 13);
            this.lblMatrix.TabIndex = 14;
            this.lblMatrix.Text = "Matrix:";
            // 
            // txtAMultY
            // 
            this.txtAMultY.Location = new System.Drawing.Point(63, 90);
            this.txtAMultY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAMultY.Name = "txtAMultY";
            this.txtAMultY.Size = new System.Drawing.Size(64, 20);
            this.txtAMultY.TabIndex = 13;
            // 
            // lblAMultY
            // 
            this.lblAMultY.AutoSize = true;
            this.lblAMultY.Location = new System.Drawing.Point(4, 93);
            this.lblAMultY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAMultY.Name = "lblAMultY";
            this.lblAMultY.Size = new System.Drawing.Size(34, 13);
            this.lblAMultY.TabIndex = 12;
            this.lblAMultY.Text = "a*y->:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(4, 72);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(58, 13);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "Vektor x->:";
            // 
            // txtEV1
            // 
            this.txtEV1.Location = new System.Drawing.Point(63, 45);
            this.txtEV1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEV1.Name = "txtEV1";
            this.txtEV1.Size = new System.Drawing.Size(64, 20);
            this.txtEV1.TabIndex = 9;
            // 
            // lblFactorA
            // 
            this.lblFactorA.AutoSize = true;
            this.lblFactorA.Location = new System.Drawing.Point(4, 49);
            this.lblFactorA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactorA.Name = "lblFactorA";
            this.lblFactorA.Size = new System.Drawing.Size(49, 13);
            this.lblFactorA.TabIndex = 8;
            this.lblFactorA.Text = "Faktor a:";
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
            // butFunctionAMultX
            // 
            this.butFunctionAMultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFunctionAMultX.Location = new System.Drawing.Point(479, 84);
            this.butFunctionAMultX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butFunctionAMultX.Name = "butFunctionAMultX";
            this.butFunctionAMultX.Size = new System.Drawing.Size(81, 38);
            this.butFunctionAMultX.TabIndex = 32;
            this.butFunctionAMultX.Text = "f(a*x)";
            this.butFunctionAMultX.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(737, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ausgabekoordinatensystem:";
            // 
            // grpAusgabe
            // 
            this.grpAusgabe.Controls.Add(this.txtVectorAMultX);
            this.grpAusgabe.Controls.Add(this.txtVectorFX);
            this.grpAusgabe.Controls.Add(this.lblVectorAMultX);
            this.grpAusgabe.Controls.Add(this.lblVectorFX);
            this.grpAusgabe.Location = new System.Drawing.Point(725, 73);
            this.grpAusgabe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAusgabe.Name = "grpAusgabe";
            this.grpAusgabe.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAusgabe.Size = new System.Drawing.Size(170, 85);
            this.grpAusgabe.TabIndex = 34;
            this.grpAusgabe.TabStop = false;
            this.grpAusgabe.Text = "Datenausgabe";
            // 
            // txtVectorAMultX
            // 
            this.txtVectorAMultX.Location = new System.Drawing.Point(57, 45);
            this.txtVectorAMultX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVectorAMultX.Name = "txtVectorAMultX";
            this.txtVectorAMultX.Size = new System.Drawing.Size(76, 20);
            this.txtVectorAMultX.TabIndex = 3;
            // 
            // txtVectorFX
            // 
            this.txtVectorFX.Location = new System.Drawing.Point(57, 22);
            this.txtVectorFX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVectorFX.Name = "txtVectorFX";
            this.txtVectorFX.Size = new System.Drawing.Size(76, 20);
            this.txtVectorFX.TabIndex = 2;
            // 
            // lblVectorAMultX
            // 
            this.lblVectorAMultX.AutoSize = true;
            this.lblVectorAMultX.Location = new System.Drawing.Point(4, 47);
            this.lblVectorAMultX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorAMultX.Name = "lblVectorAMultX";
            this.lblVectorAMultX.Size = new System.Drawing.Size(43, 13);
            this.lblVectorAMultX.TabIndex = 1;
            this.lblVectorAMultX.Text = "f(a*x->):";
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
            // coordinateSystem1
            // 
            this.coordinateSystem1.Location = new System.Drawing.Point(18, 236);
            this.coordinateSystem1.Name = "coordinateSystem1";
            this.coordinateSystem1.Size = new System.Drawing.Size(360, 348);
            this.coordinateSystem1.TabIndex = 35;
            // 
            // coordinateSystem2
            // 
            this.coordinateSystem2.Location = new System.Drawing.Point(617, 236);
            this.coordinateSystem2.Name = "coordinateSystem2";
            this.coordinateSystem2.Size = new System.Drawing.Size(360, 348);
            this.coordinateSystem2.TabIndex = 36;
            // 
            // FrmLinAbbVielBelVek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 619);
            this.Controls.Add(this.coordinateSystem2);
            this.Controls.Add(this.coordinateSystem1);
            this.Controls.Add(this.grpAusgabe);
            this.Controls.Add(this.butFunctionAMultX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLinAbbVielBelVek";
            this.Text = "FrmLinAbbVielBelVek";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAusgabe.ResumeLayout(false);
            this.grpAusgabe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Button butDeterminante;
        private System.Windows.Forms.GroupBox grpAusgabe;
        private System.Windows.Forms.TextBox txtVectorAMultX;
        private System.Windows.Forms.TextBox txtVectorFX;
        private System.Windows.Forms.Label lblVectorAMultX;
        private System.Windows.Forms.Label lblVectorFX;
        private CoordinateSystem coordinateSystem1;
        private CoordinateSystem coordinateSystem2;
    }
}