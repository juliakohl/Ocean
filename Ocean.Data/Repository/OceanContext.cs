using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean.Data.Models.Domain;

namespace Ocean.Data.Repository
{
    public class OceanContext : DbContext
    {
         public OceanContext() : base("OceanContext")
        {
            Database.SetInitializer(new OceanInitialiser());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

    }
}
