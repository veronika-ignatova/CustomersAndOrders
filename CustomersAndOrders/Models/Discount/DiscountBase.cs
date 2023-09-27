
using Core.Enums;
using Core.Interfaces;

namespace Core.Model.Discount
{
    public abstract class DiscountBase: IDiscount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DiscountType DiscountType { get; protected set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual void SetDiscount(IOrder order)
        {
            if (order != null)
            {
                if (order.Discounts == null) order.Discounts = new List<IDiscount>();
                order.Discounts.Add(this);
            }
        }
    }
}
