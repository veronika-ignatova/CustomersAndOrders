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
        string Name { get; set; }
        public DiscountType DiscountType { get;}
        string Description { get; set; }
        int Value { get; set; }
        DateTime? StartDate { get; set; }
        DateTime? EndDate { get; set; }
        abstract void SetDiscount(IOrder order);
    }
}
