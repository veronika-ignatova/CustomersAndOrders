using Core.Enums;
using Core.Interfaces;
using Core.Model;

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
