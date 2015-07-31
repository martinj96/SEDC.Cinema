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
    public class GenreService
    {
        private IGenreRepository _genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public void AddGenre(GenreDto dto)
        {
            var entity = new Genre();
            entity.Name = dto.Name;
            _genreRepository.Add(entity);
            _genreRepository.Save();
        }
        public void DeleteGenre(int id)
        {
            var genre = _genreRepository.GetById(id);
            _genreRepository.Delete(genre);
            _genreRepository.Save();
        }
        public List<GenreDto> GetAll()
        {
            var genres = _genreRepository.GetAll();
            return genres.Select(x => new GenreDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
        public List<GenreDto> GetAllNotDeleted()
        {
            var genres = _genreRepository.GetAll().Where(g => g.IsDeleted == false);
            return genres.Select(x => new GenreDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
