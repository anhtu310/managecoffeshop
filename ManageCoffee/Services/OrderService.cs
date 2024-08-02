using ManageCoffee.Models;
using ManageCoffee.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffee.Services
{
    public class OrderService
    {
        private OrderRepository repository;
        public OrderService()
        {
            ManagementDBContext managementDBContext = new ManagementDBContext();
            repository = new OrderRepository(managementDBContext);
        }

        public List<Order> GetAll()
        {
            return repository.GetAll();
        }

        public Order GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Add(Order order)
        {
            repository.Add(order);
        }

        public void Update(Order order)
        {
            repository.Update(order);
        }

        public void DeleteProductAsync(int id)
        {
            repository.DeleteAsync(id);
        }
    }
}
