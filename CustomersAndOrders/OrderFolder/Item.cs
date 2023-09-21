using CustomersAndOrders.OrderFolder.OrderInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder
{
    public class Item : ItemBase, IItem
    {
        //public double GetItemPrice(Item item)
        //{
        //    return item.Price  - item.Price * item.Discount.SetDiscountForItem(item)/100;
        //}
    }
}
