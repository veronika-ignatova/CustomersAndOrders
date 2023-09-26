using CustomersAndOrders.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder.OrderInterface
{
    public interface IOrder
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        int DeliveryId { get; set; }
        ICustomer Customer { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string OrderStatus { get; set; }
        List<IItem> Items { get; set; }
        List<IDiscount> Discounts { get; set; }
        double TotalPrice { get; }
    }
}
