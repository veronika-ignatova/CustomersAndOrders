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
        public static IEnumerable<Discount> Discounts = new List<Discount>
        {
            new Discount()
            {
                Id = 1,
                DiscountType = DiscountType.None,
                Name = "Discount1",
                Description = "Discount1 with 10%",
                Value = 0
            },            
            new Discount()
            {
                Id = 2,
                DiscountType = DiscountType.Birthday,
                Name = "Discount2",
                Description = "Discount2 with 20%",
                Value = 10
            },            
            new Discount()
            {
                Id = 3,
                DiscountType = DiscountType.Holiday,
                Name = "Discount3",
                Description = "Discount3 with 30%",
                Value = 20
            },            
            new Discount()
            {
                Id = 4,
                DiscountType = DiscountType.Holiday,
                Name = "Discount4",
                Description = "Discount4 with 40%",
                Value = 40
            },            
            new Discount()
            {
                Id = 5,
                DiscountType = DiscountType.Holiday,
                Name = "Discount5",
                Description = "Discount5 with 50%",
                Value = 50
            }
        };
    }
}
