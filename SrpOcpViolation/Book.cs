using System;

namespace SrpOcpViolation
{
    public class Book
    {
        public int Id { get; set; }
        public int TotalNumberOfPages { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public RentalStatus Status { get; set; }
        public int CurrentPageNumber { get; set; }

        public void TurnPage(int pageNumber)
        {
            Console.WriteLine("Turing to page: {0}", pageNumber);
            this.CurrentPageNumber += pageNumber;
        }

        public void Rent()
        {
            Console.WriteLine("Renting book id: {0}", this.Id);
            this.Status = RentalStatus.NotAvailable;
        }

        public void Return()
        {
            Console.WriteLine("Returning book id: {0}", this.Id);
            this.Status = RentalStatus.Available;
        }
    }
}