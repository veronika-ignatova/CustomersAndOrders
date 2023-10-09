
using Core.Interfaces;

namespace Core.Model.Discount
{
    public class DiscountItemCount : DiscountBase<int>
    {
        public int ItemCount { get; set; }
        public DiscountItemCount()
        {
            DiscountType = Enums.DiscountType.ItemCount;
        }
        public override bool IsApplyDiscountForItem(IOrder order, IItem item)
        {
            if (order != null && order.Items != null && order.Items.Count > 0)
            {
                var count = 0;
                foreach (var item2 in order.Items)
                {
                    if (item.Id == item2.Id) count++;
                }

                if (count >= ItemCount)
                {
                    return true;
                }
            }
            return false;
        }
        //public override void SetDiscount(IOrder order)
        //{
        //    foreach (var item in order.Items)
        //    {
        //        var count = 0;
        //        foreach (var item2 in order.Items)
        //        {
        //            if (item.Id == item2.Id) count++;
        //        }

        //        if (count >= ItemCount)
        //        {
        //            foreach (var dis in item.Discounts)
        //            {
        //                if (dis.DiscountType == Enums.DiscountType.ItemCount)
        //                {
        //                    if (((DiscountItemCount)dis).ItemCount < this.ItemCount)
        //                    {
        //                        item.Discounts.Remove(dis);
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        return;
        //                    }
        //                }
        //            }
        //            item.Discounts.Add(this);
        //        }
        //    }
        //}
    }
}
