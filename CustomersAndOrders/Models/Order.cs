using Core.Interfaces;
namespace Core.Model
{
    public class Order : OrderBase, IOrder
    {
        public override void AddNewItem(IItem item)
        {
            if (item != null)
            {
                Items.Add(item);
                OnAddItem(item);
            }
        }

        public override double Sum<T>(Func<T, double> GetElement, IEnumerable<T> items)
        {
            double sum = 0;
            foreach (var item in items)
            {
                sum += GetElement(item);
            }
            return sum;
        }

        public override double Get1(IDiscount<int> discount)
        {
            return discount.Amount;
        }

        public override void SetDiscounts(IEnumerable<IDiscount<int>> discounts)
        {
            foreach (var discount in discounts)
            {
                if (discount.IsOrderDiscount)
                {
                    if (discount.IsApplyDiscountForOrder(this)) Discounts.Add(discount);
                }
                else
                {
                    foreach (var item in Items)
                    {
                        if (discount.IsApplyDiscountForItem(this, item)) AddDiscountToItem(item, discount);
                    }
                }
            }
        }

        protected override void AddDiscountToItem(IItem item, IDiscount<int> discount)
        {
            if (item.Discounts.ContainsKey(discount.DiscountType) && item.Discounts[discount.DiscountType].Amount < discount.Amount)
            {
                item.Discounts[discount.DiscountType] = discount;
            }
            else if (!item.Discounts.ContainsKey(discount.DiscountType))
            {
                item.Discounts.Add(discount.DiscountType, discount);
            }
        }
    }
}
