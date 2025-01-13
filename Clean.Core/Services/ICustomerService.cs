using ArchitectsOffice.Entities;
using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetItem(int id);
        void Post(Customer customer);
        int PutByCustomer(int id, Customer customer);
        int PutByStatus(int id, int status);
    }
}
