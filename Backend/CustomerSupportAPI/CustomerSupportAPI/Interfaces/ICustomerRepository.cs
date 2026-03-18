using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();

        Customer GetCustomerById(int id);

        void AddCustomer(Customer customer);
    }
}