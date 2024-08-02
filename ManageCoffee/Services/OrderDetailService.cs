using ManageCoffee.Models;
using ManageCoffee.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffee.Services
{
    public class OrderDetailService
    {
        private OrderDetailRepository repository;
        public OrderDetailService()
        {
            ManagementDBContext managementDBContext = new ManagementDBContext();
            repository = new OrderDetailRepository(managementDBContext);
        }

        public List<OrderDetail> GetAll()
        {
            return repository.GetAll();
        }

        public OrderDetail GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Add(OrderDetail order)
        {
            repository.Add(order);
        }

        public void Update(OrderDetail order)
        {
            repository.Update(order);
        }

        public void DeleteProductAsync(int id)
        {
            repository.DeleteAsync(id);
        }
    }
}
