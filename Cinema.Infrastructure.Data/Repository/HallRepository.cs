using Cinema.Core.Entities;
using Cinema.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Data.Repository
{
    public class HallRepository : BaseRepository<Hall>, IHallRepository
    {
        public HallRepository(CinemaDbContext context)
            : base(context) 
        {

        }
    }
}
