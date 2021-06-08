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
    public class UserDAO : IUserDAO
    {
        public void AddMusicToCollection(Music music, string UserId, OceanContext context)
        {
            context.Users.Find(UserId).Musics.Add(music);
        }
    }
}
