using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo2
{
    class professionalContact : Person
    {
        private string Profession { get; set; }
        private int NumberTel { get; set; }
        private string Email { get; set; }

        public List<Entreprise> LstEntreprise = new List<Entreprise>();

        public professionalContact(string name, string lastName, string profession, int numberTel, string email):base(name,lastName)
        {
            Profession = profession;
            NumberTel = numberTel;
            Email = email;
        }

        public override string ToString()
        {
            return base.ToString()+"\n    "+Profession+"\n    "+Email;
        }

        public override bool HasHisBirthday()
        {
            return false;
        }

        public void AddEntreprise(Entreprise entreprise)
        {
            LstEntreprise.Add(entreprise);
        }

        public dynamic Print()
        {
            return Name + " " + LastName + " est un contact professionnel";
        }
    }
}
