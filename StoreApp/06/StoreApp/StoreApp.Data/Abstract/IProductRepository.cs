using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        Task<int> SaveProductAsync(Product entity);
        Task<Product> DeleteProductAsync(int id);

    }
}
