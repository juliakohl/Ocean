using Ocean.Data.Models.Domain;
using Ocean.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Data.IDAO
{
    public interface IMusicDAO
    {
        Music GetMusic(int id, OceanContext context);
    }
}
