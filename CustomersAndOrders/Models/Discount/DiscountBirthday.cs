
using Core.Interfaces;

namespace Core.Model.Discount
{
    public class DiscountBirthday : DiscountBase
    {
        public DiscountBirthday()
        {
            DiscountType = Enums.DiscountType.Birthday;
        }

        public override void SetDiscount(IOrder order)
        {
            if (order != null)
            {
                if (order.Discounts == null) order.Discounts = new List<IDiscount>();
                if (DateTime.Now.Day == order.Customer?.Birthday.Day
                    && DateTime.Now.Month == order.Customer?.Birthday.Month)
                    order.Discounts.Add(this);
            }
        }
    }
}
