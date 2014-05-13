using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public interface IController
    {
        IView IView
        {
            get;
            set;
        }

        void AddView(IView view);
    }
}
