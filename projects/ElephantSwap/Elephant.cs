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
    }
}
