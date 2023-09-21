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
        public static IEnumerable<Customer> Customers = new List<Customer>
        {
            new Customer()
            {
                Id = 1,
                FirstName = "Veronika",
                LastName = "Ihnatova",
                DateOfRegistration = DateTime.Now.AddDays(-1),
                Birthday = new DateTime(2000,12,1),
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
            }
        };
    }
}
