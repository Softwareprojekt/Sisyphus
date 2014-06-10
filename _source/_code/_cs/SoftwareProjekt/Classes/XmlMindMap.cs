using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace SoftwareProjekt
{
    public class XmlMindMap
    {
        private string _filename;
        private List<XmlTopic> _listXmlTopic;

        public List<XmlTopic> ListTopic
        {
            get
            {
                return _listXmlTopic;
            }
        }

        public XmlMindMap()
        {
            _filename = "";
            _listXmlTopic = new List<XmlTopic>();
        }

        public bool ParseXml(string filename)
        {
            _filename = filename;

            
            XPathDocument xPathDocument = null;

            try
            {
                xPathDocument = new XPathDocument(_filename);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            XPathNavigator nav = xPathDocument.CreateNavigator();

            if (!nav.MoveToFirstChild())
            {
                return false;
            }

            if (nav.Name != "content")
            {
                return false;
            }

            XPathNodeIterator main = nav.SelectChildren("Topic", "");

            while (main.MoveNext())
            {
                XPathNavigator topics = main.Current.CreateNavigator();
                XPathNavigator exercisesBU = main.Current.CreateNavigator();

                XmlTopic topic = new XmlTopic();
                string idAttribute = topics.GetAttribute("id", "");
                int id = -1;
                
                if (!int.TryParse(idAttribute, out id))
                {
                    return false;
                }
                topic.TopicID = id;

                XPathNodeIterator topicNameIt = topics.SelectChildren("Name", "");
                topicNameIt.MoveNext();

                topic.TopicName = topicNameIt.Current.Value;

                XPathNodeIterator dllPathIt = topics.SelectChildren("DLLPath", "");
                dllPathIt.MoveNext();
                topic.DllPath = dllPathIt.Current.Value;



                if (topics.MoveToChild("Connections", ""))
                {
                    XPathNavigator connections = topics.CreateNavigator();
                    connections.MoveToFirstChild();

                    do
                    {
                        TopicConnect topicConnect = new TopicConnect();
                        string connectionTypeRaw = connections.GetAttribute("type", "");
                        string nextTopicRaw = connections.Value;

                        int connectionType = -1;
                        if (!int.TryParse(connectionTypeRaw, out connectionType))
                        {
                            return false;
                        }

                        int nextTopicID = -1;
                        if (!int.TryParse(nextTopicRaw, out nextTopicID))
                        {
                            return false;
                        }

                        topicConnect.ConnectionType = (EConnectionType)connectionType;
                        topicConnect.ForeignTopicID = nextTopicID;

                        topic.ConnectionList.Add(topicConnect);


                    } while (connections.MoveToNext()) ;

                }


                if (exercisesBU.MoveToChild("Exercises", ""))
                {
                    XPathNavigator exercises = exercisesBU.CreateNavigator();
                    exercises.MoveToFirstChild();
                    
                    do
                    {
                        XmlExercise exercise = new XmlExercise();

                        string exerciseIDRaw = exercises.GetAttribute("id", "");
                        int exerciseID = -1;

                        if (!int.TryParse(exerciseIDRaw, out exerciseID))
                        {
                            return false;
                        }

                        exercise.ExerciseName = exercises.Value;
                        exercise.ExerciseID = exerciseID;

                        topic.ExerciseList.Add(exercise);


                    } while (exercises.MoveToNext());
                }

                this._listXmlTopic.Add(topic);
            } 


            return true;
        }
    }
}
