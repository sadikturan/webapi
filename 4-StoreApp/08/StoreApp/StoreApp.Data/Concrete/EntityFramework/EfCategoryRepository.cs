using StoreApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Entity;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        StoreContext db = new StoreContext();

        public IEnumerable<Category> Categories
        {
            get { return db.Categories; }
        }

        public async Task<Category> DeleteCategoryAsync(int id)
        {
            Category entity = db.Categories.Find(id);

            if (entity != null)
            {
                db.Categories.Remove(entity);
            }

            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<int> SaveCategoryAsync(Category entity)
        {
            if (entity.Id == 0)
            {
                db.Categories.Add(entity);
            }
            else
            {
                Category entityToUpdate = db.Categories.Find(entity.Id);

                if (entityToUpdate != null)
                {
                    entityToUpdate.Name = entity.Name;
                }
            }
            return await db.SaveChangesAsync();
        }
    }
}
