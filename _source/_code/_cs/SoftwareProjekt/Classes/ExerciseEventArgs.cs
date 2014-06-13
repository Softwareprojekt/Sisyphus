
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt
{
    public class ExerciseEventArgs : EventArgs
    {
        public Dictionary<string, Object> CalcValues
        {
            get;
            private set;
        }
        /// <summary>
        /// Empty ctor.
        /// </summary>
        public ExerciseEventArgs()
        {

        }

        /// <summary>
        /// Ctor to return processed values to view.
        /// </summary>
        /// <param name="dict">Dictionary with processed values.</param>
        public ExerciseEventArgs(Dictionary<string, Object> dict)
        {
            this.CalcValues = dict;
        }

        public override string ToString()
        {
            int i = 0;
            string ret = string.Format("[ExerciseEventArgs Count={0}, ", this.CalcValues.Count);
            for (; i < this.CalcValues.Keys.Count - 1; i++)
            {
                ret += "Key" + i + "='" + this.CalcValues.Keys.ToArray()[i] + "', ";
            }
            ret += "Key" + i + "='" + this.CalcValues.Keys.ToArray()[i] + "']";
            return ret;
        }
    }
}
