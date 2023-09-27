using Core.Interfaces;

namespace Service
{
    public class CustomerService
    {
        protected IRepository _repository;
        public CustomerService(IRepository repository) 
        {
            _repository = repository;
        }
        public ICustomer GetCustomerWithOrderById(int id)
        {
            return _repository.GetCustomerWithOrderById(id);
        }
        public ICustomer GetCustomerByOrderId(int id)
        {
            return _repository.GetCustomerByOrderId(id);
        }

    }
}