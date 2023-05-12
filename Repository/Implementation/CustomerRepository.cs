using Domain.Entites;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private Context _dbContex;
        public CustomerRepository(Context dbContext)
        {
            _dbContex = dbContext;
        }
        public int Add(Customer c)
        {
            var newCustomer = _dbContex.Customers.Add(c);
            _dbContex.SaveChanges();
            return newCustomer.Entity.Id;
        }

        public void DeleteCustomerById(int id)
        {
            Customer c = GetCustomerById(id);
            if(c!=null)
            {
                _dbContex.Customers.Remove(c);
                _dbContex.SaveChanges();
            }
            
        }

        public void Edit(Customer c)
        {
            _dbContex.Customers.Update(c);
            _dbContex.SaveChanges();
        }

        public Customer? GetCustomerById(int id)
        {
            return _dbContex.Customers.Where(x=>x.Id == id).FirstOrDefault();
        }

        public Customer GetCustomerByName(string name)
        {
            return _dbContex.Customers.Where(x => x.Name == name).FirstOrDefault();
        }

        public List<Customer> GetListOfCustomer()
        {
            return _dbContex.Customers.ToList();

        }
    }
}
