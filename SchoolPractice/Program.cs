using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student kimberly = new Student("Kimberly", 1, 1, 4.0);
            Console.WriteLine("The Student class works! " + kimberly.Name + " is a student!");
        }
    }
}
