using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //frugal / fields

        //people / properties

        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberofPages { get; set; }

        //collect / constructors (ctors)

        public Book(string title, string author, int numberofPages)
        {
            Title = title;
            Author = author;
            NumberofPages = numberofPages;
        }
        //money / methods
        public override string ToString()
        {
            return $"The book {Title} by {Author} has {NumberofPages} pages!";
        }

    }

}

