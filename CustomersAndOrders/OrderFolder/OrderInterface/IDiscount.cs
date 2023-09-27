using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder.OrderInterface
{
    public interface IDiscount
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int Amount { get; set; }
        double? Value { get; set; }
        DiscountType DiscountType { get; set; }
        DateTime? StartDate { get; set; }
        DateTime? EndDate { get; set; }
    }
}
