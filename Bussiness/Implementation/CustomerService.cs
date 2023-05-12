using Bussiness.Abstraction;
using Domain.Entites;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Implementation
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;
        private ICartRepository _CartRepository;
        public CustomerService(ICustomerRepository customerRepository, ICartRepository CartRepository)
        {
            _customerRepository = customerRepository;
            _CartRepository = CartRepository;
        }
        public void Add(Customer c)
        {
            //create custoemr & cart 
            int newId = _customerRepository.Add(c);
            Cart newCart = new Cart()
            {
                CustomerId = newId
            };
            _CartRepository.Add(newCart);
        }

        public void DeleteCustomerById(int id)
        {
            _customerRepository.DeleteCustomerById(id);
        }

        public void Edit(Customer c)
        {
            _customerRepository.Edit(c);
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public Customer GetCustomerByName(string name)
        {
            return _customerRepository.GetCustomerByName(name);
        }

        public List<Customer> GetListOfCustomer()
        {
            return _customerRepository.GetListOfCustomer();
        }
    }
}
