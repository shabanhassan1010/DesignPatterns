using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case_Answer.Case_Answer_1_SRP
{
    #region Bad Code
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

    }

    public class PrintBook
    {
        public void Print(Book book)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }

    }
    public class SaveBook
    {
        public void Save(Book book)
        {
            Console.WriteLine($"Saving '{book.Title}' to the database...");
        }
    }
    #endregion
}
