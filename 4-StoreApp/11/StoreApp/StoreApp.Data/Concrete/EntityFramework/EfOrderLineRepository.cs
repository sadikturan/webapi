using StoreApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Entity;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class EfOrderLineRepository : IOrderLineRepository
    {
        StoreContext db = new StoreContext();

        public IEnumerable<OrderLine> OrderLines
        {
            get { return db.OrderLines; }
        }

        public async Task<OrderLine> DeleteOrderLineAsync(int id)
        {
            OrderLine entity = db.OrderLines.Find(id);

            if (entity != null)
            {
                db.OrderLines.Remove(entity);
            }

            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<int> SaveOrderLineAsync(OrderLine entity)
        {
            if (entity.Id == 0)
            {
                db.OrderLines.Add(entity);
            }
            else
            {
                OrderLine entityToUpdate = db.OrderLines.Find(entity.Id);

                if (entityToUpdate != null)
                {
                    entityToUpdate.OrderId = entity.OrderId;
                    entityToUpdate.ProductId = entity.ProductId;                  
                }
            }
            return await db.SaveChangesAsync();
        }
    }
}
