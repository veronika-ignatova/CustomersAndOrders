
using Core.Interfaces;

namespace Core.Model.Discount
{
    public class DiscountHoliday : DiscountBase
    {
        public DiscountHoliday()
        {
            DiscountType = Enums.DiscountType.Holiday;
        }
    }
}
