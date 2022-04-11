namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            int myIntValue = (int)myDecimalValue;

            MessageBox.Show("The myIntValue is " + myIntValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            // bool myBool = (bool)myDouble;
            string myString = "false";
            // myBool = (bool)myString;
            // myString = (string)myInt;
            myString = myInt.ToString();
            // myBool = (bool)myByte;
            // myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            // myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte
            + myDouble + myChar;

            MessageBox.Show("myInt is " + myInt + "\n" + "myShort is " + myShort + 
                "\n" + "myChar is " + myChar + "\n" + "myLong is " + myLong + "\n" + 
                "myString is " + myString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int myInt = 36;
            float myFloat = 16.4F;
            MessageBox.Show("my Int is " + myInt + "\n" + "my Float is " + myFloat);

            myFloat = myInt + myFloat;

            MessageBox.Show("my Float added to my Int is " + myFloat);
        }
    }
}