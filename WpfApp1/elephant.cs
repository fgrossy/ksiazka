using System.Windows;

public class Elephant
{
    public string Name { get; set; }
    public int EarSize { get; set; }

    public void WhoAmI()
    {
        MessageBox.Show($"My name is {Name} and my ear size is {EarSize} centimeters.");
    }
}
