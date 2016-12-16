using System;

namespace DefineClasses
{
    class Display
    {   // fields
        private double? size = null;
        private ulong? numberOfColors = null;
        // constructors
        public Display()
        {
        }
        public Display(double? size)
            : this(size, null)
        {
        }
        public Display(ulong? numberOfColors)
            : this(null, numberOfColors)
        {
        }
        public Display(double? size, ulong? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        // propreties
        public double? Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value <= 0f)
                {
                    throw new ArgumentOutOfRangeException("Size of screen cannot be negative or zero!");
                }
                this.size = value;
            }
        }
        public ulong? NumberOfColors
        {
            get
            {
                return numberOfColors;
            }
            private set
            {
                if (value <= 1)
                {
                    throw new ArgumentOutOfRangeException("Display can have at least two colors");
                }
                else
                {
                this.numberOfColors = value;
                }
            }
        }
    }
}