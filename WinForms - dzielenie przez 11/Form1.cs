using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___dzielenie_przez_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string number = inputTextField.Text;
            if (!isValidNumber(number))
            {
                outputLabel.Text = "Podaj liczbę billiardową! (16 - 18 cyfr)";
                return;
            }

            if (isDividedByEleven(number))
            {
                outputLabel.Text = "Liczba jest podzielna przez 11!";
            }
            else
            {
                outputLabel.Text = "Liczba nie jest podzielna przez 11!";
            }

        }

        private bool isValidNumber(string number)
        {
            Regex regex = new Regex(@"^\d{16,18}$");
            return regex.IsMatch(number);
        }

        private bool isDividedByEleven(string number)
        {
            string reversedNumber = number.Reverse().ToString();
            int sum = Convert.ToInt32(reversedNumber[0]);
            for (int i = 1; i < reversedNumber.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += Convert.ToInt32(reversedNumber[i]);
                }
                else
                {
                    sum -= Convert.ToInt32(reversedNumber[i]);
                }
            }

            if (sum % 11 == 0) 
                return true;
            return false;
        }
    }
}
