
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class Controller : IController
    {
        /// <summary>
        /// List with open Views.
        /// </summary>
        private List<IView> _viewList;
        /// <summary>
        /// List with open Excercises.
        /// </summary>
        private List<IExcercise> _excerciseList;

        public Controller()
        {
            _viewList = new List<IView>();
            _excerciseList = new List<IExcercise>();
        }

        public void AddView(IView view)
        {
            _viewList.Add(view);
        }

        public void AddExcercise(IExcercise excercise)
        {
            _excerciseList.Add(excercise);
        }

        public void FireEvent(IView v, ViewEventArgs e)
        {
            switch (e.ViewEvent)
            {
                case ViewEvents.ButtonClick:
                    break;
                case ViewEvents.TextChange:
                    break;
                default:
                    break;
            }
        }


        public void RemoveExcercise(IExcercise excercise)
        {
            _excerciseList.Remove(excercise);
        }

        public void RemoveView(IView view)
        {
            _viewList.Remove(view);
        }
    }
}
