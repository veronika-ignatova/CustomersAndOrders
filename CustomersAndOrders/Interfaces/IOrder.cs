
using Core.Model;

namespace Core.Interfaces
{
    public interface IOrder
    {
        event AddingItem? AddItem;
        int Id { get; set; }
        int CustomerId { get; set; }
        int DeliveryId { get; set; }
        ICustomer Customer { get; set; }
        IDelivery Delivery { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string OrderStatus { get; set; }
        List<IItem> Items { get; set; }
        List<IDiscount<int>> Discounts { get; set; }
        double TotalPrice { get; set; }
        void AddNewItem(IItem item);
    }
}
