
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
using SoftwareProjekt.Classes;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using SoftwareProjekt.Exercises;
using SoftwareProjekt.Enums;
using System;

namespace SoftwareProjekt.Forms
{
    // AbstractView
    public class FrmMain : AbstractView
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
        private GroupBox gbxColor;
        private Button butColorInstructions;
        private Button butColorResult;
        private Button butColorInput;
        private GroupBox gbxExerciseSpecification;
        private ColorDialog colorDialog1;
        private Button butTestExercise;
        private ComboBox _cbExercise;

        private Dictionary<TabPage, ToolStripButton[]> _controlDictionary =
    new Dictionary<TabPage, ToolStripButton[]>();

        public FrmMain()
        {
            InitializeComponent();
            _controlDictionary = InitializeDictionary();
            _cbExercise.Items.AddRange(Enum.GetNames(typeof(EExercises)));
            _cbExercise.SelectedIndex = 0;
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
            this._cbExercise = new System.Windows.Forms.ComboBox();
            this.butTestExercise = new System.Windows.Forms.Button();
            this.lblExercisebookTitle = new System.Windows.Forms.Label();
            this.tabNotebook = new System.Windows.Forms.TabPage();
            this.picWorkbook = new System.Windows.Forms.PictureBox();
            this.flpWorkbook = new System.Windows.Forms.FlowLayoutPanel();
            this.tabProtectArea = new System.Windows.Forms.TabPage();
            this.gbxColor = new System.Windows.Forms.GroupBox();
            this.butColorInstructions = new System.Windows.Forms.Button();
            this.butColorResult = new System.Windows.Forms.Button();
            this.butColorInput = new System.Windows.Forms.Button();
            this.gbxExerciseSpecification = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbutNewExercisebook = new System.Windows.Forms.ToolStripButton();
            this.tsbutLoadExercisebook = new System.Windows.Forms.ToolStripButton();
            this.tsbutCloseExercisebook = new System.Windows.Forms.ToolStripButton();
            this.tsbutExport = new System.Windows.Forms.ToolStripButton();
            this.tssExerciseBook = new System.Windows.Forms.ToolStripSeparator();
            this.tsbutNewExercise = new System.Windows.Forms.ToolStripButton();
            this.tsbutLoadExercise = new System.Windows.Forms.ToolStripButton();
            this.tsbutDeleteExercise = new System.Windows.Forms.ToolStripButton();
            this.tsbutNewExerciseType = new System.Windows.Forms.ToolStripButton();
            this.tssInstruction = new System.Windows.Forms.ToolStripSeparator();
            this.tslblInstructions = new System.Windows.Forms.ToolStripLabel();
            this.tstbxInput = new System.Windows.Forms.ToolStripTextBox();
            this.tscbxInput = new System.Windows.Forms.ToolStripComboBox();
            this.tsbutAccept = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabMainMenu.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabNotebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkbook)).BeginInit();
            this.tabProtectArea.SuspendLayout();
            this.gbxColor.SuspendLayout();
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
            this.tabMainMenu.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabMainMenu_Selecting);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this._cbExercise);
            this.tabMenu.Controls.Add(this.butTestExercise);
            this.tabMenu.Controls.Add(this.lblExercisebookTitle);
            this.tabMenu.Location = new System.Drawing.Point(4, 25);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1223, 633);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Start";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // _cbExercise
            // 
            this._cbExercise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbExercise.FormattingEnabled = true;
            this._cbExercise.Location = new System.Drawing.Point(842, 74);
            this._cbExercise.Name = "_cbExercise";
            this._cbExercise.Size = new System.Drawing.Size(281, 24);
            this._cbExercise.TabIndex = 2;
            // 
            // butTestExercise
            // 
            this.butTestExercise.Location = new System.Drawing.Point(842, 101);
            this.butTestExercise.Name = "butTestExercise";
            this.butTestExercise.Size = new System.Drawing.Size(281, 23);
            this.butTestExercise.TabIndex = 1;
            this.butTestExercise.Text = "Teste Uebung";
            this.butTestExercise.UseVisualStyleBackColor = true;
            this.butTestExercise.Click += new System.EventHandler(this.butTestExercise_Click);
            // 
            // lblExercisebookTitle
            // 
            this.lblExercisebookTitle.AutoSize = true;
            this.lblExercisebookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercisebookTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblExercisebookTitle.Location = new System.Drawing.Point(17, 14);
            this.lblExercisebookTitle.Name = "lblExercisebookTitle";
            this.lblExercisebookTitle.Size = new System.Drawing.Size(629, 29);
            this.lblExercisebookTitle.TabIndex = 0;
            this.lblExercisebookTitle.Text = "Anzeige Arbeitsbuchname nur wenn Arbeitsbuch geöffnet!";
            this.lblExercisebookTitle.Visible = false;
            // 
            // tabNotebook
            // 
            this.tabNotebook.Controls.Add(this.picWorkbook);
            this.tabNotebook.Controls.Add(this.flpWorkbook);
            this.tabNotebook.Location = new System.Drawing.Point(4, 25);
            this.tabNotebook.Name = "tabNotebook";
            this.tabNotebook.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotebook.Size = new System.Drawing.Size(1223, 633);
            this.tabNotebook.TabIndex = 1;
            this.tabNotebook.Text = "Arbeitsheft";
            this.tabNotebook.UseVisualStyleBackColor = true;
            // 
            // picWorkbook
            // 
            this.picWorkbook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picWorkbook.Enabled = false;
            this.picWorkbook.Location = new System.Drawing.Point(7, 7);
            this.picWorkbook.Name = "picWorkbook";
            this.picWorkbook.Size = new System.Drawing.Size(897, 620);
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
            this.flpWorkbook.Size = new System.Drawing.Size(310, 627);
            this.flpWorkbook.TabIndex = 0;
            this.flpWorkbook.WrapContents = false;
            // 
            // tabProtectArea
            // 
            this.tabProtectArea.Controls.Add(this.gbxColor);
            this.tabProtectArea.Controls.Add(this.gbxExerciseSpecification);
            this.tabProtectArea.Location = new System.Drawing.Point(4, 25);
            this.tabProtectArea.Name = "tabProtectArea";
            this.tabProtectArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtectArea.Size = new System.Drawing.Size(1223, 633);
            this.tabProtectArea.TabIndex = 2;
            this.tabProtectArea.Text = "Administration";
            this.tabProtectArea.UseVisualStyleBackColor = true;
            // 
            // gbxColor
            // 
            this.gbxColor.Controls.Add(this.butColorInstructions);
            this.gbxColor.Controls.Add(this.butColorResult);
            this.gbxColor.Controls.Add(this.butColorInput);
            this.gbxColor.Location = new System.Drawing.Point(718, 23);
            this.gbxColor.Name = "gbxColor";
            this.gbxColor.Size = new System.Drawing.Size(316, 533);
            this.gbxColor.TabIndex = 1;
            this.gbxColor.TabStop = false;
            this.gbxColor.Text = "Farbänderung:";
            // 
            // butColorInstructions
            // 
            this.butColorInstructions.Location = new System.Drawing.Point(175, 104);
            this.butColorInstructions.Name = "butColorInstructions";
            this.butColorInstructions.Size = new System.Drawing.Size(115, 23);
            this.butColorInstructions.TabIndex = 2;
            this.butColorInstructions.Text = "Anweisungen";
            this.butColorInstructions.UseVisualStyleBackColor = true;
            this.butColorInstructions.Click += new System.EventHandler(this.butColorInstructions_Click);
            // 
            // butColorResult
            // 
            this.butColorResult.Location = new System.Drawing.Point(175, 75);
            this.butColorResult.Name = "butColorResult";
            this.butColorResult.Size = new System.Drawing.Size(115, 23);
            this.butColorResult.TabIndex = 1;
            this.butColorResult.Text = "Ergebnisfelder";
            this.butColorResult.UseVisualStyleBackColor = true;
            this.butColorResult.Click += new System.EventHandler(this.butColorResult_Click);
            // 
            // butColorInput
            // 
            this.butColorInput.Location = new System.Drawing.Point(175, 46);
            this.butColorInput.Name = "butColorInput";
            this.butColorInput.Size = new System.Drawing.Size(115, 23);
            this.butColorInput.TabIndex = 0;
            this.butColorInput.Text = "Eingabefelder";
            this.butColorInput.UseVisualStyleBackColor = true;
            this.butColorInput.Click += new System.EventHandler(this.butColorInput_Click);
            // 
            // gbxExerciseSpecification
            // 
            this.gbxExerciseSpecification.Location = new System.Drawing.Point(20, 23);
            this.gbxExerciseSpecification.Name = "gbxExerciseSpecification";
            this.gbxExerciseSpecification.Size = new System.Drawing.Size(692, 533);
            this.gbxExerciseSpecification.TabIndex = 0;
            this.gbxExerciseSpecification.TabStop = false;
            this.gbxExerciseSpecification.Text = "Themaspezifizierung:";
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
            this.tsbutNewExerciseType,
            this.tssInstruction,
            this.tslblInstructions,
            this.tstbxInput,
            this.tscbxInput,
            this.tsbutAccept});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1255, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbutNewExercisebook
            // 
            this.tsbutNewExercisebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutNewExercisebook.Image = ((System.Drawing.Image)(resources.GetObject("tsbutNewExercisebook.Image")));
            this.tsbutNewExercisebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutNewExercisebook.Name = "tsbutNewExercisebook";
            this.tsbutNewExercisebook.Size = new System.Drawing.Size(143, 25);
            this.tsbutNewExercisebook.Text = "Arbeitsheft &anlegen";
            this.tsbutNewExercisebook.Click += new System.EventHandler(this.tsbutNewExercisebook_Click);
            // 
            // tsbutLoadExercisebook
            // 
            this.tsbutLoadExercisebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutLoadExercisebook.Image = ((System.Drawing.Image)(resources.GetObject("tsbutLoadExercisebook.Image")));
            this.tsbutLoadExercisebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutLoadExercisebook.Name = "tsbutLoadExercisebook";
            this.tsbutLoadExercisebook.Size = new System.Drawing.Size(127, 25);
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
            this.tsbutCloseExercisebook.Size = new System.Drawing.Size(151, 25);
            this.tsbutCloseExercisebook.Text = "Arbeitsheft &schließen";
            this.tsbutCloseExercisebook.Click += new System.EventHandler(this.tsbutCloseExercisebook_Click);
            // 
            // tsbutExport
            // 
            this.tsbutExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbutExport.Image")));
            this.tsbutExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutExport.Name = "tsbutExport";
            this.tsbutExport.Size = new System.Drawing.Size(166, 29);
            this.tsbutExport.Text = "Arbeitsheft &exportieren";
            this.tsbutExport.Visible = false;
            // 
            // tssExerciseBook
            // 
            this.tssExerciseBook.Name = "tssExerciseBook";
            this.tssExerciseBook.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbutNewExercise
            // 
            this.tsbutNewExercise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutNewExercise.Enabled = false;
            this.tsbutNewExercise.Image = ((System.Drawing.Image)(resources.GetObject("tsbutNewExercise.Image")));
            this.tsbutNewExercise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutNewExercise.Name = "tsbutNewExercise";
            this.tsbutNewExercise.Size = new System.Drawing.Size(96, 25);
            this.tsbutNewExercise.Text = "&Neue Übung";
            // 
            // tsbutLoadExercise
            // 
            this.tsbutLoadExercise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutLoadExercise.Image = ((System.Drawing.Image)(resources.GetObject("tsbutLoadExercise.Image")));
            this.tsbutLoadExercise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutLoadExercise.Name = "tsbutLoadExercise";
            this.tsbutLoadExercise.Size = new System.Drawing.Size(98, 29);
            this.tsbutLoadExercise.Text = "Übung laden";
            this.tsbutLoadExercise.Visible = false;
            // 
            // tsbutDeleteExercise
            // 
            this.tsbutDeleteExercise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutDeleteExercise.Image = ((System.Drawing.Image)(resources.GetObject("tsbutDeleteExercise.Image")));
            this.tsbutDeleteExercise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutDeleteExercise.Name = "tsbutDeleteExercise";
            this.tsbutDeleteExercise.Size = new System.Drawing.Size(111, 29);
            this.tsbutDeleteExercise.Text = "Übung löschen";
            this.tsbutDeleteExercise.Visible = false;
            // 
            // tsbutNewExerciseType
            // 
            this.tsbutNewExerciseType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutNewExerciseType.Image = ((System.Drawing.Image)(resources.GetObject("tsbutNewExerciseType.Image")));
            this.tsbutNewExerciseType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutNewExerciseType.Name = "tsbutNewExerciseType";
            this.tsbutNewExerciseType.Size = new System.Drawing.Size(103, 25);
            this.tsbutNewExerciseType.Text = "Neues Thema";
            this.tsbutNewExerciseType.Visible = false;
            // 
            // tssInstruction
            // 
            this.tssInstruction.Name = "tssInstruction";
            this.tssInstruction.Size = new System.Drawing.Size(6, 28);
            // 
            // tslblInstructions
            // 
            this.tslblInstructions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblInstructions.ForeColor = System.Drawing.Color.OrangeRed;
            this.tslblInstructions.Name = "tslblInstructions";
            this.tslblInstructions.Size = new System.Drawing.Size(321, 25);
            this.tslblInstructions.Text = "Bitte Arbeitsheft anlegen oder laden!";
            // 
            // tstbxInput
            // 
            this.tstbxInput.Name = "tstbxInput";
            this.tstbxInput.Size = new System.Drawing.Size(100, 28);
            this.tstbxInput.Visible = false;
            // 
            // tscbxInput
            // 
            this.tscbxInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxInput.Name = "tscbxInput";
            this.tscbxInput.Size = new System.Drawing.Size(121, 28);
            this.tscbxInput.Visible = false;
            // 
            // tsbutAccept
            // 
            this.tsbutAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutAccept.Image = ((System.Drawing.Image)(resources.GetObject("tsbutAccept.Image")));
            this.tsbutAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutAccept.Name = "tsbutAccept";
            this.tsbutAccept.Size = new System.Drawing.Size(33, 25);
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
            this.tabProtectArea.ResumeLayout(false);
            this.gbxColor.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Dictionary<TabPage, ToolStripButton[]> InitializeDictionary()
        {
            Dictionary<TabPage, ToolStripButton[]> aDictionary =
                new Dictionary<TabPage, ToolStripButton[]>();

            // if (isclassDictionary) aDictionary = _controlDictionary;
            // Buttons in Starttab
            ToolStripButton[] startButtons = { this.tsbutNewExercise, 
                this.tsbutNewExercisebook, this.tsbutLoadExercisebook,
                this.tsbutCloseExercisebook, this.tsbutAccept};
            // Buttons in Notebooktab
            ToolStripButton[] notebookButtons = {this.tsbutDeleteExercise, 
                this.tsbutDeleteExercise, this.tsbutLoadExercise,
                this.tsbutExport};
            // Buttons of Administrationtab
            ToolStripButton[] adminButtons = { this.tsbutNewExerciseType };
            aDictionary.Add(tabMenu, startButtons);
            aDictionary.Add(tabNotebook, notebookButtons);
            aDictionary.Add(tabProtectArea, adminButtons);
            return aDictionary;
        }

        private void showTabButtonsHideOthers(TabPage selectedTab)
        {
            Dictionary<TabPage, ToolStripButton[]> tempDictionary =
                new Dictionary<TabPage, ToolStripButton[]>();
            ToolStripButton[] showButtons = { };
            ToolStripButton[] hideButtons = { };

            tempDictionary = InitializeDictionary();
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
        }

        private void tabMainMenu_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // change visibility of buttons
            if (tabMainMenu.SelectedTab == tabMenu)
            { // show buttons from Start tab
                //if (Workbook.Username == null)
                if (Workbook.Instance.Username == null)
                {
                    tslblInstructions.Text = "Bitte Arbeitsheft anlegen oder laden";
                }
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
            List<string> usernames = Workbook.Instance.GetAvailableWorkbooks();
            if (usernames.ToArray().Length > 1) // several choices of books
            {
                tslblInstructions.Text = "Bitte Arbeitsbuch wählen: ";
                tscbxInput.Visible = true;
                tsbutAccept.Visible = true;
                tscbxInput.ComboBox.ValueMember = "Benutzernamen:";
                tscbxInput.ComboBox.Items.Clear();
                tscbxInput.ComboBox.Items.AddRange(usernames.ToArray());
            }
            else if (usernames.ToArray().Length > 0) // only one book exists
            {
                string usernameString = usernames.ToArray()[0];
                Workbook.Instance.Username = usernameString;
                if (Workbook.Instance.Username != null) // otherwise parsing xml file failed
                {
                    tslblInstructions.Text = "Arbeitsheft '" + usernameString + "' geladen.";
                }
                else tslblInstructions.Text = "Laden des Arbeitsheft fehlgeschlagen!";
            }
            else tslblInstructions.Text = "Kein Arbeitsbuch verfügbar!";
        }

        private void tsbutAccept_Click(object sender, System.EventArgs e)
        {
            tsbutCloseExercisebook.Enabled = true;

            if (tscbxInput.Visible)
            {
                tscbxInput.Visible = false;
                Workbook.Instance.Username = tscbxInput.Text;
                // load ExerciseBook
                if (Workbook.Instance.Username != null) // otherwise parsing xml file failed
                {
                    // show label with name of book
                    lblExercisebookTitle.Text = Workbook.Instance.Username;
                    lblExercisebookTitle.Visible = true;
                    // instructions
                    tslblInstructions.Text = "Beginne eine Übung über die Mindmap oder öffne eine Existierende im Arbeitsheft.";
                }
                else
                {
                    tslblInstructions.Text = "Laden der Arbeitsbuch-Datei schlug fehl!";
                    tsbutCloseExercisebook.Enabled = false;
                }
            }
            else
            {
                tstbxInput.Visible = false;
                // create ExerciseBook
                Workbook.Instance.Username = tstbxInput.Text;
                lblExercisebookTitle.Text = Workbook.Instance.Username;
                lblExercisebookTitle.Visible = true;
                tslblInstructions.Text = "";
                tslblInstructions.Text = "Beginne eine Übung über die Mindmap.";
            }
            tsbutAccept.Visible = false;
            // tsbutNewExercise.Enabled = true; // Note: this should only be enabled if a topic was selected
            // selecting a topic should only be possible if a exercisebook is open

        }

        private void butColorInput_Click(object sender, System.EventArgs e)
        {
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                tslblInstructions.Text = "Hinweis: Übungen neu öffnen, damit Änderungen wirksam werden!";
                this.inputColor = colorDialog1.Color;
            }
        }

        private void butColorResult_Click(object sender, System.EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tslblInstructions.Text = "Hinweis: Übungen neu öffnen, damit Änderungen wirksam werden!";
                this.resultColor = colorDialog1.Color;
            }
        }

        private void butColorInstructions_Click(object sender, System.EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tslblInstructions.Text = "Hinweis: Übungen neu öffnen, damit Änderungen wirksam werden!";
                instructionColor = colorDialog1.Color;
                tslblInstructions.ForeColor = colorDialog1.Color;
            }
        }

        private void butTestExercise_Click(object sender, System.EventArgs e)
        {
            this.OnViewChanged(new Classes.EventArguments.ViewEventArgs(Enums.EClickedButton.StartExercise, (EExercises)Enum.Parse(typeof(EExercises), _cbExercise.SelectedItem.ToString())));
        }

        private void tsbutCloseExercisebook_Click(object sender, System.EventArgs e)
        {
            Workbook.Instance.Username = null;
            tslblInstructions.Text = "Bitte ein Arbeitsbuch wählen!";
            tsbutCloseExercisebook.Enabled = false;
            tsbutNewExercise.Enabled = false;
            lblExercisebookTitle.Visible = false;
        }

        private void tabMainMenu_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // if the tabNotebook was selected even though there was
            // no workbook selected, cancel selection
            if ((Workbook.Instance.Username == null) & (e.TabPage == tabNotebook))
            {
                e.Cancel = true;
                tslblInstructions.Text = "Vor Ansicht des Arbeitsheft ist ein Arbeitsbuch auszuwählen!";
            }

        }

        //private void tsbutExport_Click(object sender, EventArgs e)
        //{
            

        //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        //    saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
        //    saveFileDialog1.Title = "Save an PDF File";
        //    saveFileDialog1.ShowDialog();

        //    if (saveFileDialog1.FileName != "")
        //    {
        //        System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

        //        this.tsbutExport.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                
        //    }
        //}

       
    }
}
