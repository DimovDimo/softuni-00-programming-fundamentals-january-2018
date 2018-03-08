using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }

        static public Student ReadStudent()
        {
            var separated = Console.ReadLine()
                .Split(' ')
                .ToList();
            var grades = separated
                    .Skip(1)
                    .ToList();
            return new Student
            {
                Name = separated[0],
                Grades = grades
                    .Select(double.Parse)
                    .ToList()
            };
        }
    }
}
