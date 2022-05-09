using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrackSimulator
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random? Randomizer;

        public bool Run()
        {
            Location += Randomizer.Next(1, 4);
            MyPictureBox.Left = StartingPosition + Location;

            if (MyPictureBox.Left >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = 15;
        }
    }
}
