using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane1
{
    class RemoveBookCommand : ICommand
    {
        public string Description => "Kitabı Kaldır.";
        public void Execute(BookList books)
        {
            Console.Clear();
            Console.WriteLine("Lütfen kitabın ID'sini giriniz.");
            int Id = Convert.ToInt32(Console.ReadLine());
            books.removeBook(Id);
            Console.WriteLine("Kitap Kaldırıldı.");

        }
    }
}
