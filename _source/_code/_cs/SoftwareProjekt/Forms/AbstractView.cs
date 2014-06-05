
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
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public abstract class AbstractView : Form, IView, IExcerciseObserver
    {
        public abstract void xyzChanged(IExcercise sender, ExcerciseEventArgs e);

        public event ViewHandler<ViewEventArgs> ViewChanged;

        /// <summary>
        /// Throws an event to subscribed listeners.
        /// </summary>
        /// <param name="e">ViewEventArgs object containing the data.</param>
		protected virtual void OnViewChanged(ViewEventArgs e)
		{
			ViewHandler<ViewEventArgs> handler = ViewChanged;
			if (handler != null)
			{
				handler(this, e);
			}
		}
        /// <summary>
        /// </summary>
        public IController Controller
        {
            get;
            set;
        }
    }
}
