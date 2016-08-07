using System.Collections.Generic;

namespace SrpOcpViolation
{
    public static class BooksDatabase
    {
        public static Dictionary<int, Book> Collection = new Dictionary<int, Book>
        {
            {1,new Book{Id= 1,  AuthorName = "Asaf", CurrentPageNumber = 0 , Status = RentalStatus.Available, Name = "Code Retreat Madness", TotalNumberOfPages = 100}},
            {2,new Book()},
            {3,new Book()},
            {4,new Book()},
            {5,new Book()},
        };
    }
}