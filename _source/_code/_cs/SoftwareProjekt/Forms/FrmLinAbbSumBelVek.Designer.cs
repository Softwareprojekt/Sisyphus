namespace SoftwareProjekt.Forms
{
    partial class FrmLinAbbSumBelVek
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
            SoftwareProjekt.Classes.Math.Matrix matrix1 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector1 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector2 = new SoftwareProjekt.Classes.Math.Vector();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dutDeterminante = new System.Windows.Forms.Button();
            this.txtDeterminante1 = new System.Windows.Forms.TextBox();
            this.ctlMaInScaleMat = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.ctlVecInY = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVecInX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.lblPointY = new System.Windows.Forms.Label();
            this.lblPointX = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butFuncionXPlusY = new System.Windows.Forms.Button();
            this.coordinateSystem1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.coordinateSystem2 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picMathEqua = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEqua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dutDeterminante);
            this.groupBox1.Controls.Add(this.txtDeterminante1);
            this.groupBox1.Controls.Add(this.ctlMaInScaleMat);
            this.groupBox1.Controls.Add(this.ctlVecInY);
            this.groupBox1.Controls.Add(this.ctlVecInX);
            this.groupBox1.Controls.Add(this.lblPointY);
            this.groupBox1.Controls.Add(this.lblPointX);
            this.groupBox1.Location = new System.Drawing.Point(37, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(359, 297);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateneingabe";
            // 
            // dutDeterminante
            // 
            this.dutDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dutDeterminante.Location = new System.Drawing.Point(176, 199);
            this.dutDeterminante.Name = "dutDeterminante";
            this.dutDeterminante.Size = new System.Drawing.Size(150, 46);
            this.dutDeterminante.TabIndex = 4;
            this.dutDeterminante.Text = "Determinante";
            this.dutDeterminante.UseVisualStyleBackColor = true;
            this.dutDeterminante.Click += new System.EventHandler(this.dutDeterminante_Click);
            // 
            // txtDeterminante1
            // 
            this.txtDeterminante1.Location = new System.Drawing.Point(176, 250);
            this.txtDeterminante1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeterminante1.MaxLength = 5;
            this.txtDeterminante1.Name = "txtDeterminante1";
            this.txtDeterminante1.ReadOnly = true;
            this.txtDeterminante1.Size = new System.Drawing.Size(150, 22);
            this.txtDeterminante1.TabIndex = 58;
            // 
            // ctlMaInScaleMat
            // 
            this.ctlMaInScaleMat.Location = new System.Drawing.Point(9, 185);
            this.ctlMaInScaleMat.Margin = new System.Windows.Forms.Padding(5);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this.ctlMaInScaleMat.Matrix = matrix1;
            this.ctlMaInScaleMat.MinimumSize = new System.Drawing.Size(131, 94);
            this.ctlMaInScaleMat.Name = "ctlMaInScaleMat";
            this.ctlMaInScaleMat.Size = new System.Drawing.Size(167, 110);
            this.ctlMaInScaleMat.TabIndex = 3;
            // 
            // ctlVecInY
            // 
            this.ctlVecInY.Location = new System.Drawing.Point(176, 52);
            this.ctlVecInY.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVecInY.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVecInY.Name = "ctlVecInY";
            this.ctlVecInY.Size = new System.Drawing.Size(161, 102);
            this.ctlVecInY.TabIndex = 2;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this.ctlVecInY.Vector = vector1;
            // 
            // ctlVecInX
            // 
            this.ctlVecInX.Location = new System.Drawing.Point(7, 49);
            this.ctlVecInX.Margin = new System.Windows.Forms.Padding(5);
            this.ctlVecInX.MinimumSize = new System.Drawing.Size(136, 94);
            this.ctlVecInX.Name = "ctlVecInX";
            this.ctlVecInX.Size = new System.Drawing.Size(161, 102);
            this.ctlVecInX.TabIndex = 1;
            vector2.X1 = float.NaN;
            vector2.X2 = float.NaN;
            this.ctlVecInX.Vector = vector2;
            // 
            // lblPointY
            // 
            this.lblPointY.AutoSize = true;
            this.lblPointY.Location = new System.Drawing.Point(207, 32);
            this.lblPointY.Name = "lblPointY";
            this.lblPointY.Size = new System.Drawing.Size(60, 17);
            this.lblPointY.TabIndex = 8;
            this.lblPointY.Text = "Vektor y";
            // 
            // lblPointX
            // 
            this.lblPointX.AutoSize = true;
            this.lblPointX.Location = new System.Drawing.Point(24, 32);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(59, 17);
            this.lblPointX.TabIndex = 0;
            this.lblPointX.Text = "Vektor x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Eingabekoordinatensystem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1151, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ausgabekoordinatensystem:";
            // 
            // butFuncionXPlusY
            // 
            this.butFuncionXPlusY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFuncionXPlusY.Location = new System.Drawing.Point(422, 182);
            this.butFuncionXPlusY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butFuncionXPlusY.Name = "butFuncionXPlusY";
            this.butFuncionXPlusY.Size = new System.Drawing.Size(115, 82);
            this.butFuncionXPlusY.TabIndex = 5;
            this.butFuncionXPlusY.Text = "f(X+Y)";
            this.butFuncionXPlusY.UseVisualStyleBackColor = true;
            this.butFuncionXPlusY.Click += new System.EventHandler(this.butFuncionXPlusY_Click);
            // 
            // coordinateSystem1
            // 
            this.coordinateSystem1.Location = new System.Drawing.Point(37, 530);
            this.coordinateSystem1.Margin = new System.Windows.Forms.Padding(4);
            this.coordinateSystem1.Name = "coordinateSystem1";
            this.coordinateSystem1.Size = new System.Drawing.Size(513, 373);
            this.coordinateSystem1.TabIndex = 28;
            // 
            // coordinateSystem2
            // 
            this.coordinateSystem2.Location = new System.Drawing.Point(979, 530);
            this.coordinateSystem2.Margin = new System.Windows.Forms.Padding(4);
            this.coordinateSystem2.Name = "coordinateSystem2";
            this.coordinateSystem2.Size = new System.Drawing.Size(529, 373);
            this.coordinateSystem2.TabIndex = 29;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(549, 954);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(60, 17);
            this.lblNotes.TabIndex = 31;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(549, 977);
            this.rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(636, 152);
            this.rtxtNotes.TabIndex = 6;
            this.rtxtNotes.Text = "";
            this.rtxtNotes.TextChanged += new System.EventHandler(this.rtxtNotes_TextChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(419, 11);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(733, 29);
            this.lblHeader.TabIndex = 32;
            this.lblHeader.Text = "Thema:  Jede lin. Abb. verträgt sich mit Summe beliebiger Vektoren";
            // 
            // picMathEqua
            // 
            this.picMathEqua.Location = new System.Drawing.Point(559, 620);
            this.picMathEqua.Margin = new System.Windows.Forms.Padding(4);
            this.picMathEqua.Name = "picMathEqua";
            this.picMathEqua.Size = new System.Drawing.Size(395, 187);
            this.picMathEqua.TabIndex = 33;
            this.picMathEqua.TabStop = false;
            // 
            // FrmLinAbbSumBelVek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 1045);
            this.Controls.Add(this.picMathEqua);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.coordinateSystem2);
            this.Controls.Add(this.coordinateSystem1);
            this.Controls.Add(this.butFuncionXPlusY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLinAbbSumBelVek";
            this.Text = "Lineare Abbildungen und Summe von Vektoren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPointY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butFuncionXPlusY;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem1;
        private SoftwareProjekt.UserControls.CoordinateSystem coordinateSystem2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picMathEqua;
        private UserControls.CtlVectorInput ctlVecInX;
        private UserControls.CtlMatrixInput ctlMaInScaleMat;
        private UserControls.CtlVectorInput ctlVecInY;
        private System.Windows.Forms.Button dutDeterminante;
        private System.Windows.Forms.TextBox txtDeterminante1;
    }
}