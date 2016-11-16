using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Binding1
{
    /// <summary>
    /// Step1: Prepare for data source.
    /// </summary>
    class DataSource : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("Name"));//?. 叫做null-conditional operator（空值的条件访问操作符），是C#6新增的语言特色。
                //if (PropertyChanged != null)
                //{
                //    PropertyChanged.Invoke(this,new PropertyChangedEventArgs("Name"));
                //}
            }
        }
    }
}
