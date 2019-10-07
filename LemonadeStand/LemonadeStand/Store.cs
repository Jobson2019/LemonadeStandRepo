using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   


    class Store
    {
        //member variable
        Player player;
        Weather weather;
        //constructor

        public Store(Player player, Weather weather)
        {
            this.player = player;
            this.weather = weather;
        }
        
        

        //member methods

        public bool BuyMenu(int today, double money)
        { 
           UserInterface.DisplayRules();
           UserInterface.DisplayInventory(player.inventory);
            Console.WriteLine("Purchase Ingredients", "Show Rules", "Start Game?", "Start Over");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Purchase Ingredients":
                    Purchasing(money);
                    break;
                case "Show Rules":
                    break;
                case "Start Game?":
                    break;
                    default "Start Over":
                    break;
            }

        }   
    }
}
