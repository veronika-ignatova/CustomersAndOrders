﻿using CustomersAndOrders.OrderFolder;
using CustomersAndOrders.OrderFolder.OrderInterface;
using CustomersAndOrders.UserFolder;
using DataBase.Constants;
using System.ComponentModel;
using System.Security.AccessControl;

namespace DataBase
{
    public class Repository : IRepository
    {
        public IOrder GetOrderById(int id)
        {
            var order = GetPrivateOrderById(id);
            if (order != null)
            {
                order.Customer = GetPrivateCustomerById(order.CustomerId);
                //order.Items = GetPrivateItemsById(order.Id);
            }
            return order;
        }


        private IDelivery GetPrivateDeliveryById(int id)
        {
            var deliverys = MyDbContext.Deliveries;
            foreach (var delivery in deliverys)
            {
                if (delivery.Id == id)
                {
                    return delivery;
                }
            }
            return null;
        }
        public ICustomer GetCustomerByOrderId(int id)
        {
            var orders = MyDbContext.Orders;
            var customers = MyDbContext.Customers;
            foreach (var order in orders)
            {
                foreach (var customer in customers)
                {
                    if (order.CustomerId == customer.Id && order.Id == id)
                    {
                        return customer;
                    }
                }
            }
            return null;
        }

        public List<IDiscount> GetAllDiscount()
        {
            var discounts = MyDbContext.Discounts;
            var results = new List<IDiscount>();

            foreach (var discount in discounts) 
            {
                if(discount.StartDate.HasValue && discount.EndDate.HasValue)
                {
                    if (discount.StartDate <= DateTime.Now && discount.EndDate >= DateTime.Now)
                    {
                        results.Add(discount);
                    }
                }
                else
                {
                    results.Add(discount);
                }
            }
            return results;
        }

        public void GetDiscountsForOrder(IOrder order)
        {
            var customer = GetCustomerByOrderId(order.Id);
            var price = GetPriceByOrderId(order.Id);
            var discountList = GetAllDiscount();
            var result = new List<IDiscount>();

            foreach (var discount in discountList)
            {
                switch (discount.DiscountType)
                {
                    case DiscountType.OrderPrice:
                        if (discount.Value.HasValue && discount.Value <= price) result.Add(discount);
                        break;
                    case DiscountType.Birthday:
                        if (DateTime.Now.Day == customer.Birthday.Day && DateTime.Now.Month == customer.Birthday.Month) result.Add(discount);
                        break;
                    case DiscountType.Holiday:
                        result.Add(discount);
                        break;
                    default:
                        break;
                }
            }
            order.Discounts = result;
        }

        public void GetTotalPriceInOrder(IOrder order)
        {
            int maxDiscount = 0;
            if (order.Discounts != null && order.Discounts.Count > 0)
            {
                foreach (var discount in order.Discounts)
                {
                    maxDiscount += discount.Amount;
                }
            }
            var price = GetPriceByOrderId(order.Id);
            order.TotalPrice = price - (price * maxDiscount / 100);
        }

        public double GetTotalWithDelivery(int id)
        {
            var deliveries = MyDbContext.Deliveries;
            var order = GetPrivateOrderById(id);
            GetTotalPriceInOrder(order);
            double deliveryPrice = 0;
            foreach (var delivery in deliveries)
            {
                if (delivery.Id == order.DeliveryId && order.Id == id)
                {
                    deliveryPrice = delivery.Price;
                }
            }
            return order.TotalPrice + deliveryPrice;
        }

        public double GetPriceByOrderId(int id)
        {
            var order = GetOrderWithItemsById(id);
            var items = order.Items;
            double price = 0;
            foreach (var item in items)
            {
                price += item.Price;
            }
            return price;
        }

        private ICustomer GetPrivateCustomerById(int id)
        {
            var customers = MyDbContext.Customers;
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }

        private IOrder GetPrivateOrderById(int id)
        {
            var orders = MyDbContext.Orders;
            foreach (var order in orders)
            {
                if (order.Id == id)
                {
                    return order;
                }
            }
            return null;
        }

        public IOrder GetOrderWithItemsById(int id)
        {
            var orders = MyDbContext.Orders;
            IOrder result = null;
            foreach (var order in orders)
            {
                if (order.Id == id)
                {
                    result = order;
                }
            }
            if (result != null)
            {
                var orderItems = MyDbContext.OrderItems;
                var items = MyDbContext.Items;

                List<IItem> resItems = new List<IItem>();

                foreach (var item in orderItems)
                {
                    if (item.OrderId == result.Id)
                    {
                        foreach (var it in items)
                        {
                            if (item.ItemId == it.Id)
                            {
                                resItems.Add(it);
                            }
                        }
                    }
                }
                result.Items = resItems;
                return result;
            }
            return null;
        }

        public ICustomer GetCustomerWithOrderById(int id)
        {
            var customers = MyDbContext.Customers;
            ICustomer result = null;
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    result = customer;
                }
            }
            if (result != null)
            {
                var orders = MyDbContext.Orders;

                List<IOrder> resOrders = new List<IOrder>();

                foreach (var order in orders)
                {
                    if (order.CustomerId == result.Id)
                    {
                        resOrders.Add(order); 
                    }
                }
                result.Orders = resOrders;
                return result;
            }
            return null;
        }


    }
}