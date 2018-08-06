using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace carttest.Models
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}