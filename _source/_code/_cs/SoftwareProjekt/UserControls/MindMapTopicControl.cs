using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public class MindMapTopicControl : UserControl
    {
        private List<MindMapButtonControl> _mindMapButtonList;
        private ITopic _logicalTopic;
        private List<TopicConnect> _topicConnectionList;


        public MindMapTopicControl()
        {
            _mindMapButtonList = new List<MindMapButtonControl>();
            _topicConnectionList = new List<TopicConnect>();

            _logicalTopic = null;

            InitializeComponent();
        }

        public List<MindMapButtonControl> ButtonList
        {
            get
            {
                return _mindMapButtonList;
            }
        }
        public List<TopicConnect> TopicConnectionList
        {
            get
            {
                return _topicConnectionList;
            }
        }

        public ITopic LogicalTopic
        {
            get
            {
                return _logicalTopic;
            }
        }

        public void RegisterTopic(ITopic topic)
        {
            _logicalTopic = topic;
        }

        public void UnregisterTopic()
        {
            _logicalTopic = null;
        }

        public void OnExcerciseButtonClicked(int excerciseID)
        {
            if (_logicalTopic == null)
            {
                return;
            }

            _logicalTopic.StartExcercise((Excercises)excerciseID);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MindMapTopicControl
            // 
            this.Name = "MindMapTopicControl";
            this.Paint += MindMapTopicControl_Paint;
            this.ResumeLayout(false);

        }

        void MindMapTopicControl_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
