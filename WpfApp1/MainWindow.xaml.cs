using System;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        // Stawka za kilometr
        private double reimburseRate = 0.39;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Pobranie wartości z pól tekstowych
                double startingMileage = Convert.ToDouble(textBoxStartingMileage.Text);
                double endingMileage = Convert.ToDouble(textBoxEndingMileage.Text);

                // Walidacja - czy początkowy stan licznika jest mniejszy od końcowego
                if (startingMileage > endingMileage)
                {
                    MessageBox.Show("Początkowy stan licznika musi być mniejszy niż końcowy stan licznika.", "Błąd");
                    return;
                }

                // Obliczanie odległości i kwoty do zwrotu
                double milesTraveled = endingMileage - startingMileage;
                double amountOwed = milesTraveled * reimburseRate;

                // Wyświetlanie wyniku
                labelResult.Text = amountOwed.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadź prawidłowe liczby.", "Błąd");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Pobranie wartości z pól tekstowych
                double startingMileage = Convert.ToDouble(textBoxStartingMileage.Text);
                double endingMileage = Convert.ToDouble(textBoxEndingMileage.Text);

                // Walidacja - czy początkowy stan licznika jest mniejszy od końcowego
                if (startingMileage > endingMileage)
                {
                    MessageBox.Show("Początkowy stan licznika musi być mniejszy niż końcowy stan licznika.", "Błąd");
                    return;
                }

                // Obliczanie odległości i kwoty do zwrotu
                double milesTraveled = endingMileage - startingMileage;
                labelResult.Text = milesTraveled.ToString();


            }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadź prawidłowe liczby.", "Błąd");
            }
        }
    }
}
