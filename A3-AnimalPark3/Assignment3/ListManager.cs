using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class ListManager<T> : IListManager<T>, IEnumerable<T>
    {
        private List<T> m_list = new List<T>();
        public int Count { get { return m_list.Count; } }


        public void Add(T t)
        {
            m_list.Add(t);
        }
        public void AddRange(T[] t)
        {
            foreach (T _t in t)
                this.Add(_t);
        }

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

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < Count && m_list[index] != null;
        }

        public void RemoveAll()
        {
            m_list.Clear();
        }

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

        public void Sort(Comparer<T> c)
        {
            m_list.Sort(c);
        }

        public new string ToString()
        {
            return string.Join(", ", ToStringArray());
        }

        public string[] ToStringArray()
        {
            return m_list.Select(x => x.ToString()).ToArray();
        }

        public List<string> ToStringList()
        {
            return m_list.Select(x => x.ToString()).ToList();
        }


        public IEnumerator<T> GetEnumerator()
        {
            return m_list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_list.GetEnumerator();
        }
    }
}
