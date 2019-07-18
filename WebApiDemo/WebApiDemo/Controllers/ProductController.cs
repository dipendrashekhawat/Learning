
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;
using System.Net;

namespace WebApiDemo.Controllers
{
    public class ProductController : ApiController
    {
        static readonly IProductManager prodManager = new ProductManager();

        //Get All Products
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            return prodManager.GetAll();
        }

        //Get Product by id
        [HttpGet]
        public Product GetProductById(int id)
        {
            var product = prodManager.Get(id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.OK);
            }
            return product;
        }

        //Add Product
        [HttpPost]
        public Product AddProduct(Product product)
        {
            product = prodManager.Add(product);
            return product;
        }

        //Update Product
        [HttpPut]
        public void UpdateProduct(Product product)
        {
            if (!prodManager.Update(product))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        //Delete Product
        [HttpDelete]
        public void DeleteProduct(int id)
        {
            Product product = prodManager.Get(id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            prodManager.Remove(id);
        }
    }
}
