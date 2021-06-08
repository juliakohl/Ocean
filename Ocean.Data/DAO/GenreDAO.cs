﻿using Ocean.Data.IDAO;
using Ocean.Data.Models.Domain;
using Ocean.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ocean.Data.DAO
{
    public class GenreDAO : IGenreDAO
    {
        private OceanContext context;
        public GenreDAO()
        {
            context = new OceanContext();
        }
        public IList<Genre> GetGenres()
        {
            return context.Genres.ToList();
        }

        public Genre GetGenre(int id)
        {
            context.Genres.Include(g => g.Musics).ToList();

            return context.Genres.Find(id);
        }

        public IList<Music> GetMusics(int id)
        {
            context.Genres.Include(g => g.Musics).ToList();
            Genre genre = context.Genres.Find(id);
            return (IList<Music>)genre.Musics;
        }
    }
}
