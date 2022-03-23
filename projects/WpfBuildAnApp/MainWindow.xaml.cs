using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBuildAnApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "WoJake";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "His name is " + name
                + "\nx is " + x
                + "\nd is " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                myLabel.Text = "x must be 10";
            }
            else
            {
                myLabel.Text = "x isn't 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Bobby Jr.";
            if ((someValue == 3) && (name == "Joe"))
            {
                myLabel.Text = "x = 3 and his name is Joe";
            }
            myLabel.Text = "This line runs no matter what!";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count += 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count -= 1;
            }
            myLabel.Text = "The answer is " + count;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            string result = "";
            int x = 3;
            while (x > 0)
            {
                if (x > 2)
                {
                    result += "a";
                }

                x -= 1;
                result += "-";

                if (x == 2)
                {
                    result += "b c";
                }
                if (x == 1)
                {
                    result += "d";
                    x -= 1;
                }
            }

            myLabel.Text = result;
            //myLabel.Text = String.Empty;
        }
    }
}
