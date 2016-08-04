using System;

namespace SrpOcpViolation
{
    public class Printer
    {
        public void Print(Book book)
        {
            Console.WriteLine("Printing: {0} - {1} - {2}",
                book.Name,
                book.AuthorName,
                book.TotalNumberOfPages);
        }

        public void Print(Newspaper newspaper)
        {
            Console.WriteLine("Printing {0} newspaper",
                newspaper.Name);
        }

        public void Print(Magazine magazine)
        {
            Console.WriteLine("Printing {0} magazine",
                magazine.Name);
        }
    }
}