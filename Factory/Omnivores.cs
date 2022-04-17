using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Omnivores : DietBase
    {

        public Omnivores()
        {
            DietName = "Omnivores";
            MenuItems = new List<string> { "Salad", "Tofu", "Water", "Fruit", "Nuts", "Cheese", "Milk", "Egg", "Fish", "Chicken", "Steak", "Shrimp" };
        }
    }
}
