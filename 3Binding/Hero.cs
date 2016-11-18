using System.ComponentModel;

namespace _3Binding
{
    public class Hero: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int id;
        private string name;
        private string skill;
        private bool hasM;

        public Hero(int id, string name, string skill, bool hasM)
        {
            Name = name;
            ID = id;
            Skill = skill;
            HasM = hasM;
        }

        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("ID"));
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public string Skill
        {
            get { return skill; }
            set
            {
                this.skill = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Skill"));
            }
        }

        public bool HasM
        {
            get { return hasM; }
            set
            {
                this.hasM = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Skill"));
            }
        }
    }
}
