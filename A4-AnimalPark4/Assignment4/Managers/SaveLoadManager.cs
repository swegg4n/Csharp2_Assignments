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
        public static string FileName { get { return Path.GetFileName(FilePath); } }


        public static SaveFileDialog CreateSaveDialog(string title, string filter)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = title;
            dialog.Filter = filter;
            dialog.InitialDirectory = RelativePath.SaveDataPath;
            return dialog;
        }

        public static void ExportAsTextFile(Data data, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Animals [");
                foreach (Animal animal in data.AnimalsList)
                    writer.WriteLine(animal.ToString());
                writer.WriteLine("]");

                writer.WriteLine("FoodItems [");
                foreach (FoodItem foodItem in data.FoodItems)
                    writer.WriteLine(foodItem.ToString());
                writer.WriteLine("]");

                writer.WriteLine("FeedingSchedules [");
                foreach (FeedingSchedule feedingSchedule in data.FeedingSchedules)
                    writer.WriteLine(feedingSchedule.ToString());
                writer.WriteLine("]");
            }
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
    }

}
