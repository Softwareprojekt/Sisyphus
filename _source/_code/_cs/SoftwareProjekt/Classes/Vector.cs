
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
    public class Vector : IMathObject
    {
        /// <summary>
        /// ctor
        /// </summary>
        public Vector(float x1, float x2)
        {
            X1 = x1;
            X2 = x2;
        }

        public float X1 { get; set; }

        public float X2 { get; set; }

        public void Add(Vector newVector)
        {
            throw new System.NotImplementedException();
        }

        static public Vector Add(Vector firstVector, Vector secondVector)
        {
            throw new System.NotImplementedException();
        }

        public void Rotate(float degree)
        {
            throw new System.NotImplementedException();
        }

        public void Rotate(Matrix matrix)
        {
            throw new System.NotImplementedException();
        }

        public void Scale(Matrix scaleMatrix)
        {
            throw new System.NotImplementedException();
        }

        public void Mirror(Line line)
        {
            throw new System.NotImplementedException();
        }

        public void Multiply(Matrix matrix)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// magnitude or norm
        /// </summary>
        public void Length()
        {
            throw new System.NotImplementedException();
        }

        static public Matrix Multiply(Matrix firstMatrix, Matrix secondMatrix)
        {
            throw new System.NotImplementedException();
        }

        public void GetData()
        {
            throw new NotImplementedException();
        }
    }
}
