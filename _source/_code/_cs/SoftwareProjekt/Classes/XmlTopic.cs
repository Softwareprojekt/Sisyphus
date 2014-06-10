using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class XmlTopic
    {
        private string _topicName;
        private string _dllPath;

        private List<XmlExercise> _xmlExerciseList;
        private int _topicID;
        private List<TopicConnect> _connectionList;

        public XmlTopic()
        {
            _connectionList = new List<TopicConnect>();
            _xmlExerciseList = new List<XmlExercise>();
            _topicName = "";
            _topicID = -1;
        }

        public List<XmlExercise> ExerciseList
        {
            get
            {
                return _xmlExerciseList;
            }
            set
            {
                _xmlExerciseList = value;
            }
        }
        public List<TopicConnect> ConnectionList
        {
            get { return _connectionList; }
            set { _connectionList = value; }
        }
        public string TopicName
        {
            get
            {
                return _topicName;
            }
            set
            {
                _topicName = value;
            }
        }
        public string DllPath
        {
            get { return _dllPath; }
            set { _dllPath = value; }
        }
        public int TopicID
        {
            get { return _topicID; }
            set { _topicID = value; }
        }
    }
}
