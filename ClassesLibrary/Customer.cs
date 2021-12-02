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
        public List<ContactInfo> ContactInfo { get; set; }

        //collect / constructors (ctors)
        public Customer(string customerID, string firstName, string lastName, List<ContactInfo> contactInfo)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;
        }

        //money / methods

        public override string ToString()
        {
            string customerInfo = "";

            foreach (ContactInfo c in ContactInfo)
            {
                customerInfo += c + "\n";
            }//end foreach

            return $"\nCustomer Name: {FirstName} {LastName}\n" +
                $"Customer ID:\n{CustomerID}\n" +
                $"Contact Info:\n{customerInfo}\n";
        }
    }
}
