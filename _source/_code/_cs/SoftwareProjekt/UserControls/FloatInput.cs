﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt.UserControls
{
    public class FloatInput : TextBox
    {
        public FloatInput()
        {
            FloatValue = float.NaN;
            this.MouseClick += FloatInput_MouseClick;
        }

        void FloatInput_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && float.IsNaN(this.FloatValue))
            {
                this.SelectAll();
            }
        }

        public float FloatValue { get; private set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            float f = float.NaN;
            
            if (!this.Parse(this.Text.Replace('.', ','), out f))
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                this.BackColor = System.Drawing.Color.White;
            }
           
           
            this.FloatValue = f;
            base.OnTextChanged(e);
        }

        private bool Parse(string s, out float f)
        {
            float retval = 0f;

            if (float.TryParse(s, NumberStyles.Float ,CultureInfo.InvariantCulture,out retval))
            {
                f = retval;
#if DEBUG
                Console.WriteLine("SUCCESS @ FloatInput.Parse => " + f);
#endif
                return true;
            }

            f = float.NaN;
#if DEBUG
            Console.WriteLine("ERROR @ FloatInput.Parse => " + f);
#endif
            return false;
        }

		public bool IsValid()
		{
			return !float.IsNaN(this.FloatValue);
		}
    }
}
