using SpokojnySklep.classes;
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

namespace SpokojnySklep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cart cart = new Cart();
        int CurrentProduct;

        public MainWindow()
        {
            InitializeComponent();
            InitializeProductViewer();
            CurrentProduct = 0;
            scrollLeftBtn.IsEnabled = false;
        }

        public void InitializeProductViewer()
        {
            productNameField.Text = cart.Products.ElementAt(CurrentProduct).Name;
            productPriceField.Text = cart.Products.ElementAt(CurrentProduct).Price.ToString();
        }

        private void scrollLeftBtn_Click(object sender, RoutedEventArgs e)
        {
            CurrentProduct -= 1;
            scrollRightBtn.IsEnabled = true;
            InitializeProductViewer();
            if (CurrentProduct == 0)
                scrollLeftBtn.IsEnabled = false;
        }

        private void scrollRightBtn_Click(object sender, RoutedEventArgs e)
        {
            CurrentProduct += 1;
            scrollLeftBtn.IsEnabled = true;
            InitializeProductViewer();
            if (CurrentProduct == cart.Products.Count - 1)
                scrollRightBtn.IsEnabled = false;
        }

        private void PercentageDiscountOption_Checked(object sender, RoutedEventArgs e)
        {
            cart.DiscountStrategy = new PercentageDiscount();
            DiscountField.IsEnabled = true;
            DiscountLabel.Content = "%";

        }

        private void FixedAmountDiscountOption_Checked(object sender, RoutedEventArgs e)
        {
            cart.DiscountStrategy = new FixedAmountDiscount();
            DiscountField.IsEnabled = true;
            DiscountLabel.Content = "zl";
        }

        private void calculateCartBtn_Click(object sender, RoutedEventArgs e)
        {
            int discount = Convert.ToInt32(DiscountField.Text);
            cartValueBeforeDiscount.Text = cart.CalculateCartValue().ToString();
            cartValueAfterDiscount.Text = cart.CalculateCartValueWithDiscount(cart.DiscountStrategy, discount).ToString();
        }

        private void AddProduct(object sender, KeyEventArgs e) 
        {
            if (e.Key == Key.A && Keyboard.Modifiers == ModifierKeys.Control)
            {
                MessageBox.Show("YES!");
            }
        }
    }
}