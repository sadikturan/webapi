using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Abstract
{
   public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        Task<int> SaveOrderAsync(Order entity);
        Task<Order> DeleteOrderAsync(int id);
    }
}
