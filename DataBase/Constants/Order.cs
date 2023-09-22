using CustomersAndOrders.OrderFolder;
using CustomersAndOrders.OrderFolder.OrderInterface;
using CustomersAndOrders.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Constants
{
    internal partial class MyDbContext
    {
        public static IEnumerable<IOrder> Orders = new List<IOrder>
        {
            new Order 
            {
                Id = 1,
                CustomerId = 1,
                Name = "Order1",
                Description = "Order1 for customer 1",
                OrderStatus = "done"
            },            
            new Order
            {
                Id = 2,
                CustomerId = 1,
                Name = "Order2",
                Description = "Order2 for customer 2",
                OrderStatus = "ariving tomorrow"
            },            
            new Order
            {
                Id = 3,
                CustomerId = 3,
                Name = "Order3",
                Description = "Order3 for customer 3",
                OrderStatus = "order created"
            },
            new Order
            {
                Id = 4,
                CustomerId = 4,
                Name = "Order4",
                Description = "Order4 for customer 4",
                OrderStatus = "order created"
            },
            new Order
            {
                Id = 5,
                CustomerId = 5,
                Name = "Order5",
                Description = "Order5 for customer 5",
                OrderStatus = "order created"
            },

        };
    }
}
