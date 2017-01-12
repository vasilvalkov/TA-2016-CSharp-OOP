namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Category : ICategory
    {
        private const int CategoryMinLength = 2;
        private const int CategoryMaxLength = 15;
        private string name;
        private ICollection<IProduct> productList;

        public Category(string name)
        {
            this.Name = name;
            this.ProductList = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(
                value,
                CategoryMaxLength,
                CategoryMinLength,
                String.Format(GlobalErrorMessages.InvalidStringLength, "Category name", CategoryMinLength, CategoryMaxLength));

                this.name = value;
            }
        }

        public ICollection<IProduct> ProductList
        {
            get
            {
                return this.productList;
            }
            private set
            {
                Validator.CheckIfNull(value);

                this.productList = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.ProductList.Add(cosmetics);
        }

        public string Print()
        {
            StringBuilder text = new StringBuilder();

            ICollection<IProduct> sortedProducts = this.ProductList
                                                            .OrderBy(prod => prod.Brand)
                                                            .ThenByDescending(prod => prod.Price)
                                                            .ToArray();

            text.AppendLine($"{this.name} category – {this.ProductList.Count} products/product in total");

            foreach (var item in sortedProducts)
            {
                text.AppendLine(item.Print());
            }

            return text.ToString();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (this.ProductList.Contains(cosmetics))
            {
                this.ProductList.Remove(cosmetics);
            }
            else
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
        }
    }
}