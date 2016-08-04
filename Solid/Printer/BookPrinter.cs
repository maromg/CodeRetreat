using System;

namespace Solid.Printer
{
    public class BookPrinter : IPrinter<Book>
    {
        public void Print(Book printable)
        {
            Console.WriteLine("Printing: {0} - {1} - {2}",
                printable.Name,
                printable.AuthorName,
                printable.TotalNumberOfPages);
        }
    }
}