using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ENCAPSULATION
{
    internal class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reverseTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reverseTeam = new List<Person>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return firstTeam.AsReadOnly();}
        }

        public IReadOnlyCollection<Person> ReverseTeam
        {
            get { return reverseTeam.AsReadOnly();}
        } 

        public void addPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reverseTeam.Add(person);
            }
        }
    }
}
