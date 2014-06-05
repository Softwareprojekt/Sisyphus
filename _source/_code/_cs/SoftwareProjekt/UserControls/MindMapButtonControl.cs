
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
    public class MindMapButtonControl : UserControl
    {
        private EAlignType _alignment;
        private string _buttonText;
        private int _excerciseID;

        public event ExcerciseClickEvent ButtonClicked;

        public MindMapButtonControl(string text, EAlignType alignment)
        {
            _alignment = alignment;
            _buttonText = text;
        }

        public string ButtonText
        {
            get
            {
                return _buttonText;
            }
            set
            {
                _buttonText = value;
            }
        }

        public bool LeftAlign
        {
            get
            {
                return (_alignment == EAlignType.AlignLeft);
            }
            set
            {
                _alignment = EAlignType.AlignLeft;
            }
        }
        public bool RightAlign
        {
            get
            {
                return (_alignment == EAlignType.AlignRight);
            }
            set
            {
                _alignment = EAlignType.AlignRight;
            }
        }
        public bool TopAlign
        {
            get
            {
                return (_alignment == EAlignType.AlignTop);
            }
            set
            {
                _alignment = EAlignType.AlignTop;
            }
        }
        public bool BottomAlign
        {
            get
            {
                return (_alignment == EAlignType.AlignBottom);
            }
            set
            {
                _alignment = EAlignType.AlignBottom;
            }
        }

        public int ExcerciseID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
