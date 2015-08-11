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
        private IActorRepository _actorRepository;
        public MovieService(IMovieRepository movieRepository, IActorRepository actorRepository)
        {
            _movieRepository = movieRepository;
            _actorRepository = actorRepository;
        }
        public void AddMovie(MovieDto dto){
            var entity = new Movie();
            entity.Name = dto.Name;
            entity.StartDate = dto.StartDate;
            entity.EndDate = dto.EndDate;
            entity.ImageUrl = dto.ImageUrl;
            entity.TicketPrice = dto.TicketPrice;
            _movieRepository.Add(entity);
            _movieRepository.Save();
        }
        public Movie GetMovieById(int id)
        {
            return _movieRepository.GetById(id);
        }
        public void AddActor(Movie entity, Actor actor)
        {
            _movieRepository.Edit(entity);
            entity.Actors.Add(actor);
            _movieRepository.Save();
        }
        public void RemoveActor(Movie entity, Actor actor)
        {
            _movieRepository.Edit(entity);
            entity.Actors.Remove(actor);
            _movieRepository.Save();
        }
        public List<ActorDto> GetActors(int id)
        {
            var entity = _movieRepository.GetById(id);
            return entity.Actors.Select(x => new ActorDto()
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname
            }).ToList();
        }
        public void DeleteMovie(int id)
        {
            var movie = _movieRepository.GetById(id);
            _movieRepository.Delete(movie);
            _movieRepository.Save();
        }
        public List<MovieDto> GetAll()
        {
            var movies = _movieRepository.GetAll();
            return movies.Select(x => new MovieDto()
            {
                Id = x.Id,
                Name = x.Name,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                TicketPrice = x.TicketPrice,
                ImageUrl = x.ImageUrl,
                Actors = x.Actors,
                Gengres = x.Gengres,
                Halls = x.Halls
            }).ToList();
        }
        public List<MovieDto> GetAllNotDeleted()
        {
            var movies = _movieRepository.GetAll().Where(m => m.IsDeleted == false);
            return movies.Select(x => new MovieDto()
            {
                Id = x.Id,
                Name = x.Name,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                TicketPrice = x.TicketPrice,
                ImageUrl = x.ImageUrl,
                Actors = x.Actors,
                Gengres = x.Gengres,
                Halls = x.Halls
            }).ToList();
        }
    }
}
