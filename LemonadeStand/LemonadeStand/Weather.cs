using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //variables
        public string condition;
        public int temperature;
        private List <string> weatherConditions;
        public string forecast;
        public string predictedForecast;
        public List <int> weekForeCast;
        public List <int> weekTemperatures;
    
        static Random rng = new Random(DateTime.Now.Millisecond);
        public Weather()
        {
            weatherConditions = new List<string>() { "Terrible", "Pretty Bad", "Awful", "Stay Inside", "Overcast", "THUNDAH, AAAAAAAAAAAAAAAAAAAAAAAAAAAAH", "Monsoon" };
            weekForeCast = new List<int>();
            weekTemperatures = new List<int>();
        }
        // methods
        public string DailyForecast(int currentDay)
        {
            return weatherConditions[weekForeCast[currentDay]];
        }
        public int DailyTemperature(int currentDay)
        {
            return weekTemperatures[currentDay];
        }
        public void CreateTemperature()
        {
            for (int i = 0; i < 7; i++)
            {
                int temp = rng.Next(40, 100);
                weekTemperatures.Add(temp);
            }
        }
        public void CreateWeather()
        {
            for (int i = 0; i < 7; i++)
            {
                int weatherValue = rng.Next(1, 10); // scale down

                if (weatherValue <= 1)
                {
                    weekForeCast.Add(1);
                }
                if (weatherValue <= 3 && weatherValue > 2)
                {
                    weekForeCast.Add(2);
                }
                if (weatherValue <= 4 && weatherValue > 3)
                {
                    weekForeCast.Add(3);
                }
                if (weatherValue <= 5  && weatherValue > 4)
                {
                    weekForeCast.Add(4);
                }
                if (weatherValue < 8 && weatherValue > )
                {
                    weekForeCast.Add(5);
                }
                if (weatherValue < 98 && weatherValue > 94)
                {
                    weekForeCast.Add(6);
                }
                if (weatherValue < 100 && weatherValue > 97)
                {
                    weekForeCast.Add(7);
                }
            }
        }
    }

    //constructor

    //methods
}

