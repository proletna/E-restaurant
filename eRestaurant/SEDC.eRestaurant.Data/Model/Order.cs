using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.eRestaurant.Data.Model
{
    class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderCreated { get; set; }
        public string OrderComment { get; set; }
        public int OrderTableNumber { get; set; }
        public double OrderTotalPrice {get; }
        public int OrderTotalQuantity { get; }
        public OrderStatus Status { get; set; }

    }
}
