using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Abstract
{
   public interface IOrderLineRepository
    {
        IEnumerable<OrderLine> OrderLines { get; }
        Task<int> SaveOrderLineAsync(OrderLine entity);
        Task<OrderLine> DeleteOrderLineAsync(int id);
    }
}
