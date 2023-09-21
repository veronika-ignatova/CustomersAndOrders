using CustomersAndOrders.OrderFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.UserFolder
{
    public abstract class UserBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; protected set; }
        public DateTime Birthday { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public List<Order> Orders { get; set; }

    }
}
