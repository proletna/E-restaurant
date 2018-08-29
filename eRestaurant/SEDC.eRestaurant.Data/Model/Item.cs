using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.eRestaurant.Data.Model
{
    class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public string ItemContents { get; set; }
        public string ItemDescription { get; set; }
        public bool ItemAvailability { get; set; }
    }
}
