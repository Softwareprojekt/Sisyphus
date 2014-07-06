
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

using SoftwareProjekt.Delegates;
using SoftwareProjekt.Enums;
using SoftwareProjekt.Interfaces;
using System;
using System.Windows.Forms;

namespace SoftwareProjekt.UserControls.MindMap
{
    public class CtlMindMap : UserControl, IWorkbookObserver
    {
        private MindMapButtonControl DrehungSpiegelungStreckung;
        private MindMapButtonControl UmkehrungInverseMatrix;
        private MindMapTopicControl topicLinAbb;
        private MindMapTopicControl affAbbildungTopic;
        private MindMapButtonControl GeometrischeEigenschaften;
        private MindMapButtonControl VertraeglichkeitmitSummenundViel;
        private MindMapButtonControl VertraeglichkeitLinarkombination;
        private MindMapButtonControl MatrixAlsZuordnung;
        private MindMapButtonControl hintereinanderAusfuehrung;
        private MindMapButtonControl HintereinanderausfuehrungUmkehrbarkeit;
        private MindMapButtonControl Zuordnungsvorschrift2Dreiecke;
        private MindMapTopicControl fraktaleTopic;
        private MindMapButtonControl geometrischeEigenschaftenAffAbb;
        private MindMapButtonControl LGS;
        private MindMapButtonControl IFS;
        private MindMapButtonControl ChaosSpiel;
        private MindMapTopicControl parallelTopic;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape15;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape14;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape13;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape12;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape11;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape10;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape28;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape27;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape26;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape25;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape24;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape23;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape22;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape21;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape20;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape19;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape18;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape17;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape16;
        private Label label1;
        private Label label2;
        private Label label3;


        public event ExerciseClickEvent MindMapExerciseSelected;


        public CtlMindMap()
        {
            this.Paint += CtlMindMap_Paint;


            InitializeComponent();

            DrehungSpiegelungStreckung.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            UmkehrungInverseMatrix.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            GeometrischeEigenschaften.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            VertraeglichkeitmitSummenundViel.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            VertraeglichkeitLinarkombination.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            MatrixAlsZuordnung.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            hintereinanderAusfuehrung.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            HintereinanderausfuehrungUmkehrbarkeit.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            Zuordnungsvorschrift2Dreiecke.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            geometrischeEigenschaftenAffAbb.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            LGS.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            IFS.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;
            ChaosSpiel.ButtonClicked += DrehungSpiegelungStreckung_ButtonClicked;

            SoftwareProjekt.Classes.Workbook.Instance.RegisterObserver(this);
        }

        void DrehungSpiegelungStreckung_ButtonClicked(EExercises exerciseID)
        {
            if (exerciseID != EExercises.InvalidExercise)
            {
                if (MindMapExerciseSelected != null)
                {
                    MindMapExerciseSelected(exerciseID);
                }
            }
        }

