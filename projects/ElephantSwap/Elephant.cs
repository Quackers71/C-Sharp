using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantSwap
{
    internal class Elephant
    {
        public string Name = "";
        public int EarSize;

         public void WhoAmI()
        {
            MessageBox.Show("My Ears are " + EarSize + " inches tall.", Name + " says...");
        }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message, this.Name);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.TellMe(message, this);
        }
    }
}
