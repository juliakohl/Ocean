using Ocean.Data.DAO;
using Ocean.Data.IDAO;
using Ocean.Data.Models.Domain;
using Ocean.Data.Repository;
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
            using (var context = new OceanContext())
            {
                return genreDAO.GetGenres(context);
            }
                
        }

        public Genre GetGenre(int id)
        {
            using (var context = new OceanContext())
            {
                return genreDAO.GetGenre(id, context);
            }
        }

        public IList<Music> GetMusics(int id)
        {
            using (var context = new OceanContext())
            {
                IList<Music> music = genreDAO.GetMusics(id, context).ToList();
                return music;
            }
        }
    }
}
