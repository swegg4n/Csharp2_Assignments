using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Assignment4
{
    static class RelativePath
    {
        public static string SaveDataPath
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

        public static string ImagesFolderPath
        {
            get
            {
#if DEBUG
                int trimcount = 10;
#else
                int trimcount = 12;
#endif
                //Creates a relative path to a prederermined folder with images
                string startupPath = Application.StartupPath;
                string path = startupPath.Substring(0, startupPath.Length - trimcount) + "\\Images";
                return path;
            }
        }
    }

    static class SaveManager
    {
        public static string FilePath { get; set; } = null;


        public static SaveFileDialog CreateSaveDialog(string title, string filter)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = title;
            dialog.Filter = filter;
            dialog.InitialDirectory = RelativePath.SaveDataPath;
            return dialog;
        }

        public static void SaveAsTextFile(Data data, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                //for (int i = 0; i < animalData.Count; i++)
                //{
                //    writer.WriteLine(animalData[i].ToString());
                //}
            }
        }

        public static void SaveTextFile(Data data)
        {
            SaveAsTextFile(data, FilePath);
        }
    }

    class LoadManager
    {
        public static OpenFileDialog CreateOpenDialog(string title, string filter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = title;
            dialog.Filter = filter;
            dialog.InitialDirectory = RelativePath.SaveDataPath;
            return dialog;
        }

        public static string[] ReadTextFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                List<string> lines = new List<string>();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                return lines.ToArray();
            }
        }

        //public static Animal TextToAnimal(string text)
        //{
        //    string[] data = text.Split(new string[] { ", " }, StringSplitOptions.None);
        //}
    }

}
