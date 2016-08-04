namespace Solid
{
    public interface IBooksRepository
    {
        Book Get(int bookId);
        void UpdatePage(int bookId, int pageNumber);
        void UpdateStatus(int bookId, RentalStatus status);
    }
}