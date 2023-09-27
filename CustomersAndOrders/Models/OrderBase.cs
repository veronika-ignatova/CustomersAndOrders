using Core.Interfaces;
namespace Core.Model
{
    public abstract class OrderBase: IOrder
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DeliveryId { get; set; }
        public ICustomer Customer { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrderStatus { get; set; }
        public List<IItem> Items { get; set; }
        public List<IDiscount> Discounts { get; set; }
        public double TotalPrice { get; set; }
        public IDelivery Delivery { get; set; }
    }
}
