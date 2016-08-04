using System;
using Solid.Model;

namespace Solid.Printer
{
    public class NewspaperPrinter : IPrinter<Newspaper>
    {
        public void Print(Newspaper printable)
        {
            Console.WriteLine("Printing: {0}", printable.Name);
        }
    }
}