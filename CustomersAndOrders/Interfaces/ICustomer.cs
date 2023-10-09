using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICustomer
    {
        List<IOrder> Orders { get; set; }
        DateTime Birthday { get; set; }
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        UserType UserType { get; }
        DateTime DateOfRegistration { get; set; }
    }
}
