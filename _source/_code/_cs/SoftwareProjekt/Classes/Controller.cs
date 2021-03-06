﻿
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

using SoftwareProjekt.Classes.EventArguments;
using SoftwareProjekt.Enums;
using SoftwareProjekt.Interfaces;
using SoftwareProjekt.Exercises;
using SoftwareProjekt.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SoftwareProjekt.Classes
{
    public class Controller : IController
    {
        /// <summary>
        /// List with open Exercises and corresponding Views.
        /// </summary>
        private Dictionary<IView, IExercise> _exerciseList;

        private AbstractView _mainForm;

        private FrmProgress _progressForm;
        public Controller(AbstractView mainForm)
        {
            _exerciseList = new Dictionary<IView, IExercise>(10);
            _mainForm = mainForm;
            _mainForm.Controller = this;
            _mainForm.ViewChanged += this.HandleViewChanged;
            _progressForm = new FrmProgress();

            Application.Run(mainForm);
        }

        void HandleViewChanged(IView sender, ViewEventArgs e)
        {
            switch (e.ViewEvent)
            {
                case EViewEvents.Coordinate:
                    Console.WriteLine(sender + " " + e.Coordinates.ToString());
                    break;
                case EViewEvents.ButtonClick:
                    Console.WriteLine(sender + " " + e.ClickedButton.ToString());

                    // get exercise corresponding to view.
                    switch (e.ClickedButton)
                    {
                        case EClickedButton.StartCalculation:
                            _progressForm.Exercise = _exerciseList[sender];
                            _exerciseList[sender].StartWork();
                            _progressForm.ShowDialog();
                            break;
                        case EClickedButton.StartExercise:
                            IExercise exercise = null;
                            IView view = null;

                            //TODO: 
                            switch (e.ExerciseId)
                            {
                                case EExercises.VertraeglichkeitMitLinearkomb:
                                    exercise = new VertrMitLinearkomb();
                                    view = new FrmVertrMitLinearkomb();
                                    break;
                                case EExercises.LinAbbAusSumBelVek:
                                    exercise = new LinAbbSumBelVek();
                                    view = new FrmLinAbbSumBelVek();
                                    break;
                                case EExercises.LinAbbMitVielfachemBelVek:
                                    exercise = new LinAbbVielBelVek();
                                    view = new FrmLinAbbVielBelVek();
                                    break;
                                case EExercises.HintereinanderausfLinAbb:
                                    exercise = new HinterLinAbb();
                                    view = new FrmHinterLinAbb();
                                    break;
                                case EExercises.UmkehrungLinAbb:
                                    exercise = new UmkehrungLinAbb();
                                    view = new FrmUmkehrungLinAbb();
                                    break;
                                case EExercises.DrehungLinAbbUmUrsprung:
                                    exercise = new DrehLinAbbUrsp();
                                    view = new FrmDrehLinAbbUrsp();
                                    break;
                                case EExercises.SpiegelungLinAbbanUrspungsgeraden:
                                    exercise = new SpiegLinAbbUrsp();
                                    view = new FrmSpiegLinAbbUrsp();
                                    break;
                                case EExercises.ZuordungsvorschriftEinerAffAbb:
                                    exercise = new ZuordAffAbb();
                                    view = new FrmZuordAffAbb();
                                    break;
                                case EExercises.FraktalerzeugungMitIFS:
                                    exercise = new FraktalErzIFS();
                                    view = new FrmFraktalErzIFS();
                                    break;
                                case EExercises.FraktalerzeugungMitChaos:
                                    exercise = new FraktalChaos();
                                    view = new FrmFraktalChaos();
                                    break;
                                default:
                                    break;
                            }
                            this.AddExercise(exercise, view);
                            break;
                        case EClickedButton.CloseProgressForm:
                            _progressForm.Invoke(new Action(() => _progressForm.Close()));
                            break;
                        default:
                            throw new ArgumentException("Not a valid ClickedButton.", "e");
                    }
                    break;
                default:
                    throw new ArgumentException("Not a valid ViewEvent.", "e");
            }
        }

        public void AddExercise(IExercise exercise, IView view)
        {
            // connect to eventhandler and attach to exercise.
            view.ViewChanged += HandleViewChanged;
            view.Closing += view_Closing;
            view.Controller = this;
            exercise.AttachView(view);

            // check workbook for existing entries for this exercise.
            view.LoadState(Workbook.Instance.GetEntryState(exercise.Id));

            // change colors of input and result vectors
            view.inputColor = _mainForm.inputColor;
            view.resultColor = _mainForm.resultColor;

            // add exercise and view to list.
            _exerciseList.Add(view, exercise);

            view.Show();
        }

        void view_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _exerciseList[(IView)sender].AbortWork();
            this.RemoveExercise((IView)sender);
        }

        public void RemoveExercise(IView view)
        {
            IExercise exercise = _exerciseList[view];
            // save state of exercise in workbook.
            if (Workbook.Instance.Username != null && MessageBox.Show("Möchten Sie diese Übung ihn Ihrem Arbeitsheft speichern?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Workbook.Instance.SetEntryState(exercise.Id, view.SaveState(), view);
            }

            // disconnect and dispose view before releasing reference.
            view.ViewChanged -= HandleViewChanged;
            view.Dispose();

            // remove exercise and view from list.
            _exerciseList.Remove(view);
        }
    }
}
