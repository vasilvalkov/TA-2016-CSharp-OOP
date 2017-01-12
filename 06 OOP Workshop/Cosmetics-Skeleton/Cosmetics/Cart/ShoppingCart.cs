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
            private set { this.productList = value; }
        }

        public void AddProduct(IProduct product)
        {
            this.productList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.productList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.ProductList.Contains(product);
        }

        public decimal TotalPrice()
        {
            return this.ProductList.Sum(x => x.Price);
        }
    }
}