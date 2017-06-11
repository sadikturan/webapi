using StoreApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Entity;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class EfOrderRepository : IOrderRepository
    {
        StoreContext db = new StoreContext();

        public IEnumerable<Order> Orders
        {
            get { return db.Orders; }
        }

        public async Task<Order> DeleteOrderAsync(int id)
        {
            Order entity = db.Orders.Find(id);

            if (entity != null)
            {
                db.Orders.Remove(entity);
            }

            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<int> SaveOrderAsync(Order entity)
        {
            if (entity.Id == 0)
            {
                db.Orders.Add(entity);
            }
            else
            {
                Order entityToUpdate = db.Orders.Find(entity.Id);

                if (entityToUpdate != null)
                {
                    entityToUpdate.UserName = entity.UserName;
                    entityToUpdate.TotalPrice = entity.TotalPrice;
                }
            }
            return await db.SaveChangesAsync();
        }
    }
}
