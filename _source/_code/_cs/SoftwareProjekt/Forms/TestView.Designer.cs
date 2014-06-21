namespace SoftwareProjekt.Forms
{
    partial class TestView
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
            this._coordSys = new SoftwareProjekt.UserControls.CoordinateSystem();
            this._matrix = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this._vector = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._btnCalc = new System.Windows.Forms.Button();
            this.ctlFormDrawTest = new SoftwareProjekt.UserControls.FormulaDrawer.CtlFormularDraw();
            this.picArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // _coordSys
            // 
            this._coordSys.Location = new System.Drawing.Point(16, 15);
            this._coordSys.Margin = new System.Windows.Forms.Padding(4);
            this._coordSys.Name = "_coordSys";
            this._coordSys.Size = new System.Drawing.Size(379, 334);
            this._coordSys.TabIndex = 0;
            // 
            // _matrix
            // 
            this._matrix.Location = new System.Drawing.Point(415, 15);
            this._matrix.Margin = new System.Windows.Forms.Padding(5);
            matrix1.X11 = float.NaN;
            matrix1.X12 = float.NaN;
            matrix1.X21 = float.NaN;
            matrix1.X22 = float.NaN;
            this._matrix.Matrix = matrix1;
            this._matrix.MinimumSize = new System.Drawing.Size(175, 116);
            this._matrix.Name = "_matrix";
            this._matrix.Size = new System.Drawing.Size(175, 116);
            this._matrix.TabIndex = 1;
            // 
            // _vector
            // 
            this._vector.Location = new System.Drawing.Point(415, 128);
            this._vector.Margin = new System.Windows.Forms.Padding(5);
            this._vector.MinimumSize = new System.Drawing.Size(181, 116);
            this._vector.Name = "_vector";
            this._vector.Size = new System.Drawing.Size(181, 116);
            this._vector.TabIndex = 2;
            vector1.X1 = float.NaN;
            vector1.X2 = float.NaN;
            this._vector.Vector = vector1;
            // 
            // _btnCalc
            // 
            this._btnCalc.Location = new System.Drawing.Point(437, 263);
            this._btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this._btnCalc.Name = "_btnCalc";
            this._btnCalc.Size = new System.Drawing.Size(139, 73);
            this._btnCalc.TabIndex = 3;
            this._btnCalc.Text = "Calculate";
            this._btnCalc.UseVisualStyleBackColor = true;
            this._btnCalc.Click += new System.EventHandler(this._btnCalc_Click);
            // 
            // ctlFormDrawTest
            // 
            this.ctlFormDrawTest.BackColor = System.Drawing.Color.Transparent;
            this.ctlFormDrawTest.Equation = null;
            this.ctlFormDrawTest.Filename = "dhzkmmxz.pxd.tiff";
            this.ctlFormDrawTest.Filepath = null;
            this.ctlFormDrawTest.FontSize = 8;
            this.ctlFormDrawTest.Location = new System.Drawing.Point(684, 144);
            this.ctlFormDrawTest.Margin = new System.Windows.Forms.Padding(5);
            this.ctlFormDrawTest.Name = "ctlFormDrawTest";
            this.ctlFormDrawTest.Size = new System.Drawing.Size(326, 87);
            this.ctlFormDrawTest.TabIndex = 4;
            // 
            // picArrow
            // 
            this.picArrow.BackColor = System.Drawing.Color.Transparent;
            this.picArrow.Image = global::SoftwareProjekt.Properties.Resources.arrowToRight;
            this.picArrow.Location = new System.Drawing.Point(648, 15);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(720, 386);
            this.picArrow.TabIndex = 5;
            this.picArrow.TabStop = false;
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 436);
            this.Controls.Add(this.ctlFormDrawTest);
            this.Controls.Add(this._btnCalc);
            this.Controls.Add(this._vector);
            this.Controls.Add(this._matrix);
            this.Controls.Add(this._coordSys);
            this.Controls.Add(this.picArrow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestView";
            this.Text = "TestView";
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SoftwareProjekt.UserControls.CoordinateSystem _coordSys;
        private SoftwareProjekt.UserControls.CtlMatrixInput _matrix;
        private SoftwareProjekt.UserControls.CtlVectorInput _vector;
        private System.Windows.Forms.Button _btnCalc;
        private UserControls.FormulaDrawer.CtlFormularDraw ctlFormDrawTest;
        private System.Windows.Forms.PictureBox picArrow;
    }
}