using System;
using System.Windows;
using System.Windows.Controls;

//Version 1
namespace WpfApp1
{
    internal class Program
    {
        private static int _count;
        private static Label _label;
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var clicker = new Clicker();
            window.Content = clicker.Panel;
            app.Run(window);
        }
    }
}

/* Version 1

   namespace WpfApp1
   {
       internal class Program
       {
           private static int _count;
           private static Label _label;
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
               button.Click += ButtonClick;
               _label = new Label
               {
                    Content = "Trykk på knappen!"
               };
               panel.Children.Add(button);
               panel.Children.Add(_label);
               window.Content = panel;
               app.Run(window);
            }
           
           private static void ButtonClick(object sender, RoutedEventArgs e)
           {
               _count++;
               _label.Content = _count;
           }
       }
   }
 */