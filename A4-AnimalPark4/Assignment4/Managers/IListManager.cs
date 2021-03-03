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
        /// Adds an element to the list
        /// </summary>
        void Add(T t);

        /// <summary>
        /// Adds a collection of elements to the list
        /// </summary>
        void AddRange(T[] t);

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
    }
}
