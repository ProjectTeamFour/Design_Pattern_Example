using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Sever
{
    public class ProductServer
    {
        private ProductRepository _productRepository;
        public ProductServer() {
            _productRepository = new ProductRepository();
        }
        public IEnumerable<Product> GetByFilter(int num) 
        {
            var res = _productRepository.GetAll().Where(x => x.Price == num);
            return res;
        }
    }
}