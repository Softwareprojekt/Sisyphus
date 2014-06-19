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
            SoftwareProjekt.Classes.Math.Vector vector14 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Vector vector13 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix7 = new SoftwareProjekt.Classes.Math.Matrix();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblXPlusY = new System.Windows.Forms.Label();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.lblPointY = new System.Windows.Forms.Label();
            this.lblPointX = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVectorXY = new System.Windows.Forms.Label();
            this.lblVectorY = new System.Windows.Forms.Label();
            this.lblFX = new System.Windows.Forms.Label();
            this.butFuncionXPlusY = new System.Windows.Forms.Button();
            this.coordinateSystem1 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.coordinateSystem2 = new SoftwareProjekt.UserControls.CoordinateSystem();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picMathEqua = new System.Windows.Forms.PictureBox();
            this.ctlVecInX = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlVecInY = new SoftwareProjekt.UserControls.CtlVectorInput();
            this.ctlMaInScaleMat = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEqua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlMaInScaleMat);
            this.groupBox1.Controls.Add(this.ctlVecInY);
            this.groupBox1.Controls.Add(this.ctlVecInX);
            this.groupBox1.Controls.Add(this.lblXPlusY);
            this.groupBox1.Controls.Add(this.lblMatrix);
            this.groupBox1.Controls.Add(this.lblPointY);
            this.groupBox1.Controls.Add(this.lblPointX);
            this.groupBox1.Location = new System.Drawing.Point(98, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(269, 321);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateneingabe";
            // 
            // lblXPlusY
            // 
            this.lblXPlusY.AutoSize = true;
            this.lblXPlusY.Location = new System.Drawing.Point(18, 144);
            this.lblXPlusY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXPlusY.Name = "lblXPlusY";
            this.lblXPlusY.Size = new System.Drawing.Size(38, 13);
            this.lblXPlusY.TabIndex = 28;
            this.lblXPlusY.Text = "x1+x2:";
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(18, 186);
            this.lblMatrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(63, 13);
            this.lblMatrix.TabIndex = 10;
            this.lblMatrix.Text = "scaleMatrix:";
            // 
            // lblPointY
            // 
            this.lblPointY.AutoSize = true;
            this.lblPointY.Location = new System.Drawing.Point(155, 26);
            this.lblPointY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointY.Name = "lblPointY";
            this.lblPointY.Size = new System.Drawing.Size(46, 13);
            this.lblPointY.TabIndex = 8;
            this.lblPointY.Text = "Vektor y";
            // 
            // lblPointX
            // 
            this.lblPointX.AutoSize = true;
            this.lblPointX.Location = new System.Drawing.Point(18, 26);
            this.lblPointX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(46, 13);
            this.lblPointX.TabIndex = 0;
            this.lblPointX.Text = "Vektor x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Eingabekoordinatensystem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(863, 415);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ausgabekoordinatensystem:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVectorXY);
            this.groupBox2.Controls.Add(this.lblVectorY);
            this.groupBox2.Controls.Add(this.lblFX);
            this.groupBox2.Location = new System.Drawing.Point(711, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(347, 224);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ergebnis";
            // 
            // lblVectorXY
            // 
            this.lblVectorXY.AutoSize = true;
            this.lblVectorXY.Location = new System.Drawing.Point(4, 72);
            this.lblVectorXY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorXY.Name = "lblVectorXY";
            this.lblVectorXY.Size = new System.Drawing.Size(65, 13);
            this.lblVectorXY.TabIndex = 10;
            this.lblVectorXY.Text = "f(x1->+x2->):";
            // 
            // lblVectorY
            // 
            this.lblVectorY.AutoSize = true;
            this.lblVectorY.Location = new System.Drawing.Point(4, 49);
            this.lblVectorY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVectorY.Name = "lblVectorY";
            this.lblVectorY.Size = new System.Drawing.Size(39, 13);
            this.lblVectorY.TabIndex = 8;
            this.lblVectorY.Text = "f(x2->):";
            // 
            // lblFX
            // 
            this.lblFX.AutoSize = true;
            this.lblFX.Location = new System.Drawing.Point(4, 26);
            this.lblFX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFX.Name = "lblFX";
            this.lblFX.Size = new System.Drawing.Size(39, 13);
            this.lblFX.TabIndex = 0;
            this.lblFX.Text = "f(x1->):";
            // 
            // butFuncionXPlusY
            // 
            this.butFuncionXPlusY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFuncionXPlusY.Location = new System.Drawing.Point(484, 120);
            this.butFuncionXPlusY.Margin = new System.Windows.Forms.Padding(2);
            this.butFuncionXPlusY.Name = "butFuncionXPlusY";
            this.butFuncionXPlusY.Size = new System.Drawing.Size(86, 67);
            this.butFuncionXPlusY.TabIndex = 27;
            this.butFuncionXPlusY.Text = "f(X+Y)";
            this.butFuncionXPlusY.UseVisualStyleBackColor = true;
            this.butFuncionXPlusY.Click += new System.EventHandler(this.butFuncionXPlusY_Click);
            // 
            // coordinateSystem1
            // 
            this.coordinateSystem1.Location = new System.Drawing.Point(28, 431);
            this.coordinateSystem1.Name = "coordinateSystem1";
            this.coordinateSystem1.Size = new System.Drawing.Size(385, 303);
            this.coordinateSystem1.TabIndex = 28;
            // 
            // coordinateSystem2
            // 
            this.coordinateSystem2.Location = new System.Drawing.Point(734, 431);
            this.coordinateSystem2.Name = "coordinateSystem2";
            this.coordinateSystem2.Size = new System.Drawing.Size(397, 303);
            this.coordinateSystem2.TabIndex = 29;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(412, 775);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 31;
            this.lblNotes.Text = "Notizen:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(412, 794);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this.rtxtNotes.TabIndex = 30;
            this.rtxtNotes.Text = "";
            this.rtxtNotes.TextChanged += new System.EventHandler(this.rtxtNotes_TextChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(314, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(599, 24);
            this.lblHeader.TabIndex = 32;
            this.lblHeader.Text = "Thema:  Jede lin. Abb. verträgt sich mit Vielfachen beliebiger Vektoren";
            // 
            // picMathEqua
            // 
            this.picMathEqua.Location = new System.Drawing.Point(419, 504);
            this.picMathEqua.Name = "picMathEqua";
            this.picMathEqua.Size = new System.Drawing.Size(296, 152);
            this.picMathEqua.TabIndex = 33;
            this.picMathEqua.TabStop = false;
            // 
            // ctlVecInX
            // 
            this.ctlVecInX.Location = new System.Drawing.Point(5, 40);
            this.ctlVecInX.Name = "ctlVecInX";
            this.ctlVecInX.Size = new System.Drawing.Size(121, 83);
            this.ctlVecInX.TabIndex = 29;
            vector14.X1 = float.NaN;
            vector14.X2 = float.NaN;
            this.ctlVecInX.Vector = vector14;
            // 
            // ctlVecInY
            // 
            this.ctlVecInY.Location = new System.Drawing.Point(132, 42);
            this.ctlVecInY.Name = "ctlVecInY";
            this.ctlVecInY.Size = new System.Drawing.Size(121, 83);
            this.ctlVecInY.TabIndex = 30;
            vector13.X1 = float.NaN;
            vector13.X2 = float.NaN;
            this.ctlVecInY.Vector = vector13;
            // 
            // ctlMaInScaleMat
            // 
            this.ctlMaInScaleMat.Location = new System.Drawing.Point(7, 202);
            matrix7.X11 = float.NaN;
            matrix7.X12 = float.NaN;
            matrix7.X21 = float.NaN;
            matrix7.X22 = float.NaN;
            this.ctlMaInScaleMat.Matrix = matrix7;
            this.ctlMaInScaleMat.Name = "ctlMaInScaleMat";
            this.ctlMaInScaleMat.Size = new System.Drawing.Size(125, 89);
            this.ctlMaInScaleMat.TabIndex = 31;
            // 
            // FrmLinAbbSumBelVek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 930);
            this.Controls.Add(this.picMathEqua);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.coordinateSystem2);
            this.Controls.Add(this.coordinateSystem1);
            this.Controls.Add(this.butFuncionXPlusY);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLinAbbSumBelVek";
            this.Text = "Lineare Abbildungen und Vielfache von Vektoren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMathEqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.Label lblPointY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVectorXY;
        private System.Windows.Forms.Label lblVectorY;
        private System.Windows.Forms.Label lblFX;
        private System.Windows.Forms.Label lblXPlusY;
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
    }
}