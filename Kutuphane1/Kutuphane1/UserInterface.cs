using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Kutuphane1
{
    class UserInterface
    {
        public void startApp(int sizeX, int sizeY)
        {
            this.mainMenu();
            
        }

        public void mainMenu()
        {
            
            var commands = new ICommand[]
            {
                new AddBookCommand(),
                new RemoveBookCommand(),
                new ShowAllBooksCommand(),
                new SearchBook(),
                new BorrowBookCommand(),
                new ReturnBookCommand(),
                new ExitCommand()

            };
            var books = new BookList();
            
            while (true)
            {
                Console.WriteLine("Kütüphaneye hoşgeldiniz.");
                Console.WriteLine("Hangi işlemi yapmak istersiniz?");


                for (int i = 0; i < commands.Length; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, commands[i].Description);
                }
                

                var userChoice = string.Empty;
                var commandIndex = -1;
                do
                {
                    userChoice = Console.ReadLine();
                }
                while (!int.TryParse(userChoice, out commandIndex) || commandIndex > commands.Length);

                commands[commandIndex - 1].Execute(books);
                
            }
          

            

        }
    }
}
