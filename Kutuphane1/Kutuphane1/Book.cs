using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Kutuphane1
{
    class Book
    {
        public int BookId { get; set; }

        public string BookName { get; set; }

        public string BookAuthor { get; set; }

        public int ReleaseDate { get; set; }

        
        
        public bool available = true;

        [JsonConstructor]
        public Book(int bookId, string name, string author, int releaseDate)
        {
            BookId = bookId;
            BookName = name;
            BookAuthor = author;
            ReleaseDate = releaseDate;

        }
    }
}
