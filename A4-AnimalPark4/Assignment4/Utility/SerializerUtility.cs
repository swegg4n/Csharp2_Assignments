using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Assignment4.Utility
{

    static class Binary_Serializer
    {
        /// <summary>
        /// Serializes object: <paramref name="obj"/> to a new file located at: <paramref name="path"/>, using a binary formatter
        /// </summary>
        public static bool Serialize<T>(T obj, string path)
        {
            if (obj != null)
            {
                using (FileStream fileStream = File.Create(path))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(fileStream, obj);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to deserialize data at path: <paramref name="path"/> to an object of type: <typeparamref name="T"/>, using a binary formatter
        /// </summary>
        public static T Deserialize<T>(string path)
        {
            using (FileStream fileStream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                T obj = (T)formatter.Deserialize(fileStream);
                return obj;
            }
        }

    }

    static class XML_Serializer
    {
        /// <summary>
        /// Serializes object: <paramref name="obj"/> to a new file located at: <paramref name="path"/>, using an XML serializer
        /// </summary>
        public static bool Serialize<T>(T obj, string path)
        {
            if (obj != null)
            {
                using (FileStream fileStream = File.Create(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    xmlSerializer.Serialize(fileStream, obj);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to deserialize data at path: <paramref name="path"/> to an object of type: <typeparamref name="T"/>, using an xml serializer
        /// </summary>
        public static T Deserialize<T>(string path)
        {
            using (FileStream fileStream = File.Open(path, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                T obj = (T)xmlSerializer.Deserialize(fileStream);
                return obj;
            }
        }
    }

}
