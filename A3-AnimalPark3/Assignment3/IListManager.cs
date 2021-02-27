using System.Collections.Generic;

namespace Assignment3
{
    interface IListManager<T>
    {
        int Count { get; }

        void Add(T t);
        void AddRange(T[] t);
        bool ChangeAt(T t, int index);
        bool CheckIndex(int index);
        void RemoveAll();
        bool RemoveAt(int index);
        T GetAt(int index);
        void Sort(Comparer<T> c);
        string ToString();
        string[] ToStringArray();
        List<string> ToStringList();
    }
}
