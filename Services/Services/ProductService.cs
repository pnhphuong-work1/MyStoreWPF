
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using Repositories.Abstractions;
using Services.Abstractions;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _iProductRepository;
        public ProductService()
        {
            _iProductRepository = new ProductRepository();
        }

        public void AddProduct(Product product)
        {
            _iProductRepository.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _iProductRepository.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            _iProductRepository.DeleteProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _iProductRepository.GetAllProducts();
        }

        public Product? GetProductById(int productId)
        {
            return _iProductRepository.GetProductById(productId);
        }
    }
}
