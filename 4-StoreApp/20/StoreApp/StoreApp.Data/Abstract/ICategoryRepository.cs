using StoreApp.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreApp.Data.Abstract
{
    public interface ICategoryRepository
    {
        //
        IEnumerable<Category> Categories { get; }
        Task<int> SaveCategoryAsync(Category entity);
        Task<Category> DeleteCategoryAsync(int id);
    }
}
