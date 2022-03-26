namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }
}