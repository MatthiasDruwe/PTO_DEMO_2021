using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_s
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Alina", 'v', 14));
            students.Add(new Student("Vincent", 'm', 15));
            students.Add(new Student("Simon", 'm', 12));
            students.Add(new Student("Hanane", 'v', 13));
            students.Add(new Student("Julie", 'v', 11));
            students.Add(new Student("Abdelmounaim", 'm', 16));

            foreach(Student student in students)
            {
                if (student.Sex == 'v')
                {
                    Console.WriteLine(student.Name);
                }
            }


            // laatste element terug geven
            Student lastStudent = students.Last();
            Student firstStudent = students.First();

            double average=  students.Average(GetScore);
            double min = students.Min(GetScore);
            double max = students.Max(GetScore);

            List<Student> femaleStudents = students.Where(FilterMethode).ToList();

            Console.WriteLine(firstStudent.Name);
            Console.WriteLine(lastStudent.Name);
            Console.WriteLine(average);
            Console.WriteLine(min);
            Console.WriteLine(max);
            foreach(Student student in femaleStudents)
            {
                Console.WriteLine(student.Name);
            }

            Console.ReadKey();
        }

        private static double GetScore(Student student)
        {
            return student.Score;
        }

        private static bool FilterMethode(Student student)
        {
            return student.Sex == 'v';
        }
    }
}
