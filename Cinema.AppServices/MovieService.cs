using Cinema.AppServices.DTOs;
using Cinema.Core.Entities;
using Cinema.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.AppServices
{
    public class MovieService
    {
        private IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void AddMovie(MovieDto dto){
            var entity = new Movie();
            entity.Actors = dto.Actors;
            entity.EndDate = dto.EndDate;
            entity.Gengres = dto.Gengres;
            entity.Halls = dto.Halls;
            entity.ImageUrl = dto.ImageUrl;
            entity.Name = dto.Name;
            entity.StartDate = dto.StartDate;
        }
    }
}
