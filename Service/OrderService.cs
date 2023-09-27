using Core.Enums;
using Core.Interfaces;
using Core.Model.Discount;

namespace Service
{
    public class OrderService
    {
        protected IRepository _repository;
        public OrderService(IRepository repository)
        {
            _repository = repository;
        }

        public IOrder GetOrderById(int id)
        {
            var order = _repository.GetOrderById(id);
            GetDiscountsForOrder(order);
            ApplyAllDiscountsForOrder(order);

            return order;
        }

        private void GetDiscountsForOrder(IOrder order)
        {
            var discountList = _repository.GetAllDiscount();

            foreach (var discount in discountList)
            {
                discount.SetDiscount(order);
            }
        }

        private void ApplyAllDiscountsForOrder(IOrder order)
        {
            double orderPrice = 0;
            if (order.Items != null && order.Items.Count > 0)
            {
                foreach (var item in order.Items)
                {
                    orderPrice += GetItemPrice(item);
                }
            }
            
            var dis = 0;
            foreach (var discount in order.Discounts)
            {
                if (discount.DiscountType != DiscountType.OrderPrice && discount.Value > dis)
                {
                    dis = discount.Value;
                }
            }
            orderPrice -= orderPrice * dis / 100;

            dis = 0;
            foreach(var discount in order.Discounts)
            {
                if (discount.DiscountType == DiscountType.OrderPrice && orderPrice >= ((DiscountOrderPrice)discount).MinPrice && dis < discount.Value)
                {
                    dis = discount.Value;
                }
            }
            
            order.TotalPrice = orderPrice - (dis * orderPrice / 100);
        }

        private double GetItemPrice(IItem item)
        {
            var discountValue = 0;

            if(item.Discounts != null && item.Discounts.Count > 0)
            {
                foreach (var discount in item.Discounts)
                {
                    discountValue += discount.Value;
                }
            }

            return item.Price - discountValue * item.Price / 100;
        }

    }
}
