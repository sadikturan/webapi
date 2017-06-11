using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete.EntityFramework;
using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace StoreApp.Service.Controllers
{
    public class CategoriesController : ApiController
    {
        ICategoryRepository _categoryRepository;

        public CategoriesController()
        {
            _categoryRepository = new EfCategoryRepository();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.Categories;
        }

        public Category GetCategory(int id)
        {
            return _categoryRepository.Categories.Where(i => i.Id == id).FirstOrDefault();
        }

        public async Task PostCategory(Category entity)
        {
            await _categoryRepository.SaveCategoryAsync(entity);
        }

        public async Task DeleteProduct(int id)
        {
            await _categoryRepository.DeleteCategoryAsync(id);
        }
    }
}
