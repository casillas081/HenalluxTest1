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

            eleve.AddActivity(activities);
            eleve.AddActivity(activities1);
            eleve.AddActivity(activities2);

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


            var pupilGrade1Plus6 = from pupil in lstPupils
                                   where pupil.Age > 6 && pupil.Grade == 1
                                   select pupil;

            if(pupilGrade1Plus6 != null)
            {
                foreach(var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil);
                    
                }
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

            foreach(var person in listFusion)
            {
                System.Console.Write(person);
            }

            System.Console.Read();
        }
    }
}
