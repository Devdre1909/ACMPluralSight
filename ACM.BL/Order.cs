using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public bool ValidateData()
        {
            if (OrderDate == null) return false;
            return true;
        }
        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        public void Save()
        {

        }
    }
}