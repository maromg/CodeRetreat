namespace Solid.Interface
{
    public interface IReadable
    {
        string Name { get; set; }
        int TotalNumberOfPages { get;set; }
    }

    public interface IRentable : IReadable
    {
        int Id { get; set; }
    }
}