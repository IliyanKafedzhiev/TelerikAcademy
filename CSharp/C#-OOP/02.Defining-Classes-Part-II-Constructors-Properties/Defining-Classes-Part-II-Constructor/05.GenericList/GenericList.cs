using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericList
{
    class GenericList <T>
    {
        //fields and proparties
        private T[] list;
        public T[] List
        {
            get
            {
                return list;
            }
            set
            {
                    list =new T[Capacity];
                    Count = value.Length;
                    for (int i = 0; i < value.Length; i++)
                    {
                        list[i] = value[i];
                    }
            }
        }

        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            set {
                if (value < 1)
                {
                    throw new ArgumentException("Capacity must be greater than 0");
                }
                capacity = value; 
            }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set {
                if (value < 0 && value > Capacity)
                {
                    throw new ArgumentException("Count must be greater than 0 and lesser than Capacity");
                }
                count = value;
            }
        }

        // constructor
        GenericList (int capacity)
        {
            Capacity = capacity;
            Count = 0;
            list = new T[capacity];
        }

        //methods
        public void Add(T element)
        {
            if (Count < Capacity)
            {
                list[Count] = element;
                Count++;
            }
            else
            {
                T[] newList = new T[Capacity *= 2];
                for (int j = 0; j < count; j++)
                {
                    newList[j] = list[j];
                }
                list = newList;

                list[Count] = element;
                Count++;
            }
        }
        public T this[int i]
        {
            get {
                if (i<0 || i>=Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return list[i];
            }
            set {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                list[i] = value; }
        }
        public void RemoveElement(int i)
        {
            if (i < 0 || i >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            list[i] = list[Count - 1];
            Count--;
        }
        public void InsertAt(T element, int i)
        {
            if (i < 0 || i >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            if (Count < Capacity)
            {
                list[Count] = list[i];
                Count++;
                list[i] = element;
            }
            else
            {
                T[] newList = new T[Capacity *= 2];
                for (int j = 0; j < count; j++)
                {
                    newList[j] = list[j];
                }
                list = newList;

                list[Count] = list[i];
                Count++;
                list[i] = element;
            }
        }
        public void Clear()
        {
            Count = 0;
        }
        public int IndexOfElement(T element)
        {
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if (list[i].Equals(element))
                {
                    index = i;
                }
            }
            return index;
        } 
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                result.Append(list[i].ToString() + "\n");
            }
            return result.ToString();
        }

    }
    class Test
    {
        static void Main()
        {

        }
    }
}
