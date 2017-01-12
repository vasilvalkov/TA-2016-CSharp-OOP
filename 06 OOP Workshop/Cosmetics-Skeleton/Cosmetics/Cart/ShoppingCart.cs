namespace Cosmetics.Cart
{
    using Cosmetics.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> productList;

        public ShoppingCart()
        {
            this.ProductList = new List<IProduct>();
        }

        public ICollection<IProduct> ProductList
        {
            get { return new List<IProduct>(this.productList); }
            set { this.productList = value; }
        }

        public void AddProduct(IProduct product)
        {
            this.ProductList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.ProductList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.ProductList.Contains(product);
        }

        public decimal TotalPrice()
        {
            return this.ProductList.Sum(prod => prod.Price);
        }
    }
}