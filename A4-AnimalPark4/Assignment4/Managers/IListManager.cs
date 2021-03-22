using System.Collections.Generic;

namespace Assignment4
{
    /// <summary>
    /// Interface for implementing the ListManager data structure
    /// </summary>
    /// <typeparam name="T">The contained type of the ListManager</typeparam>
    interface IListManager<T>
    {
        /// <summary>
        /// Returns the number of elements in the list
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Tries to add an element to the list
        /// </summary>
        bool Add(T t);

        /// <summary>
        /// Tries to add a collection of elements to the list
        /// </summary>
        bool AddRange(ICollection<T> t);

        /// <summary>
        /// Tries to change the element at position: <paramref name="index"/> in the list to value: <typeparamref name="T"/>
        /// </summary>
        bool ChangeAt(T t, int index);

        /// <summary>
        /// Checks if index: <paramref name="index"/> exists within the bounds of the list
        /// </summary>
        bool CheckIndex(int index);

        /// <summary>
        /// Clears the list from all elements
        /// </summary>
        void RemoveAll();

        /// <summary>
        /// Tries to remove the element at position: <paramref name="index"/> from the list
        /// </summary>
        bool RemoveAt(int index);

        /// <summary>
        /// Tries to return the element at position: <paramref name="index"/> in the list
        /// </summary>
        T GetAt(int index);

        /// <summary>
        /// Returns the list data
        /// </summary>
        List<T> Data();

        /// <summary>
        /// Checks if value: <paramref name="value"/> exists in the list
        /// </summary>
        bool Contains(T value);

        /// <summary>
        /// Sorts the list using comparer <paramref name="c"/>
        /// </summary>
        void Sort(Comparer<T> c);

        /// <summary>
        /// Returns the list data as a string
        /// </summary>
        string ToString();

        /// <summary>
        /// Returns the list data as a string array
        /// </summary>
        string[] ToStringArray();

        /// <summary>
        /// Returns the list data as a string list
        /// </summary>
        List<string> ToStringList();


        /// <summary>
        /// Serializes this list's data to <paramref name="fileName"/>, using a binary serializer
        /// </summary>
        bool BinarySerialize(string fileName);

        /// <summary>
        /// Deserializes the data in file: <paramref name="fileName"/>, as binary
        /// </summary>
        void BinaryDeserialize(string fileName);

        /// <summary>
        /// Serializes this list's data to <paramref name="fileName"/>, using an XML serializer
        /// </summary>
        bool XmlSerialize(string filename);

        /// <summary>
        /// Deserializes the data in file: <paramref name="fileName"/>, as XML
        /// </summary>
        void XmlDeserialize(string filename);
    }
}
