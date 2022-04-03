using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for (int count = 0; count < numberOfTimes; count++)
            {
                finalString += thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
