
using Core.Interfaces;

namespace Core.Model.Discount
{
    public class DiscountOrderPrice : DiscountBase
    {
        public DiscountOrderPrice() 
        {
            DiscountType = Enums.DiscountType.OrderPrice;
        }
        public double MinPrice { get; set; }
    }
}
