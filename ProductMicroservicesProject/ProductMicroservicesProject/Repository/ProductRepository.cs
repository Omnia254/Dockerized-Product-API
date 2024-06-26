﻿using Microsoft.EntityFrameworkCore;
using ProductMicroservicesProject.Models;

namespace ProductMicroservicesProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDBContext _dbContext;
        public ProductRepository(ProductDBContext context)
        {
            _dbContext = context;
        }
        public void DeleteProduct(int productid)
        {
            var product = _dbContext.Products.Find(productid);
            _dbContext.Products.Remove(product);
            Save();
        }

        public Product GetProductById(int productid)
        {
            return _dbContext.Products.Find(productid);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }
    }
}
