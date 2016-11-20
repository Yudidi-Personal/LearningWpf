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

namespace CollectionBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetDataSource();
        }

        private void SetDataSource()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student{StuNum=1, Name="Tim", Age=28},
                new Student{StuNum=2, Name="Ma Guo", Age=25},
                new Student{StuNum=3, Name="Yan", Age=25},
                new Student{StuNum=4, Name="Xaiochen", Age=28},
                new Student{StuNum=5, Name="Miao miao", Age=24},
                new Student{StuNum=6, Name="Ma Zhen", Age=24}
            };
            lb.ItemsSource = studentList;
            lb.DisplayMemberPath = "Name";
            //需求变更
            //lb.SelectedValuePath = "stuName";
            //Binding binding = new Binding() { Source = lb, Path = new PropertyPath("SelectedValue") };
            //stuNumTextBox.SetBinding(TextBox.TextProperty, binding);

            this.lb.SelectedValuePath = "StuNum";
            this.stuNumTextBox.SetBinding(TextBox.TextProperty, new Binding("SelectedValue") { Source = this.lb });
        }

    }
}
