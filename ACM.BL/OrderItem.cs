using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool ValidateData()
        {
            if (Quantity <= 0) return false;
            if (ProductId <= 0) return false;
            if (PurchasePrice == null) return false;
            return true;
        }
        public OrderItem Retrieve(int productId)
        {
            return new OrderItem();
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public void Save()
        {

        }

    }
}