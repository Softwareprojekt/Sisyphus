
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

using SoftwareProjekt.UserControls.Workbook;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.IO;
using System.Xml;
using SoftwareProjekt.Classes.Math;
using System.Drawing;
using System.Globalization;

namespace SoftwareProjekt.Classes
{
    public class Workbook
    {
        private static Workbook _instance = null;
        private string _username;
        private readonly string _folderName = null;
        private List<WorkbookEntry> _workbookEntryList;
        private Workbook()
        {
            _folderName = Path.Combine(Directory.GetCurrentDirectory(), "Workbooks");

            _workbookEntryList = new List<WorkbookEntry>(Enum.GetNames(typeof(Enums.EExercises)).Length);
            for (int i = 1; i < _workbookEntryList.Capacity + 1; i++)
            {
                WorkbookEntry entry = new WorkbookEntry();
                entry.ExerciseID = (Enums.EExercises)i;

                _workbookEntryList.Add(entry);
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
                foreach (WorkbookEntry entry in _workbookEntryList)
                {
                    entry.Clear();
                }
                _username = value;

                if (value == null)
                {
                    return;
                }
                try
                {
                    this.Load();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not load the Workbook.\nFile might be corrupted.", "Workbook", MessageBoxButtons.OK);
                    Console.WriteLine("ERROR @ Workbook.Load: " + e.Message);
                    this.Username = null;
                }

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
            if (!File.Exists(file))
            {
                return false;
            }
            XmlReader reader = XmlReader.Create(file);
            reader.ReadToFollowing("Username");
            if (_username != reader.ReadElementString("Username"))
            {
                return false;
            }
            foreach (WorkbookEntry entry in _workbookEntryList)
            {
                reader.ReadToFollowing("CreationDate");
                entry.CreationDate = DateTime.Parse(reader.ReadElementString("CreationDate"), CultureInfo.InvariantCulture);
                reader.ReadToFollowing("ExerciseID");
                entry.ExerciseID = (Enums.EExercises)Enum.Parse(typeof(Enums.EExercises), reader.ReadElementString("ExerciseID"));

                reader.ReadToFollowing("NumberOfDictionaryEntries");
                int noe;

                if (!int.TryParse(reader.ReadElementString("NumberOfDictionaryEntries"), out noe))
                {
                    continue;
                }
                if (noe != 0)
                {
                    entry.State = new Dictionary<string, object>();
                }
                for (int i = 0; i < noe; i++)
                {
                    reader.ReadToFollowing("Key");
                    string key = reader.ReadElementString("Key");
                    string elementType = "";
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                elementType = reader.Name;
                                break;
                            default:
                                break;
                        }
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            break; //while
                        }
                    }
                    if (elementType == "Vector")
                    {
                        reader.ReadToFollowing("X1");
                        float x1 = float.Parse(reader.ReadElementString("X1"), CultureInfo.InvariantCulture);

                        reader.ReadToFollowing("X2");
                        float x2 = float.Parse(reader.ReadElementString("X2"), CultureInfo.InvariantCulture);
                        Vector vec = new Vector(x1, x2);
                        entry.State.Add(key, vec);
                    }
                    else if (elementType == "Matrix")
                    {
                        reader.ReadToFollowing("X11");
                        float x11 = float.Parse(reader.ReadElementString("X11"), CultureInfo.InvariantCulture);

                        reader.ReadToFollowing("X12");
                        float x12 = float.Parse(reader.ReadElementString("X12"), CultureInfo.InvariantCulture);

                        reader.ReadToFollowing("X21");
                        float x21 = float.Parse(reader.ReadElementString("X21"), CultureInfo.InvariantCulture);

                        reader.ReadToFollowing("X22");
                        float x22 = float.Parse(reader.ReadElementString("X22"), CultureInfo.InvariantCulture);

                        Matrix m = new Matrix(x11, x12, x21, x22);
                        entry.State.Add(key, m);
                    }
                    else if (elementType == "Value")
                    {
                        reader.ReadToFollowing("Value");
                        float val = float.Parse(reader.ReadElementString("Value"), CultureInfo.InvariantCulture);

                        entry.State.Add(key, val);
                    }
                    else if (elementType == "Notes")
                    {
                        reader.ReadToFollowing("Notes");
                        string note = reader.ReadElementString("Notes");

                        entry.State.Add(key, note);
                    }
                    else
                    {

                    }
                }

            }

            reader.Close();

            //load all available images
            foreach (WorkbookEntry item in _workbookEntryList)
            {
                try
                {
                    string dir = Path.Combine(_folderName, _username);
                    string filename = Path.Combine(dir, item.ExerciseID.ToString() + ".bmp");
                    if (File.Exists(filename))
                    {
                        Bitmap pic = new Bitmap(filename);
                        item.Screenshot = (Image)pic;
                    }
                }
                catch (Exception)
                {
                    //could not load picture, 
                }

            }


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
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(file, settings);

