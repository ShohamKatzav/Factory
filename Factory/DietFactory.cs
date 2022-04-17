using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class DietFactory
    {
        public DietBase GetDiet(string dietName)
        {
            switch (dietName)
            {
                case "ve":
                case "vegan":
                    return new Vegan();
                case "vg":
                case "vegerarian":
                    return new Vegetarian();
                case "om":
                case "omnivores":
                    return new Omnivores();
                default:
                    Console.WriteLine("Sorry, invalid input, please try again.");
                    break;
            }
            return null;
        }
    }
}
