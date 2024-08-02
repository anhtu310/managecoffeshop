using ManageCoffee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffee.Repository
{
    public class OrderDetailRepository
    {
        private readonly ManagementDBContext _context;

        public OrderDetailRepository(ManagementDBContext context)
        {
            _context = context;
        }

        public List<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }

        public OrderDetail GetById(int id)
        {
            return _context.OrderDetails.Find(id);
        }

        public void Add(OrderDetail order)
        {
            _context.OrderDetails.Add(order);
            _context.SaveChanges();
        }

        public void Update(OrderDetail order)
        {
            _context.OrderDetails.Update(order);
            _context.SaveChanges();
        }

        public void DeleteAsync(int id)
        {
            var order = _context.OrderDetails.Find(id);
            if (order != null)
            {
                _context.OrderDetails.Remove(order);
                _context.SaveChanges();
            }
        }

    }
}
