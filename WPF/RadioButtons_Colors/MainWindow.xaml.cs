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

namespace RadioButtons_Colors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KolorContext kolorContext;
        public MainWindow()
        {
            InitializeComponent();
            kolorContext = new KolorContext();
            kolorContext.Database.EnsureCreated();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Brush lastColor = label.Background;
            ramka.BorderBrush = lastColor;

            RadioButton RB = (RadioButton)sender;
            //MessageBox.Show(RB.Tag.ToString());
            Brush newColor = (Brush)new BrushConverter().ConvertFromString(RB.Content.ToString());
            label.Background = newColor;

            string kolor = RB.Content.ToString();
            kolorContext.Kolory.Add(new Kolor { Nazwa = kolor });
            lista.Items.Add(kolor);
            kolorContext.SaveChanges();
        }
    }
}