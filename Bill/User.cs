using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login_with_Master_Page.Bill
{
    public class User
    {
        public int Uid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 

        public string Role { get; set; }
    }
}