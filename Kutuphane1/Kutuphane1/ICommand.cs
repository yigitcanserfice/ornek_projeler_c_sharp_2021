using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane1
{
    interface ICommand
    {
        string Description { get; }
        void Execute(BookList bookList);
        
    }
}
