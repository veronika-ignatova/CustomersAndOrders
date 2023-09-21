using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder
{
    public abstract class DeliveryBase
    {
        public int Id { get; set; }
        public DeliveryCompany DeliveryCompany { get; set; }
        public double Price { get; set; }
    }
}
