using Ocean.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Data.IDAO
{
    public interface IGenreDAO 
    {
        IList<Genre> GetGenres();

        Genre GetGenre(int id);

        IList<Music> GetMusics(int id);

    }
}
