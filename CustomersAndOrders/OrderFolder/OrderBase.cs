using CustomersAndOrders.OrderFolder.OrderInterface;
using CustomersAndOrders.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder
{
    public abstract class OrderBase
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrderStatus { get; set; }
        public List<IItem> Items { get; set; }
        public List<IDiscount> Discounts { get; set; }
        public double TotalPrice { get; }
    }
}
