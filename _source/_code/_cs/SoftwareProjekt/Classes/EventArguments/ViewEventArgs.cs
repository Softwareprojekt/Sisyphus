
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

using SoftwareProjekt.Classes.Math;
using SoftwareProjekt.Enums;
using System;

namespace SoftwareProjekt.Classes.EventArguments
{
    public class ViewEventArgs : EventArgs
    {
        /// <summary>
        /// Holds the event that happened on the View.
        /// </summary>
        public EViewEvents ViewEvent
        {
            get;
            private set;
        }

        /// <summary>
        /// Holds the x, y coordinates in case of ViewEvent is Coordinate.
        /// </summary>
        public Vector Coordinates
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        public EClickedButton ClickedButton
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public ViewEventArgs(EClickedButton e)
        {
            this.ViewEvent = EViewEvents.ButtonClick;
            this.ClickedButton = e;
        }

        /// <summary>
        /// Creates a new ViewEventArgs object holding coordinates in a Vector object.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        public ViewEventArgs(float x, float y)
        {
            this.ViewEvent = EViewEvents.Coordinate;
            this.Coordinates = new Vector(x, y);
        }
    }

}
