using Practica6_DI.Classes;
using Practica6_DI.Interface;

namespace Practica6_DI.Services
{
    public class CustomerService
    {
      
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomer(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public void CreateCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }

    }
}
