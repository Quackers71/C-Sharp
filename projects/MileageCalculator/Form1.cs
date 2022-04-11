namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        int startingMileage = 1;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        public void castUpDownValues()
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            castUpDownValues();

            if (startingMileage >= endingMileage)
            {
                string title = "Cannot Calculate Mileage";
                MessageBox.Show("The starting mileage must be less than the ending mileage!", title);
                label4.Text = "$0";
                label6.Text = "0";
            }
            else
            {

                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = String.Format("${0:N2}", amountOwed);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            castUpDownValues();

            if (startingMileage >= endingMileage)
            {
                label4.Text = "$0";
                label6.Text = "0";
            }
            else
            {
                milesTraveled = endingMileage - startingMileage;
                label6.Text = String.Format("{0:N2}", milesTraveled.ToString());
            }
        }
    }
}