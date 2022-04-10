namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        long bank = 100;
        long cdcFund = 100000000000;


        public Form1()
        {
            InitializeComponent();

            bob = new Guy() { Name = "bob", Cash = 100 };
            joe = new Guy() { Name = "joe", Cash = 50 };

            UpdateForm();
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            } else
            {
                MessageBox.Show("The Bank is out of Money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(10));
            UpdateForm();
        }

        private void joeGivesToBank_Click(object sender, EventArgs e)
        {
            bank += joe.GiveCash(10);
            UpdateForm();
        }

        private void bobGivesToBank_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(10);
            UpdateForm();
        }

        private void hyperInflation_Click(object sender, EventArgs e)
        {
            bank += cdcFund;
            UpdateForm();
        }
    }
}