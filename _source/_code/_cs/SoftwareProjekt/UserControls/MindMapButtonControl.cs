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
