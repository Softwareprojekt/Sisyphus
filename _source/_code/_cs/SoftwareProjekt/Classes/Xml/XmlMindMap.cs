
#region LicenseHeader
/*
 * Copyright (C) 2014 Technische Hochschule Amberg
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
#endregion

using SoftwareProjekt.Enums;
using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace SoftwareProjekt.Classes.Xml
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


                    } while (connections.MoveToNext());

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
