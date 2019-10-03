using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        static Random random = new Random(DateTime.Now.Millisecond);
        public double tempMultiplier;
        public double weatherMultiplier;

        // create demand method
        public bool BuyChance(int weather, int temp)
        {
        

            if (weather == 0)
            { 
                weatherMultiplier = 0.4;
            }
            if (weather == 1)
            {
                weatherMultiplier = 0.6;
            }
            if (weather == 2)
            {
                weatherMultiplier = 0.8;
            }
            if (weather == 3)
            {
                weatherMultiplier = 1.0;
            }
            if (weather == 4)
            {
                weatherMultiplier = 1.1;
            }
            if (weather == 5)
            {
                weatherMultiplier = 1.2;
            }
            if (weather == 6)
            {
                weatherMultiplier = 1.3;
            }
            if (weather == 7)
            {
                weatherMultiplier = 1.4;
            }
            if (temp == 0)
            {
                tempMultiplier = 0.4;
            }
            if (temp == 1)
            {
                tempMultiplier = 0.6;
            }
            if (temp == 2)
            {
                tempMultiplier = 0.8;
            }
            if (temp == 3)
            {
                tempMultiplier = 1.0;
            }
            if (temp == 4)
            {
                tempMultiplier = 1.1;
            }
            if (temp == 5)
            {
                tempMultiplier = 1.2;
            }
            if (temp == 6)
            {
                tempMultiplier = 1.3;
            }
            if (temp == 7)
            {
                tempMultiplier = 1.4;
            }

            double chanceToBuy = random.Next(1, 100);
            double buyMod = (tempMultiplier * weatherMultiplier * chanceToBuy);
            if (buyMod >= 50)
            
            {
                return true; 


            }
            else
            {
                return false;
            }



        }

        



        // create multiplier based on cost, weather and temp



       
    }
}
