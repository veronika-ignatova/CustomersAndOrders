using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder
{
    public abstract class ItemBase
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemSize Size { get; set; }
        public double Price { get; set; }
        public Discount Discount { get; set; }

    }
}
