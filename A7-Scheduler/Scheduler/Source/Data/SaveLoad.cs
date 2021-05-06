using System.IO;
using System.Windows.Forms;

namespace Scheduler.Source
{
    /// <summary>
    /// Helper class used for saving, loading and syncronizing data. 
    /// </summary>
    class SaveLoad
    {
        public static UsersData users;
        public static EventsData events;


        private static string usersFileName = "users.txt";
        private static string eventsFileName = "events.txt";


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
        }


        /// <summary>
        /// Function used to refresh the saved users data.
        /// </summary>
        public static void RenewUsersData()
        {
            users = SaveLoad.LoadUserData();
        }

        /// <summary>
        /// Function used to refresh the saved events data.
        /// </summary>
        public static void RenewEventsData()
        {
            events = SaveLoad.LoadEventData();
        }


        /// <summary>
        /// Combine user data created during runtime with already saved user data
        /// </summary>
        private static UsersData CombineUserData()
        {
            UsersData oldData = users;
            UsersData newData = LoadUserData();

            for (int i = 0; i < oldData.usersData.Count; i++)
            {
                if (newData.FindUser(oldData.usersData[i].Sign) == null)
                {
                    newData.usersData.Add(oldData.usersData[i]);
                }
                else
                {
                    newData.usersData[i] = oldData.usersData[i];
                }
            }
            users = newData;

            return newData;
        }

        /// <summary>
        /// Combine events data created during runtime with already saved events data
        /// </summary>
        private static EventsData CombineEventData()
        {
            EventsData oldData = events;
            EventsData newData = LoadEventData();

            for (int i = oldData.eventsData.Count - 1; i >= 0; i--)
            {
                if (newData.FindEvent(oldData.eventsData[i].EventId) == null)
                {
                    newData.eventsData.Add(oldData.eventsData[i]);
                    continue;
                }
                else
                {
                    newData.eventsData[i] = oldData.eventsData[i];
                }
            }
            events = newData;

            return newData;
        }

        /// <summary>
        /// Adds a new users data entry to <paramref name="userData"/> and saves it to file
        /// </summary>
        public static void AppendData(UserData userData)
        {
            if (SaveLoad.users.FindUser(userData.Sign) != null)
                return;

            SaveLoad.users.usersData.Add(userData);
            UsersData users = CombineUserData();

            Binary_Serializer.Serialize<UsersData>(users, RelativePath.SaveDataPath + usersFileName);

            //SharePoint.WriteData(usersFileName, data);
        }

        /// <summary>
        /// Adds a new events entry to <paramref name="eventData"/> and saves it to file
        /// </summary>
        public static void AppendData(EventData eventData)
        {
            bool entryExists = false;
            int index = -1;
            foreach (EventData e in SaveLoad.events.eventsData)
            {
                if (e.EventId == eventData.EventId)
                {
                    entryExists = true;
                    index = SaveLoad.events.eventsData.IndexOf(e);
                    continue;
                }
            }

            if (!entryExists)
                SaveLoad.events.eventsData.Add(eventData);
            else
                SaveLoad.events.eventsData[index] = eventData;

            EventsData combined = CombineEventData();

            Binary_Serializer.Serialize<EventsData>(combined, RelativePath.SaveDataPath + eventsFileName);
            //SharePoint.WriteData(eventsFileName, data);
        }

        /// <summary>
        /// Removes user with sign: <paramref name="userSign"/> from the save file
        /// </summary>
        public static void RemoveData(string userSign)
        {
            UsersData combined = CombineUserData();
            for (int i = combined.usersData.Count - 1; i >= 0; i--)
            {
                if (combined.usersData[i].Sign == userSign)
                    combined.usersData.RemoveAt(i);
            }
            users = combined;

            Binary_Serializer.Serialize<UsersData>(combined, RelativePath.SaveDataPath + usersFileName);
            //SharePoint.WriteData(usersFileName, data);
        }

        /// <summary>
        /// Removes event: <paramref name="eventData"/> from the save file
        /// </summary>
        public static void RemoveData(EventData eventData)
        {
            EventsData combined = CombineEventData();

            foreach (EventData e in combined.eventsData)
            {
                if (e.EventId == eventData.EventId)
                {
                    events.eventsData.Remove(e);
                    break;
                }
            }
            events = combined;

            Binary_Serializer.Serialize<EventsData>(combined, RelativePath.SaveDataPath + usersFileName);
            //SharePoint.WriteData(eventsFileName, data);
        }


        private static UsersData LoadUserData()
        {
            //string data = SharePoint.ReadData(usersFileName);
            UsersData users = Binary_Serializer.Deserialize<UsersData>(RelativePath.SaveDataPath + usersFileName);

            return users;
        }
        private static EventsData LoadEventData()
        {
            //string data = SharePoint.ReadData(eventsFileName);
            EventsData events = Binary_Serializer.Deserialize<EventsData>(RelativePath.SaveDataPath + eventsFileName);

            return events;
        }


        //used for testing
        public static void CreateEmptyUserFile()
        {
            Binary_Serializer.Serialize<UsersData>(new UsersData(), RelativePath.SaveDataPath + usersFileName);
        }
        //used for testing
        public static void CreateEmptyEventsFile()
        {
            Binary_Serializer.Serialize<EventsData>(new EventsData(), RelativePath.SaveDataPath + eventsFileName);
        }


    }

}
