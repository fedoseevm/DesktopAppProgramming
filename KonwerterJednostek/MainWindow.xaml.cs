using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KonwerterJednostek
{
    public partial class MainWindow : Window
    {
        Dictionary<string, double> jednostkiDlugosci = new Dictionary<string, double>()
        {
            { "metr", 1.0 },
            { "kilometr", 1000.0 },
            { "centymetr", 0.01 },
            { "cal", 0.0254 },
            { "stopa", 0.0254 * 12 },
            { "mila", 0.0254 * 12 * 5280 }
        };

        public MainWindow()
        {
            InitializeComponent();

            foreach (var jednostka in jednostkiDlugosci.Keys)
            {
                comboBoxFrom.Items.Add(jednostka);
                comboBoxTo.Items.Add(jednostka);
            }

            comboBoxFrom.SelectedIndex = 0;
            comboBoxTo.SelectedIndex = 1;
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(inputText.Text, out double value) || value < 0)
            {
                MessageBox.Show("Podaj poprawną dodatnią liczbę.", "Błąd");
                return;
            }

            string from = comboBoxFrom.SelectedItem.ToString();
            string to = comboBoxTo.SelectedItem.ToString();

            double valueInMeters = value * jednostkiDlugosci[from];
            double result = valueInMeters / jednostkiDlugosci[to];

            labelResult.Content = result.ToString("F2");

            string wpis = $"{value} {from} = {result:F2} {to}";
            historyList.Items.Insert(0, wpis);

            if (historyList.Items.Count > 5)
                historyList.Items.RemoveAt(5);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            inputText.Text = "0";
            labelResult.Content = "0";
            historyList.Items.Clear();
        }
    }
}