using Core.Interfaces;
using Core.Model;

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
                DeliveryId = 1,
                Name = "Order1",
                Description = "Order1 for customer 1",
                OrderStatus = "done"
            },            
            new Order
            {
                Id = 2,
                CustomerId = 1,
                DeliveryId = 1,
                Name = "Order2",
                Description = "Order2 for customer 2",
                OrderStatus = "ariving tomorrow"
            },            
            new Order
            {
                Id = 3,
                CustomerId = 3,
                DeliveryId = 2,
                Name = "Order3",
                Description = "Order3 for customer 3",
                OrderStatus = "order created"
            },
            new Order
            {
                Id = 4,
                CustomerId = 4,
                DeliveryId = 3,
                Name = "Order4",
                Description = "Order4 for customer 4",
                OrderStatus = "order created"
            },
            new Order
            {
                Id = 5,
                CustomerId = 5,
                DeliveryId = 3,
                Name = "Order5",
                Description = "Order5 for customer 5",
                OrderStatus = "order created"
            },

        };
    }
}
