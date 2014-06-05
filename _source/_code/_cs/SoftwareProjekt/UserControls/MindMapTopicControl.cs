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

        public System.Collections.Generic.List<SoftwareProjekt.MindMapButtonControl> ButtonList
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ITopic LogicalTopic
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public System.Collections.Generic.List<SoftwareProjekt.TopicConnect> TopicConnectionList
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void RegisterTopic(ITopic topic)
        {
            throw new System.NotImplementedException();
        }

        public void UnregisterTopic()
        {
            throw new System.NotImplementedException();
        }

        public void OnExcerciseButtonClicked(int excerciseID)
        {
            throw new System.NotImplementedException();
        }
    }
}
