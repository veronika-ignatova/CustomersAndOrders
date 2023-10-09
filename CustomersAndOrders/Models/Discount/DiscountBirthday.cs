
using Core.Interfaces;

namespace Core.Model.Discount
{
    public class DiscountBirthday : DiscountBase<int>
    {
        public DiscountBirthday()
        {
            DiscountType = Enums.DiscountType.Birthday;
            IsOrderDiscount = true;
        }
        public override bool IsApplyDiscountForOrder(IOrder order)
        {
            if (order != null)
            {
                if (IsAdditionalDiscount)
                {
                    var dis = order.Discounts.FirstOrDefault(x => x.DiscountType == this.DiscountType);
                    if (dis != null)
                    {
                        if (dis.Amount < this.Amount)
                        {
                            order.Discounts.Remove(dis);
                            return true;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (!order.Discounts.Any(x => !x.IsAdditionalDiscount))
                    {
                        return true;
                    }
                    else
                    {
                        if (order.Discounts.Any(x => !x.IsAdditionalDiscount && x.Amount < this.Amount))
                        {
                            order.Discounts.RemoveAll(x => !x.IsAdditionalDiscount);
                            return true;
                        }
                    }
                }

            }
            return false;
        }
        //public override void SetDiscount(IOrder order)
        //{
        //    if (order != null)
        //    {
        //        if (order.Discounts == null) order.Discounts = new List<IDiscount<int>>();
        //        if (DateTime.Now.Day == order.Customer?.Birthday.Day
        //            && DateTime.Now.Month == order.Customer?.Birthday.Month)
        //            order.Discounts.Add(this);
        //    }
        //}
    }
}
