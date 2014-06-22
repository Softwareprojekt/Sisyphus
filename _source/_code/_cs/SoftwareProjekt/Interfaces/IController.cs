
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

namespace SoftwareProjekt.Interfaces
{
    public interface IController
    {

        /// <summary>
        /// Adds a new Exercise and View to the List. Also sets the Controller and subscribes to ViewChanged event handler.
        /// </summary>
        /// <param name="exercise">Newly created Exercise.</param>
        /// <param name="view">Newly created View.</param>
        void AddExercise(IExercise exercise, IView view);

        /// <summary>
        /// Remove Exercise and corresponding View from the List.
        /// <param name="exercise">Exercise to remove from List.</param>
        /// </summary>
        void RemoveExercise(IView view);
    }
}
