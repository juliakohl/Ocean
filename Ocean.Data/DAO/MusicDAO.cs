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
    public class MusicDAO : IMusicDAO
    {
        private OceanContext context;

        public MusicDAO()
        {
            context = new OceanContext();
        }

        public Music GetMusic(int id, OceanContext context)
        {
            return context.Musics.Find(id);
        }
    }
}
