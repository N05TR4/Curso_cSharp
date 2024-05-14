using Practica6_DI.Classes;
using Practica6_DI.Interface;





namespace Practica6_DI.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerById(int id)
        {
            // Lógica para obtener un cliente por ID
            return new Customer { Id = id, Name = "Jose Alberto" };
        }

        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        
    }
}
