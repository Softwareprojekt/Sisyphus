
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

namespace SoftwareProjekt.Classes
{
    public class Controller : IController
    {
        /// <summary>
        /// List with open Exercises and corresponding Views.
        /// </summary>
        private Dictionary<IExercise, IView> _exerciseList;

        private System.Windows.Forms.Form _mainForm;

        public Controller(System.Windows.Forms.Form mainForm)
        {
            //TODO: Change IExercise to Value and IView to Key in Dictionary.
            _exerciseList = new Dictionary<IExercise, IView>(10);
            _mainForm = mainForm;
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
                            _exerciseList.Single(x => x.Value == sender).Key.StartWork();
                            break;
                        case EClickedButton.StartExercise:
                            IExercise exercise = null;
                            IView view = null;
                            
                            //TODO: 
                            switch (e.ExerciseId)
                            {
                                case EExercises.ZuordnungsvorschriftLinAbb:
                                    break;
                                case EExercises.LinAbbAusSumBelVek:
                                    break;
                                case EExercises.LinAbbMitVielfachemBelVek:
                                    break;
                                case EExercises.HintereinanderausfLinAbb:
                                    break;
                                case EExercises.UmkehrungLinAbb:
                                    break;
                                case EExercises.DrehungLinAbbUmUrsprung:
                                    exercise = new DrehLinAbbUrsp();
                                    view = new FrmDrehLinAbbUrsp();
                                    break;
                                case EExercises.SpiegelungLinAbbanUrspungsgeraden:
                                    break;
                                case EExercises.ZuordungsvorschriftEinerAffAbb:
                                    break;
                                case EExercises.FraktalerzeugungMitIFS:
                                    break;
                                default:
                                    break;
                            }
                            this.AddExercise(exercise, view);
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

            // add exercise and view to list.
            _exerciseList.Add(exercise, view);
        }

        void view_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.RemoveExercise((IView)sender);
        }

        public void RemoveExercise(IView view)
        {
            IExercise exercise = _exerciseList.Single(x => x.Value == view).Key;
            // save state of exercise in workbook.
            Workbook.Instance.SetEntryState(exercise.Id, view.SaveState());

            // disconnect and dispose view before releasing reference.
            view.ViewChanged -= HandleViewChanged;
            view.Dispose();

            // remove exercise and view from list.
            _exerciseList.Remove(exercise);
        }
    }
}
