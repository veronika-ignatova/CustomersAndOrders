using Core.Interfaces;
using Core.Model;

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
                Price = 100
            },
            new Item()
            {
                Id = 2,
                Name = "Laptop",
                Description = "Cool laptop",
                Price = 1000,
            },
            new Item()
            {
                Id = 3,
                Name = "Computer",
                Description = "New computer",
                Price = 150,
            },            
            new Item()
            {
                Id = 4,
                Name = "Mouse",
                Description = "Small mouse",
                Price = 25,
            },            
            new Item()
            {
                Id = 5,
                Name = "Keyboard",
                Description = "Hot-swap keyboard",
                Price = 199,
            }
        };
    }
}
