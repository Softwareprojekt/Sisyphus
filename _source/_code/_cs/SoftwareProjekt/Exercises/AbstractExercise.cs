
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
using SoftwareProjekt.Interfaces;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SoftwareProjekt.Exercises
{
    public abstract class AbstractExercise : IExercise
    {
        /// <summary>
        /// Name of exercise.
        /// </summary>
        protected Thread _workingThread = null;
        private IView _view;

        public EExercises Id
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        public void AbortWork()
        {
            if (_workingThread != null && _workingThread.IsAlive)
            {
                _workingThread.Abort();
            }
        }

        /// <summary>
        /// </summary>
        public bool LoadState(FileStream File)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        public bool SaveState(FileStream File, string Data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        public void StartWork()
        {
            // create a separate thread for DoWork()
            _workingThread = new Thread(() => this.DoWork(_view));
            _workingThread.Name = this.Id.ToString();
            _workingThread.Start();
        }

        /// <summary>
        /// </summary>
        public event ExerciseHandler<ExerciseEventArgs> ExerciseChanged;

        /// <summary>
        /// </summary>
        public void AttachView(IView observer)
        {
            ExerciseChanged += new ExerciseHandler<ExerciseEventArgs>(observer.ExerciseChanged);
            _view = observer;
        }

        /// <summary>
        /// Supply attached view with new calculated data.
        /// </summary>
        /// <param name="e">Calculated data.</param>
        protected void Finalize(ExerciseEventArgs e)
        {
            // fire event to notify view that stuff has changed.
            if (this.ExerciseChanged != null)
            {
                this.ExerciseChanged(this, e);
            }
        }

        /// <summary>
        /// Much calculation. Wow.
        /// </summary>
        protected abstract void DoWork(IView view);
    }
}
