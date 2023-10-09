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
        public DateTime CreateOrder {  get; set; }
        public double Price
        {
            get
            {
                return Sum<IItem>(x => x.TotalPrice, Items);
            }
        }
        public double TotalPrice
        {
            get
            {
                return Price - Sum<IDiscount<int>>(Get1, Discounts) * Price / 100;
            }
        }
        public IDelivery Delivery { get; set; }
        public abstract void AddNewItem(IItem item);
        public abstract double Sum<T>(Func<T, double> GetElement, IEnumerable<T> items);
        public abstract double Get1(IDiscount<int> discount);
        public abstract void SetDiscounts(IEnumerable<IDiscount<int>> discounts);
        protected abstract void AddDiscountToItem(IItem item, IDiscount<int> discount);
        protected void OnAddItem(IItem item)
        {
            AddItem?.Invoke(this, $"Added new item {item.Id}");
        }
    }
}
