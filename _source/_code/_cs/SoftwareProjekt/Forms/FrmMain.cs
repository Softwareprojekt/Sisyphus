
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
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using SoftwareProjekt.Exercises;
using SoftwareProjekt.Enums;
using System;

// stuff for pdf export
using org.pdfclown.documents;
using files = org.pdfclown.files;
using org.pdfclown.tools;
using composition = org.pdfclown.documents.contents.composition;
using org.pdfclown.documents.contents.fonts;
using org.pdfclown.documents.interaction;
using org.pdfclown.documents.interchange.metadata;
using org.pdfclown.documents.interaction.viewer;
using xObjects = org.pdfclown.documents.contents.xObjects;
using entities = org.pdfclown.documents.contents.entities;
using org.pdfclown.util.math.geom;

namespace SoftwareProjekt.Forms
{
    // AbstractView
    public class FrmMain : AbstractView
    {
        private TabControl tabMainMenu;
        private TabPage tabNotebook;
        private FlowLayoutPanel flpWorkbook;
        private PictureBox picWorkbook;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbutNewExercisebook;
        private ToolStripButton tsbutLoadExercisebook;
        private ToolStripButton tsbutCloseExercisebook;
        private ToolStripButton tsbutExport;
        private ToolStripSeparator tssExerciseBook;
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
        private RichTextBox _rtxtNotes;
        private TabPage tabMenu;
        private CtlMindMap ctlMindMap1;
        private SaveFileDialog sfdialExportPDF;
        private ToolStripButton tsbutReplace;
        private ToolStripButton tsbutCancel;

        private Dictionary<TabPage, ToolStripButton[]> _controlDictionary =
    new Dictionary<TabPage, ToolStripButton[]>();

        public FrmMain()
        {
            InitializeComponent();
            _controlDictionary = InitializeDictionary();
            SoftwareProjekt.Classes.Workbook.Instance.AddEntries(flpWorkbook.Controls, picWorkbook, _rtxtNotes);
            ctlMindMap1.MindMapExerciseSelected += ctlMindMap1_MindMapExerciseSelected;
        }

