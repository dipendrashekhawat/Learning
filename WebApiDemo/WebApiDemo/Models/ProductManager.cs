using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class ProductManager: IProductManager
    {
        List<Product> products = new List<Product>();
        private int _autoProductId = 1;

        public ProductManager()
        {
            Add(new Product { Name = "Pen", Type = "Stationary", Description = "Pen from Lexi Company", Price = 10 });
            Add(new Product { Name = "Ball", Type = "Sports", Description = "Ball from Hedley", Price = 65 });
            Add(new Product { Name = "Battery", Type = "Electronics", Description = "Duracell batteries", Price = 20 });
            Add(new Product { Name = "Books", Type = "Stationary", Description = "Academic books", Price = 2000 });
            Add(new Product { Name = "Gym Bag", Type = "Sports", Description = "Gym Bag from Reebok", Price = 1500 });
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            var product = products.Find(p => p.Id == id);
            return product;
        }

        public Product Add(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            product.Id = _autoProductId++;
            products.Add(product);
            return product;
        }

        public void Remove(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }

        public bool Update(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            int index = products.FindIndex(p => p.Id == product.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(product);
            return true;
        }
    }
}
