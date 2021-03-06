using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Assignment4.Utility
{

    static class Binary_Serializer
    {
        public static void Serialize<T>(T obj, string path)
        {
            using (FileStream fileStream = File.Create(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(fileStream, obj);
            }
        }

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
        public static void Serialize<T>(T obj, string path)
        {
            using (FileStream fileStream = File.Create(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(fileStream, obj);
            }
        }

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
