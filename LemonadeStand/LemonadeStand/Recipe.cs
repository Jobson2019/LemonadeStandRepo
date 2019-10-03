using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables
        public int amountLemons;
        public int amountSugarCubes;
        public int amountIceCubes;
        public double priceCup;

        //constructor

        public Recipe()
        {
            amountLemons = 8;
            amountSugarCubes = 4;
            amountIceCubes = 5;
            priceCup = 0.50;
        }


        //methods

        //public void ChooseRecipe(Inventory inventory, Weather weather)
       // {
        //    UserInterface.DisplayInventory(inventory);
          //  UserInterface.DisplayWeather(weather);

       // }

        //work on being able to augment recipe
    }
}
