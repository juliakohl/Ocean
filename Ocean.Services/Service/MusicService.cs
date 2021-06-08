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
    public class MusicService : IMusicService
    {
        private IMusicDAO musicDAO;
        public MusicService()
        {
            musicDAO = new MusicDAO();
        }

        public Music GetMusic(int id)
        {
            return musicDAO.GetMusic(id);
        }
    }
}
