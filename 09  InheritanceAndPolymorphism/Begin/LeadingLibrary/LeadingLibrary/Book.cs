using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingLibrary
{
    public class Book
    {
        public string Title { get; }
        public BookCategory Category { get; }
        public int BookCode { get; }
        public Book(string title, BookCategory category, int bookCode)
        {
            Title = title;
            Category = category;
            BookCode = bookCode;
        }
    }
}
