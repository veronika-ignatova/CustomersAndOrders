using CustomersAndOrders.OrderFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.UserFolder
{
    public class Customer : UserBase, ICustomer
    {
        public Customer()
        {
            UserType = UserType.Customer;
        }
    }
}
