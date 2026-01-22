using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
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

namespace BaseConnection1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WczytajOsoby();
        }

        private void WczytajOsoby()
        {
            string connectionString =
                @"Server=(localdb)\MSSQLLocalDB;Database=Respect;Trusted_Connection=True;";

            string query = "SELECT * FROM osoby";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                OsobyGrid.ItemsSource = tabela.DefaultView;
            }
        }
    }
}