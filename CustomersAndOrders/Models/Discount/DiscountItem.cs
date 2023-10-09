using Core.Interfaces;
using Core.Model.Discount;

namespace Core.Models.Discount
{
    public class DiscountItem: DiscountBase<int>
    {
        public int ItemId { get; set; }
        public DiscountItem()
        {
            DiscountType = Enums.DiscountType.Item;
        }

        public override bool IsApplyDiscountForItem(IOrder order, IItem item)
        {
            if (order != null && order.Items != null && order.Items.Count > 0)
            {
                if (item.Id == ItemId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
