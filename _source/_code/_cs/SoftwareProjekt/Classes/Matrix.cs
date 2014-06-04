
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
    public class Matrix : IMathObject
    {
        /// <summary>
        /// ctor
        /// </summary>
        public Matrix(float x_11, float x_12, float x_21, float x_22)
        {
            throw new System.NotImplementedException();
        }

        public float Determinante
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public float X11 { get; set; }

        public float X12 { get; set; }

        public float X21 { get; set; }

        public float X22 { get; set; }

        public void GetData()
        {
            throw new NotImplementedException();
        }

        public void Invert()
        {
            throw new System.NotImplementedException();
        }

        public void Multiply(Matrix newMatrix)
        {
            throw new System.NotImplementedException();
        }

        public Matrix Multiply(Matrix firstMatrix, Matrix secondMatrix)
        {
            throw new System.NotImplementedException();
        }
    }
}
