namespace SrpOcpValid.Printer
{
    public interface IPrinter<T>
    {
        void Print(T printable);
    }
}