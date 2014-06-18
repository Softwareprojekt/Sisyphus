using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareProjekt.Interop
{
    [System.Security.SuppressUnmanagedCodeSecurity()]
    class InteropMimeTex
    {
        private InteropMimeTex () // need this dummy
        {
        }

        [System.Runtime.InteropServices.DllImport("MimeTeX.dll")]
        internal static extern int CreateGifFromEq(string expr, string fileName);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        internal extern static IntPtr GetModuleHandle(string lpModuleName);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        internal extern static bool FreeLibrary(IntPtr hLibModule); 
    }
    
}
