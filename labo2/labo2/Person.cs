using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo2
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        public abstract bool HasHisBirthday();

        public override string ToString()
        {
            return Name + " " + Lastname;
        }
    }
}
