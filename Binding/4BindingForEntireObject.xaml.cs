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
using System.Windows.Shapes;

namespace Binding
{
    /// <summary>
    /// Interaction logic for _4BindingForEntireObject.xaml
    /// </summary>
    public partial class _4BindingForEntireObject : Window
    {
        public _4BindingForEntireObject()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = true;
            popup.PopupAnimation = System.Windows.Controls.Primitives.PopupAnimation.Scroll;
        }

        private void btn2Click(object sender, RoutedEventArgs e)
        {
            popup2.IsOpen = true;
        }

        //private void btn1_Click(object sender, RoutedEventArgs e)
        //{
        //    popusBottom2.IsOpen = false;
        //    popusBottom2.IsOpen = true;
        //    popusBottom2.PopupAnimation = System.Windows.Controls.Primitives.PopupAnimation.Slide;

        //    if (popusBottom2.IsOpen == false)
        //    {
        //        popusBottom2.IsOpen = true;
        //    }
        //}
    }
}
