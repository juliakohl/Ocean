using Ocean.Data.Models.Domain;
using Ocean.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Data.IDAO
{
    public interface IArtistDAO
    {
        void AddMusicToCollection(Music music, Artist artist, OceanContext context);

        IList<Artist> GetArtists(OceanContext context);

        Artist GetArtist(int id, OceanContext context);
    }
}
