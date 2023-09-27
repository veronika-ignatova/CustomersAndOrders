using Core.Enums;
using Core.Interfaces;

namespace Core.Model
{
    public class Customer : UserBase, ICustomer
    {
        public Customer()
        {
            UserType = UserType.Customer;
        }

    }
}