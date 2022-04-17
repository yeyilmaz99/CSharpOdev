using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Yunus";
            students[1] = "Yagmur";
            students[2] = "Emir";

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            string Student1 = "Yunus";
            string Student2 = "Yagmur";
            string Student3 = "Emir";

            string[] Students3 = new[] {Student1, Student2 ,Student3};
            string[] Students4 =  { Student1, Student2, Student3 };


            string[] students2 = new[] { "Yunus", "Yagmur", "Emir" };
        }
    }
}
