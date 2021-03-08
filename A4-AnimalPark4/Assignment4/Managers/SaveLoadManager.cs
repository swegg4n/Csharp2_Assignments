using System.IO;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// Class responsible for creating relative paths to certain folders
    /// </summary>
    static class RelativePath
    {
        public static string SaveDataPath   //Creates a relative path to a prederermined folder with SaveData
        {
            get 
            {
#if DEBUG
                int trimcount = 10;
#else
                int trimcount = 12;
#endif
                string startupPath = Application.StartupPath;
                string path = startupPath.Substring(0, startupPath.Length - trimcount) + "\\SaveData\\";
                return path;
            }
        }

        public static string ImagesFolderPath   //Creates a relative path to a prederermined folder with images
        {
            get
            {
#if DEBUG
                int trimcount = 10;
#else
                int trimcount = 12;
#endif            
                string startupPath = Application.StartupPath;
                string path = startupPath.Substring(0, startupPath.Length - trimcount) + "\\Images";
                return path;
            }
        }
    }

    /// <summary>
    /// Class responsible for helping saving of files
    /// </summary>
    static class SaveManager
    {
        public static string FilePath { get; set; } = null;
        public static string FileName { get { return Path.GetFileName(FilePath); } }


        /// <summary>
        /// Helper function for creating an SaveFileDialog.
        /// </summary>
        /// <returns>Returns the created dialog</returns>
        public static SaveFileDialog CreateSaveDialog(string title, string filter)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = title;
            dialog.Filter = filter;
            dialog.InitialDirectory = RelativePath.SaveDataPath;
            return dialog;
        }

        /// <summary>
        /// Helper function for exporting the data: <paramref name="data"/> as text with a custom format, to path: <paramref name="path"/>
        /// </summary>
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

    /// <summary>
    /// Class responsible for helping loading of files
    /// </summary>
    class LoadManager
    {
        /// <summary>
        /// Helper function for creating an OpenFileDialog.
        /// </summary>
        /// <returns>Returns the created dialog</returns>
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
