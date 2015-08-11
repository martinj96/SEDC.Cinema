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
    public class HallService
    {
        private IHallRepository _hallRepository;
        public HallService(IHallRepository hallRepository)
        {
            _hallRepository = hallRepository;
        }
        public void AddHall(HallDto dto)
        {
            var entity = new Hall();
            entity.Name = dto.Name;
            _hallRepository.Add(entity);
            _hallRepository.Save();
        }
        public void DeleteHall(int id)
        {
            var hall = _hallRepository.GetById(id);
            _hallRepository.Delete(hall);
            _hallRepository.Save();
        }
        public List<HallDto> GetAll()
        {
            var halls = _hallRepository.GetAll();
            return halls.Select(x => new HallDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
        public List<HallDto> GetAllNotDeleted()
        {
            var halls = _hallRepository.GetAll().Where(g => g.IsDeleted == false);
            return halls.Select(x => new HallDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
