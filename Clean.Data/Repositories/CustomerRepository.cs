using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetListAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetItemAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task PostAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            //await _context.SaveChangesAsync();
        }

        public async Task<int> PutByCustomerAsync(int id, Customer customer)
        {
            var existingCustomer = await _context.Customers.FindAsync(id);
            if (existingCustomer != null)
            {
                _context.Entry(existingCustomer).CurrentValues.SetValues(customer);
                //await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task<int> PutByStatusAsync(int id, int status)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                customer.Status = status;
                //await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
    }
}
