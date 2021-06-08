using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.Services.Models
{
    public class MusicGenreArtist
    {
        public string Title { get; set; }
        public int num_track { get; set; }
        public int duration { get; set; }
        public System.DateTime DateReleased { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int Genre { get; set; }
        public int Artist { get; set; }
    }
}
