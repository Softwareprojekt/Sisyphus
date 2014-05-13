using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public class MainWindow : Form, IView
    {

        public void Show()
        {
            throw new NotImplementedException();
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

        public MindMap MindMap
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


        public void SetController(IController controller)
        {
            throw new NotImplementedException();
        }
    }
}