            writer.WriteStartDocument();
            writer.WriteStartElement("Workbook");
            writer.WriteElementString("Username", _username);

            writer.WriteStartElement("WorkbookEntries");
            foreach (WorkbookEntry entry in _workbookEntryList)
            {
                writer.WriteStartElement("WorkbookEntry");

                writer.WriteElementString("CreationDate", entry.CreationDate.ToString(CultureInfo.InvariantCulture));
                writer.WriteElementString("ExerciseID", entry.ExerciseID.ToString());

                //data
                if (entry.State == null) //started?
                {
                    writer.WriteElementString("NumberOfDictionaryEntries", "0");
                    writer.WriteEndElement();
                    continue;
                }
                writer.WriteElementString("NumberOfDictionaryEntries", entry.State.Count.ToString());
                Dictionary<string, object>.Enumerator enumerator = entry.State.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    writer.WriteStartElement("DictionaryEntry");
                    string key = enumerator.Current.Key;
                    object value = enumerator.Current.Value;

                    writer.WriteElementString("Key", key);

                    if (value.GetType() == typeof(Vector))
                    {
                        writer.WriteStartElement("Vector");
                        writer.WriteElementString("X1", (value as Vector).X1.ToString(CultureInfo.InvariantCulture));
                        writer.WriteElementString("X2", (value as Vector).X2.ToString(CultureInfo.InvariantCulture));
                        writer.WriteEndElement(); // Vector
                    }
                    else if (value.GetType() == typeof(Matrix))
                    {
                        writer.WriteStartElement("Matrix");
                        writer.WriteElementString("X11", (value as Matrix).X11.ToString(CultureInfo.InvariantCulture));
                        writer.WriteElementString("X12", (value as Matrix).X12.ToString(CultureInfo.InvariantCulture));
                        writer.WriteElementString("X21", (value as Matrix).X21.ToString(CultureInfo.InvariantCulture));
                        writer.WriteElementString("X22", (value as Matrix).X22.ToString(CultureInfo.InvariantCulture));
                        writer.WriteEndElement(); // Matrix
                    }
                    else if (value.GetType() == typeof(Single)) //notes
                    {
                        writer.WriteStartElement("Value");
                        writer.WriteElementString("Value", ((Single)value).ToString(CultureInfo.InvariantCulture));
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
            if (!Directory.Exists(_folderName))
            {
                Directory.CreateDirectory(_folderName);
            }
            foreach (string file in Directory.EnumerateFiles(_folderName, "*.xml"))
            {
                XmlReader reader = XmlReader.Create(file);
                reader.ReadToFollowing("Username");
                usernames.Add(reader.ReadElementString("Username"));
                reader.Close();
            }
            return usernames;
        }

        public System.Collections.Generic.Dictionary<string, object> GetEntryState(Enums.EExercises id)
        {
            foreach (WorkbookEntry entry in _workbookEntryList)
            {
                if (entry.ExerciseID == id)
                {
                    return entry.State;
                }
            }
            //no entry with this Exercise
            return null;
        }

        public void SetEntryState(Enums.EExercises id, System.Collections.Generic.Dictionary<string, object> state, SoftwareProjekt.Interfaces.IView view)
        {
            if (string.IsNullOrEmpty(Username))
            {
                return;
            }

            WorkbookEntry entry1 = null;
            foreach (WorkbookEntry entry in _workbookEntryList)
            {
                if (entry.ExerciseID == id)
                {
                    entry1 = entry;
                    entry.State = state;
                    break;
                }
            }
            if (entry1 == null)
            {
                return;
            }
            try
            {
                this.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save the Workbook", "Workbook", MessageBoxButtons.OK);
            }
            string dir = Path.Combine(_folderName, _username);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string filename = Path.Combine(dir, id.ToString() + ".bmp");
            SoftwareProjekt.Forms.AbstractView aview = (SoftwareProjekt.Forms.AbstractView)view;
            Bitmap pic = new Bitmap(aview.Width, aview.Height);
            Rectangle r = new Rectangle(0, 0, aview.Width, aview.Height);
            aview.DrawToBitmap(pic, r);
            try
            {
                if (entry1 != null && entry1.Screenshot != null)
                {
                    entry1.Screenshot.Dispose();
                    entry1.Screenshot = null;
                }
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                pic.Save(filename);
                entry1.Screenshot = (Image)pic;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the form.\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AddEntries(System.Windows.Forms.Control.ControlCollection collection, PictureBox picbox)
        {
            foreach (WorkbookEntry item in _workbookEntryList)
            {
                item.PictureBox = picbox;
            }
            collection.AddRange(_workbookEntryList.ToArray());
        }

    }
}
