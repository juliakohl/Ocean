using Ocean.Data.DAO;
using Ocean.Data.IDAO;
using Ocean.Data.Models.Domain;
using Ocean.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Services.Service
{
    public class GenreService : IGenreService 
    {
        private IGenreDAO genreDAO;
        public GenreService()
        {
            genreDAO = new GenreDAO();
        }
        public IList<Genre> GetGenres()
        {
            return genreDAO.GetGenres();
        }

        public Genre GetGenre(int id)
        {
            return genreDAO.GetGenre(id);
        }

        public IList<Music> GetMusics(int id)
        {
            IList<Music> music = genreDAO.GetMusics(id).ToList();
            return music;
        }
    }
}
