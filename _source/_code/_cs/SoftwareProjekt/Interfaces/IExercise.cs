
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
using SoftwareProjekt.Enums;
using System.IO;

namespace SoftwareProjekt.Interfaces
{
    public interface IExercise
    {
        /// <summary>
        /// Notify View that exercise has changed.
        /// </summary>
        event ExerciseHandler<ExerciseEventArgs> ExerciseChanged;

        EExercises Id
        {
            get;
            set;
        }

        /// <summary>
        /// Kill worker thread immediately.
        /// </summary>
        void AbortWork();

        /// <summary>
        /// Start worker thread and calculate.
        /// </summary>
        void StartWork();

        /// <summary>
        /// Attach View to Exercise. Used to notify View of new data.
        /// </summary>
        void AttachView(IView observer);
    }
}
