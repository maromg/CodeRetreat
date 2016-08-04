using Solid.Interface;

namespace Solid.Model
{
    public class Newspaper : IReadable
    {
        public string Name { get; set; }
        public int TotalNumberOfPages { get; set; }
    }
}