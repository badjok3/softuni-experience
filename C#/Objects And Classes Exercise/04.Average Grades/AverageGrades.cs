namespace _04.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            Student currentStudent = new Student();
            var result = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var studentInfo = Console.ReadLine().Split(' ');

                currentStudent = new Student
                {
                    Name = studentInfo[0],
                    Grades = new List<double>()
                };

                for (int j = 1; j < studentInfo.Length; j++)
                {
                    currentStudent.Grades.Add(double.Parse(studentInfo[j]));
                }

                currentStudent.Average = currentStudent.Grades.Average();
                if (currentStudent.Average >= 5)
                {
                    result.Add(currentStudent);
                }
            }
            var output = result.OrderBy(x => x.Name).ThenByDescending(x => x.Average);
            foreach (var student in output)
            {
                Console.WriteLine($"{student.Name} -> {student.Average:f2}");
            }
        }
    }
}
