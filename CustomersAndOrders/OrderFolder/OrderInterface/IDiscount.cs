﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders.OrderFolder.OrderInterface
{
    public interface IDiscount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public DiscountType DiscountType { get; set; }
    }
}