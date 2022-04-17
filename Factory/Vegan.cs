using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Vegan : DietBase
    {
        public Vegan()
        {
            DietName = "Vegan";
            MenuItems = new List<string> { "Salad", "Tofu", "Water", "Fruit", "Nuts" };
        }

    }
}
