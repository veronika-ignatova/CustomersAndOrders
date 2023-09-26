using CustomersAndOrders.OrderFolder;
using CustomersAndOrders.OrderFolder.OrderInterface;
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
        public static IEnumerable<IDelivery> Deliveries = new List<IDelivery>
        {
            new Devilery()
            {
                Id = 1,
                DeliveryCompany = DeliveryCompany.NovaPosta,
                Price = 100
            },
            new Devilery()
            {
                Id = 2,
                DeliveryCompany = DeliveryCompany.UkrPosta,
                Price = 50
            },
            new Devilery()
            {
                Id = 3,
                DeliveryCompany = DeliveryCompany.Meets,
                Price = 75
            }
        };
    }
}
