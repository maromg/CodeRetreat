using System;
using System.Reflection;
using Ninject;
using Solid.Interface;
using Solid.Model;
using Solid.Printer;

namespace Solid
{
    class Program
    {
        private static StandardKernel s_Kernel;

        static void Main(string[] args)
        {
            InitIoC();

            IPageTurner pageTurner = s_Kernel.Get<IPageTurner>();
            IBooksLibrary booksLibrary = s_Kernel.Get<IBooksLibrary>();

            IReadable magazine = new Magazine
            {
                Name = "AWESOME CODE RETREAT @ PICSCOUT",
                TotalNumberOfPages = 100
            };

            IReadable newspaper = new Newspaper
            {
                Name = "AWESOME CODE RETREAT @ PICSCOUT",
                TotalNumberOfPages = 100
            };

            IRentable book = booksLibrary.Rent(bookId: 1);

            for (int i = 1; i < book.TotalNumberOfPages; i++)
            {
                pageTurner.Turn(book.Id, i);
            }

            booksLibrary.Return(book.Id);

            PrintReadables(book, newspaper, magazine);


            Console.ReadKey();
        }

        private static void PrintReadables(IRentable book, IReadable newspaper, IReadable magazine)
        {
            IPrinter<Book> bookPrinter = s_Kernel.Get<IPrinter<Book>>();
            IPrinter<Magazine> magazinePrinter = s_Kernel.Get<IPrinter<Magazine>>();
            IPrinter<Newspaper> newsPaperPrinter = s_Kernel.Get<IPrinter<Newspaper>>();

            bookPrinter.Print((Book)book);
            magazinePrinter.Print((Magazine)magazine);
            newsPaperPrinter.Print((Newspaper)newspaper);
        }

        private static void InitIoC()
        {
            s_Kernel = new StandardKernel();
            s_Kernel.Load(Assembly.GetExecutingAssembly());
        }

    }
}

