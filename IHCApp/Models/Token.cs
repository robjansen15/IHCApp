using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHCApp.Models
{
    public class Token
    {
        public Token(string token, string email)
        {
            _Token = token;
            _Email = email;
        }

        public string _Token { get; set; }
        public string _Email { get; set; }
    }
}