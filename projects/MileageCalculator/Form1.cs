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

        public void resetLabels()
        {
            label4.Text = "$0";
            label6.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            castUpDownValues();

            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = String.Format("${0:N2}", amountOwed);
            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage!", "Cannot Calculate Mileage");
                resetLabels();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            castUpDownValues();

            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                label6.Text = String.Format("{0:N2}", milesTraveled.ToString());
            }
            else
            {
                resetLabels();
            }
        }
    }
}