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
                outputLabel.Text = "Podaj liczbę milionową!";
                return;
            }

            outputLabel.Text = "";

            int sumOfRemainders = GetRemaindersSum(number);

            if (sumOfRemainders % 7 == 0)
                outputLabel.Text = "Liczba jest podzielna przez 7!";
            else
                outputLabel.Text = "Liczba nie jest podzielna przez 7!";
        }

        private bool isValidNumber(string number)
        {
            Regex regex = new Regex(@"^\d{7,9}$");

            return regex.IsMatch(number);
        }

        private int ModuloSeven(int number)
        {
            int n = number / 7;     // Iloraz dzielenia całkowitego
            return number - 7 * n;
        }

        private int GetRemaindersSum(int number)
        {
            int sum = 0;
            while (number.Length > 0)
            {
                int part;
                if (number.Length >= 2)
                {
                    part = Convert.ToInt32(number.Substring(number.Length - 2));
                    number = number.Substring(0, number.Length - 2);
                }
                else
                {
                    part = Convert.ToInt32(number);
                    number = "";
                }

                sum += ModuloSeven(part);
            }
            return sum;
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
