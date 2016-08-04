using System;

namespace SrpOcpValid.Printer
{
    public class NewspaperPrinter : IPrinter<Newspaper>
    {
        public void Print(Newspaper printable)
        {
            Console.WriteLine("Printing: {0}", printable.Name);
        }
    }
}