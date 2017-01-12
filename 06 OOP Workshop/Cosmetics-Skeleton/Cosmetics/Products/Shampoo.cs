using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
	public class Shampoo : Product, IShampoo, IProduct
	{
		private UsageType usage;

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

		public uint Milliliters { get; private set; }

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
			text.AppendLine($"  * Quantity: {this.Milliliters} ml");
			text.AppendLine($"  * Usage: {this.Usage}");

			return text.ToString();
		}
	}
}
