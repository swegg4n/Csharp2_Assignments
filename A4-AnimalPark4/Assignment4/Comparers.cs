using System.Collections.Generic;

namespace Assignment4
{
    public abstract class Comparer<T> : IComparer<T>
    {
        public abstract int Compare(T x, T y);
    }


    class IDComparer : Comparer<Animal>
    {
        /// <summary>
        /// Compares ID
        /// </summary>
        public override int Compare(Animal x, Animal y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }

    class NameComparer : Comparer<Animal>
    {
        /// <summary>
        /// Compares Name, then ID
        /// </summary>
        public override int Compare(Animal x, Animal y)
        {
            if (x.Name == y.Name)
            {
                return new IDComparer().Compare(x, y);
            }
            else
            {
                return x.Name.CompareTo(y.Name);
            }
           
        }
    }

    class AgeComparer : Comparer<Animal>
    {
        /// <summary>
        /// Compares Age, then ID
        /// </summary>
        public override int Compare(Animal x, Animal y)
        {
            if (x.Age == y.Age)
            {
                return new IDComparer().Compare(x, y);
            }
            else
            {
                return x.Age.CompareTo(y.Age);
            }
        }
    }

    class SpeciesComparer : Comparer<Animal>
    {
        /// <summary>
        /// Compares Species name, then ID
        /// </summary>
        public override int Compare(Animal x, Animal y)
        {
            if (x.GetSpecies() == y.GetSpecies())
            {
                return new IDComparer().Compare(x, y);
            }
            else
            {
                return x.GetSpecies().CompareTo(y.GetSpecies());
            }       
        }
    }
}
