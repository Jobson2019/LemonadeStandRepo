﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.SetupDays();
            game.RunDays();
            //Game game = new Game();
            //game.RunGame();
            //Console.ReadLine();
            //UserInterface.DisplayRules();
            //Weather.DisplayWeather();

        }
    }
}
