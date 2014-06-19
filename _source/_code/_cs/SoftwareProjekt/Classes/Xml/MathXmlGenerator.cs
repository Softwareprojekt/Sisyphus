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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftwareProjekt.Enums;

namespace SoftwareProjekt.Classes.Xml
{
    class MathXmlGenerator
    {
        string _xmlDoc;

        public string XmlDoc
        {
            get 
            { 
                return _xmlDoc; 
            }
        }

        public MathXmlGenerator()
        {
            _xmlDoc = "<math xmlns='http://www.w3.org/1998/Math/MathML' display='block'>\n";
        }

        public void AddSign(EMathSign sign, int tabs = 0)
        {
            for (int i = 0; i < tabs; i++)
            {
                _xmlDoc += "\t";
            }

            switch (sign)
            {
                case EMathSign.Plus:
                    _xmlDoc += "<mo>+</mo>";
                    break;
                case EMathSign.Minus:
                    _xmlDoc += "<mo>-</mo>";
                    break;
                case EMathSign.Division:
                    _xmlDoc += "<mo>&divide;</mo>";
                    break;
                case EMathSign.Multiply:
                    _xmlDoc += "<mo>&sdot;</mo>";
                    break;
                case EMathSign.Assignment:
                    _xmlDoc += "<mo>=</mo>";
                    break;
                default:
                    break;
            }

            _xmlDoc += "\n";
        }

        public void AddVector(Vector vec, System.Drawing.Color col)
        {
            _xmlDoc += "<mfenced open='(' close=')' separators=''>\n";

            _xmlDoc += "<mtable>\n";
            _xmlDoc += "\t<mtr>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + string.Format("#{0}{1}{2}", col.R.ToString("X2"), col.G.ToString("X2"), col.B.ToString("X2")) + "'>" + vec.X1 + "</mn>\n";
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t</mtr>\n";

            _xmlDoc += "\t<mtr>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + string.Format("#{0}{1}{2}", col.R.ToString("X2"), col.G.ToString("X2"), col.B.ToString("X2")) + "'>" + vec.X2 + "</mn>\n";
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t</mtr>\n";

            _xmlDoc += "</mtable>\n";
            _xmlDoc += "</mfenced>\n";
        }

        public void AddCombinedVectors(Vector vec1, Vector vec2, System.Drawing.Color col1, System.Drawing.Color col2, EMathSign sign)
        {
        }

        public void AddMathExpression(string expr1, string expr2, System.Drawing.Color col1, System.Drawing.Color col2, EMathSign sign)
        {
        }

        public void AddMatrix(Matrix mat, System.Drawing.Color column1Color, System.Drawing.Color column2Color)
        {
            _xmlDoc += "<mfenced open='[' close=']' separators=''>\n";

            _xmlDoc += "<mtable>\n";
            _xmlDoc += "\t<mtr>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + string.Format("#{0}{1}{2}", column1Color.R.ToString("X2"), column1Color.G.ToString("X2"), column1Color.B.ToString("X2")) + "'>" + mat.X11 + "</mn>\n";
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + string.Format("#{0}{1}{2}", column2Color.R.ToString("X2"), column2Color.G.ToString("X2"), column2Color.B.ToString("X2")) + "'>" + mat.X12 + "</mn>\n";
            _xmlDoc += "\t\t</mtd>\n";
            

            _xmlDoc += "\t</mtr>\n";

            _xmlDoc += "\t<mtr>\n";
            
            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + string.Format("#{0}{1}{2}", column1Color.R.ToString("X2"), column1Color.G.ToString("X2"), column1Color.B.ToString("X2")) + "'>" + mat.X21 + "</mn>\n";
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + string.Format("#{0}{1}{2}", column2Color.R.ToString("X2"), column2Color.G.ToString("X2"), column2Color.B.ToString("X2")) + "'>" + mat.X22 + "</mn>\n";           
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t</mtr>\n";

            _xmlDoc += "</mtable>\n";
            _xmlDoc += "</mfenced>\n";
        }

        public void AddNode(string node)
        {
            _xmlDoc += node + "\n";

        }

        public void Finish()
        {
            _xmlDoc += "</math>";

            Console.WriteLine(_xmlDoc);
        }
    }
}
