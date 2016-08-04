using Solid.Interface;

namespace Solid.Model
{
    public class Magazine : IReadable
    {
        public string Name { get; set; }
        public int TotalNumberOfPages { get; set; }
    }
}