using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder.OrderInterface
{
    public interface IItem
    {
        //public double GetItemPrice(Item item);
        int Id { get; set; }
        public int DiscountId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        ItemSize Size { get; set; }
        double Price { get; set; }
        Discount Discount { get; set; }
    }
}
