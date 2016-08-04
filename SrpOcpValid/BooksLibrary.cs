using System;

namespace SrpOcpValid
{
    public class BooksLibrary
    {
        readonly BooksRepository m_BooksRepository = new BooksRepository();

        public Book Rent(int bookId)
        {
            Console.WriteLine("Renting book id: {0}", bookId);
            Book book = m_BooksRepository.Get(bookId);
            m_BooksRepository.UpdateStatus(book.Id, RentalStatus.NotAvailable);
            return book;
        }

        public Book Return(int bookId)
        {
            Console.WriteLine("Returning book id: {0}", bookId);
            Book book = m_BooksRepository.Get(bookId);
            m_BooksRepository.UpdateStatus(book.Id, RentalStatus.Available);
            return book;
        }
    }
}