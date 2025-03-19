namespace WinForms___challenge_liczby_binarne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "";
            outputLabel2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(inputTextBox.Text);

            string bin = Dec2Bin(number);

            string output = "";
            int counter = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] == '1')
                {
                    output += counter;
                }
                counter++;
            }
            //output.(',');
            outputLabel.Text = '(' + output + ')';
        }

        private string Dec2Bin(int number)
        {
            string result = "";
            while (number > 0)
            {
                result = Convert.ToString(number % 2) + result;
                number /= 2;
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = inputTextBox2.Text;
            double result = 0;

            foreach (char x in input)
            {
                string digit = x + "";
                result += Math.Pow(2, Convert.ToInt32(digit) - 1);
            }
            outputLabel2.Text = Convert.ToString(result);
        }
    }
}
