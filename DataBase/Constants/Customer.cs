using Core.Interfaces;
using Core.Model;

namespace DataBase.Constants
{
    internal partial class MyDbContext
    {
        public static IEnumerable<ICustomer> Customers = new List<ICustomer>
        {
            new Customer()
            {
                Id = 1,
                FirstName = "Veronika",
                LastName = "Ihnatova",
                DateOfRegistration = DateTime.Now.AddDays(-1),
                Birthday = new DateTime(2000,09,27),
                Email = "email@gmail.com",
                Password = "password",
                UserName = "nickname"
            },
            new Customer()
            {
                Id = 2,
                FirstName = "Alina",
                LastName = "Polishyk",
                DateOfRegistration = DateTime.Now,
                Birthday = new DateTime(2007,8,8),
                Email = "alina@gmail.com",
                Password = "alinaTheBest",
                UserName = "AlinaPol"
            },
            new Customer()
            {
                Id = 3,
                FirstName = "Katya",
                LastName = "Mandryk",
                DateOfRegistration = DateTime.Now.AddDays(-99),
                Birthday = new DateTime(1990,2,17),
                Email = "kateryna@gmail.com",
                Password = "myPass",
                UserName = "Kateryna1990"
            },
            new Customer()
            {
                Id = 4,
                FirstName = "Anya",
                LastName = "Kryk",
                DateOfRegistration = DateTime.Now.AddDays(-101),
                Birthday = new DateTime(1991,3,1),
                Email = "kryk123@gmail.com",
                Password = "123456",
                UserName = "anyakryk"
            },
            new Customer()
            {
                Id = 5,
                FirstName = "Oleksa",
                LastName = "Gryniv",
                DateOfRegistration = DateTime.Now.AddDays(-5),
                Birthday = new DateTime(2000,8,10),
                Email = "gryniv2000@gmail.com",
                Password = "gryniv",
                UserName = "oleksa123"
            }
        };
    }
}
