﻿using CustomersAndOrders.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder.OrderInterface
{
    public interface IOrder
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        Customer Customer { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string OrderStatus { get; set; }
        List<Item> Items { get; set; }
        List<Discount> Discounts { get; set; }
        double TotalPrice { get; }
    }
}