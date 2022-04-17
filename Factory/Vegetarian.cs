using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Vegetarian : DietBase
    {
        public Vegetarian()
        {
            DietName = "Vegetarian";
            MenuItems = new List<string> { "Salad", "Tofu", "Water", "Fruit", "Nuts", "Cheese", "Milk", "Egg" };
        }
    }
}
