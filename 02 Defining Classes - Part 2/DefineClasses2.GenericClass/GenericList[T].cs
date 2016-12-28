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
            get
            {
                ValidateIndex(index);
                return this.list[index];
            }
            set
            {
                ValidateIndex(index);
                this.list[index] = value;
            }
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
        public void Trim()
        {
            AutoResize(this.count);
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
                this.AutoResize(2 * Capacity);
            }
        }
        private void AutoResize(int capacity)
        {
            var tempList = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                tempList[i] = this.list[i];
            }

            this.list = tempList;
        }
        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentOutOfRangeException("Index is out of the boundaries of the list!");
            }
        }
    }
}