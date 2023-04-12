using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    internal class LådaCollection : ICollection<Låda>
    {
        private List<Låda> innerCol;

        public LådaCollection() { innerCol = new List<Låda>(); }
        public Låda this[int index]
        {
            get { return (Låda)innerCol[index]; }
            set { innerCol[index] = value; }
        }
        public int Count
        {
            get { return innerCol.Count; }
        }

        public bool IsReadOnly { get { return false; } }

        public void Add(Låda item)
        {
            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine($"A box with the dimensions height: {item.höjd} length: {item.längd} width: {item.bredd} already exists");
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public bool Contains(Låda item)
        {
            bool found = false;

            foreach (Låda l in innerCol)
            {
                if (l.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public bool Contains(EqualityComparer<LådaSameDimensions> comp)
        {
            bool found = false;
            foreach (Låda l in innerCol)
            {
                if (comp.Equals(comp))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array can not be null.");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index can not be negative.");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection");
            }
            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }

        public bool Remove(Låda item)
        {
            bool result = false;

            for (int i = 0; i < innerCol.Count; i++)
            {
                Låda låda = innerCol[i];
                if (new LådaSameDimensions().Equals(låda, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
    }
}
