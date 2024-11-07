using System.Windows;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        Elephant lloyd = new Elephant { Name = "Lloyd", EarSize = 40 };
        Elephant lucinda = new Elephant { Name = "Lucinda", EarSize = 33 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonLloyd_Click(object sender, RoutedEventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void buttonLucinda_Click(object sender, RoutedEventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void buttonSwap_Click(object sender, RoutedEventArgs e)
        {
            Elephant temp = lloyd;
            lloyd = lucinda;
            lucinda = temp;

            MessageBox.Show("Objects swapped!");
        }
    }
}
