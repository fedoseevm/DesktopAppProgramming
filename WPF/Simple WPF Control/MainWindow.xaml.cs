using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Simple_WPF_Control
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected bool isValidName = false;
        protected bool isValidZip = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Length < 5)
            {
                MessageBox.Show("Name must contain at least 5 characters");
            }
            else isValidName = true;
        }

        private void zipCodeInput_LostFocus(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^\d{2}-\d{3}$");
            if (!regex.IsMatch(zipCodeInput.Text))
            {
                MessageBox.Show("Zip code must look like XX-XXX !");
            }
            else isValidZip = true;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isValidName) MessageBox.Show("Name must contain at least 5 characters");
            else if (!isValidZip) MessageBox.Show("Zip code must look like XX-XXX !");
            else
            {
                MessageBox.Show("Congratulations! Your form was sent.");
                Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}