using System;
using SrpOcp.Printer;

namespace SrpOcpValid.Printer
{
    public class MagazinePrinter : IPrinter<Magazine>
    {
        public void Print(Magazine printable)
        {
            Console.WriteLine("Printing: {0}", printable.Name);
        }
    }
}