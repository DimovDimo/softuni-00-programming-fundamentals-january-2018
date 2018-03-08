using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var countStudents = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < countStudents; i++)
            {
                students.Add(Student.ReadStudent());
            }

            var exelentStudents = students
                .Where(s => s.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade)
                .ToList();

            foreach (var student in exelentStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }
}
