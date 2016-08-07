using System;
using SrpOcpValid;

namespace SrpOcp
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine
            {
                Name = "AWESOME CODE RETREAT @ PICSCOUT",
                TotalNumberOfPages = 100
            };

            Newspaper newspaper = new Newspaper
            {
                Name = "AWESOME CODE RETREAT @ PICSCOUT",
                TotalNumberOfPages = 100
            };

            BooksLibrary booksLibrary = new BooksLibrary();
            PageTurner pageTurner = new PageTurner();
            Printer printer = new Printer();

            Book book = booksLibrary.Rent(bookId: 1);

            for (int i = 1; i < book.TotalNumberOfPages; i++)
            {
                pageTurner.Turn(book.Id, i);
            }

            booksLibrary.Return(book.Id);

            printer.Print(book);
            printer.Print(newspaper);
            printer.Print(magazine);

            Console.ReadKey();
        }
    }
}
