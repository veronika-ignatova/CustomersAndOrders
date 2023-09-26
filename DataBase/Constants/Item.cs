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
        public static IEnumerable<IItem> Items = new List<IItem>
        {
            new Item()
            {
                Id = 1,
                Name = "Book",
                Description = "Book about cats",
                Price = 100,
                DiscountId = 4
            },
            new Item()
            {
                Id = 2,
                Name = "Laptop",
                Description = "Cool laptop",
                Price = 1000,
                DiscountId = 2
            },
            new Item()
            {
                Id = 3,
                Name = "Computer",
                Description = "New computer",
                Price = 150,
                DiscountId = 3
            },            
            new Item()
            {
                Id = 4,
                Name = "Mouse",
                Description = "Small mouse",
                Price = 25,
                DiscountId = 1
            },            
            new Item()
            {
                Id = 5,
                Name = "Keyboard",
                Description = "Hot-swap keyboard",
                Price = 199,
                DiscountId = 2
            }
        };
    }
}
