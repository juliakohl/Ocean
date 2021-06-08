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
    public class ArtistService : IArtistService
    {
        private IArtistDAO artistDAO;
        public ArtistService()
        {
            artistDAO = new ArtistDAO();
        }

        public IList<Artist> GetArtists()
        {
            using (var context = new OceanContext())
            {
                return artistDAO.GetArtists(context);
            }

        }
    }
}
