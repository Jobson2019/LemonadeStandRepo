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
            "Randy", "Big Dirty Dave", "Jack", "Beta-Male Eric", "Marky Mark", "Ice T", "Racist Dan", "Tom Sellick's Moustache", "Nazi Jake", "Pedo-stache Jake", "Jake Three", 
            "Amish Gabe", "Alex 'The ToothPick' Hardy", "Dippin Danny", "T-Dawg", "Adam 'The Defector' Newman", "Annie QuietSides", "Fish-Eye Larry", "Dave 'SpeakEasy' Willy", "Big Nate",
            "Chief Runs With Pony-Tail", "Randy?", "Caucasian Buddha", "White Boy Steve", "Hispanic Buddha"  
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

            //"Terrible", "Pretty Bad", "Awful", "Weak", "Overcast", "Ok", "Nice"
            // weather switch all except 0 to else if statments

            if (weather.condition == "Terrible")
            { 
                weatherMultiplier = 0.4;
            }
            else if (weather.condition == "Pretty Bad")
            {
                weatherMultiplier = 0.6;
            }
            else if (weather.condition == "Awful")
            {
                weatherMultiplier = 0.8;
            }
            else if (weather.condition == "Weak")
            {
                weatherMultiplier = 1.0;
            }
            else if (weather.condition == "Overcast")
            {
                weatherMultiplier = 1.1;
            }
            else if (weather.condition == "Ok")
            {
                weatherMultiplier = 1.2;
            }
            else if (weather.condition == "Nice")
            {
                weatherMultiplier = 1.3;
            }
            else if (weather.condition == "Beautiful")
            {
                weatherMultiplier = 1.4;
            }



            if (weather.temperature >= 40 && weather.temperature < 50 )
            {
                tempMultiplier = 0.4;
            }
            else if (weather.temperature >= 51 && weather.temperature <  60)
            {
                tempMultiplier = 0.6;
            }
            else if (weather.temperature >= 61 && weather.temperature < 70)
            {
                tempMultiplier = 0.8;
            }
            else if (weather.temperature >= 71 && weather.temperature < 80)
            {
                tempMultiplier = 1.0;
            }
            else if (weather.temperature >= 81 && weather.temperature < 90)
            {
                tempMultiplier = 1.1;
            }
            else if (weather.temperature >=91 && weather.temperature < 93)
            {
                tempMultiplier = 1.2;
            }
            else if (weather.temperature >= 94 && weather.temperature < 96)
            {
                tempMultiplier = 1.3;
            }
            else if (weather.temperature >= 97 && weather.temperature < 98)
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
