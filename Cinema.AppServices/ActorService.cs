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
    public class ActorService
    {
        private IActorRepository _actorRepository;
        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        public void AddActor(ActorDto dto)
        {
            var entity = new Actor();
            entity.Name = dto.Name;
            entity.Surname = dto.Surname;
            _actorRepository.Add(entity);
            _actorRepository.Save();
        }
        public Actor GetActorById(int id)
        {
            return _actorRepository.GetById(id);
        }
        public void DeleteActor(int id)
        {
            var actor = _actorRepository.GetById(id);
            _actorRepository.Delete(actor);
            _actorRepository.Save();
        }
        public List<ActorDto> GetAll()
        {
            var actors = _actorRepository.GetAll();
            return actors.Select(x => new ActorDto()
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname
            }).ToList();
        }
        public List<ActorDto> GetAllNotDeleted()
        {
            var actors = _actorRepository.GetAll().Where(a => a.IsDeleted == false);
            return actors.Select(x => new ActorDto()
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname
            }).ToList();
        }
    }
}
