using Practica6_DI.Classes;



namespace Practica6_DI.Interface
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);
    }
}
