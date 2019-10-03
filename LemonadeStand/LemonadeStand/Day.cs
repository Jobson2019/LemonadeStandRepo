using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //variables

        public double dailyProfits;
        public Weather dailyWeather;
        public List<Customer> dailyCustomers;
        public string dayName;
        public int weekday;
        
        public Day(string name)
        {
            dayName = name;
            dailyWeather = new Weather();
            dailyCustomers = new List<Customer>();
        }


        public void RunDay()
        {
            
        }

        public void CreateCustomers()
        {
            
            for (int i = 0; i < 26; i++)
            {
                Customer customer = new Customer();
                dailyCustomers.Add(customer);

            }
            for (int i = 0; i < 26; i++)
            {
                dailyCustomers[i].BuyChance(dailyWeather);
            }
        }

    }



    

       
}
