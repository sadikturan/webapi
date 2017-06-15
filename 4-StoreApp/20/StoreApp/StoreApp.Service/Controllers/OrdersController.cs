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
    public class OrdersController : ApiController
    {
        IOrderRepository _orderRepository;

        public OrdersController()
        {
            _orderRepository = new EfOrderRepository();
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orderRepository.Orders;
        }

        public Order GetOrder(int id)
        {
            return _orderRepository.Orders.Where(i => i.Id == id).FirstOrDefault();
        }

        public async Task PostOrder(Order entity)
        {
            await _orderRepository.SaveOrderAsync(entity);
        }
        public async Task DeleteOrder(int id)
        {
            await _orderRepository.DeleteOrderAsync(id);
        }
    }
}
