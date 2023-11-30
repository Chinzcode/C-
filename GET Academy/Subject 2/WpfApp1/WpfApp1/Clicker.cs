using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    internal class Clicker
    {
        private readonly Label Label;
        private int Count;
        public StackPanel Panel { get; }

        public Clicker()
        {
            Panel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };
            var button = new Button
            {
                Content = "Trykk her!"
            };
            button.Click += ButtonClick;
            this.Label = new Label
            {
                Content = "Trykk på knappen!"
            };
            Panel.Children.Add(button);
            Panel.Children.Add(this.Label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            this.Count++;
            this.Label.Content = this.Count;
        }
    }
}
