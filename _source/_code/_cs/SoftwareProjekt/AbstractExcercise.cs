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
