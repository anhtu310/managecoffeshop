using ManageCoffee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffee.Repository
{
    public class ProductRepository
    {
        private readonly ManagementDBContext _context;

        public ProductRepository(ManagementDBContext context)
        {
            _context = context;
        }

        public  List<Product> GetAll()
        {
            return  _context.Products.ToList();
        }
        public List<Product> GetByName(string title)
        {
            // Assuming _context is your DbContext and Products is a DbSet<Product>
            return _context.Products
                            .Where(p => p.Title.Contains(title))
                            .ToList();
        }
        public List<Product> GetByCategoryId(int id_cat)
        {
            // Assuming _context is your DbContext and Products is a DbSet<Product>
            return _context.Products
                           .Where(p => p.IdCat == id_cat)
                           .ToList();
        }
        public Product GetById(int id)
        {
            return  _context.Products.Find(id);
        }

        public  void Add(Product product)
        {
             _context.Products.Add(product);
             _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
             _context.SaveChanges();
        }

        public void DeleteAsync(int id)
        {
            var product =  _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                 _context.SaveChanges();
            }
        }

    }
}
