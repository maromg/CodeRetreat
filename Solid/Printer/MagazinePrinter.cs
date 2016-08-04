using System;
using Solid.Model;

namespace Solid.Printer
{
    public class MagazinePrinter : IPrinter<Magazine>
    {
        public void Print(Magazine printable)
        {
            Console.WriteLine("Printing: {0}", printable.Name);
        }
    }
}