        void ctlMindMap1_MindMapExerciseSelected(EExercises exerciseID)
        {
            this.OnViewChanged(new Classes.EventArguments.ViewEventArgs(EClickedButton.StartExercise, exerciseID));
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
            this.ctlMindMap1 = new SoftwareProjekt.UserControls.MindMap.CtlMindMap();
            this.tabNotebook = new System.Windows.Forms.TabPage();
            this._rtxtNotes = new System.Windows.Forms.RichTextBox();
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
            this.tsbutLoadExercise = new System.Windows.Forms.ToolStripButton();
            this.tsbutDeleteExercise = new System.Windows.Forms.ToolStripButton();
            this.tsbutNewExerciseType = new System.Windows.Forms.ToolStripButton();
            this.tssInstruction = new System.Windows.Forms.ToolStripSeparator();
            this.tslblInstructions = new System.Windows.Forms.ToolStripLabel();
            this.tstbxInput = new System.Windows.Forms.ToolStripTextBox();
            this.tscbxInput = new System.Windows.Forms.ToolStripComboBox();
            this.tsbutAccept = new System.Windows.Forms.ToolStripButton();
            this.tsbutReplace = new System.Windows.Forms.ToolStripButton();
            this.tsbutCancel = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.sfdialExportPDF = new System.Windows.Forms.SaveFileDialog();
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
            this.tabMenu.Controls.Add(this.ctlMindMap1);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1223, 636);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Start";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // ctlMindMap1
            // 
            this.ctlMindMap1.Location = new System.Drawing.Point(0, 0);
            this.ctlMindMap1.Name = "ctlMindMap1";
            this.ctlMindMap1.Size = new System.Drawing.Size(1223, 636);
            this.ctlMindMap1.TabIndex = 0;
            // 
            // tabNotebook
            // 
            this.tabNotebook.Controls.Add(this._rtxtNotes);
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
            // _rtxtNotes
            // 
            this._rtxtNotes.Location = new System.Drawing.Point(8, 498);
            this._rtxtNotes.Name = "_rtxtNotes";
            this._rtxtNotes.Size = new System.Drawing.Size(895, 132);
            this._rtxtNotes.TabIndex = 2;
            this._rtxtNotes.Text = "";
            // 
            // picWorkbook
            // 
            this.picWorkbook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picWorkbook.Enabled = false;
            this.picWorkbook.Location = new System.Drawing.Point(7, 7);
            this.picWorkbook.Name = "picWorkbook";
            this.picWorkbook.Size = new System.Drawing.Size(897, 476);
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
            this.tabProtectArea.Controls.Add(this.gbxColor);
            this.tabProtectArea.Controls.Add(this.gbxExerciseSpecification);
            this.tabProtectArea.Location = new System.Drawing.Point(4, 22);
            this.tabProtectArea.Name = "tabProtectArea";
            this.tabProtectArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtectArea.Size = new System.Drawing.Size(1223, 636);
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
            this.tsbutLoadExercise,
            this.tsbutDeleteExercise,
            this.tsbutNewExerciseType,
            this.tssInstruction,
            this.tslblInstructions,
            this.tstbxInput,
            this.tscbxInput,
            this.tsbutAccept,
            this.tsbutReplace,
            this.tsbutCancel});
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
            this.tsbutCloseExercisebook.Click += new System.EventHandler(this.tsbutCloseExercisebook_Click);
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
            this.tsbutExport.Click += new System.EventHandler(this.tsbutExport_Click);
            // 
            // tssExerciseBook
            // 
            this.tssExerciseBook.Name = "tssExerciseBook";
            this.tssExerciseBook.Size = new System.Drawing.Size(6, 25);
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
            this.tsbutLoadExercise.Click += new System.EventHandler(this.tsbutLoadExercise_Click);
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
            this.tsbutDeleteExercise.Click += new System.EventHandler(this.tsbutDeleteExercise_Click);
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
            this.tstbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstbxInput_KeyDown);
            // 
            // tscbxInput
            // 
            this.tscbxInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxInput.Name = "tscbxInput";
            this.tscbxInput.Size = new System.Drawing.Size(121, 25);
            this.tscbxInput.Visible = false;
            this.tscbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tscbxInput_KeyDown);
            // 
            // tsbutAccept
            // 
            this.tsbutAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutAccept.Image = ((System.Drawing.Image)(resources.GetObject("tsbutAccept.Image")));
            this.tsbutAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutAccept.Name = "tsbutAccept";
            this.tsbutAccept.Size = new System.Drawing.Size(27, 22);
            this.tsbutAccept.Text = "OK";
            this.tsbutAccept.Visible = false;
            this.tsbutAccept.Click += new System.EventHandler(this.tsbutAccept_Click);
            // 
            // tsbutReplace
            // 
            this.tsbutReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutReplace.Image = ((System.Drawing.Image)(resources.GetObject("tsbutReplace.Image")));
            this.tsbutReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutReplace.Name = "tsbutReplace";
            this.tsbutReplace.Size = new System.Drawing.Size(47, 22);
            this.tsbutReplace.Text = "Ersetze";
            this.tsbutReplace.Visible = false;
            this.tsbutReplace.Click += new System.EventHandler(this.tsbutReplace_Click);
            // 
            // tsbutCancel
            // 
            this.tsbutCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbutCancel.Image")));
            this.tsbutCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutCancel.Name = "tsbutCancel";
            this.tsbutCancel.Size = new System.Drawing.Size(69, 22);
            this.tsbutCancel.Text = "Abbrechen";
            this.tsbutCancel.Visible = false;
            this.tsbutCancel.Click += new System.EventHandler(this.tsbutCancel_Click);
            // 
            // sfdialExportPDF
            // 
            this.sfdialExportPDF.Filter = "\"PDF files (*.pdf)|*.pdf";
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
            ToolStripButton[] startButtons = { 
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
                else tsbutCloseExercisebook.Enabled = true;
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
            tscbxInput.Visible = false;
            tstbxInput.Visible = true;
            tsbutAccept.Visible = true;
            tstbxInput.Focus();
        }

        private void tsbutLoadExercisebook_Click(object sender, System.EventArgs e)
        {
            List<string> usernames = Workbook.Instance.GetAvailableWorkbooks();
            tstbxInput.Visible = false;
            if (usernames.ToArray().Length > 1) // several choices of books
            {
                tslblInstructions.Text = "Bitte Arbeitsbuch wählen: ";
                tscbxInput.Visible = true;
                tsbutAccept.Visible = true;
                tscbxInput.Focus();
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
                    tsbutCloseExercisebook.Enabled = true;
                    tslblInstructions.Text = "Arbeitsheft '" + usernameString + "' geladen.";
                }
                else tslblInstructions.Text = "Laden des Arbeitsheft fehlgeschlagen!";
            }
            else tslblInstructions.Text = "Kein Arbeitsbuch verfügbar!";
        }

        private void tsbutAccept_Click(object sender, System.EventArgs e)
        {
            if (tstbxInput.Text == "" && tscbxInput.Text == "")
            {
                tslblInstructions.Text = "Bitte Arbeitsbuchnamen eingeben!";
                return;
            }
            if (tscbxInput.Visible)
            {
                // load existing book
                tscbxInput.Visible = false;
                Workbook.Instance.Username = tscbxInput.Text;
                if (Workbook.Instance.Username != null) // otherwise parsing xml file failed
                {
                    // instructions
                    tslblInstructions.Text = "Beginne eine Übung über die Mindmap oder öffne eine Existierende im Arbeitsheft.";
                    tsbutCloseExercisebook.Enabled = true;
                }
                else
                {
                    tslblInstructions.Text = "Laden der Arbeitsbuch-Datei schlug fehl!";
                    tsbutCloseExercisebook.Enabled = false;
                }
            }
            else
            {
                // create book, if none with this name exists! 
                // otherwise ask user, how to proceed.  
                tstbxInput.Visible = false;
                if (Exists(tstbxInput.Text))
                {
                    // following is only relevant if the workbook to create, is already open
                    if (Workbook.Instance.Username == tstbxInput.Text)
                    {
                        Workbook.Instance.Username = null;
                    }
                    tslblInstructions.Text = "Arbeitsbuch existiert bereits! Ersetzen oder Abbrechen?";
                    tsbutReplace.Visible = true;
                    tsbutCancel.Visible = true;
                    tsbutAccept.Visible = false;
                    return;
                }
                Workbook.Instance.Username = tstbxInput.Text;
                tslblInstructions.Text = "";
                tslblInstructions.Text = "Beginne eine Übung über die Mindmap.";
                tsbutCloseExercisebook.Enabled = true;
            }
            tsbutAccept.Visible = false;
        }

        private bool Exists(string bookName)
        {
            List<String> existingBookNames = Workbook.Instance.GetAvailableWorkbooks();
            foreach (string existingBookName in existingBookNames)
            {
                if (bookName == existingBookName) return true;
            }
            return false;
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

        private void tsbutCloseExercisebook_Click(object sender, System.EventArgs e)
        {
            Workbook.Instance.Username = null;
            tslblInstructions.Text = "Bitte ein Arbeitsbuch wählen!";
            tsbutCloseExercisebook.Enabled = false;
            
        }

        private void tabMainMenu_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // if the tabNotebook was selected even though there was
            // no workbook selected, cancel selection
            if ((Workbook.Instance.Username == null) && (e.TabPage == tabNotebook))
            {
                e.Cancel = true;
                tslblInstructions.Text = "Vor Ansicht des Arbeitsheft ist ein Arbeitsbuch auszuwählen!";
            }

        }

        private void tsbutExport_Click(object sender, EventArgs e)
        {
            // 1. Opening the PDF file...
            files.File file = new files.File();

            // 2. Get its corresponding document!
            /* NOTE: a Document object is the high-level (semantic) representation of a PDF file. */
            Document document = file.Document;

            // 3. Insert the contents into the document!
            uint pageNum = 1;
            string[] exerciseImages = GetImagePathes();
            foreach (string exerciseImage in exerciseImages)
            {
                PopulateWithExerciseImage(document, exerciseImage, pageNum);
                pageNum += 1;
            }
            //Populate(document);

            // 4. Serialize the PDF file using a specified path
            string outputPath = PromptFileChoice();
            string text = Serialize(file, Workbook.Instance.Username, outputPath);
        }

        private void PopulateWithExerciseImage(Document document, string exerciseImage, uint pageNum)
        //private void Populate(Document document)
        {
            // 1. Add the page to the document!
            Page page = new Page(document,
                PageFormat.GetSize(
                PageFormat.SizeEnum.A4,
                PageFormat.OrientationEnum.Landscape)
            ); // Instantiates the page inside the document context.
            document.Pages.Add(page); // Puts the page in the pages collection.

            // 2. Create a content composer for the page!

            composition.PrimitiveComposer composer = new composition.PrimitiveComposer(page);
            //composition.BlockComposer composer = new composition.BlockComposer(page);

            // 3. Inserting contents...
            // Set the font to use!
            var defaultFont = new StandardType1Font(
                document,
                StandardType1Font.FamilyEnum.Courier,
                true,
                false
                );
            composer.SetFont(defaultFont, 14);
            composer.ShowText(
              "Sisyphus, Arbeitsbuch: " + Workbook.Instance.Username,
              new PointF(32, 48)
              );

            // -> No support of bmp nor png format!
            try
            {
                exerciseImage = GetJpeg(exerciseImage, pageNum);
                entities::Image image = entities::Image.Get(exerciseImage);
                xObjects::XObject imageXObject = image.ToXObject(document);
                // Show the image!
                float imageWidth = image.Width / 2 + 50;
                System.Console.WriteLine(imageWidth);
                if (imageWidth > 740.0) imageWidth = 740;
                composer.ShowXObject(
                  imageXObject,
                  new PointF(44, 78),
                  GeomUtils.Scale(imageXObject.Size, new SizeF(imageWidth, 0))
                );

            }
            catch (Exception e)
            {
                Console.WriteLine("Reading Path failed: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            composer.SetFont(
              new StandardType1Font(
                document,
                StandardType1Font.FamilyEnum.Courier,
                true,
                false
                ),
              12
              );
            // page number
            composer.SetFont(defaultFont,11);
            composer.ShowText(pageNum.ToString(), 
                new PointF(page.Size.Width / 2 - 20, page.Size.Height - 50));
            // 4. Flush the contents into the page!
            composer.Flush();
        }

        // required for export to PDF!
        private String GetJpeg(String inputImagePath, uint count)
        {
            var encoderParameters = new EncoderParameters(1);
            Image img = Image.FromFile(inputImagePath);
            string sepChar = System.IO.Path.DirectorySeparatorChar.ToString();
            string tmpPath = Path.GetTempPath() + sepChar + count.ToString() + ".jpg";
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 72L);
            img.Save(tmpPath, GetEncoder(ImageFormat.Jpeg), encoderParameters);
            return tmpPath;
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private String[] GetImagePathes()
        {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            string sepChar = System.IO.Path.DirectorySeparatorChar.ToString();
            string bookPath = currentDirectory + sepChar + "Workbooks" + sepChar + Workbook.Instance.Username;
            string[] availableImages = Directory.GetFiles(bookPath, "*.bmp", SearchOption.TopDirectoryOnly);
            return availableImages;
        }

        private string Serialize(files::File file, string title, string path)
        {
            ApplyDocumentSettings(file.Document, title);

            string outputFilePath = path;

            try
            { file.Save(outputFilePath, files::SerializationModeEnum.Standard); }
            catch (Exception e)
            {
                Console.WriteLine("File writing failed: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("\nOutput: " + outputFilePath);

            return outputFilePath;

        }

        private void ApplyDocumentSettings(Document document, string title)
        {
            if (title == null)
                return;

            // Viewer preferences.
            ViewerPreferences view = new ViewerPreferences(document); // Instantiates viewer preferences inside the document context.
            document.ViewerPreferences = view; // Assigns the viewer preferences object to the viewer preferences function.
            view.DisplayDocTitle = true;

            // Document metadata.
            Information info = document.Information;
            info.Clear();
            info.CreationDate = DateTime.Now;
            info.Creator = GetType().FullName;
            info.Title = "Sisyphus, Arbeitsbuch: " + title;
        }

        private string PromptFileChoice()
        {
            DialogResult pdfPath = sfdialExportPDF.ShowDialog();
            sfdialExportPDF.Title = "Wähle einen Pfad mit Namen oder eine PDF Datei";
            if (pdfPath == DialogResult.OK)
            {
                tslblInstructions.Text = sfdialExportPDF.FileName + " exportiert";
                System.Console.WriteLine(sfdialExportPDF.FileName);
                return sfdialExportPDF.FileName;
            }
            else return "Ausgabe";
        }

        private void tsbutLoadExercise_Click(object sender, EventArgs e)
        {
            Enums.EExercises exercise = determineExercise();
            if (exercise == Enums.EExercises.InvalidExercise) return;
            this.OnViewChanged(new Classes.EventArguments.ViewEventArgs(
                Enums.EClickedButton.StartExercise, exercise));
        }

        private void tsbutDeleteExercise_Click(object sender, EventArgs e)
        {
            Enums.EExercises exercise = determineExercise();
            if (exercise == Enums.EExercises.InvalidExercise)
            {
                this.tslblInstructions.Text = "Löschen der Übung fehlgeschlagen!";
                return;
            }
            Workbook.Instance.DeleteEntry(exercise);
            
            this.tslblInstructions.Text = "Übung '" + exercise.ToString() + "' gelöscht!";
        }

        private Enums.EExercises determineExercise()
        {
            Bitmap displayedBitmap = (Bitmap)picWorkbook.Image;

            string[] availableImages = GetImagePathes();
            foreach (string imgString in availableImages)
            {
                Size sSize = picWorkbook.Image.Size;
                Bitmap exerciseImage = (Bitmap)resizeImage(Image.FromFile(imgString), sSize);
                System.Console.WriteLine(imgString);
                if (compare(exerciseImage, displayedBitmap))
                {
                    // open the exercise
                    char[] extension = ".bmp".ToCharArray();
                    String exercise = Path.GetFileName(imgString).TrimEnd(extension);
                        
                    try
                    {
                        // bb was trimmed off, probably with '.bmp'
                        if (exercise == "ZuordnungsvorschriftLinA" ||
                            exercise == "HintereinanderausfLinA" ||
                            exercise == "UmkehrungLinA")
                        {
                            exercise += "bb";
                        }
                        return (EExercises)Enum.Parse(typeof(EExercises), exercise);
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Reading Path failed: " + e2.Message);
                        Console.WriteLine(e2.StackTrace);
                    }                
                }
            }

            return Enums.EExercises.InvalidExercise;
        }

        private bool compare(Bitmap bmp1, Bitmap bmp2)
        {
            bool flag = true;  //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bmp1.Size == bmp2.Size)
            {
                // comparing through the whole size is not required
                for (int x = 220; x < bmp1.Width-220; ++x)
                {   
                    for (int y = 12; y < 60; ++y)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y) )
                        {
                            return false;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void tstbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbutAccept_Click(sender, e);
            }

        }

        private void tscbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbutAccept_Click(sender, e);
            }
        }

        private void tsbutReplace_Click(object sender, EventArgs e)
        {
            picWorkbook.Dispose();
            Workbook.Instance.DeleteWorkbook(tstbxInput.Text);
            tsbutReplace.Visible = false;
            tsbutCancel.Visible = false;
            tsbutAccept_Click(sender, e);
        }

        private void tsbutCancel_Click(object sender, EventArgs e)
        {
            tsbutReplace.Visible = false;
            tsbutCancel.Visible = false;
            tsbutCloseExercisebook_Click(sender, e);
        }
    }
}
