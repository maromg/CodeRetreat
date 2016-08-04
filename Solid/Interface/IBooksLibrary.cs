namespace Solid
{
    public interface IBooksLibrary
    {
        Book Return(int bookId);
        Book Rent(int bookId);
    }
}