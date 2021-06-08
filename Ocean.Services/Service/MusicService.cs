using Ocean.Data.DAO;
using Ocean.Data.IDAO;
using Ocean.Data.Models.Domain;
using Ocean.Data.Repository;
using Ocean.Services.IService;
using Ocean.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Services.Service
{
    public class MusicService : IMusicService
    {
        private IMusicDAO musicDAO;
        private IGenreDAO genreDAO;
        private IUserDAO userDAO;
        private IArtistDAO artistDAO;
        public MusicService()
        {
            musicDAO = new MusicDAO();
            genreDAO = new GenreDAO();
            userDAO = new UserDAO();
            artistDAO = new ArtistDAO();
        }

        public Music GetMusic(int id)
        {
            using (var context = new OceanContext())
            {
                return musicDAO.GetMusic(id, context);
            }
        }

        public void AddMusic(MusicGenreArtist musicGenreArtist, string UserId)
        {
            #region - //Create the new Music Object
            Music newMusic = new Music()
            {
                Title = musicGenreArtist.Title,
                num_track = musicGenreArtist.num_track,
                duration = musicGenreArtist.duration,
                DateReleased = musicGenreArtist.DateReleased,
                Price = musicGenreArtist.Price,
                Image = musicGenreArtist.Image
            };
            #endregion
            #region - Do work with DAOs to add object and add to collections
            using (var context = new OceanContext())
            {
                musicDAO.AddMusic(newMusic, context);
                Genre genre = genreDAO.GetGenre(musicGenreArtist.Genre, context);
                genreDAO.AddMusicToCollection(newMusic, genre, context);
                Artist artist = artistDAO.GetArtist(musicGenreArtist.Artist, context);
                artistDAO.AddMusicToCollection(newMusic, artist, context);
                userDAO.AddMusicToCollection(newMusic, UserId, context);
                context.SaveChanges();
            }
            #endregion
        }
    }
}
