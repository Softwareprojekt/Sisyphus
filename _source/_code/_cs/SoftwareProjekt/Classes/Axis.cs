
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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    public class Axis : IAxis
    {
        private bool _isXAxis;
        private bool _isYAxis;
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="isXAxis">XAxis: true; YAxis: false</param>
        public Axis(bool isXAxis)
        {
            _isXAxis = isXAxis;
            _isYAxis = !isXAxis;            
        }

        public string Legend { get; set; }
        public float StartValue { get; set; }
        public float EndValue { get; set; }
        public float Scale { get; set; }


    }
}
