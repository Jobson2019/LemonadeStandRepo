using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        // all methods public static void
        
        

        // member variables





        //member methods

        public static void DisplayRules()
        {

            Console.WriteLine(" Filler Display Rules ");
            Console.ReadLine();

        }

        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("Filler Display Inventory");
            Console.ReadLine();

        }

        public static void DisplayWeather(Weather weather)
        {
            Console.WriteLine("Filler Display Weather");
            Console.ReadLine();
        }

        public static void DisplayRecipe(int numberSugarCubes, int numberLemons, int numberIceCubes)
        {
            Console.WriteLine("Sugar Cubes " + numberSugarCubes);
            Console.WriteLine("Lemons " + numberLemons);
            Console.WriteLine("Ice Cubes " + numberIceCubes);
        }




    }
}
