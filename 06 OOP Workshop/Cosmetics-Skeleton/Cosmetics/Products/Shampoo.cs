namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;

    public class Shampoo : Product, IShampoo, IProduct
    {
        private UsageType usage;
        private uint milliliters;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override decimal Price
        {
            get
            {
                return this.price * this.Milliliters;
            }
            protected set
            {
                this.price = value;
            }
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }
            private set
            {
                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }
            private set
            {
                this.usage = value;
            }
        }

        public override string Print()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine(base.Print());
            text.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            text.Append(string.Format("  * Usage: {0}", this.Usage));

            return text.ToString();
        }
    }
}