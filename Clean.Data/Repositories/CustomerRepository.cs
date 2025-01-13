using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Customer> GetList()
        {
            return _context.Customers.ToList();
        }
        public Customer GetItem(int id)
        {
            Customer customer = _context.Customers.ToList().Find(u => u.Id == id);
            return customer;
        }
        public void Post(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

        }
        public int PutByCustomer(int id, Customer customer)
        {
            for (int i = 0; i < _context.Customers.ToList().Count; i++)
            {
                if (_context.Customers.ToList()[i].Id == id)
                {
                    _context.Customers.ToList().RemoveAt(i);
                    _context.Customers.ToList().Insert(i, customer);
                    _context.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }
        public int PutByStatus(int id, int status)
        {
            for (int i = 0; i < _context.Customers.ToList().Count; i++)
            {
                if (_context.Customers.ToList()[i].Id == id)
                {
                    _context.Customers.ToList()[i].Status = status;
                    _context.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }
    }
}

