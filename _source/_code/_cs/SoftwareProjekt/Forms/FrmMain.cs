
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
using System.Collections.Generic;

namespace SoftwareProjekt.Forms
{
    // AbstractView
    public class FrmMain : Form
    {
        private TabControl tabMainMenu;
        private TabPage tabMenu;
        private TabPage tabNotebook;
        private FlowLayoutPanel flpWorkbook;
        private PictureBox picWorkbook;
        private Label lblExercisebookTitle;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbutNewExercisebook;
        private ToolStripButton tsbutLoadExercisebook;
        private ToolStripButton tsbutCloseExercisebook;
        private ToolStripButton tsbutExport;
        private ToolStripSeparator tssExerciseBook;
        private ToolStripButton tsbutNewExercise;
        private ToolStripButton tsbutLoadExercise;
        private ToolStripButton tsbutDeleteExercise;
        private ToolStripSeparator tssInstruction;
        private ToolStripLabel tslblInstructions;
        private ToolStripTextBox tstbxInput;
        private ToolStripComboBox tscbxInput;
        private ToolStripButton tsbutNewExerciseType;
        private TabPage tabProtectArea;
        private ToolStripButton tsbutAccept;

        private Dictionary<TabPage, ToolStripButton[]> _controlDictionary =
    new Dictionary<TabPage, ToolStripButton[]>();

