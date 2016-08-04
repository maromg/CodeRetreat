using System;

namespace Solid
{
    public class BooksLibrary : IBooksLibrary
    {
        public IBooksRepository BooksRepository;

        public BooksLibrary(IBooksRepository booksRepository)
        {
            BooksRepository = booksRepository;
        }

        public Book Rent(int bookId)
        {
            Console.WriteLine("Renting book id: {0}", bookId);
            Book book = BooksRepository.Get(bookId);
            BooksRepository.UpdateStatus(book.Id, RentalStatus.NotAvailable);
            return book;
        }

        public Book Return(int bookId)
        {
            Console.WriteLine("Returning book id: {0}", bookId);
            Book book = BooksRepository.Get(bookId);
            BooksRepository.UpdateStatus(book.Id, RentalStatus.Available);
            return book;
        }
    }
}