using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane1
{
    class SearchBook : ICommand
    {
        public string Description => "Kitabın Id'sine göre arama ";
        public void Execute(BookList books)
        {
            Console.Clear();
            Console.WriteLine("Lütfen kitabın ID'sini giriniz. ");
            int Id = Convert.ToInt32(Console.ReadLine());
            books.searchBook(Id);
        }
    }
}
