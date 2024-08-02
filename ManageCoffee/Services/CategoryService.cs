using ManageCoffee.Models;
using ManageCoffee.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffee.Services
{
    public class CategoryService
    {
        private CategoryRepository repository;
        public CategoryService()
        {
            ManagementDBContext managementDBContext = new ManagementDBContext();
            repository = new CategoryRepository(managementDBContext);
        }

        public List<Category> GetAll()
        {
            return repository.GetAll();
        }
        public List<Category> GetByName(string name)
        {
            return repository.GetByName(name);
        }

        public Category GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Add(Category category)
        {
            repository.Add(category);
        }

        public void Update(Category category)
        {
            repository.Update(category);
        }

        public void DeleteProductAsync(int id)
        {
            repository.DeleteAsync(id);
        }
    }
}
