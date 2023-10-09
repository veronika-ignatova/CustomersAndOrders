using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IDiscount<T>
    {
        T Id { get; set; }
        string Description { get; set; }
        public DiscountType DiscountType { get;}
        DateTime? StartDate { get; set; }
        DateTime? EndDate { get; set; }
        int Amount { get; set; }
        string Name { get; set; }
        bool IsOrderDiscount { get; set; }
        bool IsAdditionalDiscount { get; set; }
        bool IsApplyDiscountForOrder(IOrder order);
        bool IsApplyDiscountForItem(IOrder order, IItem item);
        //abstract void SetDiscount(IOrder order);
    }
}
