﻿using System;
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
            Student s1 = new Student();
            s1.FirstName = "Jack";
            s1.LastName = "Skeleington";
            s1.Id = "125824";
            s1.Gpa = 3.0f;

            Student s2 = new Student("Oggie","Boggie","875687", 2.3f);

            Console.WriteLine($"Student Name: {s1.FirstName} {s1.LastName}\n" +
                  $"ID: {s1.Id}      GPA: {s1.Gpa}\n");

            Console.WriteLine(s2);

            Console.WriteLine("\n**** Car Info ****\n");

            Vehicle v1 = new Vehicle();
            v1.Make = "Jeep";
            v1.Model = "Wrangler";
            v1.Year = 1982;
            v1.Weight = 2950;

            Vehicle v2 = new Vehicle("Bugatti", "Veyron", 2009, 4250);

            Console.WriteLine($"A {v1.Year} {v1.Make} {v1.Model} weights roughly {v1.Weight} Lbs.\n");

            Console.WriteLine(v2);

        }
    }
}
