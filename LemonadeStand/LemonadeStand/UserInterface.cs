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
            Console.WriteLine("You have " + inventory.lemons.Count + " Lemons");
            Console.WriteLine("You have " + inventory.iceCubes.Count + " Ice Cubes");
            Console.WriteLine("You have " + inventory.cups.Count + " Cups");
            Console.WriteLine("You have " + inventory.sugarCubes + " Sugar Cubes");

            Console.ReadLine();

        }
        //public string DailyForecast(int currentDay)
        //{
        //    return weatherConditions[weekForeCast[currentDay]];
        //}
        //public int DailyTemperature(int currentDay)
        //{
        //    return weekTemperatures[currentDay];
        //}

        public static void DisplayWeather(Weather weather)
        {
            Console.WriteLine("The Weather is " + weather.condition);
            Console.WriteLine("The Temperature is " + weather.temperature);
            Console.ReadLine();
        }

        public static void DisplayRecipe(int numberSugarCubes, int numberLemons, int numberIceCubes)
        {
            Console.WriteLine("Sugar Cubes " + numberSugarCubes);
            Console.WriteLine("Lemons " + numberLemons);
            Console.WriteLine("Ice Cubes " + numberIceCubes);
        }

        public static void DisplayWeekDay(Game game)
        {
            
            Console.WriteLine("Today is " + game.dayNames);
        }



    }
}
