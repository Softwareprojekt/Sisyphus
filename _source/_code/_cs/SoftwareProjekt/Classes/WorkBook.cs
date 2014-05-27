using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SoftwareProjekt
{
    public class WorkBook 
    {
        private List<WorkBookView> _controlsList;
        private XmlWorkbook ConfigFile;
        private int _username;
        private ScreenshotCreator _screenshotBuilder;
    
        public string Username
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<WorkBookView> GetWorkBookControl(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Load(string filename)
        {
            throw new System.NotImplementedException();
        }

        public void Save(int id, UserControl control, string notices)
        {
            throw new System.NotImplementedException();
        }

    }
}
