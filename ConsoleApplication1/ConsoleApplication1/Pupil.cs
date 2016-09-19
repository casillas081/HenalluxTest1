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



        private char[] tabEval;

        public char[] TabEval
        {
            get { return tabEval; }
            set { tabEval = value; }
        }


        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(String name, int age) : this(name, age, 1) { }

        public void AddActivity(Activity activity)
        {
            LstActivities.Add(activity);
        }

        public void AddEvalutation(String title = null, char evaluation = 'S')
        {
            for(int i = 0; i < TabEval.Length && i < LstActivities.Count(); i++)
            {
                if (LstActivities.ElementAt(i).Equals(title))
                {
                    TabEval[i] = evaluation;
                }
            }
        }

        public override String ToString()
        {
            string ch = base.ToString(); // reprend le toString de Person
            int cptActivities = LstActivities.Count(); // mets le nbr d'activité
            if(cptActivities == 0)
            {
                ch += " n'a pas encore choisi d'activité\n";
            }
            else
            {
                ch += " a comme activitée(s) :\n";
                foreach (Activity activity in LstActivities)
                {
                    ch += " "+activity + " \n";
                }
            }

            return ch;
        }
    }
}
