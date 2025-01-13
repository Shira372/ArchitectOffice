using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Core.Services;
using Clean.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public List<Customer> GetAll()
        {
            return _customerRepository.GetList();
        }

        public Customer GetItem(int id)
        {
            return _customerRepository.GetItem(id);
        }

        public void Post(Customer customer)
        {
            _customerRepository.Post(customer);
        }

        public int PutByCustomer(int id, Customer customer)
        {
            return _customerRepository.PutByCustomer(id, customer);
        }

        public int PutByStatus(int id, int status)
        {
            return _customerRepository.PutByStatus(id, status);
        }
    }
}
