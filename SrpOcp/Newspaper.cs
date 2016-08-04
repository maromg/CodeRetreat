using SrpOcpValid;

namespace SrpOcp
{
    public class Newspaper : IReadable
    {
        public int Id { get; set; }
        public int TotalNumberOfPages { get; set; }
        public string Name { get; set; }
    }
}