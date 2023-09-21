using CustomersAndOrders.OrderFolder.OrderInterface;
using CustomersAndOrders.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder
{
    public class Devilery : DeliveryBase, IDelivery
    {
        public Devilery()
        {
            DeliveryCompany = DeliveryCompany.NovaPosta;
        }
    }
}
