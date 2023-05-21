using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane1
{
    class ExitCommand : ICommand
    {
        public string Description => "Çıkış.";
        public void Execute(BookList books) { Environment.Exit(0); }
    }
}
