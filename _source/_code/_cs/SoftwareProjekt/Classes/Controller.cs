
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

using SoftwareProjekt.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class Controller : IController
    {
        /// <summary>
        /// List with open Exercises and corresponding Views.
        /// </summary>
        private Dictionary<IExercise, IView> _exerciseList;

        public Controller()
        {
            _exerciseList = new Dictionary<IExercise, IView>(10);
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
                    IExercise exercise = _exerciseList.Single(x => x.Value == sender).Key;
                    switch (e.ClickedButton)
                    {
                        case EClickedButton.StartCalculation:
                            exercise.StartWork();
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
            view.Controller = this;
            exercise.AttachView(view);

            // add exercise and view to list.
            _exerciseList.Add(exercise, view);
        }

        public void RemoveExercise(IExercise exercise)
        {
            // disconnect and dispose view before releasing reference.
            IView v = _exerciseList[exercise];
            v.ViewChanged -= HandleViewChanged;
            v.Dispose();

            // remove exercise and view from list.
            _exerciseList.Remove(exercise);
        }
    }
}
