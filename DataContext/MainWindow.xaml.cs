using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace DataContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetBinding();
        }

        private void SetBinding()
        {
            List<Student> stuList = new List<Student>()
            {
                new Student{ID=1, Name="Tim", Age=28},
                new Student{ID=2, Name="Ma Guo", Age=25},
                new Student{ID=3, Name="Yan", Age=25},
            };
            List<Teacher> tchrList = new List<Teacher>()
            {
                new Teacher{ID=1, Name="Ma Zhen", Age=24},
                new Teacher{ID=2, Name="Miao miao", Age=24},
                new Teacher{ID=3, Name="Allen", Age=26}
            };

            stuListBox.ItemsSource = stuList;
            tchrListBox.ItemsSource = tchrList;
            stuListBox.DisplayMemberPath = "Name";
            tchrListBox.DisplayMemberPath = "Name";

            stuListBox.SelectionChanged += (sender, e) => { this.DataContext = this.stuListBox.SelectedItem; };
            tchrListBox.SelectionChanged += (sender, e) => { this.DataContext = this.tchrListBox.SelectedItem; };

            this.idTextBox.SetBinding(TextBox.TextProperty, new Binding("ID"));
            this.nameTextBox.SetBinding(TextBox.TextProperty, new Binding("Name"));
            this.ageTextBox.SetBinding(TextBox.TextProperty, new Binding("Age"));
        }
    }
}
