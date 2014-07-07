namespace SoftwareProjekt.Forms
{
    partial class FrmFraktalChaos
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
            SoftwareProjekt.Classes.Math.Vector vector5 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix5 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector6 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix6 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector7 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix7 = new SoftwareProjekt.Classes.Math.Matrix();
            SoftwareProjekt.Classes.Math.Vector vector8 = new SoftwareProjekt.Classes.Math.Vector();
            SoftwareProjekt.Classes.Math.Matrix matrix8 = new SoftwareProjekt.Classes.Math.Matrix();
            this.lblNumIteration = new System.Windows.Forms.Label();
            this.butSaveFractal = new System.Windows.Forms.Button();
            this.cosFractal = new SoftwareProjekt.UserControls.CoordinateSystem();
            this._rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.grpIFS = new System.Windows.Forms.GroupBox();
            this._txtProp4 = new SoftwareProjekt.UserControls.FloatInput();
            this._ctlVector4 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._ctlMatrix4 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this._txtProp3 = new SoftwareProjekt.UserControls.FloatInput();
            this._ctlVector3 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._ctlMatrix3 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this._txtProp2 = new SoftwareProjekt.UserControls.FloatInput();
            this._ctlVector2 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._ctlMatrix2 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this._lblProp = new System.Windows.Forms.Label();
            this._txtProp1 = new SoftwareProjekt.UserControls.FloatInput();
            this._ctlVector1 = new SoftwareProjekt.UserControls.CtlVectorInput();
            this._ctlMatrix1 = new SoftwareProjekt.UserControls.CtlMatrixInput();
            this.lblHeader = new System.Windows.Forms.Label();
            this._txtIterationen = new SoftwareProjekt.UserControls.FloatInput();
            this._grpChoices = new System.Windows.Forms.GroupBox();
            this._btnTree = new System.Windows.Forms.Button();
            this._btnFern = new System.Windows.Forms.Button();
            this._btnSquare = new System.Windows.Forms.Button();
            this._lblIteration = new System.Windows.Forms.Label();
            this._lblSteps = new System.Windows.Forms.Label();
            this._txtSteps = new SoftwareProjekt.UserControls.FloatInput();
            this.grpIFS.SuspendLayout();
            this._grpChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumIteration
            // 
            this.lblNumIteration.AutoSize = true;
            this.lblNumIteration.Location = new System.Drawing.Point(9, 48);
            this.lblNumIteration.Name = "lblNumIteration";
            this.lblNumIteration.Size = new System.Drawing.Size(95, 13);
            this.lblNumIteration.TabIndex = 2;
            this.lblNumIteration.Text = "Anzahl Iterationen:";
            // 
            // butSaveFractal
            // 
            this.butSaveFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSaveFractal.Location = new System.Drawing.Point(401, 505);
            this.butSaveFractal.Name = "butSaveFractal";
            this.butSaveFractal.Size = new System.Drawing.Size(104, 23);
            this.butSaveFractal.TabIndex = 5;
            this.butSaveFractal.Text = "&Fraktal speichern";
            this.butSaveFractal.UseVisualStyleBackColor = true;
            this.butSaveFractal.Click += new System.EventHandler(this.butSaveFractal_Click);
            // 
            // cosFractal
            // 
            this.cosFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cosFractal.DoNotRefresh = false;
            this.cosFractal.Location = new System.Drawing.Point(433, 34);
            this.cosFractal.Name = "cosFractal";
            this.cosFractal.Size = new System.Drawing.Size(520, 412);
            this.cosFractal.TabIndex = 2;
            // 
            // _rtxtNotes
            // 
            this._rtxtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtxtNotes.Location = new System.Drawing.Point(9, 635);
            this._rtxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this._rtxtNotes.Name = "_rtxtNotes";
            this._rtxtNotes.Size = new System.Drawing.Size(478, 124);
            this._rtxtNotes.TabIndex = 6;
            this._rtxtNotes.Text = "";
            this._rtxtNotes.TextChanged += new System.EventHandler(this.rtxtNotes_TextChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(9, 614);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notizen:";
            // 
            // butStart
            // 
            this.butStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butStart.Location = new System.Drawing.Point(401, 474);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(104, 23);
            this.butStart.TabIndex = 4;
            this.butStart.Text = "&Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // grpIFS
            // 
            this.grpIFS.Controls.Add(this._txtProp4);
            this.grpIFS.Controls.Add(this._ctlVector4);
            this.grpIFS.Controls.Add(this._ctlMatrix4);
            this.grpIFS.Controls.Add(this._txtProp3);
            this.grpIFS.Controls.Add(this._ctlVector3);
            this.grpIFS.Controls.Add(this._ctlMatrix3);
            this.grpIFS.Controls.Add(this._txtProp2);
            this.grpIFS.Controls.Add(this._ctlVector2);
            this.grpIFS.Controls.Add(this._ctlMatrix2);
            this.grpIFS.Controls.Add(this._lblProp);
            this.grpIFS.Controls.Add(this._txtProp1);
            this.grpIFS.Controls.Add(this._ctlVector1);
            this.grpIFS.Controls.Add(this._ctlMatrix1);
            this.grpIFS.Location = new System.Drawing.Point(12, 71);
            this.grpIFS.Name = "grpIFS";
            this.grpIFS.Size = new System.Drawing.Size(336, 411);
            this.grpIFS.TabIndex = 3;
            this.grpIFS.TabStop = false;
            this.grpIFS.Text = "IFS";
            // 
            // _txtProp4
            // 
            this._txtProp4.BackColor = System.Drawing.Color.Red;
            this._txtProp4.Location = new System.Drawing.Point(11, 332);
            this._txtProp4.Name = "_txtProp4";
            this._txtProp4.Size = new System.Drawing.Size(61, 20);
            this._txtProp4.TabIndex = 12;
            // 
            // _ctlVector4
            // 
            this._ctlVector4.EnableText = true;
            this._ctlVector4.Location = new System.Drawing.Point(228, 304);
            this._ctlVector4.MinimumSize = new System.Drawing.Size(102, 76);
            this._ctlVector4.Name = "_ctlVector4";
            this._ctlVector4.Size = new System.Drawing.Size(102, 89);
            this._ctlVector4.TabIndex = 11;
            vector5.X1 = float.NaN;
            vector5.X2 = float.NaN;
            this._ctlVector4.Vector = vector5;
            // 
            // _ctlMatrix4
            // 
            this._ctlMatrix4.EnableText = true;
            this._ctlMatrix4.Location = new System.Drawing.Point(97, 304);
            matrix5.X11 = float.NaN;
            matrix5.X12 = float.NaN;
            matrix5.X21 = float.NaN;
            matrix5.X22 = float.NaN;
            this._ctlMatrix4.Matrix = matrix5;
            this._ctlMatrix4.MinimumSize = new System.Drawing.Size(98, 76);
            this._ctlMatrix4.Name = "_ctlMatrix4";
            this._ctlMatrix4.Size = new System.Drawing.Size(125, 89);
            this._ctlMatrix4.TabIndex = 10;
            // 
            // _txtProp3
            // 
            this._txtProp3.BackColor = System.Drawing.Color.Red;
            this._txtProp3.Location = new System.Drawing.Point(11, 237);
            this._txtProp3.Name = "_txtProp3";
            this._txtProp3.Size = new System.Drawing.Size(61, 20);
            this._txtProp3.TabIndex = 9;
            // 
            // _ctlVector3
            // 
            this._ctlVector3.EnableText = true;
            this._ctlVector3.Location = new System.Drawing.Point(228, 209);
            this._ctlVector3.MinimumSize = new System.Drawing.Size(102, 76);
            this._ctlVector3.Name = "_ctlVector3";
            this._ctlVector3.Size = new System.Drawing.Size(102, 89);
            this._ctlVector3.TabIndex = 8;
            vector6.X1 = float.NaN;
            vector6.X2 = float.NaN;
            this._ctlVector3.Vector = vector6;
            // 
            // _ctlMatrix3
            // 
            this._ctlMatrix3.EnableText = true;
            this._ctlMatrix3.Location = new System.Drawing.Point(97, 209);
            matrix6.X11 = float.NaN;
            matrix6.X12 = float.NaN;
            matrix6.X21 = float.NaN;
            matrix6.X22 = float.NaN;
            this._ctlMatrix3.Matrix = matrix6;
            this._ctlMatrix3.MinimumSize = new System.Drawing.Size(98, 76);
            this._ctlMatrix3.Name = "_ctlMatrix3";
            this._ctlMatrix3.Size = new System.Drawing.Size(125, 89);
            this._ctlMatrix3.TabIndex = 7;
            // 
            // _txtProp2
            // 
            this._txtProp2.BackColor = System.Drawing.Color.Red;
            this._txtProp2.Location = new System.Drawing.Point(11, 134);
            this._txtProp2.Name = "_txtProp2";
            this._txtProp2.Size = new System.Drawing.Size(61, 20);
            this._txtProp2.TabIndex = 6;
            // 
            // _ctlVector2
            // 
            this._ctlVector2.EnableText = true;
            this._ctlVector2.Location = new System.Drawing.Point(228, 114);
            this._ctlVector2.MinimumSize = new System.Drawing.Size(102, 76);
            this._ctlVector2.Name = "_ctlVector2";
            this._ctlVector2.Size = new System.Drawing.Size(102, 89);
            this._ctlVector2.TabIndex = 5;
            vector7.X1 = float.NaN;
            vector7.X2 = float.NaN;
            this._ctlVector2.Vector = vector7;
            // 
            // _ctlMatrix2
            // 
            this._ctlMatrix2.EnableText = true;
            this._ctlMatrix2.Location = new System.Drawing.Point(97, 114);
            matrix7.X11 = float.NaN;
            matrix7.X12 = float.NaN;
            matrix7.X21 = float.NaN;
            matrix7.X22 = float.NaN;
            this._ctlMatrix2.Matrix = matrix7;
            this._ctlMatrix2.MinimumSize = new System.Drawing.Size(98, 76);
            this._ctlMatrix2.Name = "_ctlMatrix2";
            this._ctlMatrix2.Size = new System.Drawing.Size(125, 89);
            this._ctlMatrix2.TabIndex = 4;
            // 
            // _lblProp
            // 
            this._lblProp.AutoSize = true;
            this._lblProp.Location = new System.Drawing.Point(5, 19);
            this._lblProp.Name = "_lblProp";
            this._lblProp.Size = new System.Drawing.Size(97, 26);
            this._lblProp.TabIndex = 3;
            this._lblProp.Text = "Wahrscheinlichkeit\r\n in Prozent:";
            // 
            // _txtProp1
            // 
            this._txtProp1.BackColor = System.Drawing.Color.Red;
            this._txtProp1.Location = new System.Drawing.Point(11, 48);
            this._txtProp1.Name = "_txtProp1";
            this._txtProp1.Size = new System.Drawing.Size(61, 20);
            this._txtProp1.TabIndex = 2;
            // 
            // _ctlVector1
            // 
            this._ctlVector1.EnableText = true;
            this._ctlVector1.Location = new System.Drawing.Point(228, 19);
            this._ctlVector1.MinimumSize = new System.Drawing.Size(102, 76);
            this._ctlVector1.Name = "_ctlVector1";
            this._ctlVector1.Size = new System.Drawing.Size(102, 89);
            this._ctlVector1.TabIndex = 1;
            vector8.X1 = float.NaN;
            vector8.X2 = float.NaN;
            this._ctlVector1.Vector = vector8;
            // 
            // _ctlMatrix1
            // 
            this._ctlMatrix1.EnableText = true;
            this._ctlMatrix1.Location = new System.Drawing.Point(97, 19);
            matrix8.X11 = float.NaN;
            matrix8.X12 = float.NaN;
            matrix8.X21 = float.NaN;
            matrix8.X22 = float.NaN;
            this._ctlMatrix1.Matrix = matrix8;
            this._ctlMatrix1.MinimumSize = new System.Drawing.Size(98, 76);
            this._ctlMatrix1.Name = "_ctlMatrix1";
            this._ctlMatrix1.Size = new System.Drawing.Size(125, 89);
            this._ctlMatrix1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(228, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(334, 24);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Thema: Fraktal rendern mit Chaosspiel";
            // 
            // _txtIterationen
            // 
            this._txtIterationen.BackColor = System.Drawing.Color.White;
            this._txtIterationen.Location = new System.Drawing.Point(110, 45);
            this._txtIterationen.Name = "_txtIterationen";
            this._txtIterationen.Size = new System.Drawing.Size(46, 20);
            this._txtIterationen.TabIndex = 8;
            this._txtIterationen.Text = "1";
            // 
            // _grpChoices
            // 
            this._grpChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._grpChoices.Controls.Add(this._btnTree);
            this._grpChoices.Controls.Add(this._btnFern);
            this._grpChoices.Controls.Add(this._btnSquare);
            this._grpChoices.Location = new System.Drawing.Point(582, 452);
            this._grpChoices.Name = "_grpChoices";
            this._grpChoices.Size = new System.Drawing.Size(199, 123);
            this._grpChoices.TabIndex = 9;
            this._grpChoices.TabStop = false;
            this._grpChoices.Text = "Beispiele";
            // 
            // _btnTree
            // 
            this._btnTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnTree.Location = new System.Drawing.Point(6, 84);
            this._btnTree.Name = "_btnTree";
            this._btnTree.Size = new System.Drawing.Size(181, 28);
            this._btnTree.TabIndex = 2;
            this._btnTree.Text = "fraktaler Baum";
            this._btnTree.UseVisualStyleBackColor = true;
            this._btnTree.Click += new System.EventHandler(this._btnTree_Click);
            // 
            // _btnFern
            // 
            this._btnFern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFern.Location = new System.Drawing.Point(6, 50);
            this._btnFern.Name = "_btnFern";
            this._btnFern.Size = new System.Drawing.Size(181, 28);
            this._btnFern.TabIndex = 1;
            this._btnFern.Text = "Farn";
            this._btnFern.UseVisualStyleBackColor = true;
            this._btnFern.Click += new System.EventHandler(this._btnFern_Click);
            // 
            // _btnSquare
            // 
            this._btnSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnSquare.Location = new System.Drawing.Point(6, 19);
            this._btnSquare.Name = "_btnSquare";
            this._btnSquare.Size = new System.Drawing.Size(181, 28);
            this._btnSquare.TabIndex = 0;
            this._btnSquare.Text = "Quadrat";
            this._btnSquare.UseVisualStyleBackColor = true;
            this._btnSquare.Click += new System.EventHandler(this._btnSquare_Click);
            // 
            // _lblIteration
            // 
            this._lblIteration.AutoSize = true;
            this._lblIteration.Location = new System.Drawing.Point(733, 45);
            this._lblIteration.Name = "_lblIteration";
            this._lblIteration.Size = new System.Drawing.Size(48, 13);
            this._lblIteration.TabIndex = 10;
            this._lblIteration.Text = "Iteration:";
            // 
            // _lblSteps
            // 
            this._lblSteps.AutoSize = true;
            this._lblSteps.Location = new System.Drawing.Point(166, 48);
            this._lblSteps.Name = "_lblSteps";
            this._lblSteps.Size = new System.Drawing.Size(125, 13);
            this._lblSteps.TabIndex = 11;
            this._lblSteps.Text = "Anzahl Rendervorgänge:";
            // 
            // _txtSteps
            // 
            this._txtSteps.BackColor = System.Drawing.Color.White;
            this._txtSteps.Location = new System.Drawing.Point(297, 45);
            this._txtSteps.Name = "_txtSteps";
            this._txtSteps.Size = new System.Drawing.Size(43, 20);
            this._txtSteps.TabIndex = 12;
            this._txtSteps.Text = "10";
            // 
            // FrmFraktalChaos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 784);
            this.Controls.Add(this._txtSteps);
            this.Controls.Add(this._lblSteps);
            this.Controls.Add(this._lblIteration);
            this.Controls.Add(this._grpChoices);
            this.Controls.Add(this._txtIterationen);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblNumIteration);
            this.Controls.Add(this.grpIFS);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this._rtxtNotes);
            this.Controls.Add(this.cosFractal);
            this.Controls.Add(this.butSaveFractal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "FrmFraktalChaos";
            this.Text = "Fraktal rendern mit Chaosspiel ";
            this.grpIFS.ResumeLayout(false);
            this.grpIFS.PerformLayout();
            this._grpChoices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumIteration;
        private System.Windows.Forms.Button butSaveFractal;
        private SoftwareProjekt.UserControls.CoordinateSystem cosFractal;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.GroupBox grpIFS;
        private System.Windows.Forms.Label lblHeader;
        private UserControls.FloatInput _txtProp4;
        private UserControls.CtlVectorInput _ctlVector4;
        private UserControls.CtlMatrixInput _ctlMatrix4;
        private UserControls.FloatInput _txtProp3;
        private UserControls.CtlVectorInput _ctlVector3;
        private UserControls.CtlMatrixInput _ctlMatrix3;
        private UserControls.FloatInput _txtProp2;
        private UserControls.CtlVectorInput _ctlVector2;
        private UserControls.CtlMatrixInput _ctlMatrix2;
        private System.Windows.Forms.Label _lblProp;
        private UserControls.FloatInput _txtProp1;
        private UserControls.CtlVectorInput _ctlVector1;
        private UserControls.CtlMatrixInput _ctlMatrix1;
        private UserControls.FloatInput _txtIterationen;
        private System.Windows.Forms.GroupBox _grpChoices;
        private System.Windows.Forms.Button _btnTree;
        private System.Windows.Forms.Button _btnFern;
        private System.Windows.Forms.Button _btnSquare;
        private System.Windows.Forms.Label _lblIteration;
        private System.Windows.Forms.Label _lblSteps;
        private UserControls.FloatInput _txtSteps;
#if DEBUG
        private System.Windows.Forms.RichTextBox _rtxtNotes;
#endif
    }
}