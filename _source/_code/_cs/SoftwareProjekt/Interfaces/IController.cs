
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
    public interface IController
    {

        /// <summary>
        /// Adds a ViewChanged to the List.
        /// </summary>
        void AddView(IView view);

        /// <summary>
        /// Adds an Exercise to the List.
        /// </summary>
        void AddExercise(IExercise exercise);

        /// <summary>
        /// Remove an Exercise from the List.
        /// </summary>
        void RemoveExercise(IExercise exercise);

        /// <summary>
        /// Remove a ViewChanged from the List.
        /// </summary>
        void RemoveView(IView view);
    }
}
