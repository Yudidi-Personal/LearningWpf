using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext
{
    abstract class SchoolMember
    {
        int ID { get; set; }
        string Name { get; set; }
        int Age { get; set; }
    }
    class Student : SchoolMember
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Teacher : SchoolMember
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
