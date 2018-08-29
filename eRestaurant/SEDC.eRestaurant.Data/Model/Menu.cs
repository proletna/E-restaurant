using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.eRestaurant.Data.Model
{
    class Menu
    {
        public int MenuId { get; set;}
        public enum MenuType { Meals, Drinks, Wines }
        public string RestaurantName { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}
