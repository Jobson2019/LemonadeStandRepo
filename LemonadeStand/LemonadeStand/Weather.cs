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
            weatherConditions = new List<string>() {"Terrible", "Pretty Bad", "Awful", "Weak", "Overcast", "Ok", "Nice", "Beautiful" };
            //weekForeCast = new List<int>();
            weekTemperatures = new List<int>();
            CreateTemperature();
            CreateWeather();
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
           
            
               temperature = random.Next(40, 100);
                
            
        }
        public void CreateWeather()
        {
            for (int i = 0; i < 7; i++)
            {
                int weatherValue = random.Next(1, 100); // scale down

                if (weatherValue < 18)
                {
                    condition = weatherConditions[0];
                }
                else if (weatherValue < 40 && weatherValue > 19)
                {
                    condition = weatherConditions[1];
                }
                else if (weatherValue < 60 && weatherValue > 39)
                {
                    condition = weatherConditions[2];
                }
                else if (weatherValue < 80  && weatherValue > 59)
                {
                    condition = weatherConditions[3];
                }
                else if (weatherValue < 95 && weatherValue > 79)
                {
                    condition = weatherConditions[4];
                }
                else if (weatherValue < 98 && weatherValue > 94)
                {
                    condition = weatherConditions[5];
                }
                else if (weatherValue < 99 && weatherValue > 97)
                {
                    condition = weatherConditions[6];
                }
                else if (weatherValue > 99)
                {
                    condition = weatherConditions[7];
                }
            }
        }
    }

    //constructor

    //methods
}

