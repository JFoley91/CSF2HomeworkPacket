using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //frugal / fields

        //people / properties
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInfo { get; set; }

        //collect / constructors (ctors)
        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInfo)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;
        }

        //money / methods

        public override string ToString()
        {

            return $"\nCustomer Name: {FirstName} {LastName}\n" +
                $"Customer ID:\n{CustomerID}\n" +
                $"Contact Info:\n{ContactInfo}\n";
        }
    }
}
