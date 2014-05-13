using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public interface IView
    {
    
        IController IController
        {
            get;
            set;
        }

        void SetController(IController controller);

        /// <summary>
        /// Shows results from Calculation
        /// </summary>
        void Show();
    }
}
