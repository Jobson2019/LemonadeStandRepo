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
    
        static Random random
            = new Random(DateTime.Now.Millisecond);
        public Weather()
        {
            weatherConditions = new List<string>() {"Terrible", "Pretty Bad", "Awful", "Weak", "Overcast", "Ok", "Nice" };
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
                int temp = random.Next(40, 100);
                weekTemperatures.Add(temp);
            }
        }
        public void CreateWeather()
        {
            for (int i = 0; i < 7; i++)
            {
                int weatherValue = random.Next(1, 100); // scale down

                if (weatherValue < 20)
                {
                    weekForeCast.Add(1);
                }
                if (weatherValue < 40 && weatherValue > 19)
                {
                    weekForeCast.Add(2);
                }
                if (weatherValue < 60 && weatherValue > 39)
                {
                    weekForeCast.Add(3);
                }
                if (weatherValue < 80  && weatherValue > 59)
                {
                    weekForeCast.Add(4);
                }
                if (weatherValue < 95 && weatherValue > 79)
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

