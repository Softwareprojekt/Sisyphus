
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
        protected CancellationToken _abortToken;
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
            // see 2nd example from: http://blogs.msdn.com/b/pfxteam/archive/2009/05/22/9635790.aspx
            // not really sure how to use it in StartWork or DoWork

            ManualResetEvent mre = new ManualResetEvent(false);
            //register a callback that will set the MRE
            CancellationTokenRegistration registration =
               _abortToken.Register(() => mre.Set());
            using (registration)
            {
                mre.WaitOne();
                if (_abortToken.IsCancellationRequested) //did cancellation wake us?
                    throw new OperationCanceledException(_abortToken);
            } //dispose the registration, which performs the deregisteration. 

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
            Task.Factory.StartNew(() => DoWork(_view), _abortToken);
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
        /// Much calculation.
        /// </summary>
        // TODO: find out which input arguments are needed here
        // people who implement these methods should speak with each other, to clarify it;
        // the output result needs also clarification! Not sure if result of Type Dictionary makes sense.
        protected abstract void DoWork(IView view);
    }
}
