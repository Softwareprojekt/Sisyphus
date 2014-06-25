
#region LicenseHeader
/*
 * Copyright (C) 2014 Technische Hochschule Amberg
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
#endregion

using SoftwareProjekt.UserControls.MindMap;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwareProjekt.Forms
{
    // AbstractView
    public class FrmMain : Form
    {
        private TabControl tabMainMenu;
        private TabPage tabMenu;
        private TabPage tabNotebook;
        private GroupBox grpLogin;
        private Label lblPassword;
        private Label lblUser;
        private TextBox textPassword;
        private TextBox txtUser;
        private FlowLayoutPanel flpWorkbook;
        private PictureBox picWorkbook;
        private TabPage tabProtectArea;

        public FrmMain()
        {
            InitializeComponent();
            SoftwareProjekt.Classes.Workbook.Instance.AddEntries(flpWorkbook.Controls, picWorkbook);  
        }

        public CtlMindMap MindMap
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void InitializeComponent()
        {
            this.tabMainMenu = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tabNotebook = new System.Windows.Forms.TabPage();
            this.picWorkbook = new System.Windows.Forms.PictureBox();
            this.flpWorkbook = new System.Windows.Forms.FlowLayoutPanel();
            this.tabProtectArea = new System.Windows.Forms.TabPage();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tabMainMenu.SuspendLayout();
            this.tabNotebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkbook)).BeginInit();
            this.tabProtectArea.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainMenu
            // 
            this.tabMainMenu.Controls.Add(this.tabMenu);
            this.tabMainMenu.Controls.Add(this.tabNotebook);
            this.tabMainMenu.Controls.Add(this.tabProtectArea);
            this.tabMainMenu.Location = new System.Drawing.Point(12, 27);
            this.tabMainMenu.Name = "tabMainMenu";
            this.tabMainMenu.SelectedIndex = 0;
            this.tabMainMenu.Size = new System.Drawing.Size(1231, 662);
            this.tabMainMenu.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1223, 636);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Übungen";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // tabNotebook
            // 
            this.tabNotebook.Controls.Add(this.picWorkbook);
            this.tabNotebook.Controls.Add(this.flpWorkbook);
            this.tabNotebook.Location = new System.Drawing.Point(4, 22);
            this.tabNotebook.Name = "tabNotebook";
            this.tabNotebook.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotebook.Size = new System.Drawing.Size(1223, 636);
            this.tabNotebook.TabIndex = 1;
            this.tabNotebook.Text = "Arbeitsheft";
            this.tabNotebook.UseVisualStyleBackColor = true;
            // 
            // picWorkbook
            // 
            this.picWorkbook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picWorkbook.Location = new System.Drawing.Point(7, 7);
            this.picWorkbook.Name = "picWorkbook";
            this.picWorkbook.Size = new System.Drawing.Size(897, 623);
            this.picWorkbook.TabIndex = 1;
            this.picWorkbook.TabStop = false;
            // 
            // flpWorkbook
            // 
            this.flpWorkbook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpWorkbook.AutoScroll = true;
            this.flpWorkbook.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpWorkbook.Location = new System.Drawing.Point(910, 3);
            this.flpWorkbook.Name = "flpWorkbook";
            this.flpWorkbook.Size = new System.Drawing.Size(310, 630);
            this.flpWorkbook.TabIndex = 0;
            this.flpWorkbook.WrapContents = false;
            // 
            // tabProtectArea
            // 
            this.tabProtectArea.Controls.Add(this.grpLogin);
            this.tabProtectArea.Location = new System.Drawing.Point(4, 22);
            this.tabProtectArea.Name = "tabProtectArea";
            this.tabProtectArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtectArea.Size = new System.Drawing.Size(1223, 636);
            this.tabProtectArea.TabIndex = 2;
            this.tabProtectArea.Text = "Geschützter Bereich";
            this.tabProtectArea.UseVisualStyleBackColor = true;
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.lblUser);
            this.grpLogin.Controls.Add(this.textPassword);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.Location = new System.Drawing.Point(506, 240);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(206, 106);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 66);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Passwort:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(78, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Benutzername:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(90, 63);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(90, 37);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1255, 701);
            this.Controls.Add(this.tabMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "Hauptfenster";
            this.tabMainMenu.ResumeLayout(false);
            this.tabNotebook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWorkbook)).EndInit();
            this.tabProtectArea.ResumeLayout(false);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

      
        /*
                private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.Filter = "bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filename = openFileDialog1.FileName;


                        FileStream imageStream = new FileStream(filename, FileMode.Open, FileAccess.Read);


                    }
                }

                private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    SaveFileDialog safeFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                    saveFileDialog1.FilterIndex = 2;


                    if (safeFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        int width = Convert.ToInt32(Width);
                        int height = Convert.ToInt32(Height);
                        Bitmap bmp = new Bitmap(width, height);
                        DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                        bmp.Save(safeFileDialog1.FileName);


                        //Zielbild speichern!
                        //string filename = safeFileDialog1.FileName;
                        //if ((pictureBox2.Image != null))
                        //{
                        //    pictureBox2.Image.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Fehler", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        //}
                    }
                }

                private void druckenToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    PrintDialog printDialog1 = new PrintDialog();
                    printDialog1.Document = printDocument1;
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
        
                public override void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
                {
                    throw new NotImplementedException();
                }
                */
    }
}
