﻿using Bussiness.Abstraction;
using Domain.Entites;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Implementation
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddPriceToTotal(Order order)
        {
            //bussiness login
            //1.add order to database
            //2.add price to total price of orders
            order.CustomerId = 1;
            order.Cost = 1;
            order.Description = "asd";
            order.Category = "cat1";
            order.Name = "as";
            _orderRepository.Add(order);
        }

        public int CalculateFee()
        {

            return 100;
        }

        public Order GetOrder(int id)
        {
            return _orderRepository.GetOrderById(id);
        }
        public List<Order> GetOrders()
        {
            return _orderRepository.GetListOfOrders();
        }
    }
}
