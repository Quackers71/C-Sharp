using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrackSimulator
{
    public partial class Form1 : Form
    {
        public Greyhound[] GreyhoundArray = new Greyhound[4];
        public Guy[] GuyArray = new Guy[3];
        public Random MyRandomizer;

        public Form1()
        {
            InitializeComponent();

            // Initialising Dogs

            GreyhoundArray[0] = new Greyhound()
            {
                racetrackPictureBox = dog1,
                StartingPosition = dog1.Left,
                RacetrackLength = racetrackPictureBox.Width - dog1.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                racetrackPictureBox = dog2,
                StartingPosition = dog2.Left,
                RacetrackLength = racetrackPictureBox.Width - dog2.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                racetrackPictureBox = dog3,
                StartingPosition = dog3.Left,
                RacetrackLength = racetrackPictureBox.Width - dog3.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                racetrackPictureBox = dog4,
                StartingPosition = dog4.Left,
                RacetrackLength = racetrackPictureBox.Width - dog4.Width,
                Randomizer = MyRandomizer
            };

            // Initialising Guys

            // TBC


        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}