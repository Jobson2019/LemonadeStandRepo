using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        // member variables (Has A)
        private double currentMoney;

        //constructor
        public Wallet()
        {
            currentMoney = 20.00;
        }

        // member methods
        public void UpdateMoney(double MoneyChange)
        {
            currentMoney += MoneyChange;
        }

        public double GetMoney()
        {
            return currentMoney;
        }
    }
}
