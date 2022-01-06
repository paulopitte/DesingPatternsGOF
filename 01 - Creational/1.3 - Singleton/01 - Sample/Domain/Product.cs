using System;

namespace _01___Sample.Domain
{
    public sealed class Product
    {
        public Guid Id { get; private set; }
        public string Sku { get; private set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }

        public Product(string sku, string title, decimal price)
        {
            Id = Guid.NewGuid();
            Sku = sku;
            Title = title;
            Price = price;
        }
    }
}
