using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane1
{
    class BorrowBookCommand : ICommand
    {
        public string Description => "Ödünç Al.";
        public void Execute(BookList books)
        {
            Console.Clear();
            Console.WriteLine("Lütfen kitabın ID'sini giriniz.");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Ad Soyad giriniz.");
            string userName = Console.ReadLine();
            Console.WriteLine("Lütfen Adresinizi giriniz.");
            string userAdress = Console.ReadLine();
            books.BorrowBook(Id,userName,userAdress);
            Console.WriteLine("Kitap ödünç alındı.");
        }

    }
}
