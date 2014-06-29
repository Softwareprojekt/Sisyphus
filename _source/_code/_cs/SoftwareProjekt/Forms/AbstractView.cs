
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

using SoftwareProjekt.Classes.EventArguments;
using SoftwareProjekt.Delegates;
using SoftwareProjekt.Interfaces;
using SoftwareProjekt.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;


namespace SoftwareProjekt.Forms
{
    public class AbstractView : Form, IView
    {
        public Color inputColor
        {
            get { return _inputColor; }
            set
            {
                _inputColor = value;
            }
        }
        private Color _inputColor;

        public Color resultColor
        {
            get { return _resultColor; }
            set
            {
                _resultColor = value;
            }
        }
        private Color _resultColor;

        public Color instructionColor
        {
            get { return _instructionColor; }
            set
            {
                _instructionColor = value;
            }
        }
        private Color _instructionColor;

        public void ChangeFontColors(CtlVectorInput[] vectors, CtlMatrixInput[] matrices, Color col)
        {
            foreach ( CtlVectorInput v in vectors)
            {
                v.txtEle11.ForeColor = col;
                v.txtEle21.ForeColor = col;
            }
            foreach ( CtlMatrixInput m in matrices)
            {
                // FIXME
                m.ForeColor = col;
            }
            // probably too much work needed to change colors of CoordinateSystem
        }

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

        public virtual void ExerciseChanged(IExercise sender, ExerciseEventArgs e)
        {
        }

        public virtual Dictionary<string, Object> GetInputData()
        {
            Dictionary<string, Object> emptyDictionary = new Dictionary<string, Object>();
            return emptyDictionary;
        }

        protected virtual bool CheckInputs()
        {
            return false;
        }

        public virtual bool LoadState(Dictionary<string, object> state)
        {
            return false;
        }

        public Dictionary<string, object> SaveState()
        {
            return this.GetInputData();
        }
    }
}
