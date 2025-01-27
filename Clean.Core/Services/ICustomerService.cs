using ArchitectsOffice.Entities;
using Clean.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.Core.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetItemAsync(int id);
        Task PostAsync(Customer customer);
        Task<int> PutByCustomerAsync(int id, Customer customer);
        Task<int> PutByStatusAsync(int id, int status);
    }
}
