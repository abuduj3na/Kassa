using System.Diagnostics;
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

namespace Kassa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double price;
        double amount;
        double toPay;

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            price = double.Parse(priceTextBox.Text);
            amount = double.Parse(amountTextBox.Text);
            toPay = price * amount;
            amountToPayTextBox.Text = $"{toPay}";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            priceTextBox.Text = "0";
            amountTextBox.Text = "0";
            amountToPayTextBox.Text ="0";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}