
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
    public interface IView
    {
        /// <summary>
        /// Redirect events fired on the View to the Controller.
        /// </summary>
        event ViewHandler<ViewEventArgs> ViewChanged;

        /// <summary>
        /// Associated Controller.
        /// </summary>
        IController Controller
        {
            get;
            set;
        }

        /// <summary>
        /// Returns all data needed for calculation in the model.
        /// </summary>
        Dictionary<string, Object> GetInputData();

        void ExerciseChanged(IExercise sender, ExerciseEventArgs e);

        void Dispose();
    }
}
