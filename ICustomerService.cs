using FinalProject.Models;

namespace FinalProject.Service
{
    public interface ICustomerService
    {
        public List<Customer> GetAll();
        public Customer GetById(long id);
        public Customer Create(Customer customer);
        public Customer Update(Customer customer);
        public bool Delete(Customer customer);
    }
}
