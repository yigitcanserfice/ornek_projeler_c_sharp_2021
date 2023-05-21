using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Kutuphane1
{
    class BookList
    {

        List<Book> books = new List<Book>();
        List<BorrowDetails> borrow = new List<BorrowDetails>();
        
        public void addBook(int bookId, string bookName, string bookAuthor, int releaseDate) 
        {
            if (books.Exists(b => b.BookId == bookId)) return;

            books.Add(new Book(bookId, bookName, bookAuthor, releaseDate));
            DataToJson.ToJson(books);
        }

        

        public void removeBook(int id) 
        {
            books.RemoveAll(Book => Book.BookId == id);
            DataToJson.ToJson(books);
        }
        public void showBooks()
        {
            foreach (var item in books.ToArray())
            {
                Console.WriteLine("Id : {0} ", item.BookId);
                Console.WriteLine("Kitap İsmi : {0} ", item.BookName);
                Console.WriteLine("Yazar : {0} ", item.BookAuthor);
                Console.WriteLine("Yayınlanma Yılı : {0} ", item.ReleaseDate);
                
                Console.WriteLine("----------------------");
                DataToJson.ToJson(books);
            }
        }
        public void BorrowBook(int id, string userName, string userAdress)
        {
            books.RemoveAll(Book => Book.BookId == id);
            borrow.Add(new BorrowDetails(userName,userAdress,id));
            DataToJson.ToJson(books);
        }
        public void searchBook(int find)
        {
            if (books.Exists(x => x.BookId == find))
            {
                foreach (Book searchId in books)
                {
                    if (searchId.BookId == find)
                    {
                        Console.WriteLine("Id :{0}\n", searchId.BookId);
                        Console.WriteLine("Kitap İsmi :{0}\n", searchId.BookName);
                        Console.WriteLine("Yazar :{0}\n", searchId.BookAuthor);
                        Console.WriteLine("Yayınlanma Yılı :{0}\n", searchId.ReleaseDate);
                        DataToJson.ToJson(books);
                    }
                }
            }
        }
    }
}
