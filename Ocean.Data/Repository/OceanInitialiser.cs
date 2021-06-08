using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean.Data.Models.Domain;

namespace Ocean.Data.Repository
{
    public class OceanInitialiser: System.Data.Entity.DropCreateDatabaseIfModelChanges<OceanContext>
    {
        protected override void Seed(OceanContext context)
        {
            Genre genre1 = new Genre() { Name = "Rock" };
            Genre genre2 = new Genre() { Name = "Pop" };
            Genre genre3 = new Genre() { Name = "Country" };
            context.Genres.Add(genre1);
            context.Genres.Add(genre2);
            context.Genres.Add(genre3);

            context.SaveChanges();

        }
    }
}
