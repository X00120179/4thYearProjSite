using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameWebsite.Models
{
    public class Player
    {
        public long PlayerID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // public int score { get; set; }
    }
}