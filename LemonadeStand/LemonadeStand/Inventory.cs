using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //variables
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;


        //constructor
        public Inventory()
        {
            lemons = new List<Lemon>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
            sugarCubes = new List<SugarCube>();
        }
        //methods
        public void DisplayInventory()
        {
            Console.WriteLine("You have " + lemons.Count + " Lemons");
            Console.WriteLine("You have " + iceCubes.Count + " Ice Cubes");
            Console.WriteLine("You have " + cups.Count + " Cups");
            Console.WriteLine("You have " + sugarCubes + " Sugar Cubes");

        }
    }
}
