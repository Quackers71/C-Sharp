using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrackSimulator
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            return Bettor.Name + " Bets " + Amount + " on Dog #" + Dog;
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
