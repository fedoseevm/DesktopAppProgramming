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

namespace EntityFramework___produkty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KoszykContext db;
        public MainWindow()
        {
            db = new KoszykContext();
            InitializeComponent();
            //KoszykBiznes koszykBiznes = new KoszykBiznes();
            //koszykBiznes.KoszykContext.Database.EnsureCreated();
            WypelnijCombo();
        }

        private void WypelnijCombo()
        {
            List<Kategoria> kategorie = db.Kategorie.ToList();
            foreach (var item in kategorie)
            {
                combobox_kategoria.Items.Add(item);
            }
        }

        private void combobox_kategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Kategoria katSelected = (Kategoria)combobox_kategoria.SelectedItem;

            foreach (var produkt in db.Produkty)
            {
                if (produkt.Kategoria == katSelected)
                {
                    listbox_tresc.Items.Add(produkt);
                }
            }
        }
    }
}