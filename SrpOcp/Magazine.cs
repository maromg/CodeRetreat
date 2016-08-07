using SrpOcp;

namespace SrpOcpValid
{
    public class Magazine : IReadable
    {
        public int Id { get; set; }
        public int TotalNumberOfPages { get; set; }
        public string Name { get; set; }
    }
}