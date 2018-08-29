using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.eRestaurant.Data.Model
{
    class OrderItem
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int ItemQuantity { get; set; }
    }
}
