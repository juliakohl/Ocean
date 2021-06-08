using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Data.Models.Domain
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Music> Musics { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }

        public virtual ICollection<Order> Orders { get; set; }


    }
}
