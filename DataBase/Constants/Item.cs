using CustomersAndOrders.OrderFolder;
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
        public static IEnumerable<Item> Items = new List<Item>
        {
            new Item()
            {
                Id = 1,
                Name = "Book",
                DeliveryId = 1,
                Description = "Book about cats",
                Price = 100,
                DiscountId = 4
            },
            new Item()
            {
                Id = 2,
                Name = "Laptop",
                DeliveryId = 2,
                Description = "Cool laptop",
                Price = 1000,
                DiscountId = 2
            },
            new Item()
            {
                Id = 3,
                Name = "Computer",
                DeliveryId = 1,
                Description = "New computer",
                Price = 150,
                DiscountId = 3
            },            
            new Item()
            {
                Id = 4,
                Name = "Mouse",
                DeliveryId = 1,
                Description = "Small mouse",
                Price = 25,
                DiscountId = 1
            },            
            new Item()
            {
                Id = 5,
                Name = "Keyboard",
                DeliveryId = 2,
                Description = "Hot-swap keyboard",
                Price = 199,
                DiscountId = 2
            }
        };
    }
}
