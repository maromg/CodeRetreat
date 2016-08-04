using System;

namespace SrpOcpViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Book book = BooksDatabase.Collection[1];

            book.Rent();

            for (var i = 1; i < book.TotalNumberOfPages; i++)
            {
                book.TurnPage(i);
            }

            book.Return();

            printer.Print(book);
            printer.Print(new Magazine("WOW, This code retreat is awesome"));
            printer.Print(new Newspaper("AWESOME CODE RETREAT @ PICSCOUT"));

            Console.ReadLine();
        }
    }
}
