using StoreApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Entity;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class EfProductRepository : IProductRepository
    {

        StoreContext db = new StoreContext();
        public IEnumerable<Product> Products
        {
            get
            {
                return db.Products;
            }
        }

        public async Task<Product> DeleteProductAsync(int id)
        {
            Product entity = db.Products.Find(id);
            if (entity != null)
            {
                db.Products.Remove(entity);
            }
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<int> SaveProductAsync(Product entity)
        {
            if (entity.Id == 0)
            {
                db.Products.Add(entity);
            }
            else
            {
                Product entityToUpdate = db.Products.Find(entity.Id);

                if (entityToUpdate != null)
                {
                    entityToUpdate.Name = entity.Name;
                    entityToUpdate.Price = entity.Price;
                    entity.Description = entity.Description;
                    entity.CategoryId = entity.CategoryId;
                }
            }

            return await db.SaveChangesAsync();
        }
    }
}
