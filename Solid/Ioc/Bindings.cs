using Ninject.Modules;
using Solid.Model;
using Solid.Printer;

namespace Solid.Ioc
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IPageTurner>().To<PageTurner>();
            Bind<IBooksRepository>().To<BooksRepository>();
            Bind<IBooksLibrary>().To<BooksLibrary>();
            Bind<IPrinter<Book>>().To<BookPrinter>();
            Bind<IPrinter<Magazine>>().To<MagazinePrinter>();
            Bind<IPrinter<Newspaper>>().To<NewspaperPrinter>();
        }
    }
}