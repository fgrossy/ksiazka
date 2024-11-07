using System;
using System.Windows;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        private DinnerParty dinnerParty;

        public MainWindow()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty
            {
                NumberOfPeople = (int)numPeopleUpDown.Value,
                FancyDecorations = fancyDecorationsCheckBox.IsChecked == true
            };
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.CalculateCost();
            costLabel.Content = $"${cost:F2}";
        }

        private void CalculateCostButton_Click(object sender, RoutedEventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numPeopleUpDown.Value;
            dinnerParty.FancyDecorations = fancyDecorationsCheckBox.IsChecked == true;
            DisplayDinnerPartyCost();
        }

        private void numPeopleUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (dinnerParty != null)
            {
                dinnerParty.NumberOfPeople = (int)numPeopleUpDown.Value;
                DisplayDinnerPartyCost();
            }
        }

        private void fancyDecorationsCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (dinnerParty != null)
            {
                dinnerParty.FancyDecorations = fancyDecorationsCheckBox.IsChecked == true;
                DisplayDinnerPartyCost();
            }
        }
    }
}
