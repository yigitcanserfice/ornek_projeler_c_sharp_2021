using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphane1
{
    class AddBookCommand : ICommand
    {
        public string Description => "Kitap Ekle.";
        public void Execute(BookList books)
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Lütfen kitabın ID'sini giriniz.");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen kitabın adını giriniz.");
                string Name = Console.ReadLine();
                Console.WriteLine("Lütfen kitabın yazarını giriniz.");
                string Author = Console.ReadLine();
                Console.WriteLine("Lütfen kitabın yayınlanma yılını giriniz.");
                string ReleaseDateString = Console.ReadLine();
                int ReleaseDate;
                do
                {
                    bool TryToParseDate = int.TryParse(ReleaseDateString, out ReleaseDate);
                    if (TryToParseDate == false)
                    {
                        Console.WriteLine("Yanlış değer girdiniz, lütfen geçerli bir yıl giriniz.");
                        ReleaseDateString = Console.ReadLine();
                    }
                    else
                    {
                        bool CorrectDate = Enumerable.Range(0, DateTime.Today.Year).Contains(int.Parse(ReleaseDateString));
                        if (CorrectDate)
                        {
                            ReleaseDate = int.Parse(ReleaseDateString);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış değer girdiniz, lütfen geçerli bir yıl giriniz.");
                            ReleaseDateString = Console.ReadLine();
                        }
                    }
                }
                while (true);
                books.addBook(Id, Name, Author, ReleaseDate);
                Console.WriteLine();
                Console.WriteLine("Kitap Eklendi.");
                Console.ReadLine();
                Console.Clear();

            }
            catch (Exception)
            {

                Console.WriteLine("Yanlış değer girdiniz, lütfen geçerli bir değer giriniz.");
            }

        }
    }
}
