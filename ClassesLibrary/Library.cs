using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            string bookOnHand = "";
            foreach (Book b in Books)
            {
                bookOnHand += b;
            }
            return $"\nThe {LibraryName}, located at {StreetAddress} in {City},{State} {Zip}\n" +
                $"Does not normally have {bookOnHand}";

        }
    }
}
