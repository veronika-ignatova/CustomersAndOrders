using CustomersAndOrders.OrderFolder.OrderInterface;
using DataBase;

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
            return _repository.GetOrderById(id);
        }
        public IOrder GetOrderWithItemsById(int id)
        {
            return _repository.GetOrderWithItemsById(id);
        }
        //public void SetDiscount(IOrder order)
        //{

        //}

        
    }
}
