using CustomerSupportAPI.Interfaces;
using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _repository.GetAllCustomers();
        }

        public void CreateCustomer(Customer customer)
        {
            _repository.AddCustomer(customer);
        }
    }
}