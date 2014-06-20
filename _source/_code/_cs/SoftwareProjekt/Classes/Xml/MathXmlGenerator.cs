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
using System.Drawing;

namespace SoftwareProjekt.Classes.Xml
{
    class MathXmlGenerator
    {
        private class ParseContainer
        {
            public string Rest { get; set; }
            public string Main { get; set; }

            public ParseContainer()
            {
                Rest = null;
                Main = "";
            }
        }

        string _xmlDoc;
        const string piHalf = "<mfrac> <mi>&pi;</mi> <mn>2</mn></mfrac>";
        public const string PiHalfSign = "&&pihalf";
        const string MathMLMinSpace = "<mspace width='.1em' />\n";

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

        private string GetRGBString(System.Drawing.Color col)
        {
            return string.Format("#{0}{1}{2}", col.R.ToString("X2"), col.G.ToString("X2"), col.B.ToString("X2"));
        }

        private string MathMLNumber(float number, System.Drawing.Color col)
        {
            return "<mn color='" + GetRGBString(col) + "'>" + number + "</mn>\n";
        }

        public string PrintSign(EMathSign sign, int tabs = 0)
        {
            string retVal = "";
            for (int i = 0; i < tabs; i++)
            {
                retVal += "\t";
            }

            switch (sign)
            {
                case EMathSign.Plus:
                    retVal += "<mo>+</mo>";
                    break;
                case EMathSign.Minus:
                    retVal += "<mo>-</mo>";
                    break;
                case EMathSign.Division:
                    retVal += "<mo>&divide;</mo>";
                    break;
                case EMathSign.Multiply:
                    retVal += "<mo>&sdot;</mo>";
                    break;
                case EMathSign.Assignment:
                    retVal += "<mo>=</mo>";
                    break;
                default:
                    break;
            }

            retVal += "\n";

            return retVal;
        }

        public void AddVector(Vector vec, System.Drawing.Color col)
        {
            _xmlDoc += "<mfenced open='(' close=')' separators=''>\n";

            _xmlDoc += "<mtable>\n";
            _xmlDoc += "\t<mtr>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t" + MathMLNumber(vec.X1, col);
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t</mtr>\n";

            _xmlDoc += "\t<mtr>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t" + MathMLNumber(vec.X2, col);
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t</mtr>\n";

            _xmlDoc += "</mtable>\n";
            _xmlDoc += "</mfenced>\n";
        }

        public void AddCombinedVectors(Vector vec1, Vector vec2, System.Drawing.Color col1, System.Drawing.Color col2, EMathSign sign)
        {
            _xmlDoc += "<mfenced open='(' close=')' separators=''>\n";

            _xmlDoc += "<mtable>\n";
            _xmlDoc += "\t<mtr>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t" + MathMLNumber(vec1.X1, col1);
            _xmlDoc += PrintSign(sign, 3);
            _xmlDoc += "\t\t\t" + MathMLNumber(vec2.X1, col2);
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t</mtr>\n";

            _xmlDoc += "\t<mtr>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t" + MathMLNumber(vec1.X2, col1);
            _xmlDoc += PrintSign(sign, 3);
            _xmlDoc += "\t\t\t" + MathMLNumber(vec2.X2, col2);
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t</mtr>\n";

            _xmlDoc += "</mtable>\n";
            _xmlDoc += "</mfenced>\n";

        }

