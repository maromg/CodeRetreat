using System;

namespace Solid
{
    public class PageTurner : IPageTurner 
    {
        readonly BooksRepository m_BooksRepository = new BooksRepository();

        public void Turn(int bookId, int pageNumber)
        {
            Console.WriteLine("Turing to page: {0}", pageNumber);
            m_BooksRepository.UpdatePage(bookId, pageNumber);
        }
    }
}