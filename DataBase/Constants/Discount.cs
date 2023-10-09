using Core.Enums;
using Core.Interfaces;
using Core.Model.Discount;
using Core.Models.Discount;

namespace DataBase.Constants
{
    internal partial class MyDbContext
    {
        public static IEnumerable<IDiscount<int>> Discounts = new List<IDiscount<int>>
        {
            new DiscountItem()
            {
                Id = 15,
                Name = "Discount `15",
                Description = "Discount for item 1",
                Amount = 12,
                ItemId = 1,
            },
            new DiscountBirthday()
            {
                Id = 1,
                Name = "Discount1",
                Description = "Discount1 with 10%",
                Amount = 3
            },
            new DiscountHoliday()
            {
                Id = 2,
                Name = "Discount2",
                Description = "Discount2 with 20%",
                StartDate = new DateTime(2023, 11, 11),
                EndDate = new DateTime(2023, 11, 13),
                Amount = 20
            },
            new DiscountHoliday()
            {
                Id = 3,
                Name = "Discount3",
                Description = "Discount3 with 30%",
                StartDate = new DateTime(2023, 09, 25),
                EndDate = new DateTime(2023, 10, 10),
                Amount = 30
            },
            new DiscountHoliday()
            {
                Id = 4,
                Name = "Discount4",
                Description = "Discount4 with 40%",
                StartDate = new DateTime(2023, 06, 01),
                EndDate = new DateTime(2023, 07, 01),
                Amount = 40
            },
            new DiscountOrderPrice()
            {
                Id = 5,
                Name = "Discount",
                Description = "Discount5 with 3%",
                Amount = 3,
                MinPrice = 1000,
            },
            new DiscountOrderPrice()
            {
                Id = 6,
                Name = "Discount",
                Description = "Discount5 with 5%",
                Amount = 5,
                MinPrice = 3000
            },
            new DiscountItemCount()
            {
                Id = 7,
                Name = "Discount",
                Description = "Discount5 with 5%",
                Amount = 5,
                ItemCount = 3
            },
            new DiscountItemCount()
            {
                Id = 10,
                Name = "Discount",
                Description = "Discount5 with 10%",
                Amount = 10,
                ItemCount = 7
            },
            new DiscountItemCount()
            {
                Id = 8,
                Name = "Discount",
                Description = "Discount5 with 7%",
                Amount = 7,
                ItemCount = 5
            },
            new DiscountItemCount()
            {
                Id = 9,
                Name = "Discount",
                Description = "Discount5 with 3%",
                Amount = 3,
                ItemCount = 2
            },
        };
    }
}
