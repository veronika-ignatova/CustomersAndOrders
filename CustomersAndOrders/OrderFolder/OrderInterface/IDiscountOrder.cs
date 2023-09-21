using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder.OrderInterface
{
    public interface IDiscountOrder
    {
        public double SetDiscountForOrder(Order order);
    }
}
