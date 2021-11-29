using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            this.ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public bool ValidateData()
        {
            if (string.IsNullOrEmpty(Name)) return false;
            if (CurrentPrice == null) return false;
            return true;
        }
        public Product Retrieve(int productId)
        {
            return new Product();
        }
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
        public void Save() { }
    }
}