using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        //variables
        public int cupsLeftInPitcher;

       
        //constructor
        public Pitcher()
        {
            cupsLeftInPitcher = 0;
        }

        //methods

        

        public void SellCups(int cupsSold)
        {
            cupsLeftInPitcher = cupsLeftInPitcher - cupsSold; 
        }
        public void RefillPitcher()
        {
            cupsLeftInPitcher = 16;
        }
        public int CupsLeft()
        {
            return cupsLeftInPitcher;
        }
        public void EmptyPitcher()
        {
            
        }
    }


        
}
