using Core.Interfaces;

namespace Core.Interfaces
{
    public interface IRepository
    {
        List<IDiscount> GetAllDiscount();
        ICustomer GetCustomerByOrderId(int id);
        ICustomer GetCustomerWithOrderById(int id);
        IOrder GetOrderById(int id);
    }
}