using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;


namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n****** STUDENT PORTAL ******\n\n");
            //Student s1 = new Student();
            //s1.FirstName = "Jack";
            //s1.LastName = "Skeleington";
            //s1.Id = "Pumpking56";
            //s1.Gpa = 3;
            Student s1 = new Student("Jack", "Skeleington", "Pumpking56", 4);

            Student s2 = new Student("Oggie","Boggie","Boggieman87", 1);

            Console.WriteLine($"Student Name: {s1.FirstName} {s1.LastName}\n" +
                  $"ID: {s1.Id}      GPA: {s1.Gpa}\n");

            Console.WriteLine($"Student Name: {s2.FirstName} {s2.LastName}\n"+
                              $"ID: {s2.Id}      GPA: {s2.Gpa}\n");
        }
    }
}
