using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class Controller : IController
    {
        public Controller(IView view)
        {
            this.IView = view;
            view.SetController(this);
            throw new System.NotImplementedException();
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


        public void AddView(IView view)
        {
            throw new NotImplementedException();
        }
    }
}
