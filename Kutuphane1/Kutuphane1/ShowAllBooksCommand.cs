using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane1
{
    class ShowAllBooksCommand : ICommand
    {
        public string Description => "Kitap Listesini Göster ";
        public void Execute(BookList books)
        {
            Console.Clear();
            books.showBooks();
        }
    }
}
