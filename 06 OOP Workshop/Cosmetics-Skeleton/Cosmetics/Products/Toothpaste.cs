namespace Cosmetics.Products
{
	using System.Collections.Generic;
	using System.Text;
	using Contracts;
	using Common;

	public class Toothpaste : Product, IToothpaste, IProduct
	{
        private const int IngredientNameMinLength = 4;
        private const int IngredientNameMaxLength = 12;
        private readonly string ingredients;

		public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
			: base(name, brand, price, gender)
		{
            foreach (string ingredient in ingredients)
            {
                Validator.CheckIfStringLengthIsValid(
                    ingredient,
                    IngredientNameMaxLength,
                    IngredientNameMinLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", IngredientNameMinLength, IngredientNameMaxLength));
            }

			this.ingredients = string.Join(", ", ingredients);
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
			text.Append(string.Format("  * Ingredients: {0}", this.Ingredients));

			return text.ToString();
		}
	}
}