using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrackSimulator
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            if (MyBet == null)
            {
                MyLabel.Text = Name + " hasn't placed a bet.";
            }
        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (BetAmount <= Cash)
            {
                MyBet = new Bet()
                {
                    Amount = BetAmount,
                    Dog = DogToWin,
                    Bettor = this
                };
                return true;
            }
            return false;
        }

        public void Collect(int Winner)
        {
            if (MyBet != null)
            {
                Cash += MyBet.PayOut(Winner);
            }
            ClearBet();
        }
    }
}
