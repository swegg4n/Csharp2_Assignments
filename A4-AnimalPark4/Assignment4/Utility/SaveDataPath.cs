using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4.Utility
{
    static class SaveDataPath
    {
        public static string Path
        {
            get
            {
#if DEBUG
                int trimcount = 10;
#else
                int trimcount = 12;
#endif
                //Creates a relative path to a prederermined folder with SaveData
                string startupPath = Application.StartupPath;
                string path = startupPath.Substring(0, startupPath.Length - trimcount) + "\\SaveData\\";
                return path;
            }
        }
    }
}
