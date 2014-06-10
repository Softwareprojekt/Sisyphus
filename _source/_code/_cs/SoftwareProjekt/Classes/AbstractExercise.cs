
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
using System.IO;
using System.Threading;
using System.Threading.Tasks;

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
        private EventHandler _doWorkEvent;
        protected CancellationToken _abortToken;

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
        public bool ResetState(FileStream File)
        {
            // works basically like LoadState, just with different 
            // files and without loading the user inputs

            // low priority, questionable if to-be-implemented 

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
        public void StartWork(Matrix aMatrix, Vector vVector)
        {
            // create a separate thread for DoWork()
            Task<Dictionary<string, double>> CalcTask = new Task<Dictionary<string, double>>(
                resultDictionary => this.DoWork(aMatrix, (Vector)vVector), "required to compile"); // FIXME: anyone with C# Task experience, 
                                                                                                  // please fix this or give advice to Wolfgang!
            CalcTask.Start();
            CalcTask.Wait(); // wait until the task completes
        }

        /// <summary>
        /// </summary>
        public void StopWork() 
        {
            // TOCLARIFY: should there be AbortWork and StopWork or is one sufficient??? 
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
        // TODO: find out which input arguments are needed here
        // people who implement these methods should speak with each other, to clarify it;
        // the output result needs also clarification! Not sure if result of Type Dictionary makes sense.
        protected Dictionary<string,double> DoWork(Matrix aMatrix, Vector vVector)
        {
            Dictionary<string, double> emptyDictionary = new Dictionary<string, double>();
            emptyDictionary[""] = 0.0;

            // fire event to notify view that stuff has changed.
            if (this.ExerciseChanged != null) {
            	this.ExerciseChanged(this, new ExerciseEventArgs());
            }
            return emptyDictionary;
        }

        public int GetExerciseID()
        {
            return _id;
        }
    }
}
