using System;

namespace SrpOcpViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine("WOW, This code retreat is awesome", 25);
            Newspaper newspaper = new Newspaper("AWESOME CODE RETREAT @ PICSCOUT", 25);
            Book book = BooksDatabase.Collection[1];

            book.Rent();

            for (var i = 1; i < book.TotalNumberOfPages; i++)
            {
                book.TurnPage(i);
            }

            book.Return();

            magazine.Print();
            newspaper.Print();
            book.Print();

            Console.ReadLine();
        }
    }
}
