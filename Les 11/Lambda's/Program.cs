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


            Console.WriteLine("# FEMALE STUDENTS #");
            foreach (Student student in students)
            {
                if (student.Sex == 'v')
                {
                    Console.WriteLine(student.Name);
                }
            }


            // laatste element terug geven
            Student lastStudent = students.Last();
            Student firstStudent = students.First();


            double average = students.Average(GetScore);
            // (inputparam) => expressie
            double averageWithLambda = students.Average((student) => student.Score);
            double averagePercent = students.Average((student) =>
            {
                double score = student.Score;
                double scoreInPercent = score / 20;
                return scoreInPercent;
            });


            double min = students.Min(GetScore);
            double minWithLambda = students.Min((student) => student.Score);

            double max = students.Max(GetScore);
            double sum = students.Sum(GetScore);

            List<Student> femaleStudents = students.Where((student) => student.Sex == 'v').ToList();
            List<Student> maleStudents = students.Where((student) => student.Sex == 'm').ToList();
            List<Student> bestStudents = students.Where((student) => student.Score >= 15).ToList();

            Console.WriteLine("# FIRST STUDENT #");
            Console.WriteLine(firstStudent.Name);

            Console.WriteLine("# LAST STUDENT #");
            Console.WriteLine(lastStudent.Name);

            Console.WriteLine("# AVERAGE SCORE #");
            Console.WriteLine(average);
            Console.WriteLine(averageWithLambda);
            Console.WriteLine($"{averagePercent:P}");

            Console.WriteLine("# MIN SCORE #");
            Console.WriteLine(min);
            Console.WriteLine(minWithLambda);


            Console.WriteLine("# MAX SCORE #");
            Console.WriteLine(max);

            Console.WriteLine("# SUM SCORE #");
            Console.WriteLine(sum);


            Console.WriteLine("# MALE STUDENTS #");
            foreach (Student student in maleStudents)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("# FEMALE STUDENTS #");
            foreach (Student student in femaleStudents)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("# BEST STUDENTS #");
            foreach (Student student in bestStudents)
            {
                Console.WriteLine(student.Name);
            }

            List<Student> averageScoreBestStudents = students.Where((student) =>
            {
                return student.Score >= 14;
            })
                                                .Take(2)
                                                .OrderByDescending((student) => student.Name)
                                                .ToList();

            Console.WriteLine("# BEST STUDENTS with take #");
            foreach (Student student in averageScoreBestStudents)
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

        private static bool FilterMethode2(Student student)
        {
            return student.Sex == 'm';
        }

        private static bool FilterMethode3(Student student)
        {
            return student.Score >= 15;
        }
    }
}
