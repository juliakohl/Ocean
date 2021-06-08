using Ocean.Data.IDAO;
using Ocean.Data.Models.Domain;
using Ocean.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Data.DAO
{
    public class ArtistDAO : IArtistDAO
    {
        private OceanContext context;
        public ArtistDAO()
        {
            context = new OceanContext();
        }

        public void AddMusicToCollection(Music music, Artist artist, OceanContext context)
        {
            context.Artists.Find(artist.ID).Musics.Add(music);

            context.Musics.Add(music);
            artist.Musics.Add(music);
        }

        public IList<Artist> GetArtists(OceanContext context)
        {
            return context.Artists.ToList();
        }

        public Artist GetArtist(int id, OceanContext context)
        {
            return context.Artists.Find(id);
        }
    }
}
