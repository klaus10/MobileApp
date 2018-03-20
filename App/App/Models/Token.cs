using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public class Token
    {
        public int TokenId { get; set; }
        public string access_token { get; set; }
        public string error_desc { get; set; }
        public DateTime expire_date { get; set; }

        public Token() { }

    }
}
