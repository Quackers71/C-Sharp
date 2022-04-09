namespace WinFormsApp4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            Echo e1 = new Echo();
            Echo e2 = e1;

            int x = 0;
            while ( x < 4)
            {
                result += e1.Hello() + "\n";
                e1.count += +1;

                if ( x == 3)
                {
                    e2.count += +1;
                }
                if ( x > 0)
                {
                    e2.count += e1.count;
                }
                x += 1;
            }
            MessageBox.Show(result + "Count : " + e2.count);
        }
    }
}