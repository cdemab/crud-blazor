using CrudBlazor.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudBlazor.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> Get();
        Task<Customer> Get(int id);
        Task<Customer> Add(Customer customer);
        Task<Customer> Update(Customer customer);
        Task<Customer> Delete(int id);
    }
}
