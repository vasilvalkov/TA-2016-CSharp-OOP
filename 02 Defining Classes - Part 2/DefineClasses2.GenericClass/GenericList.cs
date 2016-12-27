namespace DefineClasses2.GenericClass
{
    using System;
    using System.Linq;

    public class GenericList<T>
        where T : IComparable<T>, IEquatable<T>
    {   // Fields
        private const int initialCapacity = 4;
        private T[] list;
        private int count;
        // Constructors
        public GenericList()
            : this(initialCapacity)
        { }
        public GenericList(int capacity)
        {
            this.count = 0;
            this.list = new T[capacity];
        }
        // Properties
        public int Count { get { return this.count; } }
        public int Capacity
        {
            get { return this.list.Length; }
        }
        public T this[int index]
        {
            get { return this.list[index]; }
            set { this.list[index] = value; }
        }
        // Methods
        public void Add(T element)
        {
            CapacityAvailabilityCheck();
            this.list[count++] = element;
        }
        public void InsertAt(int index, T element)
        {
            CapacityAvailabilityCheck();

            for (int i = count; i > index; i--)
            {
                this.list[i] = this.list[i - 1];
            }

            this.list[index] = element;
            count++;
        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < this.count - 1; i++)
            {
                this.list[i] = this.list[i + 1];
            }

            this.list[this.count - 1] = default(T);
            this.count--;
        }
        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                list[i] = default(T);
            }

            this.count = 0;
        }
        public T GetElement(int index)
        {
            return this.list[index];
        }
        public T Min()
        {
            T min = this.list[0];

            for (int i = 0; i < this.count; i++)
            {
                if (list[i].CompareTo(min) < 0)
                {
                    min = list[i];
                }
            }

            return min;
        }
        public T Max()
        {
            T max = this.list[0];

            for (int i = 0; i < this.count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
        public int Find(T element)
        {
            return Array.IndexOf(list, element);
        }
        public override string ToString()
        {
            return string.Join(", ", list.Select(x => x.ToString()).ToArray(), 0, count);
        }
        private void CapacityAvailabilityCheck()
        {
            if (this.Count == this.Capacity)
            {
                this.AutoGrowCapacity();
            }
        }
        private void AutoGrowCapacity()
        {
            var tempList = new T[2 * Capacity];

            for (int i = 0; i < count; i++)
            {
                tempList[i] = this.list[i];
            }

            this.list = tempList;
        }
    }
}