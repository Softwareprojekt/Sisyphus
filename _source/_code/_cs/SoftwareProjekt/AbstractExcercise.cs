
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
    public abstract class AbstractExcercise : IExcercise
    {
        private int _iID;
        private int _sName;
    
        public void AbortWork()
        {
            throw new NotImplementedException();
        }

        public void LoadState()
        {
            throw new NotImplementedException();
        }

        public void ResetState()
        {
            throw new NotImplementedException();
        }

        public void SaveState()
        {
            throw new NotImplementedException();
        }

        public void SetController()
        {
            throw new NotImplementedException();
        }

        public void StartExcercise()
        {
            throw new NotImplementedException();
        }

        public void StopExcercise()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// @TODO: should be renamed (GC)
        /// </summary>
        public void Finalize()
        {
            throw new System.NotImplementedException();
        }

        public IController IController
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IView IView
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}
