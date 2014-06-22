
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

using SoftwareProjekt.Classes.Xml;
using SoftwareProjekt.UserControls.MindMap;
using SoftwareProjekt.UserControls.Workbook;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SoftwareProjekt.Classes
{
    public class Workbook
    {        
        private static Workbook _instance = null;
        private string _username;
        private readonly string _folderName = null;
        private List<WorkbookEntry> _workbookEntriyList;
        private Workbook()
        {
            _folderName = Path.Combine(Directory.GetCurrentDirectory(), "Workbooks");

            _workbookEntriyList = new List<WorkbookEntry>(Enum.GetNames(typeof(Enums.EExercises)).Length);
            for (int i = 1; i < _workbookEntriyList.Capacity; i++)
            {
                WorkbookEntry entry = new WorkbookEntry();
                entry.ExerciseID = (Enums.EExercises)i;
                _workbookEntriyList.Add(entry);
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                this.Load();
            }
        }

        public static Workbook Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Workbook();
                }
                return _instance;
            }
        }

        /// <summary>
        /// loads all entries from xml-file
        /// </summary>
        private bool Load()
        {
            
            // parse XML-File
            string file = Path.Combine(_folderName, _username + ".xml");
            if(!File.Exists(file))
            {
                return false;
            }
            XmlReader reader = XmlReader.Create(file);

            reader.ReadToFollowing("Username");
            if (_username != reader.ReadElementString("Username"))
            {
                return false;
            }
            foreach (WorkbookEntry entry in _workbookEntriyList)
            {
                reader.ReadToFollowing("CreationDate");
                entry.CreationDate = DateTime.Parse(reader.ReadElementString("CreationDate"));
                reader.ReadToFollowing("ExerciseID");
                entry.ExerciseID = (Enums.EExercises) Enum.Parse(typeof(Enums.EExercises), reader.ReadElementString("ExerciseID"));

                //@TODO:
                //reader.IsStartElement()
                while (true)
                {
                    string key;
                    object value;
                    entry.State = new Dictionary<string, object>();
                    float x11 = float.Parse("");
                    float x12 = float.Parse("");
                    float x21 = float.Parse("");
                    float x22 = float.Parse("");

                    entry.State.Add("Matrix1", new Math.Matrix(x11, x21, x21, x22));
                }
                
            }
            // save data in the WorkbookEntry-list

            return true;
        }

        /// <summary>
        /// saves all entries to xml-file
        /// </summary>
        private void Save()
        {
            string file = Path.Combine(_folderName, _username + ".xml");
            string dir = Path.GetDirectoryName(file);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            XmlWriter writer = XmlWriter.Create(file);

            writer.WriteStartDocument();
            writer.WriteStartElement("Workbook");
            writer.WriteElementString("Username", _username);

            writer.WriteStartElement("WorkbookEntries");
            foreach (WorkbookEntry entry in _workbookEntriyList)
            {
                writer.WriteStartElement("WorkbookEntry");

                writer.WriteElementString("CreationDate", entry.CreationDate.ToString());
                writer.WriteElementString("ExerciseID", entry.ExerciseID.ToString());

                //data
                if (entry.State == null) //started?
                {
                    writer.WriteEndElement(); 
                    continue;
                }
                Dictionary<string,object>.Enumerator enumerator = entry.State.GetEnumerator();                
                while (enumerator.MoveNext())
                {
                    writer.WriteStartElement("DictionaryEntry");
                    string key = enumerator.Current.Key;
                    object value = enumerator.Current.Value;

                    writer.WriteElementString("Key", key);
 
                    if(value.GetType() == typeof(SoftwareProjekt.Classes.Math.Vector))
                    {
                        writer.WriteStartElement("Vector");
                        writer.WriteElementString("X1", (value as SoftwareProjekt.Classes.Math.Vector).X1.ToString());
                        writer.WriteElementString("X2", (value as SoftwareProjekt.Classes.Math.Vector).X2.ToString());
                        writer.WriteEndElement(); // Vector
                    }
                    else if (value.GetType() == typeof(SoftwareProjekt.Classes.Math.Matrix))
                    {
                        writer.WriteStartElement("Matrix");
                        writer.WriteElementString("X11", (value as SoftwareProjekt.Classes.Math.Matrix).X11.ToString());
                        writer.WriteElementString("X12", (value as SoftwareProjekt.Classes.Math.Matrix).X12.ToString());
                        writer.WriteElementString("X21", (value as SoftwareProjekt.Classes.Math.Matrix).X21.ToString());
                        writer.WriteElementString("X22", (value as SoftwareProjekt.Classes.Math.Matrix).X22.ToString());
                        writer.WriteEndElement(); // Matrix
                    }
                    else if (value.GetType() == typeof(float)) //notes
                    {
                        writer.WriteStartElement("Value");
                        writer.WriteElementString("value", value as string);
                        writer.WriteEndElement(); // Notes
                    }
                    else if (value.GetType() == typeof(string)) //notes
                    {
                        writer.WriteStartElement("Notes");
                        writer.WriteElementString("Notes", value as string);
                        writer.WriteEndElement(); // Notes
                    }
                    else
                    {

                    }
                    writer.WriteEndElement(); // DictionaryEntry
                }

                writer.WriteEndElement();
            }
            writer.WriteEndElement(); // WorkbookEntries
            writer.WriteEndElement(); // Workbook
            writer.WriteEndDocument();

            writer.Close();
        }

        /// <summary>
        /// list of usernames/workbooks
        /// </summary>
        public List<string> GetAvailableWorkbooks()
        {
            List<string> usernames = new List<string>();
            // check each xml-file in workbook-folder for name
            foreach (string file in Directory.EnumerateFiles(_folderName, "*.xml"))
            {
                XmlReader reader = XmlReader.Create(file);
                usernames.Add(reader.ReadElementString("Username"));
                reader.Close();
            }
            return usernames;
        }

        public System.Collections.Generic.Dictionary<string, object> GetEntryState(Enums.EExercises id)
        {
            foreach (WorkbookEntry entry in _workbookEntriyList)
            {
                if (entry.ExerciseID == id)
                {
                    return entry.State;
                }
            }
            //no entry with this Exercise
            return null;
        }

        public void SetEntryState(Enums.EExercises id, System.Collections.Generic.Dictionary<string, object> state)
        {
            foreach (WorkbookEntry entry in _workbookEntriyList)
            {
                if (entry.ExerciseID == id)
                {
                    entry.State = state;
                    return;
                }
            }
            this.Save();
        }

    }
}
