using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _2WpfLayout
{
    /// <summary>
    /// Interaction logic for StackPanel.xaml
    /// </summary>
    public partial class StackPanelLayout : Window
    {
        public StackPanelLayout()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (stackPnl.Orientation == Orientation.Horizontal)
            {
                stackPnl.Orientation = Orientation.Vertical;
            }
            else
            {
                stackPnl.Orientation = Orientation.Horizontal;
            }
        }

        private void AddButtons(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            this.Content = stackPanel;
            stackPanel.Background = new SolidColorBrush(Colors.Azure);

            stackPanel.Children.Add(new Button() { Content="Back Button one"});
            stackPanel.Children.Add(new Button() { Content="Back Button two"});
            stackPanel.Children.Add(new Button() { Content="Back Button three"});
        }
    }
}