        public void AddMathExpression(List<string> data, List<Color> colors, EMathSign sign, EMathType mathtype)
        {
            string tmpString = "";
            List<ParseContainer> tmpParseContainer = new List<ParseContainer>();

            try
            {

                for (int i = 0; i < data.Count; i++)
                {
                    int index = -1;
                    ParseContainer pc = new ParseContainer();

                    data[i] = data[i].Replace("+", "</mi>\n<mo color='" + GetRGBString(colors[i]) + "'>+</mo>\n<mi color='" + GetRGBString(colors[i]) + "'>");
                    data[i] = data[i].Replace("-", "</mi>\n<mo color='" + GetRGBString(colors[i]) + "'>-</mo>\n<mi color='" + GetRGBString(colors[i]) + "'>");
                    data[i] = data[i].Replace("-", "</mi>\n<mo color='" + GetRGBString(colors[i]) + "'>&sdot;</mo>\n<mi color='" + GetRGBString(colors[i]) + "'>");
                    data[i] = data[i].Replace("(", "</mi>\n<mo color='" + GetRGBString(colors[i]) + "'>(</mo>\n<mi color='" + GetRGBString(colors[i]) + "'>");
                    data[i] = data[i].Replace(")", "</mi>\n<mo color='" + GetRGBString(colors[i]) + "' >)</mo>\n<mi color='" + GetRGBString(colors[i]) + "'>");

                    index = data[i].IndexOf(PiHalfSign);

                    if (index != -1)
                    {
                        index = index + PiHalfSign.Length;

                        pc.Rest = data[i].Substring(index);
                        pc.Main = data[i].Substring(0, index);
                        pc.Main += "</mi>\n";
                        pc.Main = pc.Main.Replace(PiHalfSign, piHalf);
                    }
                    else
                    {
                        pc.Main = data[i];
                    }

                    tmpParseContainer.Add(pc);

                }

                switch (mathtype)
                {
                    case EMathType.None:
                        if (tmpParseContainer[0].Rest == null)
                        {
                            tmpString += "\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(sign, 3);

                        if (tmpParseContainer[1].Rest == null)
                        {
                            tmpString += "\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Rest + "</mi>\n";
                        }

                        break;

                    case EMathType.ComplexVector:

                        tmpString += "<mfenced open='(' close=')' separators=''>\n";
                        tmpString += "<mtable>\n";
                        tmpString += "\t<mtr>\n";
                        tmpString += "\t\t<mtd>\n";

                        if (tmpParseContainer[0].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(EMathSign.Multiply, 3);

                        if (tmpParseContainer[1].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(sign, 3);

                        if (tmpParseContainer[2].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[2]) + "'>" + tmpParseContainer[2].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[2]) + "'>" + tmpParseContainer[2].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[2]) + "'>" + tmpParseContainer[2].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(EMathSign.Multiply , 3);

                        if (tmpParseContainer[3].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[3]) + "'>" + tmpParseContainer[3].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[3]) + "'>" + tmpParseContainer[3].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[3]) + "'>" + tmpParseContainer[3].Rest + "</mi>\n";
                        }



                        tmpString += "\t\t</mtd>\n";
                        tmpString += "\t</mtr>\n";

                        tmpString += "\t<mtr>\n";
                        tmpString += "\t\t<mtd>\n";

                        if (tmpParseContainer[4].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[4]) + "'>" + tmpParseContainer[4].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[4]) + "'>" + tmpParseContainer[4].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[4]) + "'>" + tmpParseContainer[4].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(EMathSign.Multiply, 3);

