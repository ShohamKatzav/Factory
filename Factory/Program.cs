
namespace Factory
{
    class Program
    {
        static void Main()
        {
            DietFactory dr = new DietFactory();
            DietBase newDiet;
            while (true)
            {
                Console.WriteLine("Please Enter diet name (ve/vg/om): (Or q to quit)");
                string diet = Console.ReadLine().ToLower().Trim();
                if (diet == "q")
                    break;
                newDiet = dr.GetDiet(diet);
                if (newDiet != null)
                    newDiet.GetMenu();
            }
        }
    }
}
