using System;
using SrpOcpValid.Printer;

namespace SrpOcpValid
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksLibrary booksLibrary = new BooksLibrary();
            PageTurner pageTurner = new PageTurner();
            IPrinter<Book> bookPrinter = new BookPrinter();

            Book book = booksLibrary.Rent(bookId: 1);

            for (int i = 1; i < book.TotalNumberOfPages; i++)
            {
                pageTurner.Turn(book.Id, i);
            }

            booksLibrary.Return(book.Id);

            bookPrinter.Print(book);

            Console.ReadKey();
        }
    }
}
