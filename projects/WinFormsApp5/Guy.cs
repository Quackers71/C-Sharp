using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    class Guy
    {
        public string Name = "";
        public long Cash;

        public long GiveCash(long amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            } else
            {
                MessageBox.Show("I don't have enough cash to give you " + amount, Name + " says...");
                return 0;
            }
        }

        public long ReceiveCash(long amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            } else
            {
                MessageBox.Show(amount + " isn't an amount I'll take ", Name + " says...");
                return 0;
            }
        }
    }
}
