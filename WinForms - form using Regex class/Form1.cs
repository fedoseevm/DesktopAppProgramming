using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinForms___form_using_Regex_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            greetingsLabel.Text = "";
        }

        private void emailInputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordSubmitField_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string emailInput = emailInputField.Text;
            string password1 = passwordInputField.Text;
            string password2 = passwordSubmitField.Text;

            //if (IsEmail(emailInput) && isMatchingPasswords(password1, password2))
            //{
            //    MessageBox.Show("Udało się!");
            //}
            //else
            //{
            //    MessageBox.Show("Błędne dane");
            //}

            if (!IsEmail(emailInput))
            {
                greetingsLabel.Text = "Nieprawidłowy adres e-mail";
                return;
            }
            if (!isMatchingPasswords(password1, password2))
            {
                greetingsLabel.Text = "Hasła się różnią";
                return;
            }

            greetingsLabel.Text = $"Witaj {emailInput}";
        }

        private bool isMatchingPasswords(string password1, string password2)
        {
            string pattern = Regex.Escape(password1);
            if (Regex.IsMatch(password2, pattern))
                return true;
            return false;
        }

        private bool IsEmail(string input)
        {
            string pattern = @".@.";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            return false;
        }
    }
}
