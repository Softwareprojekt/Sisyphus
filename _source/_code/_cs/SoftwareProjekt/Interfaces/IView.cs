
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
using SoftwareProjekt.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace SoftwareProjekt.Interfaces
{
    public interface IView
    {
        Color inputColor
        {
            get;
            set;
        }

        Color resultColor
        {
            get;
            set;
        }

        Color instructionColor
        {
            get;
            set;
        }
        void ChangeFontColors(CtlVectorInput[] vectors, CtlMatrixInput[] matrices, Color col);

        /// <summary>
        /// Redirect events fired on the View to the Controller.
        /// </summary>
        event ViewHandler<ViewEventArgs> ViewChanged;

        /// <summary>
        /// Associated Controller.
        /// </summary>
        IController Controller
        {
            get;
            set;
        }

        /// <summary>
        /// Returns all data needed for calculation in the model.
        /// </summary>
        Dictionary<string, Object> GetInputData();

        void ExerciseChanged(IExercise sender, ExerciseEventArgs e);

        event System.ComponentModel.CancelEventHandler Closing;

        void Show();

        void Dispose();
        
        /// <summary>
        /// Load state of exercise from file.
        /// </summary>
        /// <returns>True if state exists in Workbook and state was loaded; Otherwise, false.</returns>
        bool LoadState(Dictionary<string, object> state);

        /// <summary>
        /// Save state of exercise to file.
        /// Calls GetInputData() internally.
        /// </summary>
        Dictionary<string, Object> SaveState();
        /// <summary>
        /// Supports rendering to the specified bitmap.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="targetBounds"></param>
        void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);
    }
}
