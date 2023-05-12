using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstraction
{
    public interface ICustomerService
    {
        public List<Customer> GetListOfCustomer();
        public Customer GetCustomerById(int id);
        public Customer GetCustomerByName(string name);
        public void DeleteCustomerById(int id);
        public void Add(Customer c);
        public void Edit(Customer c);
    }
}
