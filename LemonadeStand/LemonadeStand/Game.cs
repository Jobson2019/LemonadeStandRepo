using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // member variables
        Player player;
        List<Day> days;
        int currentDay;
        public List<string> dayNames;

        // constructor
        public Game()
        {
            currentDay = 0;
            dayNames = new List<string>()
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
        }

        public void RunGame()
        {
            UserInterface.DisplayRules();

            while (currentDay < 7)
            {
                UserInterface.DisplayWeekDay(dayNames[currentDay]);

                currentDay++;
            }
            
        }

        public void StartDay()
        {
            player.pitcher.RefillPitcher();
            Customer customer = new Customer();
            for (int i = 0; i < customer.customerNames.Count; i++)
            {
                if (player.pitcher.CupsLeft() == 0)
                {
                    Console.WriteLine("You're out of Lemonade");
                    break;
                    
                }
                
            }
           
        }

        

       

        public void SetupDays()
        {
            int numberOfDays = 7;
            for (int i = 0; i < numberOfDays; i++)
            {
                days.Add(new Day(dayNames[i]));
            }
        }
        public void RunDays()
        {
            for (int i = 0; i < days.Count; i++)
            {
                days[i].RunDay();
            }
        }

        //member methods
    }
}
