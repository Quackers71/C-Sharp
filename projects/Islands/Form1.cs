namespace Islands
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

            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            string[] islands = new string[4];
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";

            int y = 0;
            int refNum;

            while (y < 4)
            {
                refNum = index[y];
                result += "\nisland " + index[y] + " is ";
                result += islands[refNum];
                y += 1;
            }
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";

            string[] islands = new string[4];
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";

            int y = 0;

            while (y < 4)
            {
                result += "\nisland " + y + " is ";
                result += islands[y];
                y += 1;
            }
            MessageBox.Show(result);
        }
    }
}