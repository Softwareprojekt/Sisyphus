using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class TopicConnect
    {
        private EConnectionType _connectionType;
        private int _foreignTopicID;

        public EConnectionType ConnectionType
        {
            get
            {
                return _connectionType;
            }
            set
            {
                _connectionType = value;
            }
        }

        public int ForeignTopicID
        {
            get
            {
                return _foreignTopicID;
            }
            set
            {
                _foreignTopicID = value;
            }
        }
    }
}
