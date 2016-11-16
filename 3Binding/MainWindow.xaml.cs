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

/// <summary>
/// WPF的Binding学习笔记(二): http://www.cnblogs.com/pasoraku/archive/2012/10/25/2738428.html
/// </summary>
namespace _3Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitDictionary();
            Binding binding = new Binding();
            binding.Source = map;
            binding.Path = new PropertyPath("Values");
            listViewStudent.SetBinding(ListView.ItemsSourceProperty, binding);
        }

        Dictionary<string, Hero> map = new Dictionary<string, Hero>();

        private void InitDictionary()
        {
            Hero hero1 = new Hero(1, "刘备", "哭泣", true);
            map.Add(hero1.Name, hero1);
            Hero hero2 = new Hero(2, "官羽", "贪污", false);
            map.Add(hero2.Name, hero2);
            Hero hero3 = new Hero(3, "黄忠", "射击", true);
            map.Add(hero3.Name, hero3);
            Hero hero4 = new Hero(4, "魏延", "突击", true);
            map.Add(hero4.Name, hero4);
            Hero hero5 = new Hero(5, "马超", "单挑", false);
            map.Add(hero5.Name, hero5);
            Hero hero6 = new Hero(6, "曹仁", "防守", true);
            map.Add(hero6.Name, hero6);
        }
    }
}
