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

namespace EntityFrameworkDB1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DAO DAO;

        protected bool isValidName = false;
        protected bool isValidZip = false;
        public MainWindow()
        {
            InitializeComponent();
            DAO = new DAO();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Length < 5)
            {
                MessageBox.Show("Name must contain at least 5 characters");
            }
            else isValidName = true;
        }

        private void ZipCodeInput_LostFocus(object sender, RoutedEventArgs e)
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
                Osoba osoba = new Osoba();

                osoba.Name = nameInput.Text;
                osoba.Address = adressInput.Text;
                osoba.City = cityInput.Text;
                osoba.State = stateInput.Text;
                osoba.Zip = zipCodeInput.Text;

                DAO.dodajOsobe(osoba);
            }
        }

        private void wypelnijListeMiastami()
        {
            List<Osoba> osoby = DAO.pobierzOsoby();
            foreach (Osoba osoba in osoby)
            {

            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}