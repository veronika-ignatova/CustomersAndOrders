using Core.Interfaces;

namespace Core.Interfaces
{
    public interface IRepository
    {
        List<IDiscount<int>> GetAllDiscount();
        ICustomer GetCustomerByOrderId(int id);
        ICustomer GetCustomerWithOrderById(int id);
        IOrder GetOrderById(int id);
        IItem GetItemById(int id);
    }
}