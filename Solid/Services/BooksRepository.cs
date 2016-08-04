namespace Solid
{
    public class BooksRepository : IBooksRepository
    {
        public Book Get(int bookId)
        {
            return BooksDatabase.Collection[bookId];
        }

        public void UpdateStatus(int bookId, RentalStatus status)
        {
            BooksDatabase.Collection[bookId].Status = status;
        }

        public void UpdatePage(int bookId, int pageNumber)
        {
            BooksDatabase.Collection[bookId].CurrentPageNumber = pageNumber;
        }
    }
}