using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane1
{
    class BorrowDetails
    {      
        public string userName { get; set; }
        public string userAddress { get; set; }
        public int borrowBookId { get; set; }       
        
        public BorrowDetails(string user_Name, string user_Address, int borrow_BookId)
        {
            borrowBookId = borrow_BookId;
            userName = user_Name;
            userAddress = user_Address;            

        }
    }
}
