using System.Text.RegularExpressions;

namespace WinForms___dzielenie_przez_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "";
        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string number = inputField.Text;
            if (!isValidNumber(number))
            {
                outputLabel.Text = "Podaj liczbê milionow¹!";
                return;
            }

            outputLabel.Text = "";
            int sum = 0;
            while (number.Length > 0)
            {
                Modulo
            }
        }

        private bool isValidNumber(string number)
        {
            Regex regex = new Regex(@"^\d{7,9}$");

            return regex.IsMatch(number);
        }

        private int Modulo(int number)
        {
            for (int i = 1; i <= number / 7; i++)
            {

            }
            return number;
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
