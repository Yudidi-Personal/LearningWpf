using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3Binding1
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

        private void OneDataSourceConnectOneControl()
        {
            txt1.Margin = new Thickness(50, 0, 50, 0);
            txt2.Margin = new Thickness(50, 50, 50, 0);

            txt1.BorderBrush = new SolidColorBrush(Colors.Red);
            txt2.Background = new SolidColorBrush(Colors.Red);

            // Create Binding
            DataSource ds = new DataSource { Name = "Data Source" };
            Binding binding = new Binding { Source = ds, Path = new PropertyPath("Name") };
            // Connect data source and target
            txt1.SetBinding(TextBlock.TextProperty, binding);
        }

        private void CtlConnectCtl()
        {
           //Do it at xaml.
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OneDataSourceConnectOneControl();
        }
    }
}