        void CtlMindMap_Paint(object sender, PaintEventArgs e)
        {
            SoftwareProjekt.Classes.Workbook workbook = SoftwareProjekt.Classes.Workbook.Instance;

            /*DrehungSpiegelungStreckung.MachiningCondition = (workbook.GetEntryState(DrehungSpiegelungStreckung.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            UmkehrungInverseMatrix.MachiningCondition = (workbook.GetEntryState(UmkehrungInverseMatrix.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            GeometrischeEigenschaften.MachiningCondition = (workbook.GetEntryState(GeometrischeEigenschaften.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            VertraeglichkeitmitSummenundViel.MachiningCondition = (workbook.GetEntryState(VertraeglichkeitmitSummenundViel.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            VertraeglichkeitLinarkombination.MachiningCondition = (workbook.GetEntryState(VertraeglichkeitLinarkombination.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            MatrixAlsZuordnung.MachiningCondition = (workbook.GetEntryState(MatrixAlsZuordnung.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            hintereinanderAusfuehrung.MachiningCondition = (workbook.GetEntryState(hintereinanderAusfuehrung.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            HintereinanderausfuehrungUmkehrbarkeit.MachiningCondition = (workbook.GetEntryState(HintereinanderausfuehrungUmkehrbarkeit.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            Zuordnungsvorschrift2Dreiecke.MachiningCondition = (workbook.GetEntryState(Zuordnungsvorschrift2Dreiecke.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            geometrischeEigenschaftenAffAbb.MachiningCondition = (workbook.GetEntryState(geometrischeEigenschaftenAffAbb.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            LGS.MachiningCondition = (workbook.GetEntryState(LGS.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            IFS.MachiningCondition = (workbook.GetEntryState(IFS.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            ChaosSpiel.MachiningCondition = (workbook.GetEntryState(ChaosSpiel.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            */

            if (DrehungSpiegelungStreckung.ExerciseID == EExercises.InvalidExercise)
            {
                DrehungSpiegelungStreckung.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                DrehungSpiegelungStreckung.MachiningCondition = (workbook.GetEntryState(DrehungSpiegelungStreckung.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (UmkehrungInverseMatrix.ExerciseID == EExercises.InvalidExercise)
            {
                UmkehrungInverseMatrix.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                UmkehrungInverseMatrix.MachiningCondition = (workbook.GetEntryState(UmkehrungInverseMatrix.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (GeometrischeEigenschaften.ExerciseID == EExercises.InvalidExercise)
            {
                GeometrischeEigenschaften.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                GeometrischeEigenschaften.MachiningCondition = (workbook.GetEntryState(GeometrischeEigenschaften.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (VertraeglichkeitmitSummenundViel.ExerciseID == EExercises.InvalidExercise)
            {
                VertraeglichkeitmitSummenundViel.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                VertraeglichkeitmitSummenundViel.MachiningCondition = (workbook.GetEntryState(VertraeglichkeitmitSummenundViel.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (VertraeglichkeitLinarkombination.ExerciseID == EExercises.InvalidExercise)
            {
                VertraeglichkeitLinarkombination.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                VertraeglichkeitLinarkombination.MachiningCondition = (workbook.GetEntryState(VertraeglichkeitLinarkombination.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (MatrixAlsZuordnung.ExerciseID == EExercises.InvalidExercise)
            {
                MatrixAlsZuordnung.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                MatrixAlsZuordnung.MachiningCondition = (workbook.GetEntryState(MatrixAlsZuordnung.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (hintereinanderAusfuehrung.ExerciseID == EExercises.InvalidExercise)
            {
                hintereinanderAusfuehrung.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                hintereinanderAusfuehrung.MachiningCondition = (workbook.GetEntryState(hintereinanderAusfuehrung.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (HintereinanderausfuehrungUmkehrbarkeit.ExerciseID == EExercises.InvalidExercise)
            {
                HintereinanderausfuehrungUmkehrbarkeit.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                HintereinanderausfuehrungUmkehrbarkeit.MachiningCondition = (workbook.GetEntryState(HintereinanderausfuehrungUmkehrbarkeit.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (Zuordnungsvorschrift2Dreiecke.ExerciseID == EExercises.InvalidExercise)
            {
                Zuordnungsvorschrift2Dreiecke.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                Zuordnungsvorschrift2Dreiecke.MachiningCondition = (workbook.GetEntryState(Zuordnungsvorschrift2Dreiecke.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (geometrischeEigenschaftenAffAbb.ExerciseID == EExercises.InvalidExercise)
            {
                geometrischeEigenschaftenAffAbb.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                geometrischeEigenschaftenAffAbb.MachiningCondition = (workbook.GetEntryState(geometrischeEigenschaftenAffAbb.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (LGS.ExerciseID == EExercises.InvalidExercise)
            {
                LGS.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                LGS.MachiningCondition = (workbook.GetEntryState(LGS.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (IFS.ExerciseID == EExercises.InvalidExercise)
            {
                IFS.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                IFS.MachiningCondition = (workbook.GetEntryState(IFS.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

            if (ChaosSpiel.ExerciseID == EExercises.InvalidExercise)
            {
                ChaosSpiel.MachiningCondition = EMachiningCondition.NotValid;
            }
            else
            {
                ChaosSpiel.MachiningCondition = (workbook.GetEntryState(ChaosSpiel.ExerciseID).Count == 0) ? EMachiningCondition.NotDone : EMachiningCondition.SaveExists;
            }

        }



        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape28 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape27 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape26 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape25 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape24 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape23 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape22 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape21 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape20 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape19 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape18 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape17 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape16 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape15 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape14 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape13 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape12 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape11 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parallelTopic = new SoftwareProjekt.UserControls.MindMap.MindMapTopicControl();
            this.fraktaleTopic = new SoftwareProjekt.UserControls.MindMap.MindMapTopicControl();
            this.affAbbildungTopic = new SoftwareProjekt.UserControls.MindMap.MindMapTopicControl();
            this.topicLinAbb = new SoftwareProjekt.UserControls.MindMap.MindMapTopicControl();
            this.HintereinanderausfuehrungUmkehrbarkeit = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.IFS = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.VertraeglichkeitLinarkombination = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.VertraeglichkeitmitSummenundViel = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.Zuordnungsvorschrift2Dreiecke = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.DrehungSpiegelungStreckung = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.geometrischeEigenschaftenAffAbb = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.MatrixAlsZuordnung = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.UmkehrungInverseMatrix = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.hintereinanderAusfuehrung = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.GeometrischeEigenschaften = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.LGS = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.ChaosSpiel = new SoftwareProjekt.UserControls.MindMap.MindMapButtonControl();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape28,
            this.lineShape27,
            this.lineShape26,
            this.lineShape25,
            this.lineShape24,
            this.lineShape23,
            this.lineShape22,
            this.lineShape21,
            this.lineShape20,
            this.lineShape19,
            this.lineShape18,
            this.lineShape17,
            this.lineShape16,
            this.lineShape15,
            this.lineShape14,
            this.lineShape13,
            this.lineShape12,
            this.lineShape11,
            this.lineShape10,
            this.lineShape9,
            this.lineShape8,
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1223, 636);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape28
            // 
            this.lineShape28.Name = "lineShape28";
            this.lineShape28.X1 = 825;
            this.lineShape28.X2 = 845;
            this.lineShape28.Y1 = 333;
            this.lineShape28.Y2 = 327;
            // 
            // lineShape27
            // 
            this.lineShape27.Name = "lineShape27";
            this.lineShape27.X1 = 834;
            this.lineShape27.X2 = 844;
            this.lineShape27.Y1 = 313;
            this.lineShape27.Y2 = 328;
            // 
            // lineShape26
            // 
            this.lineShape26.Name = "lineShape26";
            this.lineShape26.X1 = 474;
            this.lineShape26.X2 = 485;
            this.lineShape26.Y1 = 253;
            this.lineShape26.Y2 = 263;
            // 
            // lineShape25
            // 
            this.lineShape25.Name = "lineShape25";
            this.lineShape25.X1 = 473;
            this.lineShape25.X2 = 489;
            this.lineShape25.Y1 = 252;
            this.lineShape25.Y2 = 247;
            // 
            // lineShape24
            // 
            this.lineShape24.Name = "lineShape24";
            this.lineShape24.X1 = 1092;
            this.lineShape24.X2 = 1107;
            this.lineShape24.Y1 = 493;
            this.lineShape24.Y2 = 498;
            // 
            // lineShape23
            // 
            this.lineShape23.Name = "lineShape23";
            this.lineShape23.X1 = 1108;
            this.lineShape23.X2 = 1108;
            this.lineShape23.Y1 = 482;
            this.lineShape23.Y2 = 498;
            // 
            // lineShape22
            // 
            this.lineShape22.Name = "lineShape22";
            this.lineShape22.X1 = 1000;
            this.lineShape22.X2 = 1001;
            this.lineShape22.Y1 = 361;
            this.lineShape22.Y2 = 375;
            // 
            // lineShape21
            // 
            this.lineShape21.Name = "lineShape21";
            this.lineShape21.X1 = 1002;
            this.lineShape21.X2 = 1014;
            this.lineShape21.Y1 = 361;
            this.lineShape21.Y2 = 365;
            // 
            // lineShape20
            // 
            this.lineShape20.Name = "lineShape20";
            this.lineShape20.X1 = 928;
            this.lineShape20.X2 = 922;
            this.lineShape20.Y1 = 298;
            this.lineShape20.Y2 = 309;
            // 
            // lineShape19
            // 
            this.lineShape19.Name = "lineShape19";
            this.lineShape19.X1 = 911;
            this.lineShape19.X2 = 921;
            this.lineShape19.Y1 = 301;
            this.lineShape19.Y2 = 310;
            // 
            // lineShape18
            // 
            this.lineShape18.Name = "lineShape18";
            this.lineShape18.X1 = 1020;
            this.lineShape18.X2 = 1116;
            this.lineShape18.Y1 = 597;
            this.lineShape18.Y2 = 547;
            // 
            // lineShape17
            // 
            this.lineShape17.Name = "lineShape17";
            this.lineShape17.X1 = 956;
            this.lineShape17.X2 = 1044;
            this.lineShape17.Y1 = 564;
            this.lineShape17.Y2 = 526;
            // 
            // lineShape16
            // 
            this.lineShape16.Name = "lineShape16";
            this.lineShape16.X1 = 878;
            this.lineShape16.X2 = 777;
            this.lineShape16.Y1 = 351;
            this.lineShape16.Y2 = 401;
            // 
            // lineShape15
            // 
            this.lineShape15.Name = "lineShape15";
            this.lineShape15.X1 = 949;
            this.lineShape15.X2 = 859;
            this.lineShape15.Y1 = 360;
            this.lineShape15.Y2 = 453;
            // 
            // lineShape14
            // 
            this.lineShape14.Name = "lineShape14";
            this.lineShape14.X1 = 998;
            this.lineShape14.X2 = 1110;
            this.lineShape14.Y1 = 357;
            this.lineShape14.Y2 = 501;
            // 
            // lineShape13
            // 
            this.lineShape13.Name = "lineShape13";
            this.lineShape13.X1 = 1059;
            this.lineShape13.X2 = 1009;
            this.lineShape13.Y1 = 261;
            this.lineShape13.Y2 = 315;
            // 
            // lineShape12
            // 
            this.lineShape12.Name = "lineShape12";
            this.lineShape12.X1 = 985;
            this.lineShape12.X2 = 951;
            this.lineShape12.Y1 = 180;
            this.lineShape12.Y2 = 306;
            // 
            // lineShape11
            // 
            this.lineShape11.Name = "lineShape11";
            this.lineShape11.X1 = 873;
            this.lineShape11.X2 = 877;
            this.lineShape11.Y1 = 139;
            this.lineShape11.Y2 = 127;
            // 
            // lineShape10
            // 
            this.lineShape10.Name = "lineShape10";
            this.lineShape10.X1 = 878;
            this.lineShape10.X2 = 891;
            this.lineShape10.Y1 = 125;
            this.lineShape10.Y2 = 134;
            // 
            // lineShape9
            // 
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.X1 = 878;
            this.lineShape9.X2 = 922;
            this.lineShape9.Y1 = 124;
            this.lineShape9.Y2 = 311;
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 472;
            this.lineShape8.X2 = 845;
            this.lineShape8.Y1 = 252;
            this.lineShape8.Y2 = 328;
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 444;
            this.lineShape7.X2 = 405;
            this.lineShape7.Y1 = 146;
            this.lineShape7.Y2 = 224;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 346;
            this.lineShape6.X2 = 367;
            this.lineShape6.Y1 = 113;
            this.lineShape6.Y2 = 222;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 211;
            this.lineShape5.X2 = 334;
            this.lineShape5.Y1 = 180;
            this.lineShape5.Y2 = 229;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 211;
            this.lineShape4.X2 = 293;
            this.lineShape4.Y1 = 258;
            this.lineShape4.Y2 = 258;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 211;
            this.lineShape3.X2 = 332;
            this.lineShape3.Y1 = 342;
            this.lineShape3.Y2 = 276;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 299;
            this.lineShape2.X2 = 372;
            this.lineShape2.Y1 = 427;
            this.lineShape2.Y2 = 280;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 381;
            this.lineShape1.X2 = 435;
            this.lineShape1.Y1 = 281;
            this.lineShape1.Y2 = 326;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Speziallfall / Verallgemeinerung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Speziallfall / Verallgemeinerung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(983, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Speziallfall / Verallgemeinerung";
            // 
            // parallelTopic
            // 
            this.parallelTopic.Location = new System.Drawing.Point(755, 75);
            this.parallelTopic.Name = "parallelTopic";
            this.parallelTopic.Size = new System.Drawing.Size(232, 50);
            this.parallelTopic.TabIndex = 18;
            this.parallelTopic.TopicName = "Parallelverschiebungen";
            // 
            // fraktaleTopic
            // 
            this.fraktaleTopic.Location = new System.Drawing.Point(1044, 499);
            this.fraktaleTopic.Name = "fraktaleTopic";
            this.fraktaleTopic.Size = new System.Drawing.Size(150, 50);
            this.fraktaleTopic.TabIndex = 13;
            this.fraktaleTopic.TopicName = "Fraktale";
            // 
            // affAbbildungTopic
            // 
            this.affAbbildungTopic.Location = new System.Drawing.Point(845, 310);
            this.affAbbildungTopic.Name = "affAbbildungTopic";
            this.affAbbildungTopic.Size = new System.Drawing.Size(207, 50);
            this.affAbbildungTopic.TabIndex = 5;
            this.affAbbildungTopic.TopicName = "Affine Abbildungen";
            // 
            // topicLinAbb
            // 
            this.topicLinAbb.Location = new System.Drawing.Point(295, 223);
            this.topicLinAbb.Name = "topicLinAbb";
            this.topicLinAbb.Size = new System.Drawing.Size(178, 59);
            this.topicLinAbb.TabIndex = 4;
            this.topicLinAbb.TopicName = "Lineare Abbildung";
            // 
            // HintereinanderausfuehrungUmkehrbarkeit
            // 
            this.HintereinanderausfuehrungUmkehrbarkeit.BottomAlign = false;
            this.HintereinanderausfuehrungUmkehrbarkeit.ButtonText = "Hintereinanderausführung und Umkehrbarkeit";
            this.HintereinanderausfuehrungUmkehrbarkeit.ExerciseID = SoftwareProjekt.Enums.EExercises.InvalidExercise;
            this.HintereinanderausfuehrungUmkehrbarkeit.LeftAlign = false;
            this.HintereinanderausfuehrungUmkehrbarkeit.Location = new System.Drawing.Point(493, 386);
            this.HintereinanderausfuehrungUmkehrbarkeit.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.HintereinanderausfuehrungUmkehrbarkeit.Name = "HintereinanderausfuehrungUmkehrbarkeit";
            this.HintereinanderausfuehrungUmkehrbarkeit.RightAlign = true;
            this.HintereinanderausfuehrungUmkehrbarkeit.Size = new System.Drawing.Size(285, 27);
            this.HintereinanderausfuehrungUmkehrbarkeit.TabIndex = 11;
            this.HintereinanderausfuehrungUmkehrbarkeit.TopAlign = false;
            // 
            // IFS
            // 
            this.IFS.BottomAlign = false;
            this.IFS.ButtonText = "IFS";
            this.IFS.ExerciseID = SoftwareProjekt.Enums.EExercises.FraktalerzeugungMitIFS;
            this.IFS.LeftAlign = false;
            this.IFS.Location = new System.Drawing.Point(845, 549);
            this.IFS.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.IFS.Name = "IFS";
            this.IFS.RightAlign = true;
            this.IFS.Size = new System.Drawing.Size(111, 27);
            this.IFS.TabIndex = 16;
            this.IFS.TopAlign = false;
            // 
            // VertraeglichkeitLinarkombination
            // 
            this.VertraeglichkeitLinarkombination.BottomAlign = false;
            this.VertraeglichkeitLinarkombination.ButtonText = "Spiegelung an einer Ursprungsgeraden";
            this.VertraeglichkeitLinarkombination.ExerciseID = SoftwareProjekt.Enums.EExercises.SpiegelungLinAbbanUrspungsgeraden;
            this.VertraeglichkeitLinarkombination.LeftAlign = false;
            this.VertraeglichkeitLinarkombination.Location = new System.Drawing.Point(-22, 243);
            this.VertraeglichkeitLinarkombination.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.VertraeglichkeitLinarkombination.Name = "VertraeglichkeitLinarkombination";
            this.VertraeglichkeitLinarkombination.RightAlign = true;
            this.VertraeglichkeitLinarkombination.Size = new System.Drawing.Size(233, 27);
            this.VertraeglichkeitLinarkombination.TabIndex = 8;
            this.VertraeglichkeitLinarkombination.TopAlign = false;
            // 
            // VertraeglichkeitmitSummenundViel
            // 
            this.VertraeglichkeitmitSummenundViel.BottomAlign = false;
            this.VertraeglichkeitmitSummenundViel.ButtonText = "Verträglichkeit mit Vielfachen bel. Vektoren";
            this.VertraeglichkeitmitSummenundViel.ExerciseID = SoftwareProjekt.Enums.EExercises.LinAbbMitVielfachemBelVek;
            this.VertraeglichkeitmitSummenundViel.LeftAlign = false;
            this.VertraeglichkeitmitSummenundViel.Location = new System.Drawing.Point(30, 412);
            this.VertraeglichkeitmitSummenundViel.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.VertraeglichkeitmitSummenundViel.Name = "VertraeglichkeitmitSummenundViel";
            this.VertraeglichkeitmitSummenundViel.RightAlign = true;
            this.VertraeglichkeitmitSummenundViel.Size = new System.Drawing.Size(269, 27);
            this.VertraeglichkeitmitSummenundViel.TabIndex = 7;
            this.VertraeglichkeitmitSummenundViel.TopAlign = false;
            // 
            // Zuordnungsvorschrift2Dreiecke
            // 
            this.Zuordnungsvorschrift2Dreiecke.BottomAlign = false;
            this.Zuordnungsvorschrift2Dreiecke.ButtonText = "Zuordnungsvorschrift durch 2 Dreiecke";
            this.Zuordnungsvorschrift2Dreiecke.ExerciseID = SoftwareProjekt.Enums.EExercises.ZuordungsvorschriftEinerAffAbb;
            this.Zuordnungsvorschrift2Dreiecke.LeftAlign = false;
            this.Zuordnungsvorschrift2Dreiecke.Location = new System.Drawing.Point(574, 438);
            this.Zuordnungsvorschrift2Dreiecke.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.Zuordnungsvorschrift2Dreiecke.Name = "Zuordnungsvorschrift2Dreiecke";
            this.Zuordnungsvorschrift2Dreiecke.RightAlign = true;
            this.Zuordnungsvorschrift2Dreiecke.Size = new System.Drawing.Size(285, 27);
            this.Zuordnungsvorschrift2Dreiecke.TabIndex = 12;
            this.Zuordnungsvorschrift2Dreiecke.TopAlign = false;
            // 
            // DrehungSpiegelungStreckung
            // 
            this.DrehungSpiegelungStreckung.BottomAlign = false;
            this.DrehungSpiegelungStreckung.ButtonText = "Verträglichkeit mit  Linearkombination";
            this.DrehungSpiegelungStreckung.ExerciseID = SoftwareProjekt.Enums.EExercises.ZuordnungsvorschriftLinAbb;
            this.DrehungSpiegelungStreckung.LeftAlign = true;
            this.DrehungSpiegelungStreckung.Location = new System.Drawing.Point(433, 310);
            this.DrehungSpiegelungStreckung.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.DrehungSpiegelungStreckung.Name = "DrehungSpiegelungStreckung";
            this.DrehungSpiegelungStreckung.RightAlign = false;
            this.DrehungSpiegelungStreckung.Size = new System.Drawing.Size(239, 27);
            this.DrehungSpiegelungStreckung.TabIndex = 1;
            this.DrehungSpiegelungStreckung.TopAlign = false;
            // 
            // geometrischeEigenschaftenAffAbb
            // 
            this.geometrischeEigenschaftenAffAbb.BottomAlign = false;
            this.geometrischeEigenschaftenAffAbb.ButtonText = "Geometrische Eigenscha fte n";
            this.geometrischeEigenschaftenAffAbb.ExerciseID = SoftwareProjekt.Enums.EExercises.InvalidExercise;
            this.geometrischeEigenschaftenAffAbb.LeftAlign = true;
            this.geometrischeEigenschaftenAffAbb.Location = new System.Drawing.Point(986, 165);
            this.geometrischeEigenschaftenAffAbb.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.geometrischeEigenschaftenAffAbb.Name = "geometrischeEigenschaftenAffAbb";
            this.geometrischeEigenschaftenAffAbb.RightAlign = false;
            this.geometrischeEigenschaftenAffAbb.Size = new System.Drawing.Size(208, 27);
            this.geometrischeEigenschaftenAffAbb.TabIndex = 14;
            this.geometrischeEigenschaftenAffAbb.TopAlign = false;
            // 
            // MatrixAlsZuordnung
            // 
            this.MatrixAlsZuordnung.BottomAlign = false;
            this.MatrixAlsZuordnung.ButtonText = "Drehung um den Ursprung";
            this.MatrixAlsZuordnung.ExerciseID = SoftwareProjekt.Enums.EExercises.DrehungLinAbbUmUrsprung;
            this.MatrixAlsZuordnung.LeftAlign = false;
            this.MatrixAlsZuordnung.Location = new System.Drawing.Point(3, 165);
            this.MatrixAlsZuordnung.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.MatrixAlsZuordnung.Name = "MatrixAlsZuordnung";
            this.MatrixAlsZuordnung.RightAlign = true;
            this.MatrixAlsZuordnung.Size = new System.Drawing.Size(208, 27);
            this.MatrixAlsZuordnung.TabIndex = 9;
            this.MatrixAlsZuordnung.TopAlign = false;
            // 
            // UmkehrungInverseMatrix
            // 
            this.UmkehrungInverseMatrix.BottomAlign = false;
            this.UmkehrungInverseMatrix.ButtonText = "Umkehrung <--> inverse Matrix";
            this.UmkehrungInverseMatrix.ExerciseID = SoftwareProjekt.Enums.EExercises.UmkehrungLinAbb;
            this.UmkehrungInverseMatrix.LeftAlign = true;
            this.UmkehrungInverseMatrix.Location = new System.Drawing.Point(443, 131);
            this.UmkehrungInverseMatrix.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.UmkehrungInverseMatrix.Name = "UmkehrungInverseMatrix";
            this.UmkehrungInverseMatrix.RightAlign = false;
            this.UmkehrungInverseMatrix.Size = new System.Drawing.Size(208, 27);
            this.UmkehrungInverseMatrix.TabIndex = 2;
            this.UmkehrungInverseMatrix.TopAlign = false;
            // 
            // hintereinanderAusfuehrung
            // 
            this.hintereinanderAusfuehrung.BottomAlign = false;
            this.hintereinanderAusfuehrung.ButtonText = "Hintereinanderausführung <--> Matrixmultiplikation";
            this.hintereinanderAusfuehrung.ExerciseID = SoftwareProjekt.Enums.EExercises.HintereinanderausfLinAbb;
            this.hintereinanderAusfuehrung.LeftAlign = false;
            this.hintereinanderAusfuehrung.Location = new System.Drawing.Point(41, 98);
            this.hintereinanderAusfuehrung.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.hintereinanderAusfuehrung.Name = "hintereinanderAusfuehrung";
            this.hintereinanderAusfuehrung.RightAlign = true;
            this.hintereinanderAusfuehrung.Size = new System.Drawing.Size(305, 27);
            this.hintereinanderAusfuehrung.TabIndex = 10;
            this.hintereinanderAusfuehrung.TopAlign = false;
            // 
            // GeometrischeEigenschaften
            // 
            this.GeometrischeEigenschaften.BottomAlign = false;
            this.GeometrischeEigenschaften.ButtonText = "Verträglichkeit mit Summen bel. Vektoren";
            this.GeometrischeEigenschaften.ExerciseID = SoftwareProjekt.Enums.EExercises.LinAbbAusSumBelVek;
            this.GeometrischeEigenschaften.LeftAlign = false;
            this.GeometrischeEigenschaften.Location = new System.Drawing.Point(-11, 316);
            this.GeometrischeEigenschaften.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.GeometrischeEigenschaften.Name = "GeometrischeEigenschaften";
            this.GeometrischeEigenschaften.RightAlign = true;
            this.GeometrischeEigenschaften.Size = new System.Drawing.Size(244, 27);
            this.GeometrischeEigenschaften.TabIndex = 6;
            this.GeometrischeEigenschaften.TopAlign = false;
            // 
            // LGS
            // 
            this.LGS.BottomAlign = false;
            this.LGS.ButtonText = "LGS";
            this.LGS.ExerciseID = SoftwareProjekt.Enums.EExercises.InvalidExercise;
            this.LGS.LeftAlign = true;
            this.LGS.Location = new System.Drawing.Point(1059, 246);
            this.LGS.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.LGS.Name = "LGS";
            this.LGS.RightAlign = false;
            this.LGS.Size = new System.Drawing.Size(135, 27);
            this.LGS.TabIndex = 15;
            this.LGS.TopAlign = false;
            // 
            // ChaosSpiel
            // 
            this.ChaosSpiel.BottomAlign = false;
            this.ChaosSpiel.ButtonText = "Chaos - Spiel";
            this.ChaosSpiel.ExerciseID = SoftwareProjekt.Enums.EExercises.FraktalerzeugungMitChaos;
            this.ChaosSpiel.LeftAlign = false;
            this.ChaosSpiel.Location = new System.Drawing.Point(866, 582);
            this.ChaosSpiel.MachiningCondition = SoftwareProjekt.Enums.EMachiningCondition.SaveExists;
            this.ChaosSpiel.Name = "ChaosSpiel";
            this.ChaosSpiel.RightAlign = true;
            this.ChaosSpiel.Size = new System.Drawing.Size(153, 27);
            this.ChaosSpiel.TabIndex = 17;
            this.ChaosSpiel.TopAlign = false;
            // 
            // CtlMindMap
            // 
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parallelTopic);
            this.Controls.Add(this.affAbbildungTopic);
            this.Controls.Add(this.fraktaleTopic);
            this.Controls.Add(this.topicLinAbb);
            this.Controls.Add(this.VertraeglichkeitLinarkombination);
            this.Controls.Add(this.geometrischeEigenschaftenAffAbb);
            this.Controls.Add(this.GeometrischeEigenschaften);
            this.Controls.Add(this.MatrixAlsZuordnung);
            this.Controls.Add(this.VertraeglichkeitmitSummenundViel);
            this.Controls.Add(this.UmkehrungInverseMatrix);
            this.Controls.Add(this.IFS);
            this.Controls.Add(this.hintereinanderAusfuehrung);
            this.Controls.Add(this.Zuordnungsvorschrift2Dreiecke);
            this.Controls.Add(this.LGS);
            this.Controls.Add(this.HintereinanderausfuehrungUmkehrbarkeit);
            this.Controls.Add(this.ChaosSpiel);
            this.Controls.Add(this.DrehungSpiegelungStreckung);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CtlMindMap";
            this.Size = new System.Drawing.Size(1223, 636);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CtlMindMap_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CtlMindMap_MouseClick(object sender, MouseEventArgs e)
        {

#if DEBUG
            Console.WriteLine("MindMap Measurement --> X: " + e.X + " Y: " + e.Y);
#endif

        }


        public void Notify()
        {
            this.BeginInvoke(new Action(() => { this.Refresh(); }));
        }
    }
}
