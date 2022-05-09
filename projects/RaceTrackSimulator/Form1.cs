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

        Random MyRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            // Initialising Dogs

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = dog1,
                StartingPosition = dog1.Left,
                RacetrackLength = racetrackPictureBox.Width - dog1.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = dog2,
                StartingPosition = dog2.Left,
                RacetrackLength = racetrackPictureBox.Width - dog2.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = dog3,
                StartingPosition = dog3.Left,
                RacetrackLength = racetrackPictureBox.Width - dog3.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = dog4,
                StartingPosition = dog4.Left,
                RacetrackLength = racetrackPictureBox.Width - dog4.Width,
                Randomizer = MyRandomizer
            };

            // Initialising Guys

            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                MyBet = null,
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };

            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                MyBet = null,
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };

            GuyArray[2] = new Guy()
            {
                Name = "Al",
                MyBet = null,
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

            for (int i = 0; i < 3; i++)
            {
                GuyArray[i].UpdateLabels();
            }

        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSelection.Text = GuyArray[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSelection.Text = GuyArray[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentSelection.Text = GuyArray[2].Name;
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            bettingPanel.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("The Winner is GreyHound #" + ++i + ".");
                    for (int x = 0; x < 4; x++)
                    {
                        GreyhoundArray[x].TakeStartingPosition();
                    }
                    for (int y = 0; y < 3; y++)
                    {
                        GuyArray[y].Collect(i);
                        bettingPanel.Enabled = true;
                        GuyArray[y].UpdateLabels();
                    }
                }
            }
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            int BetAmount = (int)numericUpDown1.Value;
            int DogNumber = (int)numericUpDown2.Value;

            if (joeRadioButton.Checked)
            {
                if (GuyArray[0].PlaceBet(BetAmount, DogNumber))
                {
                    joeBetLabel.Text = GuyArray[0].MyBet.GetDescription();
                }
                else
                {
                    MessageBox.Show(GuyArray[0].Name + " doesn't have enough money!");
                }
            }
            else if (bobRadioButton.Checked)
            {
                if (GuyArray[1].PlaceBet(BetAmount, DogNumber))
                {
                    bobBetLabel.Text = GuyArray[1].MyBet.GetDescription();
                }
                else
                {
                    MessageBox.Show(GuyArray[1].Name + " doesn't have enough money!");
                }
            }
            else if (alRadioButton.Checked)
            {
                if (GuyArray[2].PlaceBet(BetAmount, DogNumber))
                {
                    alBetLabel.Text = GuyArray[2].MyBet.GetDescription();
                }
                else
                {
                    MessageBox.Show(GuyArray[2].Name + " doesn't have enough money!");
                }
            }
        }
    }
}