using Bussiness.Abstraction;
using Domain.Entites;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Bussiness.Implementation
{
    public class CartService : ICartService
    {
        private ICartRepository _CartRepository;
        public CartService(ICartRepository CartRepository)
        {
            _CartRepository = CartRepository;
        }
        public void Add(Cart c)
        {
            _CartRepository.Add(c);
        }

        public Cart? GetCartById(int id)
        {
            return _CartRepository.GetCartById(id);
        }

 
    }
}
