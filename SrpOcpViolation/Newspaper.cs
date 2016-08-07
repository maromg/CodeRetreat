using System;

namespace SrpOcpViolation
{
    public class Newspaper
    {
        public string Name { get; set; }
        public int NumberOfPages { get; set; }

        public Newspaper(string name, int numberOfPages)
        {
            this.NumberOfPages = numberOfPages;
            this.Name = name;
        }


        public void Print()
        {
            Console.WriteLine("Printing {0} newspaper",
                this.Name);
        }
    }
}