        public FrmMain()
        {
            InitializeComponent();
            InitializeDictionary();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabMainMenu = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.lblExercisebookTitle = new System.Windows.Forms.Label();
            this.tabNotebook = new System.Windows.Forms.TabPage();
            this.picWorkbook = new System.Windows.Forms.PictureBox();
            this.flpWorkbook = new System.Windows.Forms.FlowLayoutPanel();
            this.tabProtectArea = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbutNewExercisebook = new System.Windows.Forms.ToolStripButton();
            this.tsbutLoadExercisebook = new System.Windows.Forms.ToolStripButton();
            this.tsbutCloseExercisebook = new System.Windows.Forms.ToolStripButton();
            this.tsbutExport = new System.Windows.Forms.ToolStripButton();
            this.tssExerciseBook = new System.Windows.Forms.ToolStripSeparator();
            this.tsbutNewExercise = new System.Windows.Forms.ToolStripButton();
            this.tsbutLoadExercise = new System.Windows.Forms.ToolStripButton();
            this.tsbutDeleteExercise = new System.Windows.Forms.ToolStripButton();
            this.tssInstruction = new System.Windows.Forms.ToolStripSeparator();
            this.tslblInstructions = new System.Windows.Forms.ToolStripLabel();
            this.tstbxInput = new System.Windows.Forms.ToolStripTextBox();
            this.tscbxInput = new System.Windows.Forms.ToolStripComboBox();
            this.tsbutNewExerciseType = new System.Windows.Forms.ToolStripButton();
            this.tsbutAccept = new System.Windows.Forms.ToolStripButton();
            this.tabMainMenu.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabNotebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkbook)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.tabMainMenu.SelectedIndexChanged += new System.EventHandler(this.tabMainMenu_SelectedIndexChanged);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.lblExercisebookTitle);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1223, 636);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Start";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // lblExercisebookTitle
            // 
            this.lblExercisebookTitle.AutoSize = true;
            this.lblExercisebookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercisebookTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblExercisebookTitle.Location = new System.Drawing.Point(17, 14);
            this.lblExercisebookTitle.Name = "lblExercisebookTitle";
            this.lblExercisebookTitle.Size = new System.Drawing.Size(502, 24);
            this.lblExercisebookTitle.TabIndex = 0;
            this.lblExercisebookTitle.Text = "Anzeige Arbeitsbuchname nur wenn Arbeitsbuch geöffnet!";
            this.lblExercisebookTitle.Visible = false;
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
            this.tabProtectArea.Location = new System.Drawing.Point(4, 22);
            this.tabProtectArea.Name = "tabProtectArea";
            this.tabProtectArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtectArea.Size = new System.Drawing.Size(1223, 636);
            this.tabProtectArea.TabIndex = 2;
            this.tabProtectArea.Text = "Administration";
            this.tabProtectArea.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbutNewExercisebook,
            this.tsbutLoadExercisebook,
            this.tsbutCloseExercisebook,
            this.tsbutExport,
            this.tssExerciseBook,
            this.tsbutNewExercise,
            this.tsbutLoadExercise,
            this.tsbutDeleteExercise,
            this.tssInstruction,
            this.tslblInstructions,
            this.tstbxInput,
            this.tscbxInput,
            this.tsbutNewExerciseType,
            this.tsbutAccept});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1255, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbutNewExercisebook
            // 
            this.tsbutNewExercisebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutNewExercisebook.Image = ((System.Drawing.Image)(resources.GetObject("tsbutNewExercisebook.Image")));
            this.tsbutNewExercisebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutNewExercisebook.Name = "tsbutNewExercisebook";
            this.tsbutNewExercisebook.Size = new System.Drawing.Size(114, 22);
            this.tsbutNewExercisebook.Text = "Arbeitsheft &anlegen";
            this.tsbutNewExercisebook.Click += new System.EventHandler(this.tsbutNewExercisebook_Click);
            // 
            // tsbutLoadExercisebook
            // 
            this.tsbutLoadExercisebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutLoadExercisebook.Image = ((System.Drawing.Image)(resources.GetObject("tsbutLoadExercisebook.Image")));
            this.tsbutLoadExercisebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutLoadExercisebook.Name = "tsbutLoadExercisebook";
            this.tsbutLoadExercisebook.Size = new System.Drawing.Size(101, 22);
            this.tsbutLoadExercisebook.Text = "Arbeitsheft &laden";
            this.tsbutLoadExercisebook.Click += new System.EventHandler(this.tsbutLoadExercisebook_Click);
            // 
            // tsbutCloseExercisebook
            // 
            this.tsbutCloseExercisebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutCloseExercisebook.Enabled = false;
            this.tsbutCloseExercisebook.Image = ((System.Drawing.Image)(resources.GetObject("tsbutCloseExercisebook.Image")));
            this.tsbutCloseExercisebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutCloseExercisebook.Name = "tsbutCloseExercisebook";
            this.tsbutCloseExercisebook.Size = new System.Drawing.Size(122, 22);
            this.tsbutCloseExercisebook.Text = "Arbeitsheft &schließen";
            // 
            // tsbutExport
            // 
            this.tsbutExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbutExport.Image")));
            this.tsbutExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutExport.Name = "tsbutExport";
            this.tsbutExport.Size = new System.Drawing.Size(131, 22);
            this.tsbutExport.Text = "Arbeitsheft &exportieren";
            this.tsbutExport.Visible = false;
            // 
            // tssExerciseBook
            // 
            this.tssExerciseBook.Name = "tssExerciseBook";
            this.tssExerciseBook.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbutNewExercise
            // 
            this.tsbutNewExercise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutNewExercise.Enabled = false;
            this.tsbutNewExercise.Image = ((System.Drawing.Image)(resources.GetObject("tsbutNewExercise.Image")));
            this.tsbutNewExercise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutNewExercise.Name = "tsbutNewExercise";
            this.tsbutNewExercise.Size = new System.Drawing.Size(78, 22);
            this.tsbutNewExercise.Text = "&Neue Übung";
            // 
            // tsbutLoadExercise
            // 
            this.tsbutLoadExercise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutLoadExercise.Image = ((System.Drawing.Image)(resources.GetObject("tsbutLoadExercise.Image")));
            this.tsbutLoadExercise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutLoadExercise.Name = "tsbutLoadExercise";
            this.tsbutLoadExercise.Size = new System.Drawing.Size(79, 22);
            this.tsbutLoadExercise.Text = "Übung laden";
            this.tsbutLoadExercise.Visible = false;
            // 
            // tsbutDeleteExercise
            // 
            this.tsbutDeleteExercise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutDeleteExercise.Image = ((System.Drawing.Image)(resources.GetObject("tsbutDeleteExercise.Image")));
            this.tsbutDeleteExercise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutDeleteExercise.Name = "tsbutDeleteExercise";
            this.tsbutDeleteExercise.Size = new System.Drawing.Size(91, 22);
            this.tsbutDeleteExercise.Text = "Übung löschen";
            this.tsbutDeleteExercise.Visible = false;
            // 
            // tssInstruction
            // 
            this.tssInstruction.Name = "tssInstruction";
            this.tssInstruction.Size = new System.Drawing.Size(6, 25);
            // 
            // tslblInstructions
            // 
            this.tslblInstructions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblInstructions.ForeColor = System.Drawing.Color.OrangeRed;
            this.tslblInstructions.Name = "tslblInstructions";
            this.tslblInstructions.Size = new System.Drawing.Size(254, 22);
            this.tslblInstructions.Text = "Bitte Arbeitsheft anlegen oder laden!";
            // 
            // tstbxInput
            // 
            this.tstbxInput.Name = "tstbxInput";
            this.tstbxInput.Size = new System.Drawing.Size(100, 25);
            this.tstbxInput.Visible = false;
            // 
            // tscbxInput
            // 
            this.tscbxInput.Name = "tscbxInput";
            this.tscbxInput.Size = new System.Drawing.Size(121, 25);
            this.tscbxInput.Visible = false;
            // 
            // tsbutNewExerciseType
            // 
            this.tsbutNewExerciseType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutNewExerciseType.Image = ((System.Drawing.Image)(resources.GetObject("tsbutNewExerciseType.Image")));
            this.tsbutNewExerciseType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutNewExerciseType.Name = "tsbutNewExerciseType";
            this.tsbutNewExerciseType.Size = new System.Drawing.Size(84, 22);
            this.tsbutNewExerciseType.Text = "Neues Thema";
            this.tsbutNewExerciseType.Visible = false;
            // 
            // tsbutAccept
            // 
            this.tsbutAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutAccept.Image = ((System.Drawing.Image)(resources.GetObject("tsbutAccept.Image")));
            this.tsbutAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutAccept.Name = "tsbutAccept";
            this.tsbutAccept.Size = new System.Drawing.Size(27, 19);
            this.tsbutAccept.Text = "OK";
            this.tsbutAccept.Visible = false;
            this.tsbutAccept.Click += new System.EventHandler(this.tsbutAccept_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1255, 701);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "Hauptfenster";
            this.tabMainMenu.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.tabNotebook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWorkbook)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeDictionary()
        {
            _controlDictionary.Clear();
            // Buttons from Start
            ToolStripButton[] startButtons = { this.tsbutNewExercise, 
                this.tsbutNewExercisebook, this.tsbutLoadExercisebook,
                this.tsbutCloseExercisebook, this.tsbutAccept};
            ToolStripButton[] notebookButtons = {this.tsbutDeleteExercise, 
                this.tsbutDeleteExercise, this.tsbutLoadExercise,
                this.tsbutExport};
            ToolStripButton[] adminButtons = {this.tsbutNewExerciseType};
            _controlDictionary.Add(tabMenu, startButtons);
            _controlDictionary.Add(tabNotebook, notebookButtons);
            _controlDictionary.Add(tabProtectArea, adminButtons);
        }

        private void showTabButtonsHideOthers(TabPage selectedTab)
        {
            Dictionary<TabPage, ToolStripButton[]> tempDictionary =
                new Dictionary<TabPage, ToolStripButton[]>();
            ToolStripButton[] showButtons = { };
            ToolStripButton[] hideButtons = { };

            tempDictionary = _controlDictionary;
            _controlDictionary.TryGetValue(selectedTab, out showButtons); // create Liste with buttons to show
            tempDictionary.Remove(selectedTab);

            if (showButtons == null) return; // prevent exception
            foreach (ToolStripButton but in showButtons)
            {
                but.Visible = true;
            }
            foreach (KeyValuePair<TabPage, ToolStripButton[]> i in tempDictionary) // hide all buttons in tempDictionary
            {
                foreach (ToolStripButton but in i.Value)
                {
                    but.Visible = false;
                }
            }
            InitializeDictionary(); // even if not visible - the class Dictionary was changed unintentionally
            
        }



        private void tabMainMenu_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabMainMenu.SelectedTab == tabMenu)
            { // show buttons from Start tab
                tslblInstructions.Text = "Bitte Arbeitsheft anlegen oder laden"; // TODO: unless Exercisebook is open!
                showTabButtonsHideOthers(tabMenu);
                this.tsbutAccept.Visible = false;
            }
            else if (tabMainMenu.SelectedTab == tabNotebook)
            {
                tslblInstructions.Text = "";
                showTabButtonsHideOthers(tabNotebook);
                tstbxInput.Visible = false;
                tscbxInput.Visible = false;

            }
            else // Administration tab
            {
                tslblInstructions.Text = "";
                showTabButtonsHideOthers(tabProtectArea);
                tstbxInput.Visible = false;
                tscbxInput.Visible = false;
            }
        }

        private void tsbutNewExercisebook_Click(object sender, System.EventArgs e)
        {
            tslblInstructions.Text = "Bitte Namen eingeben: ";
            tstbxInput.Visible = true;
            tsbutAccept.Visible = true;
        }

        private void tsbutLoadExercisebook_Click(object sender, System.EventArgs e)
        {
            tslblInstructions.Text = "Bitte Arbeitsbuch wählen: ";
            tscbxInput.Visible = true;
            tsbutAccept.Visible = true;

            // TODO: fill combobox with available exercisebooks or give a appropiate message if none available
        }

        private void tsbutAccept_Click(object sender, System.EventArgs e)
        {
            tslblInstructions.Text = "";
            if (tscbxInput.Visible)
            {
                tscbxInput.Visible = false;
                // TODO: load ExerciseBook
            }
            else
            {
                tstbxInput.Visible = false;
                // TODO: create ExerciseBook
            }
            tsbutAccept.Visible = false;

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
