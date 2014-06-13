
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

using SoftwareProjekt.Classes;
using SoftwareProjekt.Classes.Xml;
using SoftwareProjekt.Enums;
using SoftwareProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace SoftwareProjekt.UserControls.MindMap
{
    public class CtlMindMap : UserControl
    {
        private const string _filename = "config.xml";
        private List<MindMapTopicControl> _graphicalTopicList;
        private List<ITopic> _logicalTopicList;
        private List<dynamic> _dynamicExternalDll;
        private XmlMindMap _xmlParser;

        private bool _initialised;

        public CtlMindMap()
        {
            _graphicalTopicList = new List<MindMapTopicControl>();
            _logicalTopicList = new List<ITopic>();
            _dynamicExternalDll = new List<dynamic>();
            _xmlParser = new XmlMindMap();

            _initialised = false;
        }

        public void ArrangeMindMap()
        {
            this.SuspendLayout();

            this.Controls.Clear();

            int nrOfTopics = _graphicalTopicList.Count;

            int innerQuaderStartX = this.Width / 4;
            int innerQuaderStartY = this.Height / 4;

            int innerQuaderEndX = this.Width - innerQuaderStartX;
            int innerQuaderEndY = this.Height - innerQuaderStartY;

            int innerQuaderHeight = innerQuaderEndY - innerQuaderStartY;
            int innerQuaderHalfWidth = (innerQuaderEndX - innerQuaderStartX) / 2;

            int dividerTopX = innerQuaderStartX +
                    (innerQuaderEndX - innerQuaderStartX);

            int dividerTopY = innerQuaderStartY;

            int dividerBottomX = dividerTopX;
            int dividerBottomY = innerQuaderEndY;

            int nrOfLines = (nrOfTopics - 1) / 2;

            int possibleNrOfTopics = (nrOfLines + 1) * 2;
            int heightPerLine = innerQuaderHeight / (nrOfLines + 1);

            int lineOffset = 0;
            for (int i = 0; i < _graphicalTopicList.Count; i++)
            {
                if (_graphicalTopicList.Count % 2 == 1 && i == 0)
                {
                    this._graphicalTopicList[i].Size = new System.Drawing.Size(innerQuaderHalfWidth - 15, heightPerLine - 30);
                    this._graphicalTopicList[i].Location = new System.Drawing.Point(innerQuaderStartX + innerQuaderHalfWidth / 2, dividerTopY + 15);
                    lineOffset += 1;


                    this.AddExercises(_graphicalTopicList[i], EAlignType.AlignBottom | EAlignType.AlignRight | EAlignType.AlignLeft, innerQuaderStartX + innerQuaderHalfWidth / 2, dividerTopY, heightPerLine);
                }
                else
                {
                    this._graphicalTopicList[i].Size = new System.Drawing.Size(innerQuaderHalfWidth - 15, heightPerLine - 30);

                    int xValueOffset = 0;

                    if (nrOfTopics % 2 == 1)
                    {
                        if (i % 2 == 0)
                        {
                            xValueOffset = innerQuaderStartX + innerQuaderHalfWidth + 15;

                            this.AddExercises(_graphicalTopicList[i], EAlignType.AlignLeft, xValueOffset, innerQuaderStartY + lineOffset * heightPerLine, heightPerLine);
                        }
                        else
                        {
                            xValueOffset = innerQuaderStartX;
                            this.AddExercises(_graphicalTopicList[i], EAlignType.AlignRight, xValueOffset, innerQuaderStartY + lineOffset * heightPerLine, heightPerLine);
                        }

                    }
                    else
                    {
                        if (i % 2 == 1)
                        {
                            xValueOffset = innerQuaderStartX + innerQuaderHalfWidth + 15;
                            this.AddExercises(_graphicalTopicList[i], EAlignType.AlignLeft, xValueOffset, innerQuaderStartY + lineOffset * heightPerLine, heightPerLine);
                        }
                        else
                        {
                            xValueOffset = innerQuaderStartX;
                            this.AddExercises(_graphicalTopicList[i], EAlignType.AlignRight, xValueOffset, innerQuaderStartY + lineOffset * heightPerLine, heightPerLine);
                        }
                    }


                    this._graphicalTopicList[i].Location =
                        new System.Drawing.Point(xValueOffset, innerQuaderStartY + lineOffset * heightPerLine + 15);

                    if (nrOfTopics % 2 != i % 2 && i != 0)
                    {
                        lineOffset++;
                    }
                }


                this.Controls.Add(_graphicalTopicList[i]);


            }

            this.ResumeLayout(false);

            this.Invalidate();
        }

        private void AddExercises(MindMapTopicControl mindMapTopicControl, EAlignType align, int x, int y, int lineHeight)
        {
            int numberOfExercises = mindMapTopicControl.ButtonList.Count;


            for (int i = 0; i < mindMapTopicControl.ButtonList.Count; i++)
            {

            }
        }

        private void createEntriesFromXml()
        {
            foreach (XmlTopic topic in _xmlParser.ListTopic)
            {
                MindMapTopicControl topicControl = new MindMapTopicControl();
                foreach (TopicConnect connection in topic.ConnectionList)
                {
                    topicControl.TopicConnectionList.Add(connection);
                }

                foreach (XmlExercise exercise in topic.ExerciseList)
                {
                    MindMapButtonControl buttonControl =
                        new MindMapButtonControl(exercise.ExerciseName, exercise.ExerciseID, EAlignType.AlignLeft);
                    topicControl.ButtonList.Add(buttonControl);
                }

                topicControl.TopicName = topic.TopicName;
                if (topic.DllPath == "n.A.")
                {
                    switch ((ETopic)topic.TopicID)
                    {
                        case ETopic.AffineTransformation:
                            break;

                        case ETopic.ComplexNumbers:
                            break;

                        case ETopic.Fractals:
                            break;

                        case ETopic.LinearTransformation:
                            topicControl.RegisterTopic(new LinearTransformationTopic());
                            break;

                        default:
                            Console.WriteLine
                                ("Got a real problem --> invalid TopicID and no external Lib used!\n");
                            continue;
                    }
                }
                else
                {
                    dynamic externalDll = LoadDllDynamically(topic.DllPath, topic.TopicName);
                    _dynamicExternalDll.Add(externalDll);
                    topicControl.RegisterDynamicData(externalDll);
                }

                this._graphicalTopicList.Add(topicControl);

            }
        }

        private dynamic LoadDllDynamically(string dllPath, string TopicName)
        {
            var DLL = Assembly.LoadFile(dllPath);

            foreach (Type t in DLL.GetExportedTypes())
            {
                if (t.AssemblyQualifiedName == TopicName)
                {
                    return Activator.CreateInstance(t);
                }

            }

            return null;
        }

        public bool ParseXML()
        {
            bool bRetVal = _xmlParser.ParseXml(_filename);
            if (_xmlParser.ListTopic == null)
            {
                return false;
            }

            createEntriesFromXml();
            _initialised = true;

            return true;
        }

        private void InitializeComponent()
        {
            if (!this._xmlParser.ParseXml(_filename))
            {
                return;
            }
            this.SuspendLayout();
            // 
            // CtlMindMap
            // 
            this.Name = "CtlMindMap";
            this.Paint += MindMap_Paint;
            this.ResumeLayout(false);

        }

        void MindMap_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
