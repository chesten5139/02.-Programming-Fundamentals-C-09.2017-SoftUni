using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Average(); } }
    }

    class AverageGrades
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var studentProperties = Console.ReadLine().Split(' ').ToList();
                var student = new Student();
                student.Name = studentProperties[0];
                student.Grades = studentProperties.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }

            students
                .Where(g => g.AverageGrade >= 5.00)
                .OrderBy(a => a.Name)
                .ThenByDescending(a => a.AverageGrade)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.AverageGrade:F2}"));

        }
    }
}
