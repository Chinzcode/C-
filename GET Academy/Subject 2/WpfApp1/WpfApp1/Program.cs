using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var panel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };
            var button = new Button
            {
                Content = "Trykk her!"
            };
            var label = new Label
            {
                Content = "Trykk på knappen!"
            };
            panel.Children.Add(button);
            panel.Children.Add(label);
            window.Content = panel;
            app.Run(window);
        }
    }
}