                        if (tmpParseContainer[5].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[5]) + "'>" + tmpParseContainer[5].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[5]) + "'>" + tmpParseContainer[5].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[5]) + "'>" + tmpParseContainer[5].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(sign, 3);

                        if (tmpParseContainer[6].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[6]) + "'>" + tmpParseContainer[6].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[6]) + "'>" + tmpParseContainer[6].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[6]) + "'>" + tmpParseContainer[6].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(EMathSign.Multiply , 3);

                        if (tmpParseContainer[7].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[7]) + "'>" + tmpParseContainer[7].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[7]) + "'>" + tmpParseContainer[7].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[7]) + "'>" + tmpParseContainer[7].Rest + "</mi>\n";
                        }

                        tmpString += "\t\t</mtd>\n";
                        tmpString += "\t</mtr>\n";

                        tmpString += "</mtable>\n";
                        tmpString += "</mfenced>\n";

                        break;

                    case EMathType.Vector:
                        tmpString += "<mfenced open='(' close=')' separators=''>\n";
                        tmpString += "<mtable>\n";
                        tmpString += "\t<mtr>\n";
                        tmpString += "\t\t<mtd>\n";

                        

                        if (tmpParseContainer[0].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(sign, 3);

                        if (tmpParseContainer[1].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Rest + "</mi>\n";
                        }


                        tmpString += "\t\t</mtd>\n";
                        tmpString += "\t</mtr>\n";

                        tmpString += "\t<mtr>\n";
                        tmpString += "\t\t<mtd>\n";

                        if (tmpParseContainer[2].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[2]) + "'>" + tmpParseContainer[2].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[2]) + "'>" + tmpParseContainer[2].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[2]) + "'>" + tmpParseContainer[2].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(sign, 3);

                        if (tmpParseContainer[3].Rest == null)
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[3]) + "'>" + tmpParseContainer[3].Main + "</mi>\n";
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[3]) + "'>" + tmpParseContainer[3].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[3]) + "'>" + tmpParseContainer[3].Rest + "</mi>\n";
                        }

                        tmpString += "\t\t</mtd>\n";
                        tmpString += "\t</mtr>\n";

                        tmpString += "</mtable>\n";
                        tmpString += "</mfenced>\n";

                        break;

                    case EMathType.Matrix:


                        tmpString += "<mfenced open='[' close=']' separators=''>\n";

                        tmpString += "<mtable>\n";
                        tmpString += "\t<mtr>\n";
                        tmpString += "\t\t<mtd>\n";
                        if (tmpParseContainer[0].Rest == null)
                        {
                            if (tmpParseContainer[0].Main.Contains("<msub>"))
                            {
                                tmpString += "\t\t\t" + tmpParseContainer[0].Main + "\n";
                            }
                            else
                            {
                                tmpString += "\t\t\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Main + "</mi>\n";
                            }
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[0]) + "'>" + tmpParseContainer[0].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(sign, 3);

                        if (tmpParseContainer[1].Rest == null)
                        {
                            if (tmpParseContainer[1].Main.Contains("<msub>"))
                            {
                                tmpString += "\t\t\t" + tmpParseContainer[1].Main + "\n";
                            }
                            else
                            {
                                tmpString += "\t\t\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Main + "</mi>\n";
                            }
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[1]) + "'>" + tmpParseContainer[1].Rest + "</mi>\n";
                        }

                        tmpString += "\t\t</mtd>\n";

                        tmpString += "\t\t<mtd>\n";
                        if (tmpParseContainer[2].Rest == null)
                        {
                            if (tmpParseContainer[2].Main.Contains("<msub>"))
                            {
                                tmpString += "\t\t\t" + tmpParseContainer[2].Main + "\n";
                            }
                            else
                            {
                                tmpString += "\t\t\t<mi color='" + GetRGBString(colors[2]) + "'>" + tmpParseContainer[2].Main + "</mi>\n";
                            }
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[2]) + "'>" + tmpParseContainer[2].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[2]) + "'>" + tmpParseContainer[2].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(sign, 3);

                        if (tmpParseContainer[3].Rest == null)
                        {
                            if (tmpParseContainer[3].Main.Contains("<msub>"))
                            {
                                tmpString += "\t\t\t" + tmpParseContainer[3].Main + "\n";
                            }
                            else
                            {
                                tmpString += "\t\t\t<mi color='" + GetRGBString(colors[3]) + "'>" + tmpParseContainer[3].Main + "</mi>\n";
                            }
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[3]) + "'>" + tmpParseContainer[3].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[3]) + "'>" + tmpParseContainer[3].Rest + "</mi>\n";
                        }

                        tmpString += "\t\t</mtd>\n";

                        tmpString += "\t</mtr>\n";

                        tmpString += "\t<mtr>\n";

                        tmpString += "\t\t<mtd>\n";
                        if (tmpParseContainer[4].Rest == null)
                        {
                            if (tmpParseContainer[4].Main.Contains("<msub>"))
                            {
                                tmpString += "\t\t\t" + tmpParseContainer[4].Main + "\n";
                            }
                            else
                            {
                                tmpString += "\t\t\t<mi color='" + GetRGBString(colors[4]) + "'>" + tmpParseContainer[4].Main + "</mi>\n";
                            }
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[4]) + "'>" + tmpParseContainer[4].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[4]) + "'>" + tmpParseContainer[4].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(sign, 3);

                        if (tmpParseContainer[5].Rest == null)
                        {
                            if (tmpParseContainer[5].Main.Contains("<msub>"))
                            {
                                tmpString += "\t\t\t" + tmpParseContainer[5].Main + "\n";
                            }
                            else
                            {
                                tmpString += "\t\t\t<mi color='" + GetRGBString(colors[5]) + "'>" + tmpParseContainer[5].Main + "</mi>\n";
                            }
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[5]) + "'>" + tmpParseContainer[5].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[5]) + "'>" + tmpParseContainer[5].Rest + "</mi>\n";
                        }

                        tmpString += "\t\t</mtd>\n";

                        tmpString += "\t\t<mtd>\n";
                        if (tmpParseContainer[6].Rest == null)
                        {
                            if (tmpParseContainer[6].Main.Contains("<msub>"))
                            {
                                tmpString += "\t\t\t" + tmpParseContainer[6].Main + "\n";
                            }
                            else
                            {
                                tmpString += "\t\t\t<mi color='" + GetRGBString(colors[6]) + "'>" + tmpParseContainer[6].Main + "</mi>\n";
                            }
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[6]) + "'>" + tmpParseContainer[6].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[6]) + "'>" + tmpParseContainer[6].Rest + "</mi>\n";
                        }

                        tmpString += PrintSign(sign, 3);

                        if (tmpParseContainer[7].Rest == null)
                        {
                            if (tmpParseContainer[7].Main.Contains("<msub>"))
                            {
                                tmpString += "\t\t\t" + tmpParseContainer[7].Main + "\n";
                            }
                            else
                            {
                                tmpString += "\t\t\t<mi color='" + GetRGBString(colors[7]) + "'>" + tmpParseContainer[7].Main + "</mi>\n";
                            }
                        }
                        else
                        {
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[7]) + "'>" + tmpParseContainer[7].Main;
                            tmpString += MathMLMinSpace;
                            tmpString += "\t\t\t<mi color='" + GetRGBString(colors[7]) + "'>" + tmpParseContainer[7].Rest + "</mi>\n";
                        }

                        tmpString += "\t\t</mtd>\n";

                        tmpString += "\t</mtr>\n";

                        tmpString += "</mtable>\n";
                        tmpString += "</mfenced>\n";
                        break;

                }

                _xmlDoc += tmpString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddMatrix(Matrix mat, System.Drawing.Color column1Color, System.Drawing.Color column2Color)
        {
            _xmlDoc += "<mfenced open='[' close=']' separators=''>\n";

            _xmlDoc += "<mtable>\n";
            _xmlDoc += "\t<mtr>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + GetRGBString(column1Color) + "'>" + mat.X11 + "</mn>\n";
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + GetRGBString(column2Color) + "'>" + mat.X12 + "</mn>\n";
            _xmlDoc += "\t\t</mtd>\n";
            

            _xmlDoc += "\t</mtr>\n";

            _xmlDoc += "\t<mtr>\n";
            
            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + GetRGBString(column1Color) + "'>" + mat.X21 + "</mn>\n";
            _xmlDoc += "\t\t</mtd>\n";

            _xmlDoc += "\t\t<mtd>\n";
            _xmlDoc += "\t\t\t<mn color='" + GetRGBString(column2Color) + "'>" + mat.X22 + "</mn>\n";           
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

        public void AddSign(EMathSign eMathSign)
        {
            _xmlDoc += PrintSign(eMathSign);
        }
    }
}
