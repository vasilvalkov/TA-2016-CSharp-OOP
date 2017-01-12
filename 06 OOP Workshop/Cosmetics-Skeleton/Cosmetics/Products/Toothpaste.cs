namespace Cosmetics.Products
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Cosmetics.Contracts;
	using Common;

	public class Toothpaste : Product, IToothpaste, IProduct
	{
		private readonly string ingredients;

		public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
			: base(name, brand, price, gender)
		{
			this.ingredients =  string.Join(", ", ingredients);
		}

		public string Ingredients
		{
			get
			{
				return this.ingredients;
			}
		}

		public override decimal Price
		{
			get
			{
				return this.price;
			}

			protected set
			{
				this.price = value;
			}
		}

		public override string Print()
		{
			StringBuilder text = new StringBuilder();
			text.AppendLine(base.Print());
			text.AppendLine($"  * Ingredients: {this.Ingredients}");

			return base.Print();
		}
	}
}