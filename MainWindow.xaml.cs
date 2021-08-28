using ConsumoDeApiWPF.API;
using System.Threading.Tasks;
using System.Windows;

namespace ConsumoDeApiWPF
{
    public partial class MainWindow : Window
    {
        Connection _conection = new Connection();

        public MainWindow()
        {
            InitializeComponent();

        }

        private async void btnAcept_Click(object sender, RoutedEventArgs e)
        {
            var result = await _conection.GetStock(txbSymbol.Text);

            txbSymb.Text = result.Symbol;
            txbEmpresa.Text = result.Name;
            txbPreço.Text = result.Price.ToString();
        }
    }
}
