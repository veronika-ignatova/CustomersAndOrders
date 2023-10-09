using Core.Enums;

namespace Core.Interfaces
{
    public interface IDelivery
    {
        int Id { get; set; }
        DeliveryCompany DeliveryCompany { get; set; }
        double Price { get; set; }
    }
}
