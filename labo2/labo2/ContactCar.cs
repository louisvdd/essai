using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo2
{
    class ContactCar
    {
        private Person Personne { get; set; }
        private Car Voiture { get; set; }

        public ContactCar(Person personne, Car voiture)
        {
            Personne = personne;
            Voiture = voiture;
        }

        public void DynamicPrint(dynamic objet)
        {
            System.Console.WriteLine(objet.Print() + " voiture : " + Voiture.ToString());
        }
    }
}
