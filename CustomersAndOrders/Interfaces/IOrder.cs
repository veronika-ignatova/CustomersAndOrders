
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
        List<IItem> Items { get; set; }
        double Price { get; }
        double TotalPrice { get; }
        DateTime CreateOrder {  get; set; }
        List<IDiscount<int>> Discounts { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string OrderStatus { get; set; }
        void SetDiscounts(IEnumerable<IDiscount<int>> discounts);
        void AddNewItem(IItem item);
    }
}
