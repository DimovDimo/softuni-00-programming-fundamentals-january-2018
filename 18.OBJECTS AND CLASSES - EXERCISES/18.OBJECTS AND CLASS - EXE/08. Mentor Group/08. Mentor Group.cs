using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, Student>();
            string line = Console.ReadLine();
            while (line != "end of dates")
            {
                var separated = line.Split(' ').ToList();
                string name = separated[0];
                if (separated.Count > 1)
                {
                    List<DateTime> dates = separated[1]
                                    .Split(',')
                                    .Select(s => DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                                    .ToList();
                    var student = new Student();
                    student.Name = name;
                    if (students.ContainsKey(name) == false)
                    {
                        students.Add(name, student);
                        student.Dates = dates;
                    }
                    else
                    {
                        students[name].Dates.AddRange(dates);
                    }
                }
                else
                {
                    var student = new Student();
                    student.Name = name;
                    List<DateTime> dates = new List<DateTime>();
                    if (students.ContainsKey(name) == false)
                    {
                        students.Add(name, student);
                        student.Dates = dates;
                    }
                    //else
                    //{
                    //    students[name].Dates.AddRange(dates);
                    //}
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            while (line != "end of comments")
            {
                string[] separated = line.Split('-');
                string name = separated[0];
                string coment = separated[1];
                var coments = new List<string> { coment };

                if (students.ContainsKey(name))
                {
                    if (students[name].Coments != null)
                    {
                        students[name].Coments.AddRange(coments);
                    }
                    else
                    {
                        students[name].Coments = coments;
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                if (student.Value.Coments != null)
                {
                    foreach (var coment in student.Value.Coments)
                    {
                        Console.WriteLine($"- {coment}");
                    }
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.Value.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }
            }

            // First----------------------------

            //var students = new SortedDictionary<string, Student>();


            //var students = new List<Student>();
            //while (true)
            //{
            //    var input = Console.ReadLine();
            //    if (input == "end of dates")
            //    {
            //        break;
            //    }
            //
            //    var studentCurrent = new Student();
            //    var separatedName = input.Split(' ').ToList();
            //    studentCurrent.Name = separatedName[0];
            //    if (separatedName.Count > 1)
            //    {
            //        var datesCurrent = separatedName[1]
            //        .Split(',')
            //        .Select(s => DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture))
            //        .ToList();
            //        studentCurrent.Dates = datesCurrent;
            //        if (students.Any(x => x.Name == studentCurrent.Name))
            //        {
            //            var temporalStudent = students.First(x => x.Name == studentCurrent.Name);
            //            var temporalDates = temporalStudent.Dates;
            //            temporalDates.AddRange(datesCurrent);
            //        }
            //        else
            //        {
            //            students.Add(studentCurrent);
            //        }
            //    }
            //    else
            //    {
            //        if (students.Any(x => x.Name == studentCurrent.Name))
            //        {
            //            
            //        }
            //        else
            //        {
            //            students.Add(studentCurrent);
            //        }
            //    }
            //}
            //
            //while (true)
            //{
            //    var input = Console.ReadLine();
            //    if (input == "end of comments")
            //    {
            //        break;
            //    }
            //
            //    var separatedName = input.Split('-').ToList();
            //    var name = separatedName[0];
            //    var comment = separatedName[1];
            //    List<string> comments = new List<string>();
            //    comments.Add(comment);
            //    if (students.Any(x => x.Name == name))
            //    {
            //        var temporalStudent = students.First(x => x.Name == name);
            //        var temporalComents = temporalStudent.Coments;
            //        if (temporalComents != null)
            //        {
            //            temporalComents.AddRange(comments);
            //        }
            //        else
            //        {
            //            temporalComents = comments;
            //        }
            //
            //        temporalStudent.Coments = temporalComents;
            //    }
            //}
            //
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.Name);
            //    Console.WriteLine("Comments:");
            //    if (student.Coments != null)
            //    {
            //        foreach (var coment in student.Coments)
            //        {
            //            Console.WriteLine($"- {coment}");
            //        }
            //    }
            //
            //    Console.WriteLine("Dates attended:");
            //    foreach (var date in student.Dates.OrderBy(x => x))
            //    {
            //        Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
            //    }
            //}
        }
    }
}
