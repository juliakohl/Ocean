using Ocean.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Services.IService
{
    public interface IMusicService
    {
        Music GetMusic(int id);
    }
}
