using Cinema.Core.Entities;
using Cinema.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Data.Repository
{
    public class ActorRepository : BaseRepository<Actor>, IActorRepository
    {
        public ActorRepository(CinemaDbContext context) 
            : base(context)
        {

        }
    }
}
