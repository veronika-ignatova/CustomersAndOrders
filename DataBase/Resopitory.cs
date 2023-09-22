using CustomersAndOrders.OrderFolder.OrderInterface;
using CustomersAndOrders.UserFolder;
using DataBase.Constants;

namespace DataBase
{
    public class Repository
    {
        public IOrder GetOrderById(int id)
        {
            var order = GetPrivateOrderById(id);
            if (order != null)
            {
                order.Customer = (Customer)GetPrivateCustomerById(order.CustomerId);
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