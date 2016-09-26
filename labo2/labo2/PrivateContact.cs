using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo2
{
    class PrivateContact : Person
    {
        private int TelNumber { get; set; }
        private string Email { get; set; }
        private DateTime DateBirth { get; set; }

        public PrivateContact(string name, string lastName, int telNumber,string email, DateTime dateBirth):base(name, lastName)
        {
            TelNumber = telNumber;
            Email = email;
            DateBirth = dateBirth;
        }

        public PrivateContact(string name, string lastName, int telNumber, string email) : base(name, lastName)
        {
            TelNumber = telNumber;
            Email = email;
        }

        public override bool HasHisBirthday()
        {
            return (DateTime.Today.Month == DateBirth.Month && DateTime.Today.Day == DateBirth.Day);
        }

        public override string ToString()
        {
            return base.ToString()+" "+TelNumber+" "+Email+"\n";
        }

        public String Print()
        {
            return Name +" "+ LastName + " est un contact privé";
        }

    }
}
