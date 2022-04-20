namespace SloppyJoesSandwiches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            refreshMenu();
        }

        public void refreshMenu()
        {
            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };

            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            label4.Text = menu.GetMenuItem();
            label5.Text = menu.GetMenuItem();
            label6.Text = menu.GetMenuItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshMenu();
        }
    }
}