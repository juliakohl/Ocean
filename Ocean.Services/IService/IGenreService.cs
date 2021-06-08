using Ocean.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Services.IService
{
    public interface IGenreService
    {
        IList<Genre> GetGenres();

        Genre GetGenre(int id);

        IList<Music> GetMusics(int id);
    }
}
