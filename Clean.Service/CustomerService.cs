using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _customerRepository.GetListAsync();
        }

        public async Task<Customer> GetItemAsync(int id)
        {
            return await _customerRepository.GetItemAsync(id);
        }

        public async Task PostAsync(Customer customer)
        {
            await _customerRepository.PostAsync(customer);
        }

        public async Task<int> PutByCustomerAsync(int id, Customer customer)
        {
            return await _customerRepository.PutByCustomerAsync(id, customer);
        }

        public async Task<int> PutByStatusAsync(int id, int status)
        {
            return await _customerRepository.PutByStatusAsync(id, status);
        }
    }
}
