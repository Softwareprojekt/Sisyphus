using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SoftwareProjekt
{
    class InitSisyphus
    {
        static Dictionary<string, string> MathFonts = null;

    //    new string[]{"Math Roman Standard", "cm-stretchy Halb Fett", "cm-roman Standard"};

        static InitSisyphus()
        {
            MathFonts = new Dictionary<string, string>();

            MathFonts.Add("Math Roman", "math-roman");
            MathFonts.Add("cm-stretchy", "cm-stretchy");
            MathFonts.Add("cm-roman", "cm-roman");
        }

        public InitSisyphus()
        {
        }

        private bool CheckFont(KeyValuePair<string, string> entry)
        {
            Font testFont = new Font(entry.Key, 10.0f);

            if (testFont.Name == entry.Key)
            {
#if DEBUG
            Console.WriteLine("SUCCESS @ CheckFont: font " + entry.Key + " exists");
#endif
                return true;
            }

            string vbscriptFile = Path.Combine(new string[] { Path.GetTempPath(), Path.GetRandomFileName() }) + ".vbs";
            string batchFile = Path.Combine(new string[] { Path.GetTempPath(), Path.GetRandomFileName() }) + ".bat";
            string absolutePath = Path.Combine(new string[] { Directory.GetCurrentDirectory(), "Fonts", entry.Value }) + ".ttf";

            if (!File.Exists(absolutePath))
            {
#if DEBUG
                Console.WriteLine("ERROR @ CheckFont: failed to find font file for font " + entry.Key + " at " + absolutePath);
#endif      
                MessageBox.Show("Failed to find file for font " + entry.Key + " at " + absolutePath, "Font file not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            StreamWriter sw = new StreamWriter(new FileStream(vbscriptFile, FileMode.Create));

            // let's create a vbs file we can run to install the fonts

            sw.WriteLine("Const FONTS = &H14&");
            sw.WriteLine("");
            sw.WriteLine("Set objShell = CreateObject(\"Shell.Application\") ");
            sw.WriteLine("Set objFolder = objShell.Namespace(FONTS)");

            sw.WriteLine("objFolder.CopyHere \"" + absolutePath + "\"");

            sw.Close();

            sw = new StreamWriter(new FileStream(batchFile, FileMode.Create));

            sw.WriteLine("cscript " + vbscriptFile);

            sw.Close();

            ProcessStartInfo psi = new ProcessStartInfo();
            Process process = new Process();

            psi.UseShellExecute = false;

            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.FileName = batchFile;

            process = Process.Start(psi);
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
#if DEBUG
                Console.WriteLine("ERROR @ CheckFont: failed to install font " + entry.Key);
#endif
                MessageBox.Show("It was not possible to install the font " + entry.Key + ".\nThe process failed with error code: " + process.ExitCode + ".", 
                    "Unable to install font", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

#if DEBUG
            Console.WriteLine("SUCCESS @ CheckFont: successfully installed font " + entry.Key);
#endif
            return true;
        }
        
        public bool Init()
        {

            foreach (KeyValuePair<string, string> entry in MathFonts)
            {
                if (!CheckFont(entry))
                {
                    return false;
                }
            }

            
            FileStream fs = null;

            try
            {
                fs = File.Open("config.xml", FileMode.Open); 
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine("ERROR @ InitProject: couldn't find config file for MindMap!");
                Console.WriteLine(e.Message);
#endif
                // MessageBox.Show("Config file for the exercises was not found or could not be opened! Please check your application folder!", "Config file not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            fs.Close();


            return true;
        }
    }
}
