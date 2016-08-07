namespace SrpOcp
{
    public interface IReadable
    {
         int Id { get; set; }
         int TotalNumberOfPages { get; set; }
         string Name { get; set; }
    }
}