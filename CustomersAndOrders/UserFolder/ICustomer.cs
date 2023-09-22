using CustomersAndOrders.OrderFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.UserFolder
{
    public interface ICustomer
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        UserType UserType { get; }
        DateTime Birthday { get; set; }
        DateTime DateOfRegistration { get; set; }
        List<Order> Orders { get; set; }
    }
}
