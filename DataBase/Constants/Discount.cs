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
        public static IEnumerable<IDiscount> Discounts = new List<IDiscount>
        {
            new Discount()
            {
                Id = 1,
                DiscountType = DiscountType.Birthday,
                Name = "Discount1",
                Description = "Discount1 with 10%",
                Value = 10
            },
            new Discount()
            {
                Id = 2,
                DiscountType = DiscountType.Holiday,
                Name = "Discount2",
                Description = "Discount2 with 20%",
                StartDate = new DateTime(2023, 11, 11),
                EndDate = new DateTime(2023, 11, 13),
                Value = 20
            },
            new Discount()
            {
                Id = 3,
                DiscountType = DiscountType.Holiday,
                Name = "Discount3",
                Description = "Discount3 with 30%",
                StartDate = new DateTime(2023, 12, 25),
                EndDate = new DateTime(2023, 12, 26),
                Value = 30
            },
            new Discount()
            {
                Id = 4,
                DiscountType = DiscountType.Holiday,
                Name = "Discount4",
                Description = "Discount4 with 40%",
                StartDate = new DateTime(2023, 06, 01),
                EndDate = new DateTime(2023, 07, 01),
                Value = 40
            },
            new Discount()
            {
                Id = 5,
                DiscountType = DiscountType.OrderPrice,
                Name = "Discount5",
                Description = "Discount5 with 50%",
                Value = 50
            }
        };
    }
}
