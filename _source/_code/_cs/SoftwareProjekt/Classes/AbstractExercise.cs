
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
    public abstract class AbstractExercise : IExercise
    {
        /// <summary>
        /// Id of exercise.
        /// </summary>
        private int _id;
        /// <summary>
        /// Name of exercise.
        /// </summary>
        private int _name;

        /// <summary>
        /// </summary>
        public void AbortWork()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        public void LoadState()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        public void ResetState()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        public void SaveState()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        public void StartWork()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        public void StopWork()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
		public event ExerciseHandler<ExerciseEventArgs> ExerciseChanged;

        /// <summary>
        /// </summary>
        public void AttachView(IExerciseObserver observer)
        {
            ExerciseChanged += new ExerciseHandler<ExerciseEventArgs>(observer.ExerciseChanged);
        }

        /// <summary>
        /// Much calculation.
        /// </summary>
        protected void DoWork()
        {
            // many calculation.
            // much results.
            // wow.

            // fire event to notify view that stuff has changed.
            if (this.ExerciseChanged != null) {
            	this.ExerciseChanged(this, new ExerciseEventArgs());
            }
        }
    }
}
