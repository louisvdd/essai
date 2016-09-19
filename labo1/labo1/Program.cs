using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil oli = new Pupil("oli", 99);

            Activity touche = new Activity("touche", false);
            Activity dessin = new Activity("dessin", true);

            oli.addActivity(touche);
            oli.addActivity(dessin);

            //oli.AddEvaluation("touche");

            //System.Console.Write(oli);

            List<Pupil> LstPupil = new List<Pupil>()
            {
                  new Pupil("vier", 7, 2),
                  new Pupil("augu", 9),
                  new Pupil("nono", 4),
                  new Pupil("anto", 8),
            };

            //  var pupilGrade1Plus6 = from pupil in LstPupil
            //                         where pupil.Age > 6 && pupil.Grade == 1
            //                         select pupil;

            var pupilGrade1Plus6 = LstPupil.Where(Pupil => Pupil.Age > 6 && Pupil.Grade == 1);

            if(pupilGrade1Plus6 != null)
            {
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil.ToString());
                }
            }

            List<Pupil>listPupils = new List<Pupil>()
            {
                new Pupil("2000",10,2),
                new Pupil("1995",5,1),
                 new Pupil("nono", 4),
                  new Pupil("anto", 8),
            } 

            System.Console.Read();
        }
       
    }
}
