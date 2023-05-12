using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface ICustomerRepository
    {
        public List<Customer> GetListOfCustomer();
        public Customer GetCustomerById(int id);
        public Customer GetCustomerByName(string name);
        public void DeleteCustomerById(int id);
        public int Add(Customer c);
        public void Edit(Customer c);
    }
}
