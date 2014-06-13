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
            this._coordSys = new SoftwareProjekt.CoordinateSystem();
            this._matrix = new SoftwareProjekt.CtlMatrixInput();
            this._vector = new SoftwareProjekt.CtlVectorInput();
            this._btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _coordSys
            // 
            this._coordSys.Location = new System.Drawing.Point(12, 12);
            this._coordSys.Name = "_coordSys";
            this._coordSys.Size = new System.Drawing.Size(284, 271);
            this._coordSys.TabIndex = 0;
            // 
            // _matrix
            // 
            this._matrix.Location = new System.Drawing.Point(311, 12);
            this._matrix.Name = "_matrix";
            this._matrix.Size = new System.Drawing.Size(122, 86);
            this._matrix.TabIndex = 1;
            // 
            // _vector
            // 
            this._vector.Location = new System.Drawing.Point(311, 104);
            this._vector.Name = "_vector";
            this._vector.Size = new System.Drawing.Size(122, 86);
            this._vector.TabIndex = 2;
            // 
            // _btnCalc
            // 
            this._btnCalc.Location = new System.Drawing.Point(328, 214);
            this._btnCalc.Name = "_btnCalc";
            this._btnCalc.Size = new System.Drawing.Size(104, 59);
            this._btnCalc.TabIndex = 3;
            this._btnCalc.Text = "Calculate";
            this._btnCalc.UseVisualStyleBackColor = true;
            this._btnCalc.Click += new System.EventHandler(this._btnCalc_Click);
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 311);
            this.Controls.Add(this._btnCalc);
            this.Controls.Add(this._vector);
            this.Controls.Add(this._matrix);
            this.Controls.Add(this._coordSys);
            this.Name = "TestView";
            this.Text = "TestView";
            this.ResumeLayout(false);

        }

        #endregion

        private CoordinateSystem _coordSys;
        private CtlMatrixInput _matrix;
        private CtlVectorInput _vector;
        private System.Windows.Forms.Button _btnCalc;
    }
}