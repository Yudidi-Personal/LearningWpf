using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Binding
{
    public class Hero
    {
        public Hero(int id, string name, string skill, bool hasM)
        {
            this.Name = name;
            this.Id = id;
            this.Skill = skill;
            this.HasM = hasM;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
        public bool HasM { get; set; }
    }
}
