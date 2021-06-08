using Ocean.Data.Models.Domain;
using Ocean.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Data.IDAO
{
    public interface IGenreDAO 
    {
        IList<Genre> GetGenres(OceanContext context);

        Genre GetGenre(int id, OceanContext context);

        IList<Music> GetMusics(int id, OceanContext context);

        void AddMusicToCollection(Music music, Genre genre, OceanContext context);

    }
}
