using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student student1 = new Student("xyz", 1234, 3, 3.0);
            Student student2 = new Student("abc", 1334, 4, 3.0);
            Student student3 = new Student("def", 1434, 2, 3.0);
            Student student4 = new Student("ghi", 1534, 1, 3.0);
            Student student5 = new Student("jkl", 1634);
            Student student6 = new Student("mno", 1734);
            Student student7 = new Student("pqr", 1834);

            Teacher teacher1 = new Teacher("teacher", "one", "Chemistry", 3);

            Course course1 = new Course();
            course1.Topic = "Plus two";
            course1.Instructor = teacher1;
            course1.enrolledStudents = new System.Collections.Generic.List<Student>();
            course1.enrolledStudents.Add(student1);
            course1.enrolledStudents.Add(student2);
            course1.enrolledStudents.Add(student3);
            course1.enrolledStudents.Add(student4);
            course1.enrolledStudents.Add(student5);
            course1.enrolledStudents.Add(student6);
            course1.enrolledStudents.Add(student7);

            Console.WriteLine(course1.ToString());
        }
    }
}
