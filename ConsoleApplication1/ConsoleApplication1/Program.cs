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

            List<Pupil> lstPupils = new List<Pupil>()
            {
                new Pupil("Guebel", 10, 5),
                new Pupil("Rouffi", 7),
                new Pupil("Michou", 10),
                new Pupil("Delcourt", 8, 3),
                new Pupil("Herou", 4),
            };

            var pupilGrade1Plus6 = from 

            System.Console.Write(eleve);
            System.Console.Read();
        }
    }
}
