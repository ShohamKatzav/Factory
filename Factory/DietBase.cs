using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class DietBase
    {
        protected string? DietName;
        protected List<string>? MenuItems;
        public void GetMenu()
        {
            Console.WriteLine($"{DietName}:");
            foreach (var item in MenuItems)
                Console.WriteLine($"* {item}");
        }
    }
}
