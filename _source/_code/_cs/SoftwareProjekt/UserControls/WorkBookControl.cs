using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public class WorkBookView : UserControl
    {
        private int _excerciseID;
        private string _imagePath;
        private string _notices;
        private Image _savedImage;
        private string _dateTime;

         /// <summary>
        /// ctor
        /// </summary>
        public WorkBookView()
        {
            InitializeComponent();

            throw new System.NotImplementedException();
        }

        public int CreationDate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Notizen
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int ExcerciseID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WorkBookView
            // 
            this.Name = "WorkBookView";
            this.Paint += WorkBookControl_Paint;
            this.ResumeLayout(false);

        }

        void WorkBookControl_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ForceRefresh()
        {
            throw new System.NotImplementedException();
        }

    }
}
