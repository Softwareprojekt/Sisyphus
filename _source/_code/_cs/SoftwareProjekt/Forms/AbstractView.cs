
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
using SoftwareProjekt.Delegates;
using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoftwareProjekt.Forms
{
    public abstract class AbstractView : Form, IView
    {
        public event ViewHandler<ViewEventArgs> ViewChanged;

        /// <summary>
        /// Throws an event to subscribed listeners.
        /// </summary>
        /// <param name="e">ViewEventArgs object containing the data.</param>
        protected virtual void OnViewChanged(ViewEventArgs e)
        {
            ViewHandler<ViewEventArgs> handler = ViewChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        /// <summary>
        /// </summary>
        public IController Controller
        {
            get;
            set;
        }

        public abstract void ExerciseChanged(IExercise sender, ExerciseEventArgs e);

        public abstract Dictionary<string, Object> GetInputData();

        protected abstract bool CheckInputs();

        public abstract bool LoadState(Dictionary<string, object> state);

        public Dictionary<string, object> SaveState()
        {
            return this.GetInputData();
        }
    }
}
