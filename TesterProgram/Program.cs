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

            Console.WriteLine("\n\n*** User Login Info ***\n\n");

            Login l1 = new Login();
            l1.Username = "TinyTim12";
            l1.Password = "@appl3S@uc3";

            Login l2 = new Login("DarkGhostXLR", "Bl@deStorm1989!?");

            Console.WriteLine(l2);

            Console.WriteLine($"The Password for user {l1.Username} is {l1.Password}...\n");

            Console.WriteLine($" ** Address Book **\n");

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "123 N Baker Street";
            c1.City = "Tulsa";
            c1.State = "Oklahoma";
            c1.Zip = "74008";
            c1.Phone = "555-236-4896";
            c1.Email = "Emailme24@outlook.com";

            ContactInfo c2 = new ContactInfo("58 Applepie Lane","Sweethills","Candyland","12345","555-888-7401","PattheBaker@Candyland.org");

            Console.WriteLine(c2);

            Console.WriteLine($"\nPlease come visit us at {c1.StreetAddress}! Located in {c1.City},{c1.State},{c1.Zip}!\n" +
                $"You can also call us at {c1.Phone}! or even Email your questions to {c1.Email}");

            List<ContactInfo> contactInfo = new List<ContactInfo>();
            contactInfo.Add(c1);
            contactInfo.Add(c2);
            contactInfo.RemoveAt(1);

            Customer cr1 = new Customer("1111111", "Jeffery", "Shoemaker", contactInfo);

            Console.WriteLine(cr1);
          
            Customer cr2 = new Customer("2222222", "Pat", "Baker", contactInfo);
            contactInfo.Add(c2);
            contactInfo.RemoveAt(0);
            Console.WriteLine(cr2);
        }
    }
}
