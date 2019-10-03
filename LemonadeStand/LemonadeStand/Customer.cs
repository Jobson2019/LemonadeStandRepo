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
        public List<string> customerNames;
        public string name;




        public Customer()
        {
            customerNames = new List<string>()
            {
            "Randy", "Big Dirty Dave", "Jack", "Beta-Male Eric", "Marky Mark", "Ice T", "Racist Dan", "Tom Sellick's Moustache", "Nazi Jake", "Pedo stache Jake", "Jake Three"
            };
        }




        //Find out how to pull one of these names
        public void ChooseName()
        {
            int genName = random.Next(0, 11);
            name = customerNames[genName];
        }






        // create demand method
        public bool BuyChance(Weather weather)
        {
         
        
        // weather switch all except 0 to else if statments

            if (weather.condition == "Terrible")
            { 
                weatherMultiplier = 0.4;
            }
            else if (weather.condition == "Pretty Bad")
            {
                weatherMultiplier = 0.6;
            }
            else if (weather == 2)
            {
                weatherMultiplier = 0.8;
            }
            else if (weather == 3)
            {
                weatherMultiplier = 1.0;
            }
            else if (weather == 4)
            {
                weatherMultiplier = 1.1;
            }
            else if (weather == 5)
            {
                weatherMultiplier = 1.2;
            }
            else if (weather == 6)
            {
                weatherMultiplier = 1.3;
            }
            else if (weather == 7)
            {
                weatherMultiplier = 1.4;
            }



            if (temp == 0)
            {
                tempMultiplier = 0.4;
            }
            else if (temp == 1)
            {
                tempMultiplier = 0.6;
            }
            else if (temp == 2)
            {
                tempMultiplier = 0.8;
            }
            else if (temp == 3)
            {
                tempMultiplier = 1.0;
            }
            else if (temp == 4)
            {
                tempMultiplier = 1.1;
            }
            else if (temp == 5)
            {
                tempMultiplier = 1.2;
            }
            else if (temp == 6)
            {
                tempMultiplier = 1.3;
            }
            else if (temp == 7)
            {
                tempMultiplier = 1.4;
            }

            int chanceToBuy = random.Next(1, 100);
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
