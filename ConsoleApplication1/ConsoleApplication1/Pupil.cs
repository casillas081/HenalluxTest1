using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pupil : Person
    {
        public int Grade { get; set; }

        private List<Activity> lstActivities;

        public List<Activity> LstActivities
        {
            get { return lstActivities; }
            set { lstActivities = value; }
        }



        //private char[] pupilEvaluations;

        //public char[] PupilEvaluations
        //{
        //    get { return pupilEvaluations; }
        //    set { pupilEvaluations = value; }
        //}

        private Dictionary<String, char> pupilActivities = new Dictionary<String, char>();
        public Dictionary<String, char> PupilActivities { get; set; }

        public void AddActivity(String activityTitle)
        {
            pupilActivities.Add(activityTitle, '0');
        }


        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            //PupilEvaluations = new char[Parameter.MAXACTIVITIES];
            PupilActivities = new Dictionary<string, char>();

        }

        public Pupil(String name, int age) : this(name, age, 1) { }

        //public void AddActivity(Activity activity)
        //{
        //    lstActivities.Add(activity);
        //}

        public void AddEvalutation(String title = null, char evaluation = (char)Parameter.enumEvaluation.Satisfaisant)
        {
            //for (int i = 0; i < PupilEvaluations.Length && i < LstActivities.Count(); i++)
            //{
            //    if (LstActivities.ElementAt(i).Equals(title))
            //    {
            //        PupilEvaluations[i] = evaluation;
            //    }
            //}
            if (title != null) PupilActivities[title] = evaluation;
        }

        public override String ToString()
        {
            string ch = HeaderPupil();
            ch = PrintActivitiesPupil(ch);

            return ch;


        }

        private string PrintActivitiesPupil(string ch)
        {
            int cptActivities = pupilActivities.Count(); // mets le nbr d'activité
            if (cptActivities == 0)
            {
                ch += " n'a pas encore choisi d'activité\n";
            }
            else
            {
                ch += " a comme activitée(s) :\n";
                //foreach (Activity activity in LstActivities)
                for(int i = 0; i < pupilActivities.Count(); i ++)
                {
                    //ch += " " + activity + " \n";
                    ch += PupilActivities.ElementAt(i).Key.ToString() + " : " + PupilActivities.ElementAt(i).Value;
                }
            }

            return ch;
        }

        private string HeaderPupil()
        {
            return base.ToString();
            // reprend le toString de Person
        }

        
    }
}
