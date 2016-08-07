using System;

namespace SrpOcpViolation
{
    public class Magazine
    {
        public string Name { get; set; }
        public int NumberOfPages { get; set; }

        public Magazine(string name, int numberOfPages)
        {
            this.Name = name;
            this.NumberOfPages = numberOfPages;
        }

        public void Print()
        {
            Console.WriteLine("Printing {0} magazine",
                this.Name);
        }
    }
}