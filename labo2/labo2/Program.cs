using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            PrivateContact olivier = new PrivateContact("Olivier", "Beguin", 0498658635, "olikity@gmail.com");
            PrivateContact augu = new PrivateContact("augu", "will", 0498658650, "augu@gmail.com",DateTime.Today);

            professionalContact damien = new professionalContact("damien", "jacq", "indépendant", 071473542, "damjcq@gmail.com");
            professionalContact anto = new professionalContact("anto", "man", "consultant",01477553,"antoman@gmail.com");
            professionalContact nico = new professionalContact("nico", "dardenne", "consultant", 071856525, "nicodard@gmail.com");

            Entreprise rcsc = new Entreprise("rcsc", "charleroi");
            Entreprise basson = new Entreprise("Edition du Basson", "Marcinelle");

            Car audi = new Car("abc123");
            ContactCar ref1 = new ContactCar(damien, audi);

            Car toyota = new Car("321poi");
            ContactCar ref2 = new ContactCar(olivier, toyota);

            ref1.DynamicPrint(ref1);
            ref2.DynamicPrint(ref2);

            anto.AddEntreprise(rcsc);
            anto.AddEntreprise(basson);
            nico.AddEntreprise(rcsc);

            List<professionalContact> LstPro = new List<professionalContact>()
            {
                damien,anto,nico,
            };

           /* var independant = from professionalContact in LstPro
                              where professionalContact.LstEntreprise == null
                              select professionalContact;

            var rcscConsultant = from professionalContact in LstPro
                                 where professionalContact
                                 select professionalContact;*/

           System.Console.Write(olivier.ToString() + "bon anniversaire\n");
            System.Console.Read();
        }
    }
}
