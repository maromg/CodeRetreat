using SrpOcpValid;

namespace SrpOcp
{
    public class Book : IReadable
    {
        public int Id { get; set; }
        public int TotalNumberOfPages { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public RentalStatus Status { get; set; }
        public int CurrentPageNumber { get; set; }

        public Book()
        {
            this.Status = RentalStatus.Available;
        }
    }
}