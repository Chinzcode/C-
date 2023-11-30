using System.Windows.Controls;
using System.Windows;

namespace WpfApp1
{
    internal class ClickerWithInheritance : StackPanel
    {
        private readonly Label Label;
        private int Count;

        public ClickerWithInheritance() : base()
        {
            this.Orientation = Orientation.Horizontal;
            var button = new Button
            {
                Content = "Trykk her!"
            };
            button.Click += ButtonClick;
            this.Label = new Label
            {
                Content = "Trykk på knappen!"
            }; 
            this.Children.Add(button);
            this.Children.Add(this.Label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            this.Count++;
            this.Label.Content = this.Count;
        }
    }
}
