using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil eleve = new Pupil("Schepmans", 22);
            Activity activities = new Activity("Principe de programmation", true);
            Activity activities1 = new Activity("Néerlandais", false);
            Activity activities2 = new Activity("Mathématique", true);

            eleve.AddActivity("Principe de programmation");
            eleve.AddActivity("Néerlandais");
            eleve.AddActivity("Mathématique");

            eleve.AddEvalutation("Principe de programmation");
            eleve.AddEvalutation(evaluation: 'T', title: "Mathématique");
            eleve.AddEvalutation("Néerlandais");

            System.Console.Write(eleve);

            List<Pupil> lstPupils = new List<Pupil>()
            {
                new Pupil("Guebel", 10, 5),
                new Pupil("Rouffi", 7),
                new Pupil("Michou", 10),
                new Pupil("Delcourt", 8, 3),
                new Pupil("Herou", 4),
            };


            //var pupilGrade1Plus6 = from pupil in lstPupils
            //                       where pupil.Age > 6 && pupil.Grade == 1
            //                       select pupil;

            var pupilGrade1Plus6 = lstPupils.Where(pupilFound => pupilFound.Age > 6 && pupilFound.Grade == 1);

            if (pupilGrade1Plus6 != null)
            {
                System.Console.WriteLine("\r\nDebut pupil plus de 6 ans et encore grade 1");
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil);
                    
                }
                System.Console.WriteLine("\r\nFin pupil plus de 6 ans et encore grade 1");
            }

            List<Person> listPersons = new List<Person>()
            {
                new Person("Demoumou", 26),
                new Person("Lagneaux", 23),
                new Person("BBBB", 5),
                new Person("CCCC", 2),
                new Person("DDDD", 12),
            };

            var listFusion = listPersons.Union(lstPupils);

            System.Console.WriteLine("\r\nDebut de la liste fusionne");
            foreach (var person in listFusion)
            {
                System.Console.Write(person);
            }
            System.Console.WriteLine("\r\nFin de la liste fusionne");

            List<Pupil> listPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("Flo", 10, 5),
                new Pupil("Marti", 7),
                new Pupil("Lolo", 9),
                new Pupil("Lolo", 9),
                new Pupil("Nico", 4),
                new Pupil("Flo", 10, 5),
            };

            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());

            System.Console.WriteLine("\r\nDebut de la liste dupliquée");
            var nbPupil = 0;
            foreach (var pupil in listPupilsNoDuplicated)
            {
                nbPupil++;
                System.Console.Write(pupil);
            }
            System.Console.Write(nbPupil);
            System.Console.WriteLine("\r\nFin de la liste dupliquée");

            System.Console.Read();
        }
    }
}
