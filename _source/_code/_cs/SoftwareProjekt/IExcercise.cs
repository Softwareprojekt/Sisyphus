using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public interface IExcercise : INotebook
    {
        IController IController
        {
            get;
            set;
        }

        /// <summary>
        /// Shows the results in the View
        /// </summary>
        IView IView
        {
            get;
            set;
        }
    
        void AbortWork();

        void LoadState();

        void ResetState();

        void SaveState();

        void SetController();

        void StartExcercise();

        void StopExcercise();
    }
}
