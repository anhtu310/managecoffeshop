using ManageCoffee.Models;
using ManageCoffee.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffee.Services
{
    public class ProductService
    {
        private ProductRepository repository;
        public ProductService() {
            ManagementDBContext managementDBContext = new ManagementDBContext();
            repository = new ProductRepository(managementDBContext);
        }

        public  List<Product> GetAll()
        {
            return repository.GetAll();
        }
        public List<Product> GetByTitle(string name)
        {
            return repository.GetByName(name);
        }
        public List<Product> GetByIdCategory(int id)
        {
            return repository.GetByCategoryId(id);
        }

        public  Product GetById(int id)
        {
            return repository.GetById(id);
        }

        public void  Add(Product product)
        {
            repository.Add(product);
        }

        public void Update(Product product)
        {
             repository.Update(product);
        }

        public void  DeleteProductAsync(int id)
        {
            repository.DeleteAsync(id);
        }
    }
}
