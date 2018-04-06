using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConsoleApp
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatics ComputeStatitcs()
        {
            GradeStatics stats = new GradeStatics();
            float sum = 0;


            foreach (var grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowesGrade = Math.Min(grade, stats.LowesGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                NameChanged(_name, value);

                _name = value;
            }
        }//Backing field is created here 
        public NameChangedDelegate NameChanged;
        
        private List<float> grades;
    }
}
