using CustomersAndOrders.OrderFolder.OrderInterface;
using CustomersAndOrders.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IRepository
    {
        IOrder GetOrderById(int id);
        IOrder GetOrderWithItemsById(int id);
        ICustomer GetCustomerWithOrderById(int id);
        ICustomer GetCustomerByOrderId(int id);

    }
}
