using System;

namespace SrpOcpViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Magazine magazine = new Magazine("WOW, This code retreat is awesome");
            Newspaper newspaper = new Newspaper("AWESOME CODE RETREAT @ PICSCOUT");
            Book book = BooksDatabase.Collection[1];

            book.Rent();

            for (var i = 1; i < book.TotalNumberOfPages; i++)
            {
                book.TurnPage(i);
            }

            book.Return();

            printer.Print(book);
            printer.Print(newspaper);
            printer.Print(magazine);

            Console.ReadLine();
        }
    }
}
