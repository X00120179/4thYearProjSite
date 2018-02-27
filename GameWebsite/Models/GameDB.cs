using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameWebsite.Models
{
    public class GameDB:DbContext
    {
        public DbSet<Player> Table { get; set; }
    }
}