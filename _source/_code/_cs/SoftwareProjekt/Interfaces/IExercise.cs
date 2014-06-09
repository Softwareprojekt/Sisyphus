
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
    public interface IExercise
    {
        /// <summary>
        /// Notify View that exercise has changed.
        /// </summary>
        event ExerciseHandler<ExerciseEventArgs> ExerciseChanged;

        /// <summary>
        /// Kill worker thread immediately.
        /// </summary>
        void AbortWork();

        /// <summary>
        /// Load state of exercise from file.
        /// </summary>
        void LoadState();

        /// <summary>
        /// Reset state of exercise. Default values.
        /// </summary>
        void ResetState();

        /// <summary>
        /// Save state of exercise to file.
        /// </summary>
        void SaveState();

        /// <summary>
        /// Start worker thread and calculate.
        /// </summary>
        void StartWork();

        /// <summary>
        /// Stop worker thread gracefully.
        /// </summary>
        void StopWork();

        /// <summary>
        /// Attach View to Exercise. Used to notify View of new data.
        /// </summary>
        void AttachView(IExerciseObserver observer);

        /// <summary>
        /// returns the exercise id
        /// </summary>
        /// <returns>the exercise id</returns>
        int GetExerciseID();
    }
}
