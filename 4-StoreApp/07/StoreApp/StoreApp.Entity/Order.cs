using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entity
{
   public class Order
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }

        public List<OrderLine> Orderlines { get; set; }

    }
}
