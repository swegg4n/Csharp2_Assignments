using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    /// <summary>
    /// The implementation of the ListManager
    /// </summary>
    public class ListManager<T> : IListManager<T>, IEnumerable<T>
    {
        private List<T> m_list = new List<T>();
        public int Count { get { return m_list.Count; } }

        /// <summary>
        /// Adds an element to the list
        /// </summary>
        public void Add(T t)
        {
            m_list.Add(t);
        }
        /// <summary>
        /// Adds a collection of elements to the list
        /// </summary>
        public void AddRange(T[] t)
        {
            foreach (T _t in t)
                this.Add(_t);
        }

        /// <summary>
        /// Tries to change the element at position: <paramref name="index"/> in the list to value: <typeparamref name="T"/>
        /// </summary>
        public bool ChangeAt(T t, int index)
        {
            if (CheckIndex(index))
            {
                m_list[index] = t;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if index: <paramref name="index"/> exists within the bounds of the list
        /// </summary>
        public bool CheckIndex(int index)
        {
            return index >= 0 && index < Count && m_list[index] != null;
        }

        /// <summary>
        /// Clears the list from all elements
        /// </summary>
        public void RemoveAll()
        {
            m_list.Clear();
        }

        /// <summary>
        /// Tries to remove the element at position: <paramref name="index"/> from the list
        /// </summary>
        public bool RemoveAt(int index)
        {
            if (CheckIndex(index))
            {
                m_list.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Tries to return the element at position: <paramref name="index"/> in the list
        /// </summary>
        public T GetAt(int index)
        {
            if (CheckIndex(index))
            {
                return m_list[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }


        /// <summary>
        /// Tries to return the element at position: <paramref name="index"/> in the list
        /// </summary>
        public T this[int index]
        {
            get => GetAt(index);
            set => ChangeAt(value, index);
        }

        /// <summary>
        /// Sorts the list using comparer <paramref name="c"/>
        /// </summary>
        public void Sort(Comparer<T> c)
        {
            m_list.Sort(c);
        }

        /// <summary>
        /// Returns the list data as a string
        /// </summary>
        public new string ToString()
        {
            return string.Join(", ", ToStringArray());
        }

        /// <summary>
        /// Returns the list data as a string array
        /// </summary>
        public string[] ToStringArray()
        {
            return m_list.Select(x => x.ToString()).ToArray();
        }

        /// <summary>
        /// Returns the list data as a string list
        /// </summary>
        public List<string> ToStringList()
        {
            return m_list.Select(x => x.ToString()).ToList();
        }

        /// <summary>
        /// Returns the list's enumerator used for iteration over the list
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            return m_list.GetEnumerator();
        }

        /// <summary>
        /// Returns the list's enumerator used for iteration over the list
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_list.GetEnumerator();
        }
    }
}
