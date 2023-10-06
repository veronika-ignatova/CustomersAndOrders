using Core.Interfaces;
namespace Core.Model
{
    public delegate void AddingItem(object obj, string message);
    public abstract class OrderBase
    {
        public event AddingItem? AddItem;
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DeliveryId { get; set; }
        public ICustomer Customer { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrderStatus { get; set; }
        public List<IItem> Items { get; set; }
        public List<IDiscount<int>> Discounts { get; set; }
        public double TotalPrice { get; set; }
        public IDelivery Delivery { get; set; }
        public abstract void AddNewItem(IItem item);
        protected void OnAddItem(IItem item)
        {
            AddItem?.Invoke(this, $"Added new item {item.Id}");
        }
    }